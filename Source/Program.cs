using System;
using System.Windows.Forms;

namespace Mastermind
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ChooseMode choose = new ChooseMode();
            if (choose.ShowDialog() == DialogResult.OK)
                Application.Run(new Form1());
        }
    }
}
