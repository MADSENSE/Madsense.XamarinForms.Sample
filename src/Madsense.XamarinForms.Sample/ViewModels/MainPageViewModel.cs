using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string SelectedItem { get; set; }
        public MvvmHelpers.ObservableRangeCollection<string> Items { get; } = new MvvmHelpers.ObservableRangeCollection<string>();

        public MainPageViewModel()
        {
            Items.AddRange(new List<string> { "Apple", "Banana", "Watermelon", "Pineapple" });
            SelectedItem = Items.First();
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}