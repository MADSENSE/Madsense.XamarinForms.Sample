using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    { public string SelectedItem { get; set; }
        
        public event PropertyChangedEventHandler PropertyChanged;

        public ICollection<string> ItemsSource { get; } = new List<string>{ "Test1", "Test2", "Test3" };

        public Command ItemChangedCommand { get; }

        public MainPageViewModel()
        {
            ItemChangedCommand = new Command(async () => await ItemChanged());
        }

        private async Task ItemChanged()
        {
            var itemHasChanged = SelectedItem;
            await Task.CompletedTask;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}