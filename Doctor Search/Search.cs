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
//using System.Data;




namespace Doctor_Search
{
    public partial class Search : Form
    {
        DBDataContext DB = new DBDataContext();
        public Search()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            var conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\C#\Doctor Search\Doctor Search\DB.mdf; Integrated Security = True;"; conn.Open();
            string s = textBox2.Text;
            string s2 = comboBox1.Text;
            var c = from b2 in DB.DocRegs
                    where b2.Area == s && b2.Category == s2
                    select new {b2.Name, b2.PhoneNumber, b2.Category,b2.Area, b2.Chamber };
            dataGridView1.DataSource = c;
            
            
            /*string s = textBox2.Text;
            string s2 = comboBox1.Text;
            var str = from a2 in DB.DocRegs
                      where a2.UserName == s && a2.Password == s2
                      select a2;
            DocReg pa = str.First();
            s2 = pa.Password.ToString();
            if (s != null && s2 != null)
            {
                if (s.Equals(textBox2.Text) && s2.Equals(comboBox1.Text))
                {
                    //this.Hide();

                    // dataGridView1 d = new dataGridView1();


                }
                /* int id = int.Parse(textBox2.Text);
                stu s = db.stus.SingleOrDefault(x => x.Id == id);
                 if (s != null)
                 {
                     textBox1.Text = s.name;
                     textBox2.Text = s.email;

                 }
                 else
                     MessageBox.Show(" Data not found");*/
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }
    }
}

