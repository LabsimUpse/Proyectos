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
//-----------------------------------
using System.Data.OleDb;

namespace LoginSystem
{
    public partial class cteaccwind : Form
    {

        DatabaseConnection connDB;

        public cteaccwind()
        {
            InitializeComponent();
            connDB = new DatabaseConnection();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textced_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void texttercniv_TextChanged(object sender, EventArgs e)
        {

        }

        private void textapel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textnomb_TextChanged(object sender, EventArgs e)
        {


        }

        private void buttoncreate_Click(object sender, EventArgs e)
        {
            DocInfo Doc = new DocInfo();
            Doc.CI1 = textced.Text;
            Doc.Nombres1 = textnomb.Text;
            Doc.Apellidos1 = textapel.Text;
            Doc.Titulo1a = texttercniv.Text;
            Doc.Titulo2a = textcuarniv.Text;
            Doc.Titulo3a = textquinniv.Text;
            Doc.Usuario1 = textusername.Text;
            Doc.Password1 = textcont.Text;

            connDB.dataInsert(Doc);
            this.Close();
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textcuarniv_TextChanged(object sender, EventArgs e)
        {

        }

        private void textquinniv_TextChanged(object sender, EventArgs e)
        {

        }

        private void cteaccwind_Load(object sender, EventArgs e)
        {
            
        }

        private void textcont_TextChanged(object sender, EventArgs e)
        {

        }

        private void textusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
