using Android.Content;
using Android.Graphics.Drawables;

using MentalEdge.Controls;
using MentalEdge.Droid.Renderers;

using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MEEntry), typeof(MEEntryRenderer))]
namespace MentalEdge.Droid.Renderers
{
    public class MEEntryRenderer : EntryRenderer
	{
		public MEEntryRenderer(Context context) : base(context)
		{
		}

		public MEEntry ElementV2 => Element as MEEntry;
		protected override FormsEditText CreateNativeControl()
		{
			var control = base.CreateNativeControl();
			UpdateBackground(control);
			return control;
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == MEEntry.CornerRadiusProperty.PropertyName)
			{
				UpdateBackground();
			}
			else if (e.PropertyName == MEEntry.BorderThicknessProperty.PropertyName)
			{
				UpdateBackground();
			}
			else if (e.PropertyName == MEEntry.BorderColorProperty.PropertyName)
			{
				UpdateBackground();
			}

			base.OnElementPropertyChanged(sender, e);
		}

		protected override void UpdateBackgroundColor()
		{
			UpdateBackground();
		}
		protected void UpdateBackground(FormsEditText control)
		{
			if (control == null) return;

			var gd = new GradientDrawable();
			gd.SetColor(Element.BackgroundColor.ToAndroid());
			gd.SetCornerRadius(Context.ToPixels(ElementV2.CornerRadius));
			gd.SetStroke((int)Context.ToPixels(ElementV2.BorderThickness), ElementV2.BorderColor.ToAndroid());
			control.SetBackground(gd);

			var padTop = (int)Context.ToPixels(ElementV2.Padding.Top);
			var padBottom = (int)Context.ToPixels(ElementV2.Padding.Bottom);
			var padLeft = (int)Context.ToPixels(ElementV2.Padding.Left);
			var padRight = (int)Context.ToPixels(ElementV2.Padding.Right);

			control.SetPadding(padLeft, padTop, padRight, padBottom);
		}
		protected override void UpdateBackground()
		{
			UpdateBackground(Control);
		}
	}
}