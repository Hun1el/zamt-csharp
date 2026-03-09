using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Pr21
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void Task(object sender, EventArgs e)
        {
            int number;
            try
            {
                number = Convert.ToInt32(txtFourDigitNumber.Text);
                if (number < 1000 || number > 9999)
                {
                    MessageBox.Show("Введите корректное четырехзначное число.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Введите корректное четырехзначное число.");
                return;
            }

            int distance;
            try
            {
                distance = Convert.ToInt32(txtDistance.Text);
                if (distance <= 0)
                {
                    MessageBox.Show("Введите корректное (положительное) расстояние в сантиметрах.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Введите корректное (положительное) расстояние в сантиметрах.");
                return;
            }

            string str = txtString.Text;
            if (str.Length < 30)
            {
                MessageBox.Show("Строка должна содержать минимум 30 символов. Текущая длина: " + str.Length);
                return;
            }

            bool t2 = Task2(number);
            string result;

            if (t2)
            {
                result = "Цифры образуют возрастающую последовательность.";
            }
            else
            {
                result = "Цифры не образуют возрастающую последовательность.";
            }

            int metr = distance / 100;
            string mod = Replace(str, out int count);

            GenerateWordDocument(number, result, metr, str, mod, count);
        }

        private bool Task2(int number)
        {
            int digit = 10;
            while (number > 0)
            {
                int current = number % 10;
                if (current >= digit)
                    return false;
                digit = current;
                number /= 10;
            }
            return true;
        }


        private string Replace(string input, out int count)
        {
            char[] chars = input.ToCharArray();
            count = 0;

            for (int i = 1; i < chars.Length; i += 2)
            {
                chars[i] = '%';
                count++;
            }

            return new string(chars);
        }



        private void GenerateWordDocument(int number, string result, int metr, string str, string mod, int count)
        {
            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = null;
            object missing = System.Reflection.Missing.Value;

            try
            {
                wordDoc = wordApp.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                wordDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientPortrait;

                wordDoc.PageSetup.TopMargin = wordApp.InchesToPoints(0.60f);
                wordDoc.PageSetup.BottomMargin = wordApp.InchesToPoints(0.60f);
                wordDoc.PageSetup.LeftMargin = wordApp.InchesToPoints(0.80f);
                wordDoc.PageSetup.RightMargin = wordApp.InchesToPoints(0.59f);

                Word.Paragraph headerParagraph = wordDoc.Content.Paragraphs.Add(ref missing);
                headerParagraph.Range.Text = "МДК.01.01 Разработка программных модулей";
                headerParagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                headerParagraph.Range.Font.Size = 18;
                headerParagraph.Range.Font.Bold = 1;
                headerParagraph.Range.InsertParagraphAfter();

                Word.Paragraph subHeaderParagraph = wordDoc.Content.Paragraphs.Add(ref missing);
                subHeaderParagraph.Range.Text = "ПР21 «Программное создание документов MS Word в языке C#»";
                subHeaderParagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                subHeaderParagraph.Range.Font.Size = 16;
                subHeaderParagraph.Range.Font.Bold = 0;
                subHeaderParagraph.Range.InsertParagraphAfter();

                Word.Paragraph studentInfo = wordDoc.Content.Paragraphs.Add(ref missing);
                studentInfo.Range.Text = "Выполнил Солоников А.С., студент группы ИС-22А";
                studentInfo.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                studentInfo.Range.Font.Size = 16;
                studentInfo.Range.Font.Bold = 0;
                studentInfo.Range.InsertParagraphAfter();

                Word.Paragraph taskResults = wordDoc.Content.Paragraphs.Add(ref missing);
                taskResults.Range.Text = $"Задание 1:\nНачальное число: {number}\nРезультат: {result}\n\n" +
                                         $"Задание 2:\nНачальное расстояние: {metr * 100} см\nПолных метров: {metr}\n\n" +
                                         $"Задание 3:\nНачальная строка: {str}\nМодифицированная строка: {mod}\n" +
                                         $"Количество замен: {count}";
                taskResults.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                taskResults.Range.Font.Size = 14;
                taskResults.Range.Font.Bold = 0;
                taskResults.Range.InsertParagraphAfter();

                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Pr21Var17.docx";
                object filename = filePath;
                wordDoc.SaveAs2(ref filename);
                wordDoc.Close(ref missing, ref missing, ref missing);
                wordApp.Quit(ref missing, ref missing, ref missing);

                MessageBox.Show("Документ успешно создан и сохранен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании документа: " + ex.Message);
            }
            finally
            {
                if (wordDoc != null)
                {
                    try 
                    {
                        wordDoc.Close(ref missing, ref missing, ref missing);
                    }
                    catch 
                    { 

                    }
                }
                if (wordApp != null)
                {
                    try 
                    {
                        wordApp.Quit(ref missing, ref missing, ref missing);
                    } 
                    catch
                    {

                    }
                }
            }
        }





        private void lblFourDigitNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblDistance_Click(object sender, EventArgs e)
        {

        }

        private void txtString_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
