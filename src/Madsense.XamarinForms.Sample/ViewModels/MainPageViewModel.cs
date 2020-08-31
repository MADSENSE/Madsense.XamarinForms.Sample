using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using MvvmHelpers;
using Xamarin.Forms;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public ObservableRangeCollection<string> Items { get; }

        public ICommand AddItemCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            Items = new ObservableRangeCollection<string>();
            AddItemCommand = new Command(() =>
            {
                Items.Add($"Item {Items.Count + 1}");
            });
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}