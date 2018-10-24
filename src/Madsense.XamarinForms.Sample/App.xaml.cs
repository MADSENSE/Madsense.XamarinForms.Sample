using Prism.Ioc;

namespace Madsense.XamarinForms.Sample
{
	public partial class App
	{
	    protected override void OnInitialized()
	    {
	        InitializeComponent();

	        NavigationService.NavigateAsync($"{nameof(Xamarin.Forms.NavigationPage)}/{nameof(MainPage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
	    {
	        containerRegistry.RegisterForNavigation<Xamarin.Forms.NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
	    }
	}
}