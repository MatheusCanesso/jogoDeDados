using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projJogoDados
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSorteio_Click(object sender, EventArgs e)
        {
            int num1 = random.Next(1, 7);

            if(num1 == 1)
            {
                pictureBox1.Image = Properties.Resources.dado1;
            } else if(num1 == 2){
                pictureBox1.Image = Properties.Resources.dado2;
            } else if(num1 == 3)
            {
                pictureBox1.Image = Properties.Resources.dado3;
            } else if(num1 == 4)
            {
                pictureBox1.Image = Properties.Resources.dado4;
            } else if(num1 == 5)
            {
                pictureBox1.Image = Properties.Resources.dado5;
            } else
            {
                pictureBox1.Image = Properties.Resources.dado6;
            }
        }
    }
}
