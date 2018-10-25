using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class ColorSelection : UserControl
    {
        // Public event declaration that accepts a ColorSelectionEventArgs.
        // EventHandler acts a little like a Generic, accepting the necessary type.
        public event EventHandler<ColorSelectionEventArgs> ColorSelected;

        protected virtual void OnColorSelected(ColorSelectionEventArgs e)
        {
            // If the event has been fired, invoke the event with the
            // arguments.
            ColorSelected?.Invoke(this, e);
        }

        public ColorSelection()
        {
            InitializeComponent();
        }

        private void tb_Scroll(object sender, EventArgs e)
        {
            // When the value of one of the trackbars is changed,
            // update the panel color and raise the ColorSelected event.
            int redValue = tbRed.Value;
            int greenValue = tbGreen.Value;
            int blueValue = tbBlue.Value;
            Color setColor = Color.FromArgb(redValue, greenValue, blueValue);
            try
            {
                colorPanel.BackColor = setColor;
                // Include the ColorSelectionEventArgs class.
                OnColorSelected(new ColorSelectionEventArgs(setColor));
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }
    }

    public class ColorSelectionEventArgs: EventArgs
    {
        // Class to encapsulate the data that is to be sent as
        // part of the event.
        public Color SelectedColor { get; set; }

        public ColorSelectionEventArgs(Color SelectColor)
        {
            SelectedColor = SelectColor;
        }
    }
}
