using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Qingqi_Management_System
{
    public partial class AdminLogin : Form
    {
        database db = new database();
        AdminPanel ap = new AdminPanel();
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b = false;
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [Admin-Details];", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (textBox1.Text == dr["Username"].ToString() && textBox2.Text == dr["Password"].ToString())
                {
                    b = true;
                    break;
                }
            }
            if (b == true)
            {
                this.Hide();
                ap.Show();
            }
            else
                MessageBox.Show("Please insert correct username or password.");
            db.con.Close();
        }

        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            login.Show();
            this.Hide();

        }
    }
}
