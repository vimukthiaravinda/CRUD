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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetUser();
        }

        public List<User> GetUser()
        {
            string loadUserData = "SELECT * FROM users";
            List<User> users = new List<User>();
            Database db = new Database();
            SqlCommand cmd = new SqlCommand(loadUserData, db.Get_dbConnection());
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader != null)
            {
                while (dataReader.Read())
                { 
                    User user = new User();
                    user.User_id = dataReader.GetInt32(0);
                    user.First_Name = dataReader.GetString(1);
                    user.Last_name = dataReader.GetString(2);
                    user.Email = dataReader.GetString(3);
                    user.Password = dataReader.GetString(4);
                    user.Address = dataReader.GetString(5);
                    user.Country = dataReader.GetString(6);
                    user.Gender = dataReader.GetString(7);
                    users.Add(user);
                }
            }
            return users;
        }
    }
}
