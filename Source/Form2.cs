using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Mastermind
{
    //This class/form let you choose the color you want to fill the current cell with
    public partial class Form2 : XtraForm
    {
        public static Color selectedColor;

        public Form2()
        {
            InitializeComponent();
        }

        //Saves the choosen color and send OK status to the main form
        private void SetSelectedColor(SimpleButton button)
        {
            selectedColor = button.Appearance.BackColor;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //Happens when the user clicks on any of the 8 colors
        private void clickEvent(object sender, EventArgs e)
        {
            SetSelectedColor((SimpleButton)sender);
        }
    }
}
