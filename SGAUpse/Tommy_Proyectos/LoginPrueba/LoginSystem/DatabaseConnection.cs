using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------
using System.Data.OleDb;


//  Clase creada para ahorrar espacio en los códigos y simplificar el desarrollo del mismo

namespace LoginSystem
{
    class DatabaseConnection
    {
        OleDbConnection connDB;
        OleDbCommand commDB;

        public DatabaseConnection()
        {
            connDB = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=userspasswords.mdb");
            commDB = connDB.CreateCommand();
        }

        public void dataInsert(DocInfoGet Doc)
        {
            try
            {
                commDB.CommandText = "INSERT INTO UsersPasswords([CedIdent], [Nombres], [Apellidos], [TituloTercNiv], [TituloCuarNiv], [TituloQuinNiv], [Username], [Password])  VALUES('" + Doc.CedIdent1 + "', '" + Doc.Nomb1 + "', '" + Doc.Apel1 + "', '" + Doc.TTN1 + "', '" + Doc.TCN1 + "', '" + Doc.TQN1 + "', '" + Doc.USN1 + "', '" + Doc.PassW1 + "')";
                commDB.CommandType = System.Data.CommandType.Text;
                
                connDB.Open();

                commDB.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connDB.Close();
            }
        }
    }
}
