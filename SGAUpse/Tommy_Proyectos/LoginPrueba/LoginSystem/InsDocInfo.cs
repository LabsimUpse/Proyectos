using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LoginSystem
{
    class InsDocInfo
    {
        //Conexión de base de datos mediante la clase "DatabaseConnection"
        public DatabaseConnection DocInfoInsNewConnDB = new DatabaseConnection();

        //Instanciación de la clase "DocInfoGet"
        DocInfoGet DocenteInfo = new DocInfoGet();

        public void DocInfoInsert(TextBox textced, TextBox textnomb, TextBox textapel, TextBox texttercniv, TextBox textcuarniv, TextBox textquinniv, TextBox textusername, TextBox textcont)
        {

            //Get-Set de valores para Información Básica del Usuario
            DocenteInfo.CedIdent1 = textced.Text;
            DocenteInfo.Nomb1 = textnomb.Text;
            DocenteInfo.Apel1 = textapel.Text;
            DocenteInfo.TTN1 = texttercniv.Text;
            DocenteInfo.TCN1 = textcuarniv.Text;
            DocenteInfo.TQN1 = textquinniv.Text;
            DocenteInfo.USN1 = textusername.Text;
            DocenteInfo.PassW1 = textcont.Text;

            //Información se inserta por medio del miembro "dataInsert" de la clase "DatabaseConnection"
            DocInfoInsNewConnDB.dataInsert(DocenteInfo);
            
          /* try
            {

            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                

            }*/
        }

        public void DocInfoPregInsertar(ComboBox cmbBoxPreg1, ComboBox cmbBoxPreg2, ComboBox cmbBoxPreg3, ComboBox cmbBoxPreg4, ComboBox cmbBoxPreg5)
        {

            //Get-Set de las preguntas seleccionadas por el usuario
            DocenteInfo.Preg1a = cmbBoxPreg1.ToString();
            DocenteInfo.Preg2a = cmbBoxPreg2.ToString();
            DocenteInfo.Preg3a = cmbBoxPreg3.ToString();
            DocenteInfo.Preg4a = cmbBoxPreg4.ToString();
            DocenteInfo.Preg5a = cmbBoxPreg5.ToString();

            //Uso de "dataInsert" Method para ingresar los valores de las preguntas en las DB
            DocInfoInsNewConnDB.dataInsert(DocenteInfo);

        }

        public void DocInfoRespPregInsertar(TextBox textRespPreg1, TextBox textRespPreg2, TextBox textRespPreg3, TextBox textRespPreg4, TextBox textRespPreg5)
        {

            //Get-Set de las respuestas a las preguntas del usuario
            DocenteInfo.RespPreg1a = textRespPreg1.Text;
            DocenteInfo.RespPreg2a = textRespPreg2.Text;
            DocenteInfo.RespPreg3a = textRespPreg3.Text;
            DocenteInfo.RespPreg4a = textRespPreg4.Text;
            DocenteInfo.RespPreg5a = textRespPreg5.Text;

            //Uso de "dataInsert" Method para ingresar los valores de las respuestas para las preguntas
            DocInfoInsNewConnDB.dataInsert(DocenteInfo);
        }


    }
}
