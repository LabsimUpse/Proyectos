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

        DatabaseConnection connDB;



        public loginwind()
        {
            InitializeComponent();

        }

        private void cteuser_Click(object sender, EventArgs e)
        {
            grpBoxCteAcc.Visible = true;
            this.Height = 700;
            this.Width = 850;
            this.CenterToScreen();

        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            connectionDb.Open();
            OleDbCommand cmdDb = new OleDbCommand();
            cmdDb.Connection = connectionDb;
            cmdDb.CommandText = "select 1 from userpassw where Username='" + username.Text + "' and Password='" + password.Text +"'";
            OleDbDataReader reader = cmdDb.ExecuteReader();


                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Login Successfull");
                    SistGestMainWind SistGestMainWind = new SistGestMainWind();
                    SistGestMainWind.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("There are two accounts with the same username and password");
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
            try
            {
                connectionDb.Open();
                MessageBox.Show("Connection Successful");
                connectionDb.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            
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
            this.Width = 350;
            this.Height = 300;

        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            grpBoxCteAcc.Visible = false;
            this.Width = 350;
            this.Height = 300;
            this.CenterToScreen();
        }

    }
}
