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
    public partial class SignUp : Form
    {
        database db = new database();
        LOGIN login = new LOGIN();
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.conString();
            if (username.Text == "" || password.Text == "" || fullname.Text == "" || email.Text == "")
            {
                MessageBox.Show("Please insert complete data.");
            }
            else
            {
                db.con.Open();
                SqlCommand cmd1 = new SqlCommand(@"Select * From [User-Details]", db.con);
                SqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    if (username.Text == dr["Username"].ToString())
                    {
                        MessageBox.Show("Username existed, please take another.");
                        break;
                    }
                    else
                    {
                        db.con.Close();
                        db.con.Open();
                        SqlCommand cmd = new SqlCommand(@"insert into [User-Details]([Username], [Password], [FullName], [Email], [Signupdate])values(@Users, @Pass, @FulNam, @Email, @Signupdate)", db.con);
                        cmd.Parameters.AddWithValue("@Users", username.Text);
                        cmd.Parameters.AddWithValue("@Pass", password.Text);
                        cmd.Parameters.AddWithValue("@FulNam", fullname.Text);
                        cmd.Parameters.AddWithValue("@Email", email.Text);
                        cmd.Parameters.AddWithValue("@Signupdate", dateTime.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sigup successfully, please Login.");
                        username.Clear();
                        password.Clear();
                        email.Clear();
                        fullname.Clear();
                        break;
                    }
                }
                db.con.Close();
            }
        }

        private void fullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (Char)Keys.Back || e.KeyChar == (Char)Keys.Space)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == '-' || e.KeyChar == '@' || e.KeyChar >= '0'&& e.KeyChar <= '9' || e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == '-' || e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            this.FormClosed += SignUp_FormClosed;
        }

        void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
