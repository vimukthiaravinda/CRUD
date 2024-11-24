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
    public partial class Register_form : Form
    {
        string register_user = "INSERT INTO users (first_name,last_name,email,password,address,country,gender) VALUES (" +
            "@first_name,@last_name,@email,@password,@address,@country,@gender)";
        Database database = new Database();
        SqlCommand sqlCommand;
        User user = new User();
        public Register_form()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            sqlCommand = new SqlCommand(register_user,database.Get_dbConnection());
            sqlCommand.Parameters.Add(new SqlParameter("@first_name", first_name.Text));
            sqlCommand.Parameters.Add(new SqlParameter("@last_name", last_name.Text));
            sqlCommand.Parameters.Add(new SqlParameter("@email", email.Text));
            sqlCommand.Parameters.Add(new SqlParameter("@password", password.Text));
            sqlCommand.Parameters.Add(new SqlParameter("@address", address.Text));
            sqlCommand.Parameters.Add(new SqlParameter("@country",country.Text));
            sqlCommand.Parameters.Add(new SqlParameter("@gender", gender.Text));
            try
            {
                int affected_row = sqlCommand.ExecuteNonQuery();
                MessageBox.Show(affected_row + "affected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                database.Get_dbConnection().Close();
                sqlCommand.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
    }
}
