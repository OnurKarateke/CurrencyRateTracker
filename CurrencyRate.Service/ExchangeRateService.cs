using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CurrencyRate.Service
{
	public partial class ExchangeRateService : ServiceBase
	{
		public System.Timers.Timer t;
		public ExchangeRateService()
		{
			InitializeComponent();
			t = new System.Timers.Timer(120000); // set to 2 minutes
			t.Elapsed += T_Elapsed;
		}

		private void T_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			CurrencyRate.Core.BusinessLogicLayer BLL = new CurrencyRate.Core.BusinessLogicLayer();
			BLL.KurBilgileriniGuncelle();	
		}

		protected override void OnStart(string[] args)
		{
		 t.Start();
		}

		protected override void OnPause()
		{
			t.Stop();
		}

		protected override void OnContinue()
		{
			t.Start();
		}

		protected override void OnShutdown()
		{
			t.Stop();
		}
		protected override void OnStop()
		{
			t.Stop();
		}
	}
}
