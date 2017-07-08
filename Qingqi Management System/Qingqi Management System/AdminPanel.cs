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
    public partial class AdminPanel : Form
    {
        database db = new database();
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void AdminPanel_Load(object sender, EventArgs e)
        {
            db.conString();
            db.con.Open();
            SqlCommand cmd = new SqlCommand(@"Select QingqiLabel from routes", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                qingqiLabel.Items.Add(dr["QingqiLabel"].ToString());
            }
            db.con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (driverName.Text != "" && qingqiNo.Text != "" && qingqiLabel.Text != "" && qingqiLabel.Text!="Please Choose Qingqi Label" && qingqiStatus.Text != "Please Choose Qingqi Status")
            {
                bool a=false;
                db.con.Open();
                SqlCommand cmd1 = new SqlCommand("Select QingqiNo from [Admin-Panel] where DataRegistration = '" + dateTimePicker1.Text + "' And QingqiNo = '"+qingqiNo.Text+"'", db.con);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    if (textBox1.Text == dr1["QingqiNo"].ToString())
                    {
                        a = true;
                    }
                }
                db.con.Close();
                if(a==false){
                    db.con.Open();
                    SqlCommand cmd = new SqlCommand(@"insert into [Admin-Panel](DriverName, QingqiNo, QingqiLabel, DataRegistration, Status)values(@DriverName, @QingqiNo, @QingqiLabel, @DateRegistration, @Status)", db.con);
                    cmd.Parameters.AddWithValue("@DriverName", driverName.Text);
                    cmd.Parameters.AddWithValue("@QingqiNo", qingqiNo.Text);
                    cmd.Parameters.AddWithValue("@QingqiLabel", qingqiLabel.Text);
                    cmd.Parameters.AddWithValue("@DateRegistration", dtp.Text);
                    cmd.Parameters.AddWithValue("@Status", qingqiStatus.Text);
                    cmd.ExecuteNonQuery();
                    db.con.Close();
                    MessageBox.Show("Data has been entered successfully!");
                    driverName.Clear();
                    qingqiNo.Clear();
                    qingqiLabel.Text = "Please Choose Qingqi Label";
                    qingqiStatus.Text = "Please Choose Qingqi Status";
                }
                else
                    
                    MessageBox.Show("Qingqi No. is already registered.");
                }
                else
                MessageBox.Show("Please insert complete data.");
        }

        private void driverName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (char)Keys.Space || e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void qingqiNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (Char)Keys.Back || e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void qingqiLabel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void qingqiStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cngstatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cngstatus.Text != "" && cngstatus.Text != "Choose CNG Status")
            {
                db.con.Open();
                SqlCommand cmd = new SqlCommand("Update CNGStatus set CNG = '"+cngstatus.Text+"' where ID=1;", db.con);
                cmd.ExecuteNonQuery();
                db.con.Close();
                MessageBox.Show("CNG Status is updated!");
            }
            else
                MessageBox.Show("Please select status!");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            //ButtonsColors -->
            button4.BackColor = Color.DodgerBlue;
            button3.BackColor = Color.DeepSkyBlue;
            button5.BackColor = Color.DeepSkyBlue;
            button8.BackColor = Color.DeepSkyBlue;
            button9.BackColor = Color.DeepSkyBlue;
            //ButtonsColors <--
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            //ButtonsColors -->
            button3.BackColor = Color.DodgerBlue;
            button4.BackColor = Color.DeepSkyBlue;
            button5.BackColor = Color.DeepSkyBlue;
            button8.BackColor = Color.DeepSkyBlue;
            button9.BackColor = Color.DeepSkyBlue;
            //ButtonsColors <--

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ButtonsColors -->
            button5.BackColor = Color.DodgerBlue;
            button4.BackColor = Color.DeepSkyBlue;
            button3.BackColor = Color.DeepSkyBlue;
            button8.BackColor = Color.DeepSkyBlue;
            button9.BackColor = Color.DeepSkyBlue;
            //ButtonsColors <--
            LOGIN login = new LOGIN();
            login.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            //ButtonsColors -->
            button8.BackColor = Color.DodgerBlue;
            button4.BackColor = Color.DeepSkyBlue;
            button5.BackColor = Color.DeepSkyBlue;
            button3.BackColor = Color.DeepSkyBlue;
            button9.BackColor = Color.DeepSkyBlue;
            //ButtonsColors <--
        }

        private void button7_Click(object sender, EventArgs e)
        {
            db.con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [Admin-Panel] where DataRegistration = '" + dtp1.Text + "';", db.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            else
                MessageBox.Show("There is no any data to show.");
            db.con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            //ButtonsColors -->
            button9.BackColor = Color.DodgerBlue;
            button4.BackColor = Color.DeepSkyBlue;
            button5.BackColor = Color.DeepSkyBlue;
            button8.BackColor = Color.DeepSkyBlue;
            button3.BackColor = Color.DeepSkyBlue;
            //ButtonsColors <--
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (char)Keys.Space || e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (Char)Keys.Back || e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox1.Text != "" && comboBox2.Text != "" && comboBox2.Text != "Please Choose Qingqi Label" && comboBox1.Text != "Please Choose Qingqi Status" && comboBox1.Text != "")
            {
                db.con.Open();
                SqlCommand cmd = new SqlCommand(@"Update [Admin-Panel] set DriverName = '"+textBox2.Text+"', QingqiNo = '"+textBox1.Text+"', QingqiLabel = '"+comboBox2.Text+"', Status = '"+comboBox1.Text+"' where QingqiNo = '"+textBox1.Text+"' And DataRegistration = '"+dateTimePicker1.Text+"'", db.con);
                cmd.ExecuteNonQuery();
                db.con.Close();
                MessageBox.Show("Data has been updated successfully!");
                driverName.Clear();
                qingqiNo.Clear();
                qingqiLabel.Text = "Please Choose Qingqi Label";
                qingqiStatus.Text = "Please Choose Qingqi Status";
            }
            else
                MessageBox.Show("Please insert complete data.");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bool a = false;
            db.con.Open();
            SqlCommand cmd1 = new SqlCommand("Select QingqiNo from [Admin-Panel] where DataRegistration = '" + dateTimePicker1.Text + "'", db.con);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    if (textBox1.Text == dr1["QingqiNo"].ToString())
                    {
                        a = true;
                    }
                }
            db.con.Close();
            if (a == true)
            {
                db.con.Open();
                SqlCommand cmd = new SqlCommand("Select * from [Admin-Panel] where QingqiNo = '" + textBox1.Text + "' And DataRegistration = '" + dateTimePicker1.Text + "'", db.con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox1.Text = dr["QingqiNo"].ToString();
                    textBox2.Text = dr["DriverName"].ToString();
                    comboBox2.Text = dr["QingqiLabel"].ToString();
                    comboBox1.Text = dr["Status"].ToString();
                }
                db.con.Close();
            }
            else
            {
                MessageBox.Show("There is no any data exist.");
                textBox1.Clear();
                textBox2.Clear();
                comboBox1.Text = "Please Choose Qingqi Status";
                comboBox2.Text = "Please Choose Qingqi Label";
            }
            comboBox2.Items.Clear();
            db.con.Open();
            SqlCommand cmd2 = new SqlCommand(@"Select QingqiLabel from routes", db.con);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox2.Items.Add(dr2["QingqiLabel"].ToString());
            }
            db.con.Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

    }
}
