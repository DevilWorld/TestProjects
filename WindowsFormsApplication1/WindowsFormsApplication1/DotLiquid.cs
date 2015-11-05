using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotLiquid;

namespace WindowsFormsApplication1
{
    class DotLiquid
    {
        public static void test( bool blnNameSpace)
        {
            Template template = Template.Parse("hi, {{name}}" + Environment.NewLine + "{{name}}");
            var result = template.Render(Hash.FromAnonymousObject(new {name = "Robert"}));
        }
    }

    public class User
    {
        public string FirstName;
        public string LastName;
    }
}
