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
    public partial class Form4 : Form
    {
        public Form4()
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    double jml = double.Parse(textBox4.Text);
                    double harga = double.Parse(textBox5.Text);
                    textBox6.Text = (jml * harga).ToString();
                }
                else if (radioButton2.Checked == true)
                {
                    double jml = double.Parse(textBox4.Text);
                    double harga = double.Parse(textBox5.Text);
                    textBox6.Text = (jml * harga).ToString();
                }
            }
           catch
            {
                MessageBox.Show(null, "Inputan Anda Salah!", "salah", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                con.Open();
                string query = "INSERT INTO transaksi_baju (id_transaksi,id_produk,nama_pembeli,jumlah,harga,total) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"+textBox6.Text+"')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil Menyimpan");
            }
            else if (radioButton2.Checked == true)
            {
                con.Open();
                string query = "INSERT INTO transaksi_clna (id_transaksi,id_produk,nama_pembeli,jumlah,harga,total) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil Menyimpan");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                con.Open();
                string query = "UPDATE transaksi_baju SET id_produk = '" + textBox2.Text + "',nama_pembeli='" + textBox3.Text + "',jumlah='" + textBox4.Text + "',harga='" + textBox5.Text + "',total='" + textBox6.Text + "'WHERE id_transaksi = '" + textBox1.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil di ubah");
            }
            else if (radioButton2.Checked == true)
            {
                con.Open();
                string query = "UPDATE transaksi_clna SET id_produk = '" + textBox2.Text + "',nama_pembeli='" + textBox3.Text + "',jumlah='" + textBox4.Text + "',harga='" + textBox5.Text + "',total='" + textBox6.Text + "'WHERE id_transaksi = '" + textBox1.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil di ubah");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                con.Open();
                string query = "DELETE FROM transaksi_baju WHERE id_transaksi='" + textBox1.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil dihapus");
            }
            else if (radioButton2.Checked == true)
            {
                con.Open();
                string query = "DELETE FROM tbl_clna WHERE id_transaksi='" + textBox1.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Berhasil dihapus");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                con.Open();
                string query = "SELECT * FROM transaksi_baju";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (radioButton2.Checked == true)
            {
                con.Open();
                string query = "SELECT * FROM transaksi_clna";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        }
 }
