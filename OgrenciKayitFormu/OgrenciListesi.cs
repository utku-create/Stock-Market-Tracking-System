using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OgrenciKayitFormu
{
    public partial class OgrenciListesi : Form
    {
        int id;
        string conString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        public OgrenciListesi()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            dgList.DataSource = GetOgrenciler();
            dgList.Columns["ID"].Visible = false;

        }

        private object GetOgrenciler()
        {
            DataTable dtTable = new DataTable();
            try
            {

                SqlConnection conn = new SqlConnection(conString);

                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GETHİSSELER";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.SelectCommand = cmd;
                    da.Fill(dtTable);
                    conn.Close();
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dtTable;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            OgrencGirisFormu ogf = new OgrencGirisFormu();
            ogf.id = 0;
            ogf.ShowDialog();
            FillGrid();
        }





        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OgrencGirisFormu okf = new OgrencGirisFormu();
            okf.id = id;
            okf.ShowDialog();
            FillGrid();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {

                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "DEL_HİSSELER";
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            FillGrid();
        }

        private void dgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgList.Rows[dgList.CurrentRow.Index].Cells["ID"].Value);
        }



        private void dgList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void beyza_Click(object sender, EventArgs e)
        {
            
                OgrencGirisFormu ogf = new OgrencGirisFormu();
                ogf.id = 0;
                ogf.ShowDialog();
                FillGrid();
                /*buğrayı çok seviyorum 04.02.2024 çok güzel yazmış her şeyi mükemmel bugün pazar arabicadayız ama insanlar geldi :((( sonra 
                 sonra :| */
        }
    }
}




