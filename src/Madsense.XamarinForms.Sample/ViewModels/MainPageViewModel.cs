using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string _selectedValue;

        public string SelectedValue
        {
            get => _selectedValue;
            set
            {
                if (_selectedValue == value)
                    return;

                _selectedValue = value;
                OnPropertyChanged(nameof(SelectedValue));
            }
        }

        public string Value1 { get; } = nameof(Value1);
        public string Value2 { get; } = nameof(Value2);
        public string Value3 { get; } = nameof(Value3);
        public string Value4 { get; } = nameof(Value4);

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}