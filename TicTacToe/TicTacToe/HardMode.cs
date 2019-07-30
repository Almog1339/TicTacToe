using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class HardMode : Form
    {
        bool turn = true; //if true player1 turn
        int turnCount = 0;
        public HardMode()
        {
            InitializeComponent();
        }
        private void Set_StartBtn(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            Button[] buttons = new Button[] { a1, c1, a2, a3, a4, b4, b3, b2, b1, c3, c2, c4, d1, d2, d3, d4 };
            turnCount = 0;
            turn = true;
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = "";
                buttons[i].Enabled = true;
            }
        }

        private void BtnClicker(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                if (turn == true)
                {
                    b.Text = "X";
                    label1.Text = "Player O Turn";
                }
                else
                {
                    b.Text = "O";
                    label1.Text = "Player X Turn";
                }
                turn = !turn;
                turnCount++;
                b.Enabled = false;
                if (turnCount >= 7)
                {
                    CheckForWinning();
                }
            }
            catch (Exception)
            {

            }
        }
        private void CheckForWinning()
        {
            bool thereIsAWinner = false;
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (a3.Text == a4.Text) && (a1.Text != ""))
            {
                thereIsAWinner = true;
            }
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (b3.Text == b4.Text) && (b1.Text != ""))
            {
                thereIsAWinner = true;
            }
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (c3.Text == c4.Text) && (c1.Text != ""))
            {
                thereIsAWinner = true;
            }
            else if ((d1.Text == d2.Text) && (d2.Text == d3.Text) && (d3.Text == d4.Text) && (d1.Text != ""))
            {
                thereIsAWinner = true;//horizantl
            }
            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (c3.Text == d4.Text) && (a1.Text != ""))
            {
                thereIsAWinner = true;
            }
            else if ((a4.Text == b3.Text) && (b3.Text == c2.Text) && (c2.Text == d1.Text) && (a4.Text != ""))
            {
                thereIsAWinner = true;//slash
            }
            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (c1.Text == d1.Text) && (a1.Text != ""))
            {
                thereIsAWinner = true;
            }
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (c2.Text == d2.Text) && (a2.Text != ""))
            {
                thereIsAWinner = true;
            }
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (c3.Text == d3.Text) && (a3.Text != ""))
            {
                thereIsAWinner = true;
            }
            else if ((a4.Text == b4.Text) && (b4.Text == c4.Text) && (c4.Text == d4.Text) && (a4.Text != ""))
            {
                thereIsAWinner = true;//ver
            }
            if (thereIsAWinner)
            {
                string w = "";
                if (turn)
                    w = "O";
                else w = "X";
                MessageBox.Show("The Winner is: " + w + " click Ok to reset the game");
                Reset();
            }
            else if (turnCount == 13)
            {
                MessageBox.Show("It's a draw!!");
                Reset();
            }
        }

        private void Classic_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
