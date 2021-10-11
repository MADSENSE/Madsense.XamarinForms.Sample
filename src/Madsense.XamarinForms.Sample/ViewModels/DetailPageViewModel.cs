using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class DetailPageViewModel
    {
        public ObservableCollection<ItemViewModel> Items { get; } = new ObservableCollection<ItemViewModel>();
        public ICommand CloseCommand { get; }

        public DetailPageViewModel()
        {
            CloseCommand = new Command(Close);

            for (var i = 0; i < 1000; i++)
            {
                Items.Add(new ItemViewModel{Id = i, Name = $"Item {i}"});
            }
        }

        private async void Close()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }

    public class ItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}