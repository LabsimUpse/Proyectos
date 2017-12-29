using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-------------------------
using System.Data.OleDb;

namespace LoginSystem
{
    class ReadDataBase
    {

        private OleDbConnection connectionDb = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=userspasswords.mdb");



        public void usersPasswReader(string usn, string pword)
        {
            

            connectionDb.Open();
            OleDbCommand cmdDb = new OleDbCommand();
            cmdDb.Connection = connectionDb;
            cmdDb.CommandText = "select 1 from UsersPasswords where Username='" + usn + "' and Password='" + pword + "'";
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
            else if (count != 1)
            {
                MessageBox.Show("There are two accounts with the same username and password");
                connectionDb.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password");
                connectionDb.Close();
            }
        }
    }
}
