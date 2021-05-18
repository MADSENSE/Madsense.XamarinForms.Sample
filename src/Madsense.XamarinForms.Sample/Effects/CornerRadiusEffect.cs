using System;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;

[assembly: ResolutionGroupName("madsense")]
[assembly: ExportEffect(typeof(Madsense.XamarinForms.Sample.Effects.FormsCornerRadiusEffect), nameof(Madsense.XamarinForms.Sample.Effects.CornerRadiusEffect))]
namespace Madsense.XamarinForms.Sample.Effects
{
    public class CornerRadiusEffect : RoutingEffect
    {
        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.CreateAttached("CornerRadius", typeof(CornerRadius), typeof(CornerRadiusEffect),
                default(CornerRadius), propertyChanged: TryAttachEffect);

        public CornerRadiusEffect() : base($"madsense.{nameof(CornerRadiusEffect)}")
        {

        }

        public static CornerRadius GetCornerRadius(BindableObject bindable)
            => (CornerRadius)bindable.GetValue(CornerRadiusProperty);

        public static void SetCornerRadius(BindableObject bindable, CornerRadius value)
            => bindable.SetValue(CornerRadiusProperty, value);

        private static void TryAttachEffect(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(bindable is VisualElement element))
                return;

            var cornerRadiusEffects = element.Effects.OfType<CornerRadiusEffect>();

            if (GetCornerRadius(bindable) == default)
            {
                foreach (var cornerRadiusEffect in cornerRadiusEffects)
                {
                    element.Effects.Remove(cornerRadiusEffect);
                }
                return;
            }

            if (!element.Effects.OfType<CornerRadiusEffect>().Any())
                element.Effects.Add(new CornerRadiusEffect());
        }
    }

    public class FormsCornerRadiusEffect : NullEffect
    {
        protected override void OnAttached()
        {
            if (Element is VisualElement elementView)
            {
                elementView.SizeChanged += OnElementSizeChanged;
                elementView.PropertyChanged += OnElementPropertyChanged;
                CreateClip(elementView);
            }
        }

        protected override void OnDetached()
        {
            if (Element is VisualElement elementView)
            {
                elementView.SizeChanged -= OnElementSizeChanged;
                elementView.PropertyChanged -= OnElementPropertyChanged;
                elementView.Clip = null;
            }
        }

        private void OnElementSizeChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == CornerRadiusEffect.CornerRadiusProperty.PropertyName)
            {
                UpdateCornerRadius();
            }
        }
        private void UpdateCornerRadius()
        {
            if (!(Element is VisualElement elementView))
                return;

            if (elementView.Clip is RoundRectangleGeometry roundRectangleGeometry)
            {
                var cornerRadius = CornerRadiusEffect.GetCornerRadius(Element);
                roundRectangleGeometry.CornerRadius = cornerRadius;
            }
            else
            {
                CreateClip(elementView);
            }
        }

        private void UpdateSize()
        {
            if (!(Element is VisualElement elementView))
                return;

            if (elementView.Clip is RoundRectangleGeometry roundRectangleGeometry)
            {
                var rect = new Rect(0, 0, elementView.Width, elementView.Height);
                roundRectangleGeometry.Rect = rect;
            }
            else
            {
                CreateClip(elementView);
            }
        }

        private static void CreateClip(VisualElement elementView)
        {
            var cornerRadius = CornerRadiusEffect.GetCornerRadius(elementView);
            var rect = new Rect(0, 0, elementView.Width, elementView.Height);
            elementView.Clip = new RoundRectangleGeometry(cornerRadius, rect);
        }
    }
}