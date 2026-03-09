using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr18
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number) && number > 99 && number < 1000)
            {
                if (number % 2 == 0)
                {
                    label2.Text = "Число четное.";
                }
                else
                {
                    label2.Text = "Число нечетное.";
                }
            }
            else
            {
                label2.Text = "Введите корректное трехзначное число.";
            }
        }
    }
}
