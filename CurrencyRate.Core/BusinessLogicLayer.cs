using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CurrencyRate.Entities;
using System.Xml;
using System.Reflection;

namespace CurrencyRate.Core 
{
    public class BusinessLogicLayer : BaseClass
	{
		delegate void UpdateExchangeRates();

		DatabaseLogicLayer DLL;
		public BusinessLogicLayer()
		{

			DLL = new DatabaseLogicLayer();

		}


		public List<ParaBirimi> ParaBirimiListesi()
		{
			List<ParaBirimi> ParaBirimleri = new List<ParaBirimi>();

			SqlDataReader reader = DLL.ParaBirimiListesi();
			while (reader.Read())
			{
				ParaBirimleri.Add(new ParaBirimi()
				{
					ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
					Code = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
					Tanim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
					UyariLimit = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3)

				});
			}
			reader.Close();
			DLL.BaglantiIslemleri();
			return ParaBirimleri;
		}

		

		public void KurBilgileriniGuncelle()
		{

			UpdateExchangeRates UP1 = new UpdateExchangeRates(USDInfo);

			UP1.Invoke();
			UP1 += EUROInfo;
			UP1 += GBPInfo;


		}

		public void USDInfo()
		{
			List<ParaBirimi> ParaBirimiListe = ParaBirimiListesi();
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load("https://www.tcmb.gov.tr/kurlar/today.xml");
			DateTime dateTime = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
			string USD = xmlDoc.SelectSingleNode("//Tarih_Date/Currency [@CurrencyCode='USD']/CurrencyName").InnerXml;
			string USDBuying = xmlDoc.SelectSingleNode("//Tarih_Date/Currency [@CurrencyCode='USD']/BanknoteBuying").InnerXml;
			string USDSelling = xmlDoc.SelectSingleNode("//Tarih_Date/Currency [@CurrencyCode='USD']/BanknoteSelling").InnerXml;

			KurKayitEKLE(Guid.NewGuid(), ParaBirimiListe[0].ID, decimal.Parse(USDBuying), decimal.Parse(USDSelling), DateTime.Now);

		}

		public void EUROInfo()
		{
			List<ParaBirimi> ParaBirimiListe = ParaBirimiListesi();
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load("https://www.tcmb.gov.tr/kurlar/today.xml");

			string EUR = xmlDoc.SelectSingleNode("//Tarih_Date/Currency [@CurrencyCode='EUR']/CurrencyName").InnerXml;
			string EURDBuying = xmlDoc.SelectSingleNode("//Tarih_Date/Currency [@CurrencyCode='EUR']/BanknoteBuying").InnerXml;
			string EURSelling = xmlDoc.SelectSingleNode("//Tarih_Date/Currency [@CurrencyCode='EUR']/BanknoteSelling").InnerXml;

			KurKayitEKLE(Guid.NewGuid(), ParaBirimiListe[1].ID, decimal.Parse(EURDBuying), decimal.Parse(EURSelling), DateTime.Now);
		}

		public void GBPInfo()
		{
			List<ParaBirimi> ParaBirimiListe = ParaBirimiListesi();
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load("https://www.tcmb.gov.tr/kurlar/today.xml");


			string GBP = xmlDoc.SelectSingleNode("//Tarih_Date/Currency [@CurrencyCode='GBP']/CurrencyName").InnerXml;
			string GBPBuying = xmlDoc.SelectSingleNode("//Tarih_Date/Currency [@CurrencyCode='GBP']/BanknoteBuying").InnerXml;
			string GBPSelling = xmlDoc.SelectSingleNode("//Tarih_Date/Currency [@CurrencyCode='GBP']/BanknoteSelling").InnerXml;

			KurKayitEKLE(Guid.NewGuid(), ParaBirimiListe[2].ID, decimal.Parse(GBPBuying), decimal.Parse(GBPSelling), DateTime.Now);
		}


		public DataTable KurGecmisGoruntule()
		{
			DataTable DT = new DataTable();
			DT.Columns.Add("Doviz Tanım", typeof(string));
			DT.Columns.Add("Doviz Kod", typeof(string));
			DT.Columns.Add("Alış", typeof(string));
			DT.Columns.Add("Satış", typeof(string));
			DT.Columns.Add("OluşturmaTarih", typeof(string));

			List<KurGecmis> KurGecmisList = KurGecmisListe();
			List<ParaBirimi> ParabirimList = ParaBirimiListesi();

			for (int i = 0; i < KurGecmisList.Count; i++)
			{
				DT.Rows.Add(
					ParabirimList.FirstOrDefault(I => I.ID == KurGecmisList[i].ParaBirimiID).Tanim,
					ParabirimList.FirstOrDefault(I => I.ID == KurGecmisList[i].ParaBirimiID).Code,
					KurGecmisList[i].Alis.ToString(),
					KurGecmisList[i].Satis.ToString(),
					KurGecmisList[i].OlusturmaTarih.ToString("dd.MM.yyyy hh:mm")
					);
			}

			return DT;
		}

		public List<Kur> KurListe()
		{
			List<Kur> KurDegerleri = new List<Kur>();

			SqlDataReader reader = DLL.KurListe();
			while (reader.Read())
			{
				KurDegerleri.Add(new Kur()
				{
					ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
					ParaBirimiID = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
					Alis = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
					Satis = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
					OlusturmaTarih = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4)
				});
			}
			reader.Close();
			DLL.BaglantiIslemleri();

			return KurDegerleri;
		}

		public Kur KurListe(Guid ParabirimiID)
		{
			Kur Kur = new Kur();

			SqlDataReader reader = DLL.KurListe();
			while (reader.Read())
			{
				Kur = new Kur()
				{
					ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
					ParaBirimiID = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
					Alis = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
					Satis = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
					OlusturmaTarih = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4)
				};
			}
			reader.Close();
			DLL.BaglantiIslemleri();

			return Kur;
		}

		public List<KurGecmis> KurGecmisListe()
		{
			List<KurGecmis> KurGecmisListe = new List<KurGecmis>();
			SqlDataReader reader = DLL.KurGecmisListe();
			while (reader.Read())
			{
				KurGecmisListe.Add(new KurGecmis()
				{
					ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
					KurID = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
					ParaBirimiID = reader.IsDBNull(2) ? Guid.Empty : reader.GetGuid(2),
					Alis = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
					Satis = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
					OlusturmaTarih = reader.IsDBNull(5) ? DateTime.MinValue : reader.GetDateTime(5)
				});
			}
			reader.Close();
			DLL.BaglantiIslemleri();
			return KurGecmisListe;
		}

		public List<KurGecmis> KurGecmisListe(Guid ParaBirimiID)
		{
			List<KurGecmis> KurGecmisListe = new List<KurGecmis>();
			SqlDataReader reader = DLL.KurGecmisListe(ParaBirimiID);
			while (reader.Read())
			{
				KurGecmisListe.Add(new KurGecmis()
				{
					ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
					KurID = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
					ParaBirimiID = reader.IsDBNull(2) ? Guid.Empty : reader.GetGuid(2),
					Alis = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
					Satis = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
					OlusturmaTarih = reader.IsDBNull(5) ? DateTime.MinValue : reader.GetDateTime(5)
				});
			}
			reader.Close();
			DLL.BaglantiIslemleri();
			return KurGecmisListe;
		}

		public void KurKayitEKLE(Guid ID, Guid ParaBirimiID, decimal Alis, decimal Satis, DateTime OlusturmaTarih)
		{
			if (ID != Guid.Empty && ParaBirimiID != Guid.Empty && Alis != 0 && Satis != 0 && OlusturmaTarih > DateTime.MinValue)
			{
				DLL.KurKayitEKLE(new Kur()	
				{
					ID = ID,
					ParaBirimiID = ParaBirimiID,
					Alis = Alis,
					Satis = Satis,
					OlusturmaTarih = OlusturmaTarih
				});
			}
			else
			{
				
			}

		}

		

	}
}
