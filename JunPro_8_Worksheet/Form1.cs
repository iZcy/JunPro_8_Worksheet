using Npgsql;
using System.Data;

namespace JunPro_8_Worksheet
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = String.Format("Host=localhost;Port=5432;Username=postgres;Password='2Matasaya_';Database=ListofName");
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;


        private void Form_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                MessageBox.Show("Load Success!!", "SUCCESS!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView.DataSource = null;
                sql = "SELECT * FROM st_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataGridView.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                sql = @"SELECT * FROM st_insert(:_name,:_alamat,:_no_handphone)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_name", NamaBox.Text);
                cmd.Parameters.AddWithValue("_alamat", AlamatBox.Text);
                cmd.Parameters.AddWithValue("_no_handphone", HandphoneBox.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data User Berhasil diinputkan!!", "Well Done!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conn.Close();

                LoadButton.PerformClick();
                NamaBox.Text = AlamatBox.Text = HandphoneBox.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris yang akan di-update!!", "WARNING!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();

                sql = @"SELECT * FROM st_update(:_id,:_name,:_alamat,:_no_handphone)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_id", r.Cells["id"].Value.ToString());
                cmd.Parameters.AddWithValue("_name", NamaBox.Text);
                cmd.Parameters.AddWithValue("_alamat", AlamatBox.Text);
                cmd.Parameters.AddWithValue("_no_handphone", HandphoneBox.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data User Berhasil diupdate!!", "Well Done!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conn.Close();
                LoadButton.PerformClick();
                NamaBox.Text = AlamatBox.Text = HandphoneBox.Text = null;
                r = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris yang akan dihapus!!", "WARNING!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show(
                    "Apakah benar Anda ingin menghapus data " + r.Cells["name"].Value.ToString() + " ?",
                    "Hapus data terkonfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                ) != DialogResult.Yes)
                return;

            try
            {
                conn.Open();

                sql = @"SELECT * FROM st_delete(:_id)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_id", r.Cells["id"].Value.ToString());

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data User Berhasil dihapus!!", "Well Done!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conn.Close();
                LoadButton.PerformClick();
                NamaBox.Text = AlamatBox.Text = HandphoneBox.Text = null;
                r = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dataGridView.Rows[e.RowIndex];
                NamaBox.Text = r.Cells["name"].Value.ToString();
                AlamatBox.Text = r.Cells["alamat"].Value.ToString();
                HandphoneBox.Text = r.Cells["no_handphone"].Value.ToString();
            }
        }

        private void QRButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }
    }
}
