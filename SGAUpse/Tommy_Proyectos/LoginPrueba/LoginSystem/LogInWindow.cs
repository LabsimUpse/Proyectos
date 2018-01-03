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

            try
            {

                bool condCteUser1, condCteUser2, condCteUser3, condCteUserGlobal;

                condCteUser1 = (textced == null) && (textnomb == null) && (textapel == null) && (texttercniv == null) && (textcuarniv == null) && (textquinniv == null) && (textusername == null) && (textcont == null);

                condCteUser2 = (cmbBoxPreg1 == null) && (cmbBoxPreg2 == null) && (cmbBoxPreg3 == null) && (cmbBoxPreg4 == null) && (cmbBoxPreg5 == null);

                condCteUser3 = (textRespPreg1 == null) && (textRespPreg2 == null) && (textRespPreg3 == null) && (textRespPreg4 == null) && (textRespPreg5 == null);

                condCteUserGlobal = condCteUser1 && condCteUser2 && condCteUser3;

                if (condCteUserGlobal != true)
                {
                    //Se crea el usuario que se desea agregar; En caso de error, revisar clase "InsDocInfo"
                    InsDocInfo Docente = new InsDocInfo();


                    //Se utiliza el "DocInfoInsert" Method de la clase "InsDocInfo" para poder agregar información básica del usuario a la base de datos
                    Docente.DocInfoInsert(textced, textnomb, textapel, texttercniv, textcuarniv, textquinniv, textusername, textcont);

                    //Se utiliza el "DocInfoPregInsertar" Method de la clase "InsDocInfo" para poder agregar las preguntas de seguridad seleccionadas por el usuario a la base de datos
//                    Docente.DocInfoPregInsertar(cmbBoxPreg1, cmbBoxPreg2, cmbBoxPreg3, cmbBoxPreg4, cmbBoxPreg5);

                    //Se utiliza el "DocInfoRespPregInsertar" Method de la clase "InsDocInfo" para poder agregar las respuestas a las preguntas de seguridad del usuario a la base de datos
//                   Docente.DocInfoRespPregInsertar(textRespPreg1, textRespPreg2, textRespPreg3, textRespPreg4, textRespPreg5);

                    MessageBox.Show("Se ha registrado correctamente el usuario");

                    grpBoxCteAcc.Visible = false;
                    this.Width = 413;
                    this.Height = 300;
                }

            }
            catch
            {
                MessageBox.Show("No se ha podido agregar el usuario");
            }


        } // Confirma la creación del usuario e ingresa los datos en el DB de usuarios

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
        } // Permite solicitar la recuperación de la contraseña

    }
}
