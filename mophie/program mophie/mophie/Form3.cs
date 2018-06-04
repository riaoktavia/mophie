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

namespace mophie
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EDSM7FB\SQLEXPRESS;Initial Catalog=mopi;Integrated Security=True");
        private void button5_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                con.Open();
                string query = "INSERT INTO tbl_baju (id_produk,nama_produk,jenis_produk,harga,stock) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil Menyimpan");
            }
            else if (radioButton2.Checked == true)
            {
                con.Open();
                string query = "INSERT INTO tbl_celana (id_produk,nama_produk,jenis_produk,harga,stock) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil Menyimpan");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                con.Open();
                string query = "SELECT * FROM tbl_baju";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (radioButton2.Checked == true)
            {
                con.Open();
                string query = "SELECT * FROM tbl_celana";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                con.Open();
                string query = "UPDATE tbl_baju SET nama_produk = '"+textBox2.Text+"',jenis_produk='"+textBox3.Text+"',harga='"+textBox4.Text+"',stock='"+textBox5.Text+"'WHERE id_produk = '"+textBox1.Text+"'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil di ubah");
            }
            else if (radioButton2.Checked == true)
            {
                con.Open();
                string query = "UPDATE tbl_celana SET nama_produk = '" + textBox2.Text + "',jenis_produk='" + textBox3.Text + "',harga='" + textBox4.Text + "',stock='" + textBox5.Text + "'WHERE id_produk = '" + textBox1.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil di ubah");
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                con.Open();
                string query = "DELETE FROM tbl_baju WHERE id_produk='"+textBox1.Text+"'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil dihapus");
            }
            else if (radioButton2.Checked == true)
            {
                con.Open();
                string query = "DELETE FROM tbl_celana WHERE id_produk='" + textBox1.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil dihapus");
            }
        }
    }
}
