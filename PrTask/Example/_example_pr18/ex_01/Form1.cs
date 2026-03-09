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
//даны 2 числа А и В (А<=В)
//вывести на форму все символы между данными числами
namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int Demo = 1;
        Settings settings = new Settings();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            if (NullPage.Choise == 1)
            {
                textBox3.Text = "Ответ: ";
            }
            if (NullPage.Choise == 2)
            {
                textBox3.Text = "Answer: ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0,z = 0;
            if (NullPage.Licence == 1)
            {
                try
                {
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    if (a <= b)
                    {
                        if (NullPage.Choise == 1)
                        {
                            textBox3.Text = "Ответ: ";
                        }
                        if (NullPage.Choise == 2)
                        {
                            textBox3.Text = "Answer: ";
                        }
                        for (int c = a; c <= b; c++)
                        {
                            textBox3.Text += Convert.ToString(c) + " ";
                            z += c;
                        }
                        if (NullPage.Choise == 1)
                        {
                            textBox3.Text += Environment.NewLine + Environment.NewLine + "Сумма чисел = " + z;
                        }
                        if (NullPage.Choise == 2)
                        {
                            textBox3.Text += Environment.NewLine + Environment.NewLine + "Number summ = " + z;
                        }
                    }
                    else
                    {
                        if (NullPage.Choise == 1)
                        {
                            textBox3.Text = "Ошибка. 'В' должно быть больше, чем 'А'";
                        }
                        if (NullPage.Choise == 2)
                        {
                            textBox3.Text = "Error. 'B' must be greater then 'A'";
                        }

                    }
                }
                catch (FormatException n1)
                {
                    if (NullPage.Choise == 1)
                    {
                        textBox3.Text = "Число имеет неверный формат";
                    }
                    if (NullPage.Choise == 2)
                    {
                        textBox3.Text = "Number have wrong format";
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                catch (OverflowException n1)
                {
                    if (NullPage.Choise == 1)
                    {
                        textBox3.Text = "Ой! Переполнение";
                    }
                    if (NullPage.Choise == 2)
                    {
                        textBox3.Text = "Oops! Overflow";
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            if (Demo != 0 && NullPage.Licence == 0)
            {
                try
                {
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    if (a <= b)
                    {
                        if (NullPage.Choise == 1)
                        {
                            textBox3.Text = "Ответ: ";
                        }
                        if (NullPage.Choise == 2)
                        {
                            textBox3.Text = "Answer: ";
                        }
                        for (int c = a; c <= b; c++)
                        {
                            textBox3.Text += Convert.ToString(c) + " ";
                            z += c;
                        }
                        if (NullPage.Choise == 1)
                        {
                            textBox3.Text += Environment.NewLine + Environment.NewLine + "Сумма чисел = " + z;
                        }
                        if (NullPage.Choise == 2)
                        {
                            textBox3.Text += Environment.NewLine + Environment.NewLine + "Number summ = " + z;
                        }
                    }
                    else
                    {
                        if (NullPage.Choise == 1)
                        {
                            textBox3.Text = "Ошибка. 'В' должно быть больше, чем 'А'";
                        }
                        if (NullPage.Choise == 2)
                        {
                            textBox3.Text = "Error. 'B' must be greater then 'A'";
                        }

                    }
                }
                catch (FormatException n1)
                {
                    if (NullPage.Choise == 1)
                    {
                        textBox3.Text = "Число имеет неверный формат";
                    }
                    if (NullPage.Choise == 2)
                    {
                        textBox3.Text = "Number have wrong format";
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                catch (OverflowException n1)
                {
                    if (NullPage.Choise == 1)
                    {
                        textBox3.Text = "Ой! Переполнение";
                    }
                    if (NullPage.Choise == 2)
                    {
                        textBox3.Text = "Oops! Overflow";
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                Demo--;
            }
            else if (Demo == 0)
            {
                textBox3.Text = "ДЕМО-ВЕРСИЯ ОКОНЧЕНА!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Settings settings = new Settings();
            settings.Show();
            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "SUPER - MEGA - RASCHET (не активирована)";
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey Project = currentUserKey.OpenSubKey("Project");
                string Key = Project.GetValue("Licence").ToString();
                Project.Close();
                if (Key == "1")
                {
                    NullPage.Licence = 1;
                    this.Text = "SUPER - MEGA - RASCHET";
                }
                else
                {
                    this.Text = "SUPER - MEGA - RASCHET (не активирована)";
                }

                if (NullPage.Choise == 1)
                {
                    label4.Text = "Введите А и В";
                    button1.Text = "Выход";
                    button2.Text = "Очистить";
                    button3.Text = "Вывести";
                }
                if (NullPage.Choise == 2)
                {
                    label4.Text = "Input А and В";
                    button1.Text = "Exit";
                    button2.Text = "Clear";
                    button3.Text = "Output";
                }
            }
            catch(ArgumentNullException)
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey Project = currentUserKey.CreateSubKey("Project");
                Project.SetValue("Licence", 0);
                Project.Close();
            }
            catch(System.NullReferenceException)
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey Project = currentUserKey.CreateSubKey("Project");
                Project.SetValue("Licence", 0);
                Project.Close();
            }
        }
    }
}
