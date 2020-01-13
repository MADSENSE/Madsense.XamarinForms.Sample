namespace Madsense.XamarinForms.Sample.Views
{
	public partial class MainPage
	{
		public MainPage()
		{
			InitializeComponent();
            BindingContext = new ViewModels.MainPageViewModel();
		}
	}
}