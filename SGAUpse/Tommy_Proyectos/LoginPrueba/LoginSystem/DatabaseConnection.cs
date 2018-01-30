using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-------------------------------
using System.Data.OleDb;


//  Clase creada para ahorrar espacio en los códigos y simplificar el desarrollo del mismo

namespace LoginSystem
{
    class DatabaseConnection
    {
        OleDbConnection connDB;
        OleDbCommand commDB;


        // Prueba que se pueda realizar la conexión a la base de datos al momento de iniciar el programa
        public void DBConnectionTester()
        {
            try
            {
                connDB.Open();
                MessageBox.Show("Connection Successful");
                connDB.Close();
            }
            catch
            {
                MessageBox.Show("Error DBCT1"); //
            }
        }

        // Genera la conexión a la base de datos cuando se ejecute algún comando que requiera del uso de información
        public DatabaseConnection()
        {
            try 
            { 
            connDB = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=userspasswords.mdb");
            commDB = connDB.CreateCommand();
            }
            catch
            {
                MessageBox.Show("Error DBC1"); //
            }
        }

        //Clase ingresa los valores en la base de datos (Solo información relacionada con los usuarios creados)
        public void dataInsert(DocInfoGet Doc)
        {

                try
                {
                    commDB.CommandText = "INSERT INTO UsersPasswordsDocentes([CedIdent], [Nombres], [Apellidos], [TituloTercNiv], [TituloCuarNiv], [TituloQuinNiv], [Username], [Password], [Pregunta1], [Respuesta1], [Pregunta2], [Respuesta2], [Pregunta3], [Respuesta3], [Pregunta4], [Respuesta4], [Pregunta5], [Respuesta5])  VALUES('" + Doc.CedIdent1 + "', '" + Doc.Nomb1 + "', '" + Doc.Apel1 + "', '" + Doc.TTN1 + "', '" + Doc.TCN1 + "', '" + Doc.TQN1 + "', '" + Doc.USN1 + "', '" + Doc.PassW1 + "', '" + Doc.Preg1a + "', '" + Doc.RespPreg1a + "', '" + Doc.Preg2a + "', '" + Doc.RespPreg2a + "', '" + Doc.Preg3a + "', '" + Doc.RespPreg3a + "', '" + Doc.Preg4a + "', '" + Doc.RespPreg4a + "', '" + Doc.Preg5a + "', '" + Doc.RespPreg5a + "')";
                    commDB.CommandType = System.Data.CommandType.Text;


                    connDB.Open();

                    commDB.ExecuteNonQuery();

                }
                catch
                {
                    MessageBox.Show("Error DI1"); // 
                }
                finally
                {
                    connDB.Close();
                }

        }
    }
}
