using CRUD.Controller;
using CRUD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        string loginQuery = " SELECT email, password FROM users WHERE email = @email AND password = @password";
        SqlCommand cmd;
        Database db = new Database();
        User user = new User();

        public Form1()
        {
            InitializeComponent();
            if (db.Get_dbConnection().Equals(false))
            {
                Connection.Text = "DatabaseNotConnected";
                db.Get_dbConnection().Close();
            }
            else
            {
                Connection.Text = "DatabaseConnected";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register_form register = new Register_form();
            register.Show();
            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand(loginQuery, db.Get_dbConnection());
            cmd.Parameters.Add(new SqlParameter("@email",username_input.Text));
            cmd.Parameters.Add(new SqlParameter("@password",password_input.Text));

            try
            {
                using (SqlDataReader SqlDataReader = cmd.ExecuteReader())
                {
                    SqlDataReader.Read();
                    user.Email = SqlDataReader.GetString(0);
                    user.Password = SqlDataReader.GetString(1);
                     if (user.Email == username_input.Text && user.Password == password_input.Text)
                    {
                        dashboard dashboard = new dashboard();
                        dashboard.Show();
                        this.Hide();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                cmd.Dispose();
                db.Get_dbConnection().Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
