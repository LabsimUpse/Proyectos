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

        public void DocInfoInsert(TextBox textced, TextBox textnomb, TextBox textapel, TextBox texttercniv, TextBox textcuarniv, TextBox textquinniv, TextBox textusername, TextBox textcont)
        {
            //Asignación de Valores para la creaqción de usuarios por medio de la Clase "InsDocInfo"
            DatabaseConnection DocInfoNewConnDB = new DatabaseConnection();

            DocInfoGet Docente = new DocInfoGet();
            Docente.CedIdent1 = textced.Text;
            Docente.Nomb1 = textnomb.Text;
            Docente.Apel1 = textapel.Text;
            Docente.TTN1 = texttercniv.Text;
            Docente.TCN1 = textcuarniv.Text;
            Docente.TQN1 = textquinniv.Text;
            Docente.USN1 = textusername.Text;
            Docente.PassW1 = textcont.Text;

            DocInfoNewConnDB.dataInsert(Docente);
            
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

            //Asignación de Preguntas a la base de datos por medio del "dataInsert" Method perteneciente a la clase "DatabaseConnection"
            DatabaseConnection connPregDB = new DatabaseConnection();

            //Uso de la Clase "DocInfoGet" para poder asignar los valores que serán tomados luego por medio de la clase "DatabaseConnection"
            DocInfoGet DocPreg = new DocInfoGet();
            DocPreg.Preg1a = cmbBoxPreg1.Text;
            DocPreg.Preg2a = cmbBoxPreg2.Text;
            DocPreg.Preg3a = cmbBoxPreg3.Text;
            DocPreg.Preg4a = cmbBoxPreg4.Text;
            DocPreg.Preg5a = cmbBoxPreg5.Text;

            //Uso de "dataInsert" Method para ingresar los valores de las preguntas en las DB
            connPregDB.dataInsert(DocPreg);

        }

        public void DocInfoRespPregInsertar(TextBox textRespPreg1, TextBox textRespPreg2, TextBox textRespPreg3, TextBox textRespPreg4, TextBox textRespPreg5)
        {

            //Asignación de las respuestas a las preguntas a la DB por medio del "dataInsert" Method de la clase "DatabaseConnection"
            DatabaseConnection connRespPregDB = new DatabaseConnection();

            //Uso de la clase "DocInfoGet" para poder asignar valores que serán tomados luego por medio de la clase "DatabaseConnection"
            DocInfoGet DocResp = new DocInfoGet();
            DocResp.RespPreg1a = textRespPreg1.Text;
            DocResp.RespPreg2a = textRespPreg2.Text;
            DocResp.RespPreg3a = textRespPreg3.Text;
            DocResp.RespPreg4a = textRespPreg4.Text;
            DocResp.RespPreg5a = textRespPreg5.Text;

            //Uso de "dataInsert" Method para ingresar los valores de las respuestas para las preguntas
            connRespPregDB.dataInsert(DocResp);
        }


    }
}
