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


    }
}
