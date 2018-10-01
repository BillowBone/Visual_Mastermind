using System;

namespace Mastermind
{
    //Enum that defines each color that the secret code can contain
    //Blank is not a possible color, its only for the initialization
    public enum MasterColors
    {
        Red,
        Yellow,
        Green,
        Blue,
        Purple,
        Orange,
        Pink,
        Brown,
        Blank
    }

    //This class fills a tab of 5 colors for the master's code
    public class Master
    {
        private MasterColors[] masterCode = new MasterColors[5];

        public Master()
        {
            CreateMasterCode();
        }

        //This method randomly fill tha 5 colors for the master's code
        private void CreateMasterCode()
        {
            Random r = new Random();
            int rand = -1;

            for (int i = 0; i < 5; i++)
            {
                rand = r.Next(8) + 1;
                masterCode[i] = GetCorrespondingColor(rand);
            }
        }

        private MasterColors GetCorrespondingColor(int rand)
        {
            switch (rand)
            {
                case 1:
                    return (MasterColors.Red);
                case 2:
                    return (MasterColors.Yellow);
                case 3:
                    return (MasterColors.Green);
                case 4:
                    return (MasterColors.Blue);
                case 5:
                    return (MasterColors.Purple);
                case 6:
                    return (MasterColors.Orange);
                case 7:
                    return (MasterColors.Pink);
                case 8:
                    return (MasterColors.Brown);
            }
            return (MasterColors.Red);
        }

        public MasterColors[] GetMasterCode()
        {
            return (masterCode);
        }
    }
}
