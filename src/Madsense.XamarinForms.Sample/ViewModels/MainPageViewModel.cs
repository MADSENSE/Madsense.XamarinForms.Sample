using System.Windows.Input;
using Prism.Mvvm;
using Xamarin.Forms;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private bool _isFirstTemplate = true;
        public string Title => "Title from ViewModel";
        public ICommand SwitchTemplateCommand { get; }

        public bool IsFirstTemplate
        {
            get => _isFirstTemplate;
            set => SetProperty(ref _isFirstTemplate, value);
        }

        public MainPageViewModel()
        {
            SwitchTemplateCommand = new Command(() => IsFirstTemplate = !IsFirstTemplate);
        }
    }
}