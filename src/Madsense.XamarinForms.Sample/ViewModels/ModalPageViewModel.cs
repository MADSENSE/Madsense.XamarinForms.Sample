using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class ModalPageViewModel
    {
        public ICommand PopModalCommand { get; }

        public ModalPageViewModel()
        {
            PopModalCommand = new Command(async () => await PopModal());
        }

        private async Task PopModal()
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}