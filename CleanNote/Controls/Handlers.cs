using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNote.Controls
{
    public static class Handlers
    {
        public static void RegisterHandlers()
        {
            ConfigureEntry();
            ConfigureEditor();
            ConfigurePicker();
            ConfigureDatePicker();
            ConfigureTimePicker();
        }

        private static void ConfigureEntry()
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
            {
                try
                {
                    if (view is Entry)
                    {
#if __ANDROID__
                        handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
#elif __IOS__
                        handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
                        handler.PlatformView.Layer.BorderWidth = 0;
                        handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
#elif WINDOWS
                        handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
                        handler.PlatformView.BorderBrush = null;
                        handler.PlatformView.Background = null;
#endif
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            });
        }

        private static void ConfigureEditor()
        {
            Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping(nameof(Editor), (handler, view) =>
            {
                try
                {
                    if (view is Editor)
                    {
#if __ANDROID__
                        //handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());
                        //handler.PlatformView.Background = null;
                        handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
#elif __IOS__
                        //handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
                        handler.PlatformView.Layer.BorderWidth = 0;
#elif WINDOWS
                        handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
                        handler.PlatformView.BorderBrush = null;
                        handler.PlatformView.Background = null;
#endif
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            });
        }

        private static void ConfigurePicker()
        {
            Microsoft.Maui.Handlers.PickerHandler.Mapper.AppendToMapping(nameof(Picker), (handler, view) =>
            {
                try
                {
                    if (view is Picker)
                    {
#if __ANDROID__
                        //handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());
                        //handler.PlatformView.Background = null;
                        handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
#elif __IOS__
                        handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
                        handler.PlatformView.Layer.BorderWidth = 0;
#elif WINDOWS
                        handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
                        handler.PlatformView.BorderBrush = null;
                        handler.PlatformView.Background = null;
#endif
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            });
        }

        private static void ConfigureDatePicker()
        {
            Microsoft.Maui.Handlers.DatePickerHandler.Mapper.AppendToMapping(nameof(DatePicker), (handler, view) =>
            {
                try
                {
                    if (view is DatePicker)
                    {
#if __ANDROID__
                        //handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());
                        //handler.PlatformView.Background = null;
                        handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
#elif __IOS__
                        //handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
                        handler.PlatformView.Layer.BorderWidth = 0;
#elif WINDOWS
                        handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
                        handler.PlatformView.BorderBrush = null;
                        handler.PlatformView.Background = null;
#endif
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            });
        }

        private static void ConfigureTimePicker()
        {
            Microsoft.Maui.Handlers.TimePickerHandler.Mapper.AppendToMapping(nameof(TimePicker), (handler, view) =>
            {
                try
                {
                    if (view is TimePicker)
                    {
#if __ANDROID__
                        //handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());
                        //handler.PlatformView.Background = null;
                        handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
#elif __IOS__
                        //handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
                        handler.PlatformView.Layer.BorderWidth = 0;
#elif WINDOWS
                        handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
                        handler.PlatformView.BorderBrush = null;
                        handler.PlatformView.Background = null;
#endif
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            });
        }
    }
}
