﻿using System;
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


            connectionDb.Open();
            OleDbCommand cmdDb = new OleDbCommand();
            cmdDb.Connection = connectionDb;
            cmdDb.CommandText = "select 1 from UsersPasswordsDocentes where Username='" + cedval + "' and Password='" + userval + "'";
            OleDbDataReader reader = cmdDb.ExecuteReader();

            int count = 0;

            bool condReadDB1;
            bool condReadDB2;
            bool condReadDBGlobal;

            condReadDB1 = (count == 1);
            condReadDB1 = true;

            condReadDB2 = ((count == 0) && (cedval == null) && (userval == null));
            condReadDB2 = true;

            condReadDBGlobal = ((condReadDB1 == true) && (condReadDB2 != true));
            condReadDBGlobal = false;


            while (reader.Read())
            {
                count = count + 1;
            }
            if (condReadDBGlobal == true)
            {
                MessageBox.Show("Usuario y Cédula ya existentes/registrados.");

                loginwind.grpBoxCteAcc.Visible = false;
                loginwind.Width = 413;
                loginwind.Height = 300;

            }
            else if (condReadDB2 == true)
            {
                
                MessageBox.Show("Usuario y cédula no están registrados en la Base de Datos; Son válidos para el registro.");

            }

        }

    }
}

