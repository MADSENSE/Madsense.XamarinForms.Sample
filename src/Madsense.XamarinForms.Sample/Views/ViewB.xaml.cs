using System.Linq;
using System.Collections.ObjectModel;

using Xamarin.Forms.Xaml;

namespace Madsense.XamarinForms.Sample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewB
    {
        public ObservableCollection<string> Items { get; } = new ObservableCollection<string>(Enumerable.Range(0, 100).Select(i => $"Item {i}"));

        public ViewB()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}