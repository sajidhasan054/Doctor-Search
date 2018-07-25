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
    public partial class Login : Form
    {
        DBDataContext DB = new DBDataContext();
        public static string LoginStr;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string s2 = textBox2.Text;
            LoginStr = s;
            var str = from a2 in DB.UserRegs
                      where a2.UserName == s && a2.Password == s2
                      select a2;
            
            string username;
            string pass;
            
            try
            {
                UserReg pa = str.First();
                username = pa.UserName.ToString();
                pass = pa.Password.ToString();
                if (username != null && pass != null)
                {
                    if (username.Equals(textBox1.Text) && pass.Equals(textBox2.Text))
                    {
                        //this.Hide();
                        Search se = new Search();
                        se.ShowDialog();


                    }

                }
            }
            catch (Exception exve)
            {
                MessageBox.Show("Please Put valid User Name and Password");
            }
            /*Search se1 = new Search();
            se1.textBox1 = s;

            /*if(s == "" | s2 == "")
            {
                MessageBox.Show("Please provivde user name and password");
            }

            
            
            try
            {
                UserReg pa = str.First();
                s2 = pa.Password.ToString();

            }
            catch(Exception exve)
            {
                MessageBox.Show("Invalid Login");
            }
           
           if(str != null)
            {
                
                new Search().Show();
            }
            

            /*
            if (s != null && s2 != null)
            {
                if (str!=null)
                {
                    //this.Hide();
                    Search se = new Search();
                    se.ShowDialog();


                }
                


            }
            else
            {
                MessageBox.Show("Please Put valid User Name and Password");
            }
            */


        }

        private void button6_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string s2 = textBox2.Text;
            string username;
            string pass;
            var str = from a2 in DB.DocRegs
                      where a2.UserName == s && a2.Password == s2
                      select a2;
            try
            {
                DocReg pa = str.First();
                username = pa.UserName.ToString();
                pass = pa.Password.ToString();
                if (username != null && pass != null)
                {
                    if (username.Equals(textBox1.Text) && pass.Equals(textBox2.Text))
                    {
                        //this.Hide();
                        DocSearch se = new DocSearch();
                        se.ShowDialog();


                    }
                   
                }
            }
            catch(Exception exve)
            {
                MessageBox.Show("Please Put valid User Name and Password");
            }
            /*if (username != null && pass != null)
            {
                if (username.Equals(textBox1.Text) && pass.Equals(textBox2.Text))
                {
                    //this.Hide();
                    Search se = new Search();
                    se.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Please Put valid User Name and Password");
                }
            }*/
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 u1 = new Form2();
            u1.ShowDialog();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 d1 = new Form1();
            d1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Guest_Search s = new Guest_Search();
            s.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

