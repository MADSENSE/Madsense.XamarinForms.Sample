namespace Madsense.XamarinForms.Sample
{
	public partial class MainPage
	{
		public MainPage()
		{
			InitializeComponent();
            BindingContext = new MainPageViewModel();
		}
	}
}