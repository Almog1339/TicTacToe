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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Classic treeOnTree = new Classic();
            treeOnTree.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HardMode vs = new HardMode();
            vs.Show();
        }
    }
}
