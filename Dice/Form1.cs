using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice
{
    public partial class Dice : Form
    {
        bool isEven = false;

        public Dice()
        {
            InitializeComponent();
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            number1.Text = r.Next(1, 6).ToString();
            number2.Text = r.Next(1, 6).ToString();
            number3.Text = r.Next(1, 6).ToString();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            output.Clear();
            int n1 = Convert.ToInt16(number1.Text);
            int n2 = Convert.ToInt16(number2.Text);
            int n3 = Convert.ToInt16(number3.Text);

            int dice1 = getDice1(n1, n2, n3);
            int dice2 = getDice2(dice1, n1, n2, n3);

            output.AppendText("Dice 1: " + dice1.ToString() + "\n" + "Dice 2: " + dice2.ToString());
        }

        public int getDice1(int number1, int number2, int number3)
        {
            int i = (number1 + number2 + number3) % 6;
            if (i == 0)
            {
                return 6;
            }
            else {
                return i;
            }
        }

        public int getDice2(int dice1, int number1, int number2, int number3)
        {
            int temp1 = number1;
            int temp2 = number2;
            int temp3 = number3;
            int tempDice = dice1 % 2;

            //if even do things
            if (tempDice == 0)
            {
                isEven = true;
                temp1 = 7 - number1;
                temp2 = 7 - number2;
                temp3 = 7 - number3;
            }

            //check if 2 different even numbers
            if (temp1 == 2 || temp1 == 4 || temp1 == 6)
            {
                if (temp2 == 2 || temp2 == 4 || temp2 == 6)
                {
                    return temp3;
                }
                else if (temp3 == 2 || temp3 == 4 || temp3 == 6)
                {
                    return temp2;
                }

            }
            else if (temp2 == 2 || temp2 == 4 || temp2 == 6)
            {
                if (temp3 == 2 || temp3 == 4 || temp3 == 6)
                {
                    return temp1;
                }
            }
            else if (dice1 == 3 || dice1 == 6)
            {
                int i = 0;
                if (temp1 == 2 && temp2 == 2 && temp3 == 5)
                {
                    return edgeCase();

                }
                else {
                    i = calculateDifferent(temp1, temp2, temp3);
                }

                if (temp1 == 2 && temp2 == 5 && temp3 == 2)
                {
                    return edgeCase();
                }
                else {
                    i = calculateDifferent(temp1, temp2, temp3);
                }

                if (temp1 == 5 && temp2 == 2 && temp3 == 2)
                {
                    return edgeCase();
                }
                else {
                    i = calculateDifferent(temp1, temp2, temp3);
                }

                return i * 2;

            }
            else if (number1 == number2)
            {
                return temp3 + 1;
            }
            else if (number1 == number3)
            {
                return temp2 + 1;
            }
            else if (number2 == number3)
            {
                return temp1 + 1;
            }

            return 0;

        }

        public int calculateDifferent(int i1, int i2, int i3)
        {
            int counter = 0;
            if (i1 != i2)
            {
                counter += 1;
            }
            if (i1 != i3)
            {
                counter += 1;
            }
            if (i2 != i3)
            {
                counter += 1;
            }

            return counter + 1;
        }

        public int edgeCase()
        {
            if (isEven)
            {
                return 5;
            }
            else {
                return 2;
            }
        }
    }
}
