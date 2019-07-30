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
    public partial class Classic : Form
    {
        bool turn = true; //if true player1 turn
        int turnCount = 0;
        
        public Classic()
        {
            InitializeComponent();
        }
        private void Classic_Load(object sender, EventArgs e)
        {
            label1.Text = "Player O Turn";
        }

        private void Set_StartBtn(object sender, EventArgs e)
        {
            Button[] buttons = new Button[] { a1, c1, a2, a3, b3, b2, b1, c3, c2 };
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
                if (turn==true)
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
                if (turnCount >=5)
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
            if ((a1.Text == a2.Text)&&(a2.Text==a3.Text)&&(a1.Text != "")){
                thereIsAWinner = true;
            }else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (b1.Text != ""))
            {
                thereIsAWinner = true;
            }else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (c1.Text != ""))
            { 
                thereIsAWinner = true;//horizantl
            }else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (a1.Text != ""))
            {
                thereIsAWinner = true;
            }else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (a3.Text != ""))
            {
                thereIsAWinner = true;//slash
            }
            else if ((a1.Text == b1.Text)&&(b1.Text==c1.Text) && (a1.Text != ""))
            {
                thereIsAWinner = true;
            }
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (a2.Text != ""))
            {
                thereIsAWinner = true;
            }
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (a3.Text != ""))
            {
                thereIsAWinner = true;//ver
            }
            if (thereIsAWinner)
            {
                string w = "";
                if (turn)
                    w = "O";
                else w = "X";
                MessageBox.Show("The Winner is: " + w );
            }
            else if (turnCount==9)
            {
                MessageBox.Show("It's a draw!!");
            }
        }

        private void Classic_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
