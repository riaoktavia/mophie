using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mophie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text== "admin" && textBox2.Text== "admin1" || textBox1.Text=="ria" && textBox2.Text=="admin2" || textBox1.Text=="hasna" && textBox2.Text=="admin3" || textBox1.Text=="dika" && textBox2.Text=="admin4")
            {
                Form2 m = new Form2();
                m.Show();
                this.Hide();
            }
        }
    }
}
