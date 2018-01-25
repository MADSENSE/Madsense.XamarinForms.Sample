using AppKit;
using Foundation;
using Xamarin.Forms.Platform.MacOS;

namespace Madsense.XamarinForms.Sample.Mac
{
    [Register("AppDelegate")]
    public sealed class AppDelegate : FormsApplicationDelegate
    {
        public AppDelegate()
        {
            const NSWindowStyle style = NSWindowStyle.Titled | NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Miniaturizable;

            var rect = new CoreGraphics.CGRect(200, 200, 1024, 768);
            MainWindow = new NSWindow(rect, style, NSBackingStore.Buffered, false)
            {
                Title = "MADSENSE Sample",
                TitleVisibility = NSWindowTitleVisibility.Hidden,
                AutorecalculatesKeyViewLoop = true,
                FrameAutosaveName = "com.madsense.XamarinForms.Sample"
            };

            NSApplication.SharedApplication.MainMenu = new NSMenu();
        }

        public override NSWindow MainWindow { get; }

        public override void DidFinishLaunching(NSNotification notification)
        {
            Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
            base.DidFinishLaunching(notification);
        }
    }
}