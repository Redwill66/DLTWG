using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameofLifedanielT
{
    class LabAvatarFunk
    {
        Bitmap Player1 = Properties.Resources.PlayerA1;
        Bitmap Player2 = Properties.Resources.PlayerA2;
        Bitmap Player3 = Properties.Resources.PlayerA3;
        Bitmap Player4 = Properties.Resources.PlayerA4;
        Bitmap Player5 = Properties.Resources.PlayerA5;
        Bitmap Player6 = Properties.Resources.PlayerA6;
        Bitmap Player7 = Properties.Resources.PlayerA7;
        Bitmap Player8 = Properties.Resources.PlayerA8;
        Bitmap Player9 = Properties.Resources.PlayerA9;
        Bitmap Player10 = Properties.Resources.PlayerA10;
        Bitmap Player1a = Properties.Resources.PlayerA1a;
        Bitmap Player2a = Properties.Resources.PlayerA2a;
        Bitmap Player3a = Properties.Resources.PlayerA3a;
        Bitmap Player4a = Properties.Resources.PlayerA4a;
        Bitmap Player5a = Properties.Resources.PlayerA5a;
        Bitmap Player6a = Properties.Resources.PlayerA6a;
        Bitmap Player7a = Properties.Resources.PlayerA7a;
        Bitmap Player8a = Properties.Resources.PlayerA8a;
        Bitmap Player9a = Properties.Resources.PlayerA9a;
        Bitmap Player10a = Properties.Resources.PlayerA10a;
        Bitmap Player1b = Properties.Resources.PlayerA1b;
        Bitmap Player2b = Properties.Resources.PlayerA2b;
        Bitmap Player3b = Properties.Resources.PlayerA3b;
        Bitmap Player4b = Properties.Resources.PlayerA4b;
        Bitmap Player5b = Properties.Resources.PlayerA5b;
        Bitmap Player6b = Properties.Resources.PlayerA6b;
        Bitmap Player7b = Properties.Resources.PlayerA7b;
        Bitmap Player8b = Properties.Resources.PlayerA8b;
        Bitmap Player9b = Properties.Resources.PlayerA9b;
        Bitmap Player10b = Properties.Resources.PlayerA10b;
        Bitmap Player1c = Properties.Resources.PlayerA1c;
        Bitmap Player2c = Properties.Resources.PlayerA2c;
        Bitmap Player3c = Properties.Resources.PlayerA3c;
        Bitmap Player4c = Properties.Resources.PlayerA4c;
        Bitmap Player5c = Properties.Resources.PlayerA5c;
        Bitmap Player6c = Properties.Resources.PlayerA6c;
        Bitmap Player7c = Properties.Resources.PlayerA7c;
        Bitmap Player8c = Properties.Resources.PlayerA8c;
        Bitmap Player9c = Properties.Resources.PlayerA9c;
        Bitmap Player10c = Properties.Resources.PlayerA10c;
        public Image Avatar( PictureBox Ava,int Armor, int Schleif)
        {
            if (Armor == 0)
            {
                if (Schleif==0)
                {
                    Ava.BackgroundImage = Player1;
                }
                else if (Schleif == 1)
                {
                    Ava.BackgroundImage = Player1a;
                }
                else if (Schleif == 2)
                {
                    Ava.BackgroundImage = Player1b;
                }
                else if (Schleif >= 3)
                {
                    Ava.BackgroundImage = Player1c;
                }
                // Ava.BackgroundImage = Player1;
            }
            else if (Armor > 0)
            {
                if (Armor == 1)
                {
                    if (Schleif == 0)
                    {
                        Ava.BackgroundImage = Player2;
                    }
                    else if (Schleif == 1)
                    {
                        Ava.BackgroundImage = Player2a;
                    }
                    else if (Schleif == 2)
                    {
                        Ava.BackgroundImage = Player2b;
                    }
                    else if (Schleif >= 3)
                    {
                        Ava.BackgroundImage = Player2c;
                    }
                }
                else if (Armor == 2)
                {
                    if (Schleif == 0)
                    {
                        Ava.BackgroundImage = Player3;
                    }
                    else if (Schleif == 1)
                    {
                        Ava.BackgroundImage = Player3a;
                    }
                    else if (Schleif == 2)
                    {
                        Ava.BackgroundImage = Player3b;
                    }
                    else if (Schleif >= 3)
                    {
                        Ava.BackgroundImage = Player3c;
                    }
                }
                else if (Armor == 3)
                {
                    if (Schleif == 0)
                    {
                        Ava.BackgroundImage = Player4;
                    }
                    else if (Schleif == 1)
                    {
                        Ava.BackgroundImage = Player4a;
                    }
                    else if (Schleif == 2)
                    {
                        Ava.BackgroundImage = Player4b;
                    }
                    else if (Schleif >= 3)
                    {
                        Ava.BackgroundImage = Player4c;
                    }
                }
                else if (Armor == 4)
                {
                    if (Schleif == 0)
                    {
                        Ava.BackgroundImage = Player5;
                    }
                    else if (Schleif == 1)
                    {
                        Ava.BackgroundImage = Player5a;
                    }
                    else if (Schleif == 2)
                    {
                        Ava.BackgroundImage = Player5b;
                    }
                    else if (Schleif >= 3)
                    {
                        Ava.BackgroundImage = Player5c;
                    }
                }
                else if (Armor == 5)
                {
                    if (Schleif == 0)
                    {
                        Ava.BackgroundImage = Player6;
                    }
                    else if (Schleif == 1)
                    {
                        Ava.BackgroundImage = Player6a;
                    }
                    else if (Schleif == 2)
                    {
                        Ava.BackgroundImage = Player6b;
                    }
                    else if (Schleif >= 3)
                    {
                        Ava.BackgroundImage = Player6c;
                    }
                }
                else if (Armor == 6)
                {
                    if (Schleif == 0)
                    {
                        Ava.BackgroundImage = Player7;
                    }
                    else if (Schleif == 1)
                    {
                        Ava.BackgroundImage = Player7a;
                    }
                    else if (Schleif == 2)
                    {
                        Ava.BackgroundImage = Player7b;
                    }
                    else if (Schleif >= 3)
                    {
                        Ava.BackgroundImage = Player7c;
                    }
                }
                else if (Armor == 7)
                {
                    if (Schleif == 0)
                    {
                        Ava.BackgroundImage = Player8;
                    }
                    else if (Schleif == 1)
                    {
                        Ava.BackgroundImage = Player8a;
                    }
                    else if (Schleif == 2)
                    {
                        Ava.BackgroundImage = Player8b;
                    }
                    else if (Schleif >= 3)
                    {
                        Ava.BackgroundImage = Player8c;
                    }
                }
                else if (Armor == 8)
                {
                    if (Schleif == 0)
                    {
                        Ava.BackgroundImage = Player9;
                    }
                    else if (Schleif == 1)
                    {
                        Ava.BackgroundImage = Player9a;
                    }
                    else if (Schleif == 2)
                    {
                        Ava.BackgroundImage = Player9b;
                    }
                    else if (Schleif >= 3)
                    {
                        Ava.BackgroundImage = Player9c;
                    }
                }
                else if (Armor >= 9)
                {
                    if (Schleif == 0)
                    {
                        Ava.BackgroundImage = Player10;
                    }
                    else if (Schleif == 1)
                    {
                        Ava.BackgroundImage = Player10a;
                    }
                    else if (Schleif == 2)
                    {
                        Ava.BackgroundImage = Player10b;
                    }
                    else if (Schleif >= 3)
                    {
                        Ava.BackgroundImage = Player10c;
                    }
                }

            }


            return Ava.BackgroundImage;
        }
    }
}
