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
using System.Data;

namespace Doctor_Search
{
    public partial class DocSearch : Form
    {
        DBDataContext DB = new DBDataContext();
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\C#\Doctor Search\Doctor Search\DB.mdf; Integrated Security = True;");
        public DocSearch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //*** shokale update er jinish thik koa lagbe*** 


                //  if (con.State == ConnectionState.Closed)
                ///         con.Open();
                //    SqlCommand sqlCmd = new SqlCommand("DocReg", con);
                //   sqlCmd.CommandType = CommandType.StoredProcedure;
                //   sqlCmd.Parameters.AddWithValue("@Name", textBox3.Text.Trim());
                //   sqlCmd.Parameters.AddWithValue("@UserName", textBox4.Text.Trim());
                //   sqlCmd.Parameters.AddWithValue("@Password", textBox5.Text.Trim());
                //  sqlCmd.Parameters.AddWithValue("@PhoneNumber", textBox6.Text.Trim());
                //   sqlCmd.Parameters.AddWithValue("@Category", textBox7.Text.Trim());
                //   sqlCmd.Parameters.AddWithValue("@Area", textBox8.Text.Trim());
                //    sqlCmd.Parameters.AddWithValue("@Chamber", textBox9.Text.Trim());
                //   sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Updated");
            }
            catch (Exception eg)
            {
                MessageBox.Show("NOT UPDATED");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            var conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\C#\Doctor Search\Doctor Search\DB.mdf; Integrated Security = True;"; conn.Open();


            var c = from b2 in DB.DocRegs

                    select new { b2.Name, b2.PhoneNumber, b2.Category, b2.Area, b2.Chamber };
            dataGridView1.DataSource = c;
        }
        public void displayData()
        {
            var conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\C#\Doctor Search\Doctor Search\DB.mdf; Integrated Security = True;"; conn.Open();


            var c = from b2 in DB.DocRegs

                    select new { b2.Name, b2.UserName, b2.Password, b2.PhoneNumber, b2.Category, b2.Area, b2.Chamber };
            dataGridView1.DataSource = c;
        }

        private void DocSearch_Load(object sender, EventArgs e)
        {
            //displayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string s = textBox1.Text;
            string s2 = textBox2.Text;


            try
            {
               // *** Deligate korle easy hobe or else condition***

                    var conn = new SqlConnection();
                    conn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\C#\Doctor Search\Doctor Search\DB.mdf; Integrated Security = True;"; conn.Open();


                    //string Name;
                    var c = from b2 in DB.DocRegs
                            where b2.Name == s && b2.Password ==s2
                            select new { b2.Name, b2.UserName, b2.Password, b2.PhoneNumber, b2.Category, b2.Area, b2.Chamber };
                    dataGridView1.DataSource = c;
                    // var str = from a2 in DB.DocRegs
                    //           where a2.Name == s
                    //           select a2;

                    //  DocReg pa = str.First();

                    // Name = pa.Name.ToString();
                    //  if (Name != null)
                    //  {
                    //     if (Name.Equals(textBox1.Text))
                    //      {

                    //     }
                    //  }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
        }




        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            
            string s = textBox2.Text;
            string pass;
            var str = from a2 in DB.DocRegs
                      where a2.Password == s
                      select a2;
            try
            {
                DocReg pa = str.First();

                pass = pa.Password.ToString();
                if (pass != null)
                {
                    if (pass.Equals(textBox2.Text))
                    {
                        if (dataGridView1.CurrentRow.Index != -1)
                        {
                            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                            textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                            textBox5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                            textBox6.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                            textBox7.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                            textBox8.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                            textBox9.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                        }
                    }

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Map se = new Map();
            se.ShowDialog();
        }
    }
}

        

