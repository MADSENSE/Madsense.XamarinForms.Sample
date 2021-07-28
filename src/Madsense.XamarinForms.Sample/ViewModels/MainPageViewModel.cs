using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private const string LoremIpsum =
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ultrices sagittis orci a scelerisque purus semper eget. " +
            "Proin libero nunc consequat interdum varius sit. Volutpat commodo sed egestas egestas. Sed turpis tincidunt id aliquet risus feugiat. Quis ipsum suspendisse ultrices gravida dictum fusce. " +
            "Velit scelerisque in dictum non consectetur. Metus aliquam eleifend mi in nulla posuere. Tellus cras adipiscing enim eu turpis egestas pretium aenean pharetra. Tincidunt arcu non sodales neque sodales.";
        private string _text;
        private int _size;

        public MainPageViewModel()
        {
            Size = 10;
        }

        public string Text
        {
            get => _text;
            set
            {
                if (value == _text)
                    return;

                _text = value;
                OnPropertyChanged(nameof(Text));
            }
        }

        public int Size
        {
            get => _size;
            set
            {
                if (value == _size)
                    return;

                _size = value;
                OnPropertyChanged(nameof(Size));
                Text = LoremIpsum.Substring(0, value);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}