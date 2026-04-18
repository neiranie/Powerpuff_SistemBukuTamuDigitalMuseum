using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UCP1
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=LAPTOP-9BPMNG3K\\ANNEIRA;Initial Catalog=DBBukuTamuMuseum;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void Kirim_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                if (textBoxNama.Text == "")
                {
                    MessageBox.Show("Nama harus diisi");
                    textBoxNama.Focus();
                    return;
                }
                if (textBoxAsalDaerah.Text == "")
                {
                    MessageBox.Show("Asal Daerah harus diisi");
                    textBoxAsalDaerah.Focus();
                    return;
                }
                if (textBoxTujuan.Text == "")
                {
                    MessageBox.Show("Tujuan harus diisi");
                    textBoxTujuan.Focus();
                    return;
                }

                string query = @"INSERT INTO BukuTamu
                                    (namaLengkap, asalDaerah, keperluan, tanggal)
                                 VALUES
                                    (@Nama, @AsalDaerah, @Tujuan, @Tanggal)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nama", textBoxNama.Text);
                cmd.Parameters.AddWithValue("@AsalDaerah", textBoxAsalDaerah.Text);
                cmd.Parameters.AddWithValue("@Tujuan", textBoxTujuan.Text);
                cmd.Parameters.AddWithValue("@Tanggal", dateTimePicker1.Value.Date);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data berhasil dikirim");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Data gagal dikirim");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            textBoxNama.Clear();
            textBoxAsalDaerah.Clear();
            textBoxTujuan.Clear();
            dateTimePicker1.Value = DateTime.Now;
            textBoxNama.Focus();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                if (textBoxUsername.Text == "")
                {
                    MessageBox.Show("Username harus diisi");
                    textBoxUsername.Focus();
                    return;
                }
                if (textBoxPassword.Text == "")
                {
                    MessageBox.Show("Password harus diisi");
                    textBoxPassword.Focus();
                    return;
                }

                string query = "SELECT * FROM Petugas WHERE username = @Username AND password = @Password";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login berhasil! Selamat datang, " + reader["nama"].ToString());
                    reader.Close();

                    Form1 formPetugas = new Form1();
                    formPetugas.Show();
                    this.Hide();
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Username atau password salah");
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                    textBoxUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Login_Click(sender, e);
        }
    }
}