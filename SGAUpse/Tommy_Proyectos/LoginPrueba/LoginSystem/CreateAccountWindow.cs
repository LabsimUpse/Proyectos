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
    public partial class cteaccwind : Form
    {
        public cteaccwind()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = xla.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)xla.ActiveSheet;

            xla.Visible = true;

            ws.Cells[1, 1] = "Cédula";
            ws.Cells[2, 1] = "Nombres";
            ws.Cells[3, 1] = "Apellidos";
            ws.Cells[4, 1] = "Título Universitario";
            ws.Cells[5, 1] = "Usuario";

            ws.Cells[1, 2] = textced.Text;
            ws.Cells[2, 2] = textnomb.Text;
            ws.Cells[3, 2] = textapel.Text;
            ws.Cells[4, 2] = texttitun.Text;
            ws.Cells[5, 2] = textuser.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
