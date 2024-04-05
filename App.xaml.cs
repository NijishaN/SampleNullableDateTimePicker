using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace SampleNullableDateTimePicker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
            {
#if __ANDROID__

                handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
#elif __IOS__
            handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
            handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
            });
        }
    }
}
