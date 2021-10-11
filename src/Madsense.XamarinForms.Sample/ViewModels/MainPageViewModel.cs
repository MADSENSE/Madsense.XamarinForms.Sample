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

        public ICommand OpenModalCommand { get; }
        public ICommand GarbageCollectCommand { get; }

        public MainPageViewModel()
        {
            OpenModalCommand = new Command(OpenModal);
            GarbageCollectCommand = new Command(GarbageCollect);
        }

        private async void OpenModal()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new ModalPage()));
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