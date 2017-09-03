using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;


namespace LoginSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cteuser_Click(object sender, EventArgs e)
        {
            
            cteaccwind cteaccwind = new cteaccwind();
            cteaccwind.ShowDialog();   
            
        }
    }
}
