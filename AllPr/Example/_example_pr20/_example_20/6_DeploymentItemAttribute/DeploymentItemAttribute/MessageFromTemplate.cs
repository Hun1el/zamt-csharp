using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeploymentItemAttributeSample
{
    public class MessageFromTemplate
    {
        public string TemplateFolder { get; set; }

        public string FromTemplate(string name, string level, DateTime creationTime)
        {
            string path = Path.Combine(TemplateFolder, "ExamCreatedTemplate.txt");
            string template = File.ReadAllText(path);
            template = template.Replace("{Name}", name);
            template = template.Replace("{Level}", level);
            template = template.Replace("{DateAndTime}", creationTime.ToLongDateString());

            return template;
        }
    }
}
