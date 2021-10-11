using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Madsense.XamarinForms.Sample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalPage : ContentPage
    {
        public ModalPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.ModalPageViewModel();
        }
    }
}