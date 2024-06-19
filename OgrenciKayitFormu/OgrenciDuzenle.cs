using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OgrenciKayitFormu
{
    public partial class OgrencGirisFormu : Form
    {
        string conString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        public int id;


        public OgrencGirisFormu()
        {
            InitializeComponent();
        }





        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (id != 0)
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "UP_BORSA";
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@HISSEISMI", txtHisseIsmi.Text);
                        command.Parameters.AddWithValue("@LOTFIYATI", txtLotFiyati.Text);
                        command.Parameters.AddWithValue("@LOTSAYISI", txtLotSayisi.Text);
                        command.Parameters.AddWithValue("@DURUM", rbAlýs.Checked == true ? 'A' : 'S');
                        command.Parameters.AddWithValue("@ISLEMTARIHI", Convert.ToDateTime(dtpTarih.Text));
                        command.Parameters.AddWithValue("PIYASADEGERI", txtPiyasaDegeri.Text);
                        command.ExecuteNonQuery();
                    }

                }
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "IN_BORSA";
                        command.Parameters.AddWithValue("@HISSEISMI", txtHisseIsmi.Text);
                        command.Parameters.AddWithValue("@LOTFIYATI", txtLotFiyati.Text);
                        command.Parameters.AddWithValue("@LOTSAYISI", txtLotSayisi.Text);
                        command.Parameters.AddWithValue("@DURUM", rbAlýs.Checked == true ? 'A' : 'S');
                        command.Parameters.AddWithValue("@ISLEMTARIHI", Convert.ToDateTime(dtpTarih.Text));
                        command.Parameters.AddWithValue("PIYASADEGERI", txtPiyasaDegeri.Text);
                        command.ExecuteNonQuery();
                    }

                }
            }


            MessageBox.Show("Baþarýlý", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OgrencGirisFormu_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                DataTable dt = new DataTable();
                dt = GetOgrenciById(id);
                txtHisseIsmi.Text = dt.Rows[0]["HISSEISMI"].ToString();
                txtLotSayisi.Text = dt.Rows[0]["LOTSAYISI"].ToString();
                txtLotFiyati.Text = dt.Rows[0]["LOTFIYATI"].ToString();
                dtpTarih.Text = dt.Rows[0]["ISLEMTARIHI"].ToString();
                if (dt.Rows[0]["DURUM"].ToString() == "A")
                {
                    rbAlýs.Checked = true;
                }
                else
                {
                    rbSatis.Checked = true;
                }
            }
        }

        private DataTable GetOgrenciById(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "GETHÝSSEBYID";
                        cmd.Parameters.AddWithValue("@ID", id);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.SelectCommand = cmd;
                        da.Fill(dt);
                    }
                }

                return dt;
            }

            catch (Exception)
            {
                throw;
            }
        }


    }
}