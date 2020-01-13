using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private bool _isFirstTemplate = true;

        public bool IsFirstTemplate
        {
            get => _isFirstTemplate;
            set
            {
                if (_isFirstTemplate == value)
                    return;

                _isFirstTemplate = value;
                OnPropertyChanged(nameof(IsFirstTemplate));
            }
        }

        public ICommand SwitchTemplateCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            SwitchTemplateCommand = new Command(() => IsFirstTemplate = !IsFirstTemplate);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}