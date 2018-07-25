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
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string street = textBox1.Text;
            string city = textBox2.Text;
            string Hospital = textBox3.Text;

            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("https://www.google.com.bd/maps?source=tldso&hl=en");

                if (street!=string.Empty)
                {
                    queryaddress.Append(street+","+"+");
                }
                if (city != string.Empty)
                {
                    queryaddress.Append(city + "," + "+");
                }
                if (Hospital != string.Empty)
                {
                    queryaddress.Append(Hospital + "," + "+");
                }

                webBrowser1.Navigate(queryaddress.ToString());


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
    }
}
