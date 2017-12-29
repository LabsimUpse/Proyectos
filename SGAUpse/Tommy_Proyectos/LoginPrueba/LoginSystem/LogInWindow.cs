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
//------------------------------------
using System.Data.OleDb;


namespace LoginSystem
{
    public partial class loginwind : Form
    {
        
        private OleDbConnection connectionDb = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=userspasswords.mdb");

        public loginwind()
        {
            InitializeComponent();

        }

        private void cteuser_Click(object sender, EventArgs e)
        {
            grpBoxCteAcc.Visible = true;
            this.Height = 650;
            this.Width = 850;
            this.CenterToScreen();

        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                ReadDataBase loginDBReader = new ReadDataBase();
                loginDBReader.usersPasswReader(textusername.Text, textcont.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DBReader Error" + ex);
            }
            finally
            {
                connectionDb.Close();
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginwind_Load(object sender, EventArgs e)
        {
            this.Height = 300;
            this.Width = 413;

            DatabaseConnection DBTest = new DatabaseConnection();
            DBTest.DBConnectionTester();
            this.CenterToScreen();

        }

        private void menubarlogin_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitmenuitem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpBoxCteAcc_Enter(object sender, EventArgs e)
        {
            
        }

        private void textced_TextChanged(object sender, EventArgs e)
        {

        }

        private void textnomb_TextChanged(object sender, EventArgs e)
        {

        }

        private void textapel_TextChanged(object sender, EventArgs e)
        {

        }

        private void texttercniv_TextChanged(object sender, EventArgs e)
        {

        }

        private void textcuarniv_TextChanged(object sender, EventArgs e)
        {

        }

        private void textquinniv_TextChanged(object sender, EventArgs e)
        {

        }

        private void textusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textcont_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoncreate_Click(object sender, EventArgs e)
        {
            
            //Se crea el usuario que se desea agregar; En caso de error, revisar clase "InsDocInfo"
            InsDocInfo Docente = new InsDocInfo();


            //Se utiliza el "DocInfoInsert" Method de la clase "InsDocInfo" para poder agregar el usuario a la base de datos
            Docente.DocInfoInsert(textced, textnomb, textapel, texttercniv, textcuarniv, textquinniv, textusername, textcont);
            
            
            grpBoxCteAcc.Visible = false;
            this.Width = 413;
            this.Height = 300;

        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            grpBoxCteAcc.Visible = false;
            this.Width = 350;
            this.Height = 300;
            this.CenterToScreen();
        }

        private void cmbBoxRecPassMet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpBoxRecPass_Enter(object sender, EventArgs e)
        {

        }

        private void textRespPreg4_TextChanged(object sender, EventArgs e)
        {

        }

        private void passrecov_Click(object sender, EventArgs e)
        {
            grpBoxRecPass.Visible = true;
            this.Height = 850;
            this.Width = 350;
            this.CenterToScreen();
        }

    }
}
