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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n) && n > 999 && n < 10000)
            {
                int firstTwo = (n / 1000) * (n / 100 % 10);
                int lastTwo = (n % 100 / 10) * (n % 10);
                int difference = firstTwo - lastTwo;

                label2.Text = $"Разница: {difference}";
            }
            else
            {
                label2.Text = "Введите корректное четырехзначное число.";
            }
        }
    }
}
