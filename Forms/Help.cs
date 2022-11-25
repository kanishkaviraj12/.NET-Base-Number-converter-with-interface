using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_converter_interface.Forms
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            string filePath = (Application.StartupPath + "\\Help" + "\\project proposal.pdf");//location of pdf
            //openfile(filePath);
            axAcroPDF1.LoadFile(filePath);
        }
    }
}
