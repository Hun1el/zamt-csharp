using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Русский")
            {
                label1.Text = "Выберите язык";
                button1.Text = "Применить";
                button2.Text = "Отмена";
            }
            if (comboBox1.Text == "English")
            {
                label1.Text = "Choise language";
                button1.Text = "Apply";
                button2.Text = "Cancel";
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (NullPage.Licence == 1)
            {
                this.maskedTextBox1.Enabled = false;
            }
            if (NullPage.Choise == 1)
            {
                label1.Text = "Выберите язык";
                button1.Text = "Применить";
                button2.Text = "Отмена";
                comboBox1.Text = "Русский";
            }
            if (NullPage.Choise == 2)
            {
                label1.Text = "Choise language";
                button1.Text = "Apply";
                button2.Text = "Cancel";
                comboBox1.Text = "English";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Русский")
            {
                NullPage.Choise = 1;
            }
            if (comboBox1.Text == "English")
            {
                NullPage.Choise = 2;
            }
            Form1 form = new Form1();
            form.Show();
            this.Visible = false;

            string Key;
            Key = maskedTextBox1.Text;
            if (Key == "1234-1234-1234-1234")
            {
                NullPage.Licence = 1;
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey Project = currentUserKey.CreateSubKey("Project");
                Project.SetValue("Licence", NullPage.Licence);
                Project.Close();
                MessageBox.Show("Программа активирована");
                form.Text = "SUPER - MEGA - RASCHET";
                this.maskedTextBox1.Enabled = false;
            }
            //РАЗРАБОТЧИК, A2#D-12Z4-$9K!-A!2Q ЭТО НЕ КЛЮЧ!!!
        }
    }
}
