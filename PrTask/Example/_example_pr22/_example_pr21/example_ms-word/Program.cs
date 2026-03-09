using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//не забываем добавить в свойства проекта, в Reference, нужную DLL, какую? смотрите пример :)
using Word = Microsoft.Office.Interop.Word;

namespace example_ms_word
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем новый документ Word
            Word.Application wdApp = new Word.Application();
            Word.Document wdDoc = null;
            Object wdMiss = System.Reflection.Missing.Value;

            wdDoc = wdApp.Documents.Add(ref wdMiss, ref wdMiss, ref wdMiss, ref wdMiss);

            // устанавливаем ориентацию (вид) документа
            wdDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientPortrait;

            // устанавливаем размеры полей
            wdDoc.PageSetup.TopMargin = wdApp.InchesToPoints(0.60f);    //0.67 = 1.7 см
            wdDoc.PageSetup.BottomMargin = wdApp.InchesToPoints(0.60f);
            wdDoc.PageSetup.LeftMargin = wdApp.InchesToPoints(0.80f);
            wdDoc.PageSetup.RightMargin = wdApp.InchesToPoints(0.59f);  //0.59 = 1.5 см

            // выводим документ на экран
            wdApp.Visible = true;

            // устанваливаем интервал между строками
            wdApp.ActiveWindow.Selection.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
            wdApp.ActiveWindow.Selection.ParagraphFormat.SpaceAfter = 0.0F;

            // вставляем новый параграф
            // имя параграфа
            Word.Paragraph oPara5b;
            oPara5b = wdDoc.Content.Paragraphs.Add(ref wdMiss);
            //текст в параграфе
            oPara5b.Range.Text = "СЛОВО";
            //выравнивание в документе
            oPara5b.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            //размер шрифта
            oPara5b.Range.Font.Size = Convert.ToInt32(26);
            oPara5b.Range.InsertParagraphAfter();
            // закрываем параграф
            oPara5b.CloseUp();

            // и так можно вставлять параграфв неограниченное количество
            Word.Paragraph oPara5;
            oPara5 = wdDoc.Content.Paragraphs.Add(ref wdMiss);
            oPara5.Range.Text = "Пример текста";
            oPara5.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            oPara5.Range.Font.Size = Convert.ToInt32(18);
            //свойство "жирности" текста
            oPara5.Range.Font.Bold = 1;
            oPara5.Range.InsertParagraphAfter();
            oPara5.CloseUp();

            Word.Paragraph oPara8;
            oPara8 = wdDoc.Content.Paragraphs.Add(ref wdMiss);
            oPara8.Range.Text = "Задание 3. ";
            oPara8.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            oPara8.Range.Font.Size = Convert.ToInt32(18);
            oPara8.Range.Font.Bold = 0;
            wdApp.ActiveWindow.Selection.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
            wdApp.ActiveWindow.Selection.ParagraphFormat.SpaceAfter = 0.0F;
            oPara8.Range.InsertParagraphAfter();
            oPara8.CloseUp();

            // вставляем разрыв страницы 
            Word.Paragraph Line20;
            Line20 = wdDoc.Content.Paragraphs.Add(ref wdMiss);
            Line20.Range.Text = string.Empty;
            Line20.Range.Font.Size = 1;
            object oCollapseEnd = Word.WdCollapseDirection.wdCollapseEnd;
            object oPageBreak = Word.WdBreakType.wdPageBreak;
            Line20.Range.Collapse(ref oCollapseEnd);
            Line20.Range.InsertBreak(ref oPageBreak);
            Line20.Range.Collapse(ref oCollapseEnd);
            Line20.Range.InsertParagraphAfter();
            Line20.CloseUp();

            // текст на новой странице
            Word.Paragraph oPara8a;
            oPara8a = wdDoc.Content.Paragraphs.Add(ref wdMiss);
            oPara8a.Range.Text = "текст на новой странице 14 шрифтом";
            oPara8a.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            oPara8a.Range.Font.Size = Convert.ToInt32(14);
            oPara8a.Range.Font.Bold = 0;
            wdApp.ActiveWindow.Selection.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
            wdApp.ActiveWindow.Selection.ParagraphFormat.SpaceAfter = 0.0F;
            oPara8a.Range.InsertParagraphAfter();
            oPara8a.CloseUp();

            // Сохранение документа в файл
            try
            {
				// можно прописать полный путь сохранения к файлу
				// по-умолчанию, файл сохраняется в мои документы
                object filename = @"_example_file_ms-word" + ".doc";
				
				//сохраняем документ на диске
                wdDoc.SaveAs(ref filename);
				
                // Закрываем текущий документ
                wdDoc.Close(ref wdMiss, ref wdMiss, ref wdMiss);
                wdDoc = null;
				
                // Закрываем приложение Word
                wdApp.Quit(ref wdMiss, ref wdMiss, ref wdMiss);
                wdDoc = null;
            }
            catch (Exception y)
            {
                Console.WriteLine("Ошибка сохранения документа", y.ToString());
            }
        }
    }
}
