using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
//------------------------------------
using System.Data.OleDb;


namespace LoginSystem
{
    public partial class loginwind : Form
    {
        private OleDbConnection connectionDb = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=Usuarios-Contraseñas.mdb");

        public loginwind()
        {
            InitializeComponent();
        }

        private void cteuser_Click(object sender, EventArgs e)
        {
            
            cteaccwind cteaccwind = new cteaccwind();
            cteaccwind.ShowDialog();
            
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            connectionDb.Open();
            OleDbCommand cmdDb = new OleDbCommand();
            cmdDb.Connection = connectionDb;
            cmdDb.CommandText = "select 1 from Usuarios-ContraseñasDataTable where Username='" + username.Text + "' and Password='" + password.Text +"'";
            OleDbDataReader reader = cmdDb.ExecuteReader();

            int count = 0;
            while(reader.Read())
            {
                count = count + 1;
            }
            if(count==1)
            {
                MessageBox.Show("Login Successful");
                SistGestMainWind SistGestMainWind = new SistGestMainWind();
                SistGestMainWind.ShowDialog();
            }
            else 
            {
                MessageBox.Show("There are two accounts with the same username and password");
            }
           
           
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginwind_Load(object sender, EventArgs e)
        {
            try
            {
                connectionDb.Open();
                MessageBox.Show("Connection Successful");
                connectionDb.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            
        }

        private void menubarlogin_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
