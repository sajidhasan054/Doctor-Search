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
    public partial class DocPro : Form
    {
        string passTxt;
        DBDataContext DB = new DBDataContext();
        public DocPro()
        {
            InitializeComponent();
        }
        public DocPro(string a)
        {
            InitializeComponent();
            this.passTxt = a;
            
        }
        string PassTxt
        {
            set;
            get;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox4.Text = Search.passTxt;
            // var conn = new SqlConnection();
            //  conn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\C#\Doctor Search\Doctor Search\DB.mdf; Integrated Security = True;"; conn.Open();
            //  string s = textBox4.Text;

            //  var c = from b2 in DB.DocRegs
            //          where b2.Name == s
            //           select b2;
            ///dataGridView1.DataSource = c;
            //DocReg dr = new DocReg();
            // textBox1.Text = dr.Name;
            //textBox2.Text = dr.PhoneNumber;
            // textBox3.Text = dr.Category;
            //dataGridView1.DataSource = c;
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            DocProTxt.Text = this.passTxt;
            if(DocProTxt.Text.Length > 0)
            {
                
                var conn = new SqlConnection();
                conn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\C#\Doctor Search\Doctor Search\DB.mdf; Integrated Security = True;"; conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT *FROM DocReg WHERE Category like '" + Search.passTxt + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
               // dataGridView1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    //int n = dataGridView1.Rows.Add();
                    textBox1.Text = dt.Rows[0][0].ToString();
                    textBox2.Text = dt.Rows[0][4].ToString();
                    textBox3.Text = dt.Rows[0][5].ToString();
                    textBox5.Text = dt.Rows[0][5].ToString();
                    textBox5.Text = dt.Rows[0][5].ToString();

                }
            }
        }
    }
}
