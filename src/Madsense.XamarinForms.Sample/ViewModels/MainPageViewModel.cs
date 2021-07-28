using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string _text;
        private bool _isVisible;

        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                OnPropertyChanged(nameof(Text));
            }
        }

        public bool IsVisible
        {
            get => _isVisible;
            set
            {
                _isVisible = value;
                OnPropertyChanged(nameof(IsVisible));
            }
        }

        public ICommand ChangeLongTextCommand { get; }
        public ICommand ChangeShortTextCommand { get; }
        public ICommand HideLabelCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            var shortText = "Short text 12345";
            ChangeLongTextCommand = new Command(() =>
                {
                    Text = "This is a longer text to test that LineBreakMode is not working well";
                    IsVisible = true;
                });
            ChangeShortTextCommand = new Command(() =>
            {
                Text = shortText;
                IsVisible = true;
            });
            HideLabelCommand = new Command(() => IsVisible = false);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}