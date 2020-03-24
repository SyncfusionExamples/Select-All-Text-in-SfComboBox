using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;
using CustomRenderer;
using CustomRenderer.iOS;
using Syncfusion.XForms.iOS.ComboBox;

[assembly: ExportRenderer (typeof(CustomComboBox), typeof(CustomComboBoxRenderer))]
namespace CustomRenderer.iOS
{
    public class CustomComboBoxRenderer : SfComboBoxRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Syncfusion.XForms.ComboBox.SfComboBox> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                if (Control != null)
                {
                    Control.FocusChanged += Control_FocusChanged;
                }
            }
        }

        private void Control_FocusChanged(object sender, Syncfusion.iOS.ComboBox.FocusEventArgs e)
        {
            if (e.HasFocus)
            {
                Control.TextField.SelectAll(null);
            }
        }
    }
}

