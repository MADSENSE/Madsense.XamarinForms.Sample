using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public string Html { get; }
        
        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            var fontFamily = "Bellada";
            var fontFace = $"@font-face {{ font-family: '{fontFamily}'; src: url('bellada.ttf'); }}";

            var imagePath = "madsense.png";

            if (Device.RuntimePlatform == Device.UWP)
            {
                fontFace = $"@font-face {{ font-family: '{fontFamily}'; src: url('ms-appx-web:///Assets/Fonts/bellada.ttf'); }}";
                imagePath = "ms-appx-web:///Assets/madsense.png";
            }

            Html = 
                "<html>" +
                "" +
                "<head>" +
                "  <style type='text/css'>" +
                $"    {fontFace} " +
                $"    * {{ font-family: '{fontFamily}'; color: blue; }} " +
                "  </style>" +
                "</head>" +
                "" +
                "<body>" +
                "  <h1>HTML text with Bellada Font</h1>" +
                $"  <img src='{imagePath}'>" +
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