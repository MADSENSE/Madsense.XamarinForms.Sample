using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public ICommand RestartCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            RestartCommand = new Command(async () =>
            {
                var result = await new AppManager().TryRestartAsync();
                await Application.Current.MainPage.DisplayAlert("Restart", result ? "Restart Success" : "Restart Error", "OK");
            });
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}