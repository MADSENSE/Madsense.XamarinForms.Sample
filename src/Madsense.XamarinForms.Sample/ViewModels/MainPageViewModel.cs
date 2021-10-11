using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Madsense.XamarinForms.Sample.Views;
using Xamarin.Forms;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand NavigateCommand { get; }
        public ICommand GarbageCollectCommand { get; }

        public MainPageViewModel()
        {
            NavigateCommand = new Command(Navigate);
            GarbageCollectCommand = new Command(GarbageCollect);
        }

        private async void Navigate()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DetailPage());
        }

        private void GarbageCollect()
        {
            System.GC.Collect();
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}