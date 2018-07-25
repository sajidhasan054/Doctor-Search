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

namespace Doctor_Search
{
    public partial class Guest_Search : Form
    {
        DBDataContext DB = new DBDataContext();
        public Guest_Search()
        {
            InitializeComponent();
        }

        private void Guest_Search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = F:\C#\Doctor Search\Doctor Search\DB.mdf; Integrated Security = True;"; conn.Open();
            string s = textBox1.Text;
            string s2 = comboBox2.Text;
            var c = from b2 in DB.DocRegs
                    where b2.Area == s && b2.Category == s2
                    select new { b2.Name, b2.PhoneNumber, b2.Category, b2.Area, b2.Chamber };
            dataGridView1.DataSource = c;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
