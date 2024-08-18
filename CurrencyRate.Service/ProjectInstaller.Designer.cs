namespace CurrencyRate.Service
{
	partial class ProjectInstaller
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Bileşen Tasarımcısı üretimi kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.ExchangeRateTrackerService = new System.ServiceProcess.ServiceProcessInstaller();
			this.ExchangeRateService = new System.ServiceProcess.ServiceInstaller();
			// 
			// ExchangeRateTrackerService
			// 
			this.ExchangeRateTrackerService.Password = null;
			this.ExchangeRateTrackerService.Username = null;
			this.ExchangeRateTrackerService.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.serviceProcessInstaller1_AfterInstall);
			// 
			// ExchangeRateService
			// 
			this.ExchangeRateService.Description = "Retrieving exchange rate values every 2 minutes";
			this.ExchangeRateService.DisplayName = "Exchange Rate Tracker Service";
			this.ExchangeRateService.ServiceName = "Exchange Rate Tracker Service";
			this.ExchangeRateService.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
			// 
			// ProjectInstaller
			// 
			this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.ExchangeRateTrackerService,
            this.ExchangeRateService});

		}

		#endregion

		private System.ServiceProcess.ServiceProcessInstaller ExchangeRateTrackerService;
		private System.ServiceProcess.ServiceInstaller ExchangeRateService;
	}
}