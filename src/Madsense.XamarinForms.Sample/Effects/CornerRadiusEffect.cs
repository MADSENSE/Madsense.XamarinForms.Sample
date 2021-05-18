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
        public CornerRadiusEffect() : base($"madsense.{nameof(CornerRadiusEffect)}")
        {

        }

        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.CreateAttached("CornerRadius", typeof(CornerRadius), typeof(CornerRadiusEffect), new CornerRadius(0),
                propertyChanged: OnCornerRadiusChanged);

        public static CornerRadius GetCornerRadius(BindableObject bindable)
            => (CornerRadius)bindable.GetValue(CornerRadiusProperty);
        public static void SetCornerRadius(BindableObject bindable, CornerRadius value)
            => bindable.SetValue(CornerRadiusProperty, value);
        
        private static void OnCornerRadiusChanged(BindableObject bindable, object oldValue, object newValue)
        {
            AttachEffect(bindable);
        } 

        private static void AttachEffect(BindableObject bindable)
        {
            if (!(bindable is VisualElement element))
                return;

            if (element.Effects.OfType<CornerRadiusEffect>().Any())
                return;
            
            element.Effects.Add(new CornerRadiusEffect());
        }
    }

    public class FormsCornerRadiusEffect : NullEffect
    {
        protected override void OnAttached()
        {
            if (Element is VisualElement view)
            {
                view.SizeChanged += OnElementSizeChanged;
                view.PropertyChanged += OnElementPropertyChanged;
                UpdateClip();
            }

            base.OnAttached();
        }

        protected override void OnDetached()
        {
            if (Element is VisualElement view)
            {
                view.SizeChanged -= OnElementSizeChanged;
                view.PropertyChanged -= OnElementPropertyChanged;
            }

            base.OnDetached();
        }

        private void OnElementSizeChanged(object sender, EventArgs e)
        {
            UpdateClip();
        }

        private void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == CornerRadiusEffect.CornerRadiusProperty.PropertyName)
            {
                UpdateClip();
            }
        }

        private void UpdateClip()
        {
            if (!(Element is VisualElement view))
                return;

            var rect = new Rect(0, 0, view.Width, view.Height);
            var cornerRadius = CornerRadiusEffect.GetCornerRadius(Element);
            
            if (view.Clip is RoundRectangleGeometry roundRectangleGeometry)
            {
                roundRectangleGeometry.Rect = rect;
                roundRectangleGeometry.CornerRadius = cornerRadius;
            }
            else
            {
                view.Clip = new RoundRectangleGeometry(cornerRadius, rect);
            }
        }
    }
}