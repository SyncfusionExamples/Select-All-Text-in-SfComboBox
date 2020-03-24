using CustomRenderer;
using CustomRenderer.UWP;
using Syncfusion.XForms.UWP.ComboBox;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomComboBox), typeof(CustomComboBoxRenderer))]
namespace CustomRenderer.UWP
{
    public class CustomComboBoxRenderer : SfComboBoxRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Syncfusion.XForms.ComboBox.SfComboBox> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.GotFocus += Control_GotFocus;
            }
        }

        private void Control_GotFocus(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Control.SelectAll();
        }
    }
}
