using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Madsense.XamarinForms.Sample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.DetailPageViewModel();
        }
    }
}