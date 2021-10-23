using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class DetailPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<ItemViewModel> _items;

        public ObservableCollection<ItemViewModel> Items
        {
            get => _items;
            set
            {
                if (_items == value)
                    return;

                _items = value;
                OnPropertyChanged();
            }
        }

        public ICommand CloseCommand { get; }
        public ICommand NewItemsCommand { get; }
        public ICommand PopulateItemsCommand { get; }
        public ICommand ClearItemsCommand { get; }
        public ICommand GarbageCollectCommand { get; }

        public DetailPageViewModel()
        {
            CloseCommand = new Command(Close);
            NewItemsCommand = new Command(NewItems);
            PopulateItemsCommand = new Command(PopulateItems);
            ClearItemsCommand = new Command(Clear);
            GarbageCollectCommand = new Command(GarbageCollect);

            NewItems();
            PopulateItems();
        }

        private void Clear()
        {
            Items.Clear();
        }

        private void PopulateItems()
        {
            for (var i = 0; i < 1000; i++)
            {
                Items.Add(new ItemViewModel{Id = i, Name = $"Item {i}"});
            }
        }

        private void NewItems()
        {
            Items = new ObservableCollection<ItemViewModel>();
        }

        private void GarbageCollect()
        {
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        private async void Close()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class ItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}