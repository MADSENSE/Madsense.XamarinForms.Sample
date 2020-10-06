using System.Threading.Tasks;
using System.Windows.Input;
using Madsense.XamarinForms.Sample.Views;
using Xamarin.Forms;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class MainPageViewModel
    {
        public ICommand NavigateModalCommand { get; }

        public MainPageViewModel()
        {
            NavigateModalCommand = new Command(async () => await NavigateModal());
        }

        private async Task NavigateModal()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new ModalPage()));
        }
    }
}