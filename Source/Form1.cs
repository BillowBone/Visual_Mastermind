using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Mastermind
{
    //Main class/form of the game, it manages 110 buttons
    public partial class Form1 : XtraForm
    {
        //Master's code that the user have to find
        private MasterColors[] masterCode;

        //Player's code on the current row
        private MasterColors[] playerCode;

        //Contains every submit button of the form
        private SimpleButton[] submitButtons;

        //Contains the 5 colorable buttons of the current row
        private SimpleButton[] actualRowButtons;

        //Contains the 5 evaluation buttons of the current row
        private SimpleButton[] actualEvalButtons;

        //Define the actual row during all the program
        private int actualRow = 1;

        //Define if the program is in basic or hard mode
        private bool evaluation;

        //Gets the master's code from the Master class
        //Enables the first line of button and first submit button
        //Gets the status of the game : basic mode or hard mode
        public Form1()
        {
            InitializeComponent();
            Master m = new Master();
            masterCode = m.GetMasterCode();
            InitializePlayerCode();
            InitializeSubmitTab();
            FillActualButtons();
            evaluation = ChooseMode.evaluation;
        }

        //Fills the submitButtons tab with all 10 submit buttons of the game
        //Each button will appear when the game comes to its row and then disappear
        private void InitializeSubmitTab()
        {
            submitButtons = new SimpleButton[10];

            submitButtons[0] = submitButton1;
            submitButtons[1] = submitButton2;
            submitButtons[2] = submitButton3;
            submitButtons[3] = submitButton4;
            submitButtons[4] = submitButton5;
            submitButtons[5] = submitButton6;
            submitButtons[6] = submitButton7;
            submitButtons[7] = submitButton8;
            submitButtons[8] = submitButton9;
            submitButtons[9] = submitButton10;
        }

        //Fills the player's code with blanks between each try
        private void InitializePlayerCode()
        {
            playerCode = new MasterColors[5];

            for (int i = 0; i < 5; i++)
                playerCode[i] = MasterColors.Blank;
        }

        //Fills the actual row of colorable buttons + evaluation buttons
        private void FillActualButtons()
        {
            switch (actualRow)
            {
                case 1:
                    actualRowButtons = new SimpleButton []{ row_1_1, row_1_2, row_1_3, row_1_4, row_1_5 };
                    actualEvalButtons = new SimpleButton[] { eval_1_1, eval_1_2, eval_1_3, eval_1_4, eval_1_5 };
                    break;
                case 2:
                    actualRowButtons = new SimpleButton[] { row_2_1, row_2_2, row_2_3, row_2_4, row_2_5 };
                    actualEvalButtons = new SimpleButton[] { eval_2_1, eval_2_2, eval_2_3, eval_2_4, eval_2_5 };
                    break;
                case 3:
                    actualRowButtons = new SimpleButton[] { row_3_1, row_3_2, row_3_3, row_3_4, row_3_5 };
                    actualEvalButtons = new SimpleButton[] { eval_3_1, eval_3_2, eval_3_3, eval_3_4, eval_3_5 };
                    break;
                case 4:
                    actualRowButtons = new SimpleButton[] { row_4_1, row_4_2, row_4_3, row_4_4, row_4_5 };
                    actualEvalButtons = new SimpleButton[] { eval_4_1, eval_4_2, eval_4_3, eval_4_4, eval_4_5 };
                    break;
                case 5:
                    actualRowButtons = new SimpleButton[] { row_5_1, row_5_2, row_5_3, row_5_4, row_5_5 };
                    actualEvalButtons = new SimpleButton[] { eval_5_1, eval_5_2, eval_5_3, eval_5_4, eval_5_5 };
                    break;
                case 6:
                    actualRowButtons = new SimpleButton[] { row_6_1, row_6_2, row_6_3, row_6_4, row_6_5 };
                    actualEvalButtons = new SimpleButton[] { eval_6_1, eval_6_2, eval_6_3, eval_6_4, eval_6_5 };
                    break;
                case 7:
                    actualRowButtons = new SimpleButton[] { row_7_1, row_7_2, row_7_3, row_7_4, row_7_5 };
                    actualEvalButtons = new SimpleButton[] { eval_7_1, eval_7_2, eval_7_3, eval_7_4, eval_7_5 };
                    break;
                case 8:
                    actualRowButtons = new SimpleButton[] { row_8_1, row_8_2, row_8_3, row_8_4, row_8_5 };
                    actualEvalButtons = new SimpleButton[] { eval_8_1, eval_8_2, eval_8_3, eval_8_4, eval_8_5 };
                    break;
                case 9:
                    actualRowButtons = new SimpleButton[] { row_9_1, row_9_2, row_9_3, row_9_4, row_9_5 };
                    actualEvalButtons = new SimpleButton[] { eval_9_1, eval_9_2, eval_9_3, eval_9_4, eval_9_5 };
                    break;
                case 10:
                    actualRowButtons = new SimpleButton[] { row_10_1, row_10_2, row_10_3, row_10_4, row_10_5 };
                    actualEvalButtons = new SimpleButton[] { eval_10_1, eval_10_2, eval_10_3, eval_10_4, eval_10_5 };
                    break;
            }
        }

        //Calls the Form2 class/form to let the user select a ci=olor to fill the current cell with
        private void ManageColorChoice(SimpleButton button)
        {
            Form2 f = new Form2();
            if (f.ShowDialog() == DialogResult.OK)
                button.Appearance.BackColor = Form2.selectedColor;
        }

        //Gets the full name of a cell like row_x_y where x is the row's number and y the cell's number in this row
        //Rows goes from row_1_1 to row_10_5
        private int GetActualCell(string rowName)
        {
            int cell = 0;

            if (rowName.Length == 7)
                cell = rowName[6] - 49;
            else if (rowName.Length == 8)
                cell = rowName[7] - 49;
            return (cell);
        }

        //Fills the player's code tab depending on the color he chose
        private void ManagePlayerCode(SimpleButton button)
        {
            int cell = GetActualCell(button.Name);

            if (button.Appearance.BackColor == Color.Red)
                playerCode[cell] = MasterColors.Red;
            else if (button.Appearance.BackColor == Color.Yellow)
                playerCode[cell] = MasterColors.Yellow;
            else if (button.Appearance.BackColor == Color.Lime)
                playerCode[cell] = MasterColors.Green;
            else if (button.Appearance.BackColor == Color.Blue)
                playerCode[cell] = MasterColors.Blue;
            else if (button.Appearance.BackColor == Color.DarkViolet)
                playerCode[cell] = MasterColors.Purple;
            else if (button.Appearance.BackColor == Color.DarkOrange)
                playerCode[cell] = MasterColors.Orange;
            else if (button.Appearance.BackColor == Color.Magenta)
                playerCode[cell] = MasterColors.Pink;
            else if (button.Appearance.BackColor == Color.Brown)
                playerCode[cell] = MasterColors.Brown;
        }

        //Gets a color and count the number of time the player has found this color in the code
        //Only called for basic mode
        private int CountFoundGivenColorInMaster(MasterColors actualColor)
        {
            int count = 0;

            for (int i = 0; i < 5; i++)
            {
                if (masterCode[i] == playerCode[i] && masterCode[i] == actualColor)
                    count++;
            }
            return (count);
        }

        //Counts how many time a given color occurs in the master's code
        //Only called for basic mode
        private int CountGivenColorInMaster(MasterColors actualColor)
        {
            int count = 0;

            for (int i = 0; i < 5; i++)
            {
                if (masterCode[i] == actualColor)
                    count++;
            }
            return (count);
        }

        //Make the evaluation : green if the right color is at the right place,
        //red if the color isn't in the code and orange if the color is in the code but not the right place
        private void MakeEvaluation()
        {
            for (int i = 0; i < 5; i++)
            {
                if (playerCode[i] == masterCode[i])
                    actualEvalButtons[i].Appearance.BackColor = Color.Green;
                if (CountGivenColorInMaster(playerCode[i]) > CountFoundGivenColorInMaster(playerCode[i]) && playerCode[i] != masterCode[i])
                    actualEvalButtons[i].Appearance.BackColor = Color.Orange;
                if (CountGivenColorInMaster(playerCode[i]) == 0)
                    actualEvalButtons[i].Appearance.BackColor = Color.Red;
            }
            MakeEvaluationAppears();
        }

        //Evaluation buttons appears after each row validation
        private void MakeEvaluationAppears()
        {
            for (int i = 0; i < 5; i++)
                actualEvalButtons[i].Visible = true;
        }

        //Shows a pop-up message that describes each color for the evaluation buttons
        private void ExplainEvaluation(SimpleButton eval)
        {
            if (eval.Appearance.BackColor == Color.Green)
                XtraMessageBox.Show("This cell contains the right color at the right position in the code", "Evaluation");
            else if (eval.Appearance.BackColor == Color.Orange)
                XtraMessageBox.Show("This color is used in another cell in the code", "Evaluation");
            else if (eval.Appearance.BackColor == Color.Red)
                XtraMessageBox.Show("This cell contains a color that isn't in the code", "Evaluation");
            else
                XtraMessageBox.Show("This color is used in the code but you have already used it", "Evaluation");
        }

        private void ReinitializePlayerCode()
        {
            for (int i = 0; i < 5; i++)
            {
                playerCode[i] = MasterColors.Blank;
            }
        }

        private bool RowIsFull()
        {
            for (int i = 0; i < 5; i++)
            {
                if (playerCode[i] == MasterColors.Blank)
                    return (false);
            }
            return (true);
        }

        //Tells if the player found the code or not
        private bool CompareCodes()
        {
            for (int i = 0; i < 5; i ++)
            {
                if (playerCode[i] != masterCode[i])
                    return (false);
            }
            return (true);
        }

        private void DisableActualRow()
        {
            for (int i = 0; i < 5; i++)
                actualRowButtons[i].Enabled = false;
        }

        private void EnableActualRow()
        {
            for (int i = 0; i < 5; i++)
                actualRowButtons[i].Enabled = true;
        }

        //Manages each row's validation and end of the game rather if the user won or not
        private void ManageSubmit(SimpleButton submit)
        {
            if (submit.Name == "submitButton" + actualRow.ToString() && RowIsFull())
            {
                if (evaluation)
                    MakeEvaluation();
                if (CompareCodes())
                {
                    XtraMessageBox.Show("You found the code !");
                }
                else if (!CompareCodes() && actualRow < 10)
                {
                    submit.Visible = false;
                    submitButtons[actualRow].Visible = true;
                    DisableActualRow();
                    actualRow++;
                    FillActualButtons();
                    EnableActualRow();
                    ReinitializePlayerCode();
                }
                else if (!CompareCodes() && actualRow == 10)
                {
                    DisableActualRow();
                    submit.Visible = false;
                    XtraMessageBox.Show("You didn't found the code :(\nIt was : " + masterCode[0].ToString()
                        + " | " + masterCode[1].ToString() + " | " + masterCode[2].ToString() + " | " + masterCode[3].ToString()
                        + " | " + masterCode[4].ToString());
                }
            }
        }

        //Happens when the user click on any enabled colorable button
        private void clickEvent(object sender, EventArgs e)
        {
            ManageColorChoice((SimpleButton)sender);
            ManagePlayerCode((SimpleButton)sender);
        }

        //Happens when the user click on the submit button
        private void submitClickEvent(object sender, EventArgs e)
        {
            ManageSubmit((SimpleButton)sender);
        }

        //Happens when the user click on an evaluation button to know its meaning
        private void evalClickEvent(object sender, EventArgs e)
        {
            ExplainEvaluation((SimpleButton)sender);
        }
    }
}
