using Android.Content;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin_App.Controls;
using Xamarin_App.Droid.Renderers;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace Xamarin_App.Droid.Renderers
{
    class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                this.Control.SetBackgroundColor(global::Android.Graphics.Color.Orange);
            }
        }
    }
}