using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace Madsense.XamarinForms.Sample
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public ICommand OpenCommand { get; }

        public MainPageViewModel()
        {
            OpenCommand = new Command(Open);
        }

        private async void Open()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new ModalPage(), true);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}