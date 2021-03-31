using System;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Xamarin_App.iOS.Effects;

[assembly: ResolutionGroupName("GabrielCruz")]
[assembly: ExportEffect(typeof(IosFocusEffect), "FocusEffect")]
namespace Xamarin_App.iOS.Effects
{
    public class IosFocusEffect : PlatformEffect
    {
        UIColor backgroundColor;

        protected override void OnAttached()
        {
            try
            {
                Control.BackgroundColor = backgroundColor = UIColor.FromRGB(204, 153, 255);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            try
            {
                if (args.PropertyName == "IsFocused")
                {
                    if (Control.BackgroundColor == backgroundColor)
                    {
                        Control.BackgroundColor = UIColor.White;
                    }
                    else
                    {
                        Control.BackgroundColor = backgroundColor;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }
    }
}