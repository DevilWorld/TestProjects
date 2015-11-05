using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class SysObjects
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string XType { get; set; }
        public virtual List<string> Columns { get; set; }
    }
}

