using MvvmHelpers.Commands;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //public MvvmHelpers.ObservableRangeCollection<string> Items { get; } = new MvvmHelpers.ObservableRangeCollection<string>();
        //public System.Collections.ObjectModel.RangeObservableCollection<string> Items { get; } = new System.Collections.ObjectModel.RangeObservableCollection<string>();
        public Xamarin.CommunityToolkit.ObjectModel.ObservableRangeCollection<string> Items { get; } = new Xamarin.CommunityToolkit.ObjectModel.ObservableRangeCollection<string>();

        public Command ClearItemsCommand { get; }
        public Command AddItemsCommand { get; }
        public Command AddRangeItemsCommand { get; }
        public Command<string> RemoveItemCommand { get; }

        public MainPageViewModel()
        {
            AddItemsCommand = new Command(AddItems);
            AddRangeItemsCommand = new Command(AddRangeItems);
            RemoveItemCommand = new Command<string>(s => Items.Remove(s));
            ClearItemsCommand = new Command(() => Items.Clear());
        }

        private void AddItems()
        {
            var items = Enumerable.Range(Items.Count, 10).Select(i => $"Item {i}").ToArray();
            foreach (var i in items)
            {
                Items.Add(i);
            }
        }

        private void AddRangeItems()
        {
            var items = Enumerable.Range(Items.Count, 10).Select(i => $"Item {i}").ToArray();
            Items.AddRange(items);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}