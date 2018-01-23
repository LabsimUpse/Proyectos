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

        public void DocInfoInsert(TextBox textced, TextBox textnomb, TextBox textapel, TextBox texttercniv, TextBox textcuarniv, TextBox textquinniv, TextBox textusername, TextBox textcont, ComboBox cmbBoxPreg1, TextBox textRespPreg1, ComboBox cmbBoxPreg2, TextBox textRespPreg2, ComboBox cmbBoxPreg3, TextBox textRespPreg3, ComboBox cmbBoxPreg4, TextBox textRespPreg4, ComboBox cmbBoxPreg5, TextBox textRespPreg5)
        {

            bool condusercreate1 = ((textced == null) && (textnomb == null) && (textapel == null) && (texttercniv == null) && (textcuarniv == null) && (textquinniv == null) && (textusername == null) && (textcont == null));
            bool condusercreate2 = ((cmbBoxPreg1 == null) && (cmbBoxPreg2 == null) && (cmbBoxPreg3 == null) && (cmbBoxPreg4 == null) && (cmbBoxPreg5 == null));
            bool condusercreate3 = ((textRespPreg1 == null) && (textRespPreg2 == null) && (textRespPreg3 == null) && (textRespPreg4 == null) && (textRespPreg5 == null));
            bool condusercreateGlob = ((condusercreate1 && condusercreate2 && condusercreate3));

            condusercreateGlob = true;

            //Get-Set de valores para INFORMACIÓN BÁSICA del Usuario
            DocenteInfo.CedIdent1 = textced.Text;
            DocenteInfo.Nomb1 = textnomb.Text;
            DocenteInfo.Apel1 = textapel.Text;
            DocenteInfo.TTN1 = texttercniv.Text;
            DocenteInfo.TCN1 = textcuarniv.Text;
            DocenteInfo.TQN1 = textquinniv.Text;
            DocenteInfo.USN1 = textusername.Text;
            DocenteInfo.PassW1 = textcont.Text;

            //Get-Set de valores para las PREGUNTAS de seguridad seleccionadas por el Usuario
            DocenteInfo.Preg1a = cmbBoxPreg1.GetItemText(cmbBoxPreg1.SelectedItem);
            DocenteInfo.Preg2a = cmbBoxPreg2.GetItemText(cmbBoxPreg2.SelectedItem);
            DocenteInfo.Preg3a = cmbBoxPreg3.GetItemText(cmbBoxPreg3.SelectedItem);
            DocenteInfo.Preg4a = cmbBoxPreg4.GetItemText(cmbBoxPreg4.SelectedItem);
            DocenteInfo.Preg5a = cmbBoxPreg5.GetItemText(cmbBoxPreg5.SelectedItem);

            //Get-Set de valores para las RESPUESTAS a las PREGUNTAS de seguridad seleccionadas por el Usuario
            DocenteInfo.RespPreg1a = textRespPreg1.Text;
            DocenteInfo.RespPreg2a = textRespPreg2.Text;
            DocenteInfo.RespPreg3a = textRespPreg3.Text;
            DocenteInfo.RespPreg4a = textRespPreg4.Text;
            DocenteInfo.RespPreg5a = textRespPreg5.Text;

            //Información se inserta por medio del miembro "dataInsert" de la clase "DatabaseConnection"
            DocInfoInsNewConnDB.dataInsert(DocenteInfo);

        }

    }
}
