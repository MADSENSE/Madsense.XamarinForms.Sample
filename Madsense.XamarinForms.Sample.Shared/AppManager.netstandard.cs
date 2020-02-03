using System.Threading.Tasks;

namespace Madsense.XamarinForms.Sample
{
    public partial class AppManager
    {
        public Task<bool> TryRestartAsync()
        {
            return Task.FromResult(false);
        }
    }
}
