using System;
using System.Collections.Generic;
using System.Text;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class PartialViewBViewModel
    {
        public string Title => "Title from PartialView B ViewModel";
        public string Id { get; } = Guid.NewGuid().ToString();
    }
}
