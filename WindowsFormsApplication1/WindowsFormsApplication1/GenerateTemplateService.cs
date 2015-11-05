using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotLiquid;

namespace WindowsFormsApplication1
{
    class GenerateTemplateService : IGenerateTemplate
    {
        public string Generate(TemplateForObject objectType, SysObjects sysobjects)
        {
            if (objectType == TemplateForObject.Class)
            {
                Template templateClass = Template.Parse();
            }

            return string.Empty;
        }

        private string GetTemplateString()
        {
            StringBuilder sbTemplate = new StringBuilder();
            sbTemplate.Append("public class {{className}}");
            sbTemplate.AppendLine();
            sbTemplate.Append("\t");
            sbTemplate.Append()
        }
    }
}
