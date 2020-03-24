using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using CustomRenderer;
using CustomRenderer.Android;
using Android.Content;
using Syncfusion.XForms.Android.ComboBox;
using Syncfusion.Android.ComboBox;
using Android.Widget;

[assembly: ExportRenderer(typeof(CustomComboBox), typeof(CustomComboBoxRenderer))]
namespace CustomRenderer.Android
{
    class CustomComboBoxRenderer : SfComboBoxRenderer
    {
        public CustomComboBoxRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Syncfusion.XForms.ComboBox.SfComboBox> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                if (Control != null)
                {
                    Control.GetAutoEditText().SetSelectAllOnFocus(true);
                    Control.FocusChanged += Control_FocusChanged;
                }
            }
        }

        private void Control_FocusChanged(object sender, FocusChangedEventArgs e)
        {
            if (e.HasFocus)
            {
                Control.GetAutoEditText().SetSelectAllOnFocus(true);
            }
        }

    }
}