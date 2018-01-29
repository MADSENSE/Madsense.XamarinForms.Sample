using System.Windows.Input;
using Xamarin.Forms;

namespace Madsense.XamarinForms.Sample
{
    public class ModalPageViewModel
    {
        public ICommand CloseCommand { get; }

        public ModalPageViewModel()
        {
            CloseCommand = new Command(Close);
        }

        private async void Close()
        {
            await Application.Current.MainPage.Navigation.PopModalAsync(true);
        }
    }
}