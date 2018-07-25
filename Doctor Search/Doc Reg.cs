using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_Search
{
    public partial class Form1 : Form
    {
        DBDataContext DB = new DBDataContext(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=F:\C#\Doctor Search\Doctor Search\DB.mdf;Integrated Security = True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l2 = new Login();
            //Form1 f1 = new Form1();
           // f1.Hide();
            l2.ShowDialog();
        } 

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DocReg dr = new DocReg();
            dr.Name = textBox2.Text;
            dr.UserName = textBox3.Text;
            dr.Password = textBox4.Text;
            dr.PhoneNumber = textBox5.Text;
            dr.Category = textBox6.Text;
            dr.Area = textBox7.Text;
            dr.Chamber = textBox8.Text;
            DB.DocRegs.InsertOnSubmit(dr);
            DB.SubmitChanges();
            MessageBox.Show("Registered !!");

        }
    }
}
