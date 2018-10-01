using System;
using DevExpress.XtraEditors;

namespace Mastermind
{
    //This class/form let you choose rather if you want the corrections to be displayed at each turn or not
    public partial class ChooseMode : XtraForm
    {
        //Boolean that will be transfered to the Form1 class, which manage the game
        //This boolean will tell if the game displays the corrections at each turn or no
        public static bool evaluation;

        public ChooseMode()
        {
            InitializeComponent();
        }

        //Happens when the user choose the basic mode
        private void BasicMode_Click_1(object sender, EventArgs e)
        {
            evaluation = true;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        //Happens when the user choose the hard mode
        private void HardMode_Click(object sender, EventArgs e)
        {
            evaluation = false;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
