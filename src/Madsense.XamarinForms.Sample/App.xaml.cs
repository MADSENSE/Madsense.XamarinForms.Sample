using Xamarin.Forms;

namespace Madsense.XamarinForms.Sample
{
	public partial class App
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new Views.MainPage())
            {
                BarBackgroundColor = Color.Blue
            };
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