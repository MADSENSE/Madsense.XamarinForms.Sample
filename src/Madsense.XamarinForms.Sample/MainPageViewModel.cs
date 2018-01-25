using Xamarin.Forms;

using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Madsense.XamarinForms.Sample
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            DetailCommand = new Command(Detail);
        }

        public ICommand DetailCommand { get; }

        private async void Detail()
        {
            await Application.Current.MainPage.DisplayAlert("Click", "Detail on Item clicked", "OK");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}