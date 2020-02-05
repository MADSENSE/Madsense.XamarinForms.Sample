using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public string Html { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            Html = 
                "<html>" +
                "" +
                "<head>" +
                "  <style type='text/css'>" +
                "    @font-face { font-family: 'Roboto'; src: url('ms-appx-web:///Assets/Fonts/Roboto-Regular.ttf'); } " +
                "    * { font-family: 'Roboto'; color: blue; } " +
                "  </style>" +
                "</head>" +
                "" +
                "<body>" +
                "  <h1>Text in my Font</h1>" +
                "</body>" +
                "" +
                "</html>";
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}