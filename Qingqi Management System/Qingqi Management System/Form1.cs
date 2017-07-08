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
    public partial class LOGIN : Form
    {
        database db = new database();
        QingqiMS qms = new QingqiMS();
        AdminLogin admin = new AdminLogin();
        public LOGIN()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signup = new SignUp();
            signup.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b = false;
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [User-Details];", db.con);
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
                qms.Show();
            }
            else
                MessageBox.Show("Please insert correct username or password.");
            db.con.Close();
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin.Show();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            this.FormClosed += LOGIN_FormClosed;
        }

        void LOGIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
