using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5oop
{
    public partial class Form1 : Form
    {
        public Form1()
       
        {
            InitializeComponent();
            this.BackColor = Color.LightGray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Opacity = 1.5 - Opacity;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.LightGray)
            {
                this.BackColor = Color.Red;
            }
            else if (this.BackColor == Color.Red)
            {
                this.BackColor = Color.Yellow;
            }
            else if (this.BackColor == Color.Yellow)
            {
                this.BackColor = Color.Green;
            }
            else if (this.BackColor == Color.Green)
            {
                this.BackColor = Color.LightGray;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello World.\nHome заблокований з відміною карантину");
        }

        private void btnSetOfActions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnSetOfActions.Click += button2_Click;
            }
            else
            {
                btnSetOfActions.Click -= button2_Click;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                btnSetOfActions.Click += button3_Click;
            }
            else
            {
                btnSetOfActions.Click -= button3_Click;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                btnSetOfActions.Click += button4_Click;
            }
            else
            {
                btnSetOfActions.Click -= button4_Click;
            }
    }
    }
}
