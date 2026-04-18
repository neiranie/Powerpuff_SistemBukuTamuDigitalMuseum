using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UCP1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=LAPTOP-9BPMNG3K\\ANNEIRA;Initial Catalog=DBBukuTamuMuseum;Integrated Security=True";

        private int selectedId = 0;

        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void ConnectDatabase()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                MessageBox.Show("Koneksi berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal: " + ex.Message);
            }
        }

        private void MembukaKoneksi_Click(object sender, EventArgs e)
        {
            ConnectDatabase();
        }

        private void MenampilkanData_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                // ID tetap ada di grid tapi disembunyikan
                dataGridView1.Columns.Add("idTamu", "ID");
                dataGridView1.Columns.Add("namaLengkap", "Nama");
                dataGridView1.Columns.Add("asalDaerah", "Asal Daerah");
                dataGridView1.Columns.Add("keperluan", "Tujuan");
                dataGridView1.Columns.Add("tanggal", "Tanggal");

                // Sembunyikan kolom ID di grid
                dataGridView1.Columns["idTamu"].Visible = false;

                string query = "SELECT * FROM BukuTamu";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["idTamu"].ToString(),
                        reader["namaLengkap"].ToString(),
                        reader["asalDaerah"].ToString(),
                        reader["keperluan"].ToString(),
                        Convert.ToDateTime(reader["tanggal"]).ToShortDateString()
                    );
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            }
        }

        // ── Menambahkan Data (INSERT + ExecuteNonQuery) ───────────────
        private void MenambahkanData_Click(object sender, EventArgs e)
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
                cmd.Parameters.AddWithValue("@Tanggal", dateTimePicker.Value.Date);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data berhasil ditambahkan");
                    ClearForm();
                    btnMenampilkanData.PerformClick();
                }
                else
                {
                    MessageBox.Show("Data gagal ditambahkan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        // ── Mengubah Data (UPDATE + ExecuteNonQuery) ──────────────────
        private void MengubahData_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                if (selectedId == 0)
                {
                    MessageBox.Show("Pilih data dari tabel terlebih dahulu");
                    return;
                }

                string query = @"UPDATE BukuTamu
                                 SET namaLengkap = @Nama,
                                     asalDaerah  = @AsalDaerah,
                                     keperluan   = @Tujuan,
                                     tanggal     = @Tanggal
                                 WHERE idTamu = @IdTamu";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdTamu", selectedId);
                cmd.Parameters.AddWithValue("@Nama", textBoxNama.Text);
                cmd.Parameters.AddWithValue("@AsalDaerah", textBoxAsalDaerah.Text);
                cmd.Parameters.AddWithValue("@Tujuan", textBoxTujuan.Text);
                cmd.Parameters.AddWithValue("@Tanggal", dateTimePicker.Value.Date);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data berhasil diubah");
                    ClearForm();
                    btnMenampilkanData.PerformClick();
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        // ── Menghapus Data (DELETE + ExecuteNonQuery) ─────────────────
        private void MenghapusData_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                if (selectedId == 0)
                {
                    MessageBox.Show("Pilih data dari tabel terlebih dahulu");
                    return;
                }

                DialogResult resultConfirm = MessageBox.Show(
                    "Yakin ingin menghapus data?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultConfirm == DialogResult.Yes)
                {
                    string query = "DELETE FROM BukuTamu WHERE idTamu = @IdTamu";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdTamu", selectedId);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus");
                        ClearForm();
                        btnMenampilkanData.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedId = Convert.ToInt32(row.Cells["idTamu"].Value);

                textBoxNama.Text = row.Cells["namaLengkap"].Value.ToString();
                textBoxAsalDaerah.Text = row.Cells["asalDaerah"].Value.ToString();
                textBoxTujuan.Text = row.Cells["keperluan"].Value.ToString();
                dateTimePicker.Value = Convert.ToDateTime(row.Cells["tanggal"].Value);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ClearForm()
        {
            selectedId = 0;
            textBoxNama.Clear();
            textBoxAsalDaerah.Clear();
            textBoxTujuan.Clear();
            dateTimePicker.Value = DateTime.Now;
            textBoxNama.Focus();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin logout?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                Form2 formLogin = new Form2();
                formLogin.Show();
                this.Close();
            }
        }
    }
}