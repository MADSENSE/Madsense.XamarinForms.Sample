using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class ModalPageViewModel
    {
        public ObservableCollection<ItemViewModel> Items { get; } = new ObservableCollection<ItemViewModel>();
        public ICommand CloseCommand { get; }

        public ModalPageViewModel()
        {
            CloseCommand = new Command(Close);

            for (var i = 0; i < 1000; i++)
            {
                Items.Add(new ItemViewModel{Id = i, Name = $"Item {i}"});
            }
        }

        private async void Close()
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }

    public class ItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}