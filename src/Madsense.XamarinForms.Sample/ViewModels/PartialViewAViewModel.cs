using System;
using System.Linq;

namespace Madsense.XamarinForms.Sample.ViewModels
{
    public class PartialViewAViewModel
    {
        public string Title => "Title from PartialView A ViewModel";
        public string Id { get; } = Guid.NewGuid().ToString();
        public string[] Items { get; } = Enumerable.Range(0, 100).Select(i => $"Item {i}").ToArray();
    }
}