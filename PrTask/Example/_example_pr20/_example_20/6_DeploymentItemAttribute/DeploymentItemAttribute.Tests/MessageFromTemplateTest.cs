using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeploymentItemAttributeSample;
using System.IO;

namespace DeploymentItemAttributeSample.Tests
{
    // Для файлов в директории Files свойствy "Copy to Output Directory" установлено значение "copy if never"
    [TestClass]
    public class MessageFromTemplateTest
    {
        // DeploymentItem - используется для определения директорий или файлов, которые нужно скопировать в директорию
        // TestResults для доступа во время запуска тестов.
        [TestMethod]
        [DeploymentItem("Files\\ExamCreatedResult.txt")]
        [DeploymentItem("Files\\ExamCreatedTemplate.txt")]
        public void FromTemplate_PassTestValue_StringFromTemplateReturned()
        {
            MessageFromTemplate messageBuilder = new MessageFromTemplate();
            messageBuilder.TemplateFolder = ".";

            string expectedResult = File.ReadAllText("ExamCreatedResult.txt");

            string actualResult = messageBuilder.FromTemplate("TestExam", "Beginer", new DateTime(2000, 1, 1));

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
