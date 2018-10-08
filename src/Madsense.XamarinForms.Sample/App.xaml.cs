using Prism.Ioc;

namespace Madsense.XamarinForms.Sample
{
	public partial class App
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

	    protected override void RegisterTypes(IContainerRegistry containerRegistry)
	    {
            containerRegistry.RegisterForNavigation<SecondView>();
	    }

	    protected override void OnInitialized()
	    {
	        
	    }

	    protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}