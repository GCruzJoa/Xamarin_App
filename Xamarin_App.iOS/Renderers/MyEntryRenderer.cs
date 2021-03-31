using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Xamarin_App.Controls;
using Xamarin_App.iOS.Renderers;

[assembly: ExportRenderer(typeof(MyEntry),typeof(MyEntryRenderer))]
namespace Xamarin_App.iOS.Renderers
{
    public class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            // Creando
            if(e.NewElement != null)
            {
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
                Control.BorderStyle = UITextBorderStyle.Line;
            }

            // Destruyendo
            if(e.OldElement != null)
            {

            }
        }
    }
}