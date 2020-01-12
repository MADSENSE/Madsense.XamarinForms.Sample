using System;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class PartialViewAViewModel
    {
        public string Title => "Title from PartialView A ViewModel";
        public string Id { get; } = Guid.NewGuid().ToString();
    }
}