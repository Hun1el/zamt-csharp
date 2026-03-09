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
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            bool isOrdered = true;
            int index = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]) && char.IsDigit(input[i - 1]))
                {
                    if (input[i] < input[i - 1])
                    {
                        isOrdered = false;
                        index = i;
                        break;
                    }
                }
            }

            if (isOrdered)
            {
                label2.Text = "0";
            }
            else
            {
                label2.Text = $"Нарушение на индексе: {index}";
            }
        }
    }
}
