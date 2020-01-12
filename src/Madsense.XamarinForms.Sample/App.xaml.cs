using Prism.DryIoc;
using Prism.Ioc;

namespace Madsense.XamarinForms.Sample
{
	public partial class App : PrismApplication
	{
        protected override async void OnInitialized()
        {
			InitializeComponent();

            await NavigationService.NavigateAsync($"/{nameof(MainPage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
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