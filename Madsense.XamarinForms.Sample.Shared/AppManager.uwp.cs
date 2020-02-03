using System;
using System.Threading.Tasks;

using Windows.UI.Popups;
using Windows.ApplicationModel.Core;

namespace Madsense.XamarinForms.Sample
{
    public partial class AppManager
    {
        public async Task<bool> TryRestartAsync()
        {
            var result = await CoreApplication.RequestRestartAsync("Application Restart Programmatically ");

            if (result == AppRestartFailureReason.NotInForeground ||
                result == AppRestartFailureReason.RestartPending ||
                result == AppRestartFailureReason.Other)
            {
                var msgBox = new MessageDialog("Restart Failed", result.ToString());
                await msgBox.ShowAsync();
                return false;
            }

            return true;
        }
    }
}
