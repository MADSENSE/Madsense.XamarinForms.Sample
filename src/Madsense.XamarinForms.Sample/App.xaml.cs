using System.Globalization;

namespace Madsense.XamarinForms.Sample
{
	public partial class App
	{
		public App()
        {
            // It works with en-US culture
            //var culture = new CultureInfo("en-US");
            //culture.NumberFormat.CurrencySymbol = "XAM";
            //culture.NumberFormat.CurrencyDecimalSeparator = ";";
            //culture.NumberFormat.NumberDecimalSeparator = ";";
            //CultureInfo.CurrentUICulture = culture;

            // It doesn't work with a specific culture
            var culture = new CultureInfo("es-ES");
            culture.NumberFormat.CurrencySymbol = "XAM";
            culture.NumberFormat.CurrencyDecimalSeparator = ";";
            culture.NumberFormat.NumberDecimalSeparator = ";";
            CultureInfo.CurrentUICulture = culture;

            InitializeComponent();
            MainPage = new Views.MainPage();
		}

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}