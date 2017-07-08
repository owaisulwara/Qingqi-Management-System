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
    public partial class QingqiMS : Form
    {
        database db = new database();
        public QingqiMS()
        {
            InitializeComponent();
        }

        private void QingqiMS_Load(object sender, EventArgs e)
        {
            db.conString();
            db.con.Open();
            SqlCommand cmd1 = new SqlCommand(@"Select Route from Routes", db.con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read()) {
                route.Items.Add(dr1["Route"]);
            }
            db.con.Close();
            db.con.Open();
            SqlCommand cmd2 = new SqlCommand(@"Select CNG from CNGStatus where ID = 1;", db.con);
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read()) {
                cng.Text = "CNG Status: "+dr["CNG"];
            }
            db.con.Close();
            this.FormClosed += QingqiMS_FormClosed;
        }

        void QingqiMS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cng1= "";
            if (route.Text != "" && route.Text != "Choose your travelling route" && origin.Text != "" && origin.Text != "Choose your origin location" && reqarea.Text != "" && reqarea.Text != "Choose your required location")
            {
                int orig = 0, req = 0, rent = 0;
                db.con.Open();
                SqlCommand cmd = new SqlCommand(@"Select * from [Locations];", db.con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (origin.Text == dr[route.Text].ToString())
                    {
                        break;
                    }
                    else
                        orig++;
                }
                db.con.Close();
                db.con.Open();
                SqlCommand cmd1 = new SqlCommand(@"Select * from [Locations];", db.con);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    if (reqarea.Text == dr1[route.Text].ToString())
                    {
                        break;
                    }
                    else
                        req++;
                }
                db.con.Close();
                db.con.Open();
                SqlCommand cmd2 = new SqlCommand(@"Select QingqiLabel from Routes where Route='" + route.Text + "'", db.con);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    qingqilabel.Text = dr2["QingqiLabel"].ToString();
                }
                db.con.Close();
                if (orig > req)
                {
                    rent = (orig - req) * 5;
                }
                else if (req > orig)
                {
                    rent = (req - orig) * 5;
                }
                else
                    rent = 0;
                db.con.Open();
                SqlCommand cmd4 = new SqlCommand("Select CNG from CNGStatus where ID = 1;", db.con);
                SqlDataReader dr4 = cmd4.ExecuteReader();
                while (dr4.Read()) { 
                    cng1 = dr4["CNG"].ToString();
                }
                db.con.Close();
                if (cng1=="Open")
                travelrent.Text = (rent + 5).ToString();
                else
                    travelrent.Text = (rent + 10).ToString();
                db.con.Open();
                SqlCommand cmd3 = new SqlCommand(@"Select * from [Admin-Panel] where DataRegistration = '" + dtp.Text + "' And QingqiLabel='" + qingqilabel.Text + "' And  Status = 'Active'", db.con);
                SqlDataReader dr3 = cmd3.ExecuteReader();
                int c = 0;
                while (dr3.Read()) {
                    c++;
                }
                db.con.Close();
                onroad.Text = c.ToString();
            }
            else
                MessageBox.Show("Please select required data.");
        }

        private void origin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void reqarea_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void route_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void route_SelectedIndexChanged(object sender, EventArgs e)
        {
            origin.Items.Clear();
            reqarea.Items.Clear();
            db.con.Open();
            SqlCommand cmd = new SqlCommand(@"Select * from Locations;", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                origin.Items.Add(dr[route.Text].ToString());
                reqarea.Items.Add(dr[route.Text].ToString());
            }
            db.con.Close();
        }

        private void route_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            login.Show();
            this.Hide();
        }
    }
}
