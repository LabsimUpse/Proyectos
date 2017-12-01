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
          

        public cteaccwind()
        {
            InitializeComponent();

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

          //  using (var cmd = new OleDbCommand("INSERT INTO [Usuarios-Contrseñas] (Nombres, Apellidos, Título (Tercer Nivel), Título (Cuarto Nivel), Título (Quinto Nivel), Usuario, Contraseña) Values (?)", connDb)) ;
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

<<<<<<< HEAD
        private void textcuarniv_TextChanged(object sender, EventArgs e)
        {

        }

        private void textquinniv_TextChanged(object sender, EventArgs e)
        {

        }

        private void cteaccwind_Load(object sender, EventArgs e)
        {
           // var connDb = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=Usuarios-Contraseñas.mdb;");
           // connDb.Open();
            
        }

        private void textcont_TextChanged(object sender, EventArgs e)
        {

        }

        private void textusername_TextChanged(object sender, EventArgs e)
        {
=======
        private void cteaccwind_Load(object sender, EventArgs e)
        {
>>>>>>> 8c17afed8c23815e29cb31e80cf3e3c8e3a4d543

        }
    }
}
