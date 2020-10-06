using Xamarin.Forms.Xaml;

namespace Madsense.XamarinForms.Sample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalPage
    {
        public ModalPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.ModalPageViewModel();
        }
    }
}