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

        public loginwind loginwind = new loginwind();

        public void usersPasswReader(string usn, string pword)
        {
            connectionDb.Open();
            OleDbCommand cmdDb = new OleDbCommand();
            cmdDb.Connection = connectionDb;
            cmdDb.CommandText = "select 1 from UsersPasswordsDocentes where Username='" + usn + "' and Password='" + pword + "'";
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

                loginwind loginwind = new loginwind();
                loginwind.Hide();
            }
            else if (count == 0)
            {
                MessageBox.Show("Invalid Username/Password. Solicite acceso al Sistema de Gestión Académica en caso de no tener Usuario y Contraseña.");
            }
        }

        public void readAssignPregs(string usn, string pword, string preg1, string preg2, string preg3, string preg4, string preg5)
        {
            connectionDb.Open();
            OleDbCommand cmdDb = new OleDbCommand();
            cmdDb.Connection = connectionDb;
            cmdDb.CommandText = "select 1 from UsersPasswordsDocentes where Username='" + usn + "' and Password= '" + pword + "'";
            OleDbDataReader reader = cmdDb.ExecuteReader();

            int count = 0;

            while (reader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                try
                {
                }
                catch (Exception ex)
                {
                }
            }
        }


        public void readAssignResps(string usn, string pword, string resp1, string resp2, string resp3, string resp4, string resp5)
        {

        }


        // Código para verificar la existencia de usuarios ya creados previamente.
        public void readVerifDatos(string cedval, string userval)
        {

            try
            {
                connectionDb.Open();
                OleDbCommand cmdDb = new OleDbCommand();
                cmdDb.Connection = connectionDb;
                cmdDb.CommandText = "select 1 from UsersPasswordsDocentes where Username='" + cedval + "' and Password='" + userval + "'";
                OleDbDataReader reader = cmdDb.ExecuteReader();

                int count = 0;

                bool condReadDB1;
                bool condReadDB2;
                bool condReadDB3;
                bool condReadDBGlobal1;
                bool condReadDBGlobal2;
                bool condReadDBGlobal3;

                condReadDB1 = (count == 1);

                condReadDB2 = ((cedval != "") && (userval != ""));

                condReadDB3 = (count == 0);

                condReadDBGlobal1 = ((condReadDB1 == true) && (condReadDB2 != true) && (condReadDB3 != true));

                condReadDBGlobal2 = ((condReadDB2 != true) && (condReadDB3 == true));

                condReadDBGlobal3 = ((condReadDB2 == true) && (condReadDB3 == true));

                while (reader.Read())
                {
                    count = count + 1;
                }
                if (condReadDBGlobal1 == true)
                {
                    MessageBox.Show("Usuario y Cédula ya existentes/registrados.");

                    loginwind.grpBoxCteAcc.Visible = false;
                    loginwind.Width = 413;
                    loginwind.Height = 300;

                }
                else if (condReadDBGlobal2 == true)
                {
                    MessageBox.Show("Ingrese información válida para el registro.");
                }
                else if (condReadDBGlobal3 == true)
                {
                    MessageBox.Show("Usuario no registrado; prosiga con el registro.");
                    loginwind.buttoncreate.Enabled = true;
                }

            }
            catch
            {
                MessageBox.Show("Error RVD1");
            }
        }

    }
}

