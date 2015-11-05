using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private readonly ILogger _logger;

        public Form1(ILogger logger)
        {
            InitializeComponent();

            _logger = logger;
        }
    }

    public interface ILogger
    {
        void Log();
    }

    public class FileLogger : ILogger
    {
        public void Log()
        {

        }
    }
}
