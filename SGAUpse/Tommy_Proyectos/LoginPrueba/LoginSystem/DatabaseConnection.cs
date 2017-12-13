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

        public void dataInsert(DocInfo Doc)
        {
            try
            {
                commDB.CommandText = "INSERT INTO userpassw([CI], [Nombres], [Apellidos], [TituloTercNiv], [TituloCuarNiv], [TituloQuinNiv], [Username], [Password])  VALUES('" + Doc.CI1 + "', '" + Doc.Nombres1 + "', '" + Doc.Apellidos1 + "', '" + Doc.Titulo1a + "', '" + Doc.Titulo2a + "', '" + Doc.Titulo3a + "', '" + Doc.Usuario1 + "', '" + Doc.Password1 + "')";
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
