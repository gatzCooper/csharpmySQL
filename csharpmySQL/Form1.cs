using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpmySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnect.GetConnectionString();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.ToString();
            string pass = txtPassword.Text.ToString();
            string query = $"select * from users where Username = '{user}'" +
                $" and Password = '{pass}' ";

            using (var db = new MySqlConnection(MySqlConnect.GetConnectionString()))
            {
                try
                {
                    db.OpenAsync().ConfigureAwait(false);
                    using (var command = db.CreateCommand())
                    {
                        command.CommandText = query;
                        command.CommandType = CommandType.Text;
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show($"Loggin Successful!, Welcome {user}!");
                        }
                        else
                        {
                            MessageBox.Show("Login Failed!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
