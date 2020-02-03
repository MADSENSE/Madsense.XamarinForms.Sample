using System;
using System.Threading.Tasks;

using Windows.ApplicationModel.Core;

namespace Madsense.XamarinForms.Sample
{
    public partial class AppManager
    {
        public async Task<bool> TryRestartAsync()
        {
            var _ = await CoreApplication.RequestRestartAsync("Application Restart Programmatically");
            return false;
        }
    }
}
