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

        private OleDbConnection connectionDb = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=userspasswords.mdb"); // Habilita la conexión a la DB


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

        } // Habilita el cuadro que contiene los parámetros para poder crear usuarios provisionales

        private void ingresar_Click(object sender, EventArgs e)
        {

            // Condición para poder realizar el LogIn
            bool condLogIn1 = ((username.Text == null) && (password.Text == null));

            condLogIn1 = true;

            // Uso de la condición para poder realizar el Log In en conjunto con el método "usersPasswReader" para poder realizar la autenticación al sistema
            if (condLogIn1 != true)
            {
                try
                {

                    ReadDataBase loginDBReader = new ReadDataBase();
                    loginDBReader.usersPasswReader(username.Text, password.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DBReader Error" + ex);
                }
                finally
                {
                    connectionDb.Close();
                    ValidPregSeg UserValid = new ValidPregSeg();
                    UserValid.ShowDialog();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un nombre de usuario/contraseña correctos.");
            }

        } // Acccede a la DB y revisa que el usuario esté registrado y permite el acceso al SGA

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


            // Condiciones para poder realizar la creación del usuario.
            bool condCteUser1 = (textced.Text == null) && (textnomb.Text == null) && (textapel.Text == null) && (texttercniv.Text == null) && (textcuarniv.Text == null) && (textquinniv.Text == null) && (textusername.Text == null) && (textcont.Text == null);

            bool condCteUser2 = (cmbBoxPreg1.Text == null) && (cmbBoxPreg2.Text == null) && (cmbBoxPreg3.Text == null) && (cmbBoxPreg4.Text == null) && (cmbBoxPreg5.Text == null);

            bool condCteUser3 = (textRespPreg1.Text == null) && (textRespPreg2.Text == null) && (textRespPreg3.Text == null) && (textRespPreg4.Text == null) && (textRespPreg5.Text == null);

            bool condCteUserGlobal = (condCteUser1 && condCteUser2 && condCteUser3);

            condCteUserGlobal = true;

            try
            {

                if (condCteUserGlobal != true)
                {

                    //Se crea el usuario que se desea agregar; En caso de error, revisar clase "InsDocInfo"
                    InsDocInfo Docente = new InsDocInfo();


                    //Se utiliza el "DocInfoInsert" Method de la clase "InsDocInfo" para poder agregar información básica del usuario a la base de datos
                    Docente.DocInfoInsert(textced, textnomb, textapel, texttercniv, textcuarniv, textquinniv, textusername, textcont, cmbBoxPreg1, textRespPreg1, cmbBoxPreg2, textRespPreg2, cmbBoxPreg3, textRespPreg3, cmbBoxPreg4, textRespPreg4, cmbBoxPreg5, textRespPreg5);


                    MessageBox.Show("Se ha registrado correctamente el usuario.");

                    grpBoxCteAcc.Visible = false;
                    this.Width = 413;
                    this.Height = 300;
                    this.CenterToScreen();
                }
                else
                {
                    MessageBox.Show("Ingrese la información correspondiente en los campos para poder registrar el usuario.");
                }
            }
            catch
            {
                MessageBox.Show("Error BC1");
            }
            finally
            {
                textced.Text = "";
                textnomb.Text = "";
                textapel.Text = "";
                texttercniv.Text = "";
                textcuarniv.Text = "";
                textquinniv.Text = "";
                textusername.Text = "";
                textcont.Text = "";
                cmbBoxPreg1.SelectedText = "";
                textRespPreg1.Text = "";
                cmbBoxPreg2.SelectedText = "";
                textRespPreg2.Text = "";
                cmbBoxPreg3.SelectedText = "";
                textRespPreg3.Text = "";
                cmbBoxPreg4.SelectedText = "";
                textRespPreg4.Text = "";
                cmbBoxPreg5.SelectedText = "";
                textRespPreg5.Text = "";
            }

        } // Confirma la creación del usuario e ingresa los datos en el DB de usuarios

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            grpBoxCteAcc.Visible = false;
            this.Width = 413;
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
        } // Permite solicitar la recuperación de la contraseña

        private void buttonVerDatos_Click(object sender, EventArgs e)
        {
            ReadDataBase readDB = new ReadDataBase();

            readDB.readVerifDatos(textced.Text, textusername.Text);

        }


    }
}
