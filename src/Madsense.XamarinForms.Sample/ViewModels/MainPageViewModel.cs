using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private int? _currentNumber;

        public int? CurrentNumber
        {
            get => _currentNumber;
            set
            {
                if (_currentNumber == value)
                    return;

                _currentNumber = value;
                OnPropertyChanged();
            }
        }

        public ICommand IncrementCommand { get; }
        public ICommand DecrementCommand { get; }
        public ICommand ResetCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            IncrementCommand = new Command(() => CurrentNumber = (CurrentNumber ?? 0) + 1);
            DecrementCommand = new Command(() => CurrentNumber = (CurrentNumber ?? 0) - 1);
            ResetCommand = new Command(() => CurrentNumber = null);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}