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

namespace InventoryManagementSystem
{
    public partial class CostumerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=BALCAO;Initial Catalog=""CLIENTES"";Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;


        public CostumerForm()
        {
            InitializeComponent();
            LoadCostumer();            
        }
       

        public void LoadCostumer()
        {
            int i = 0;
            dgvCostumer.Rows.Clear();
            cmd = new SqlCommand("SELECT TOP 30 * FROM Clientes$ ORDER BY DataTroca DESC", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCostumer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString(), dr[14].ToString(), dr[15].ToString(), dr[16].ToString(), dr[17].ToString(), dr[18].ToString(), dr[19].ToString(), dr[20].ToString(), dr[21].ToString(), dr[22].ToString(), dr[23].ToString(), dr[24].ToString(), dr[25].ToString(), dr[26].ToString(), dr[27].ToString(), dr[28].ToString(), dr[29].ToString(), dr[30].ToString());
            }
            dr.Close();
            con.Close();
        }
        private void btnAddCostumer_Click_1(object sender, EventArgs e)
        {
            CostumerModuleForm costumerForm = new CostumerModuleForm();
            costumerForm.btnSave.Enabled = true;
            costumerForm.btnNovaTroca.Enabled = false;   
            costumerForm.ShowDialog();
            LoadCostumer();
        }
        private void dgvCostumer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCostumer.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                bool trocaOleo = (dgvCostumer.Rows[e.RowIndex].Cells[22].Value.ToString() == "SIM");
                bool trocaFiltroOleo = (dgvCostumer.Rows[e.RowIndex].Cells[23].Value.ToString() == "SIM");
                bool trocaFiltroAr = (dgvCostumer.Rows[e.RowIndex].Cells[24].Value.ToString() == "SIM");
                bool trocaFiltroComb = (dgvCostumer.Rows[e.RowIndex].Cells[25].Value.ToString() == "SIM");
                bool trocaFiltroCabine = (dgvCostumer.Rows[e.RowIndex].Cells[26].Value.ToString() == "SIM");
                bool trocaPalheta = (dgvCostumer.Rows[e.RowIndex].Cells[27].Value.ToString() == "SIM");
                bool trocaBujao = (dgvCostumer.Rows[e.RowIndex].Cells[28].Value.ToString() == "SIM");
                bool trocaFluidoDirecao = (dgvCostumer.Rows[e.RowIndex].Cells[29].Value.ToString() == "SIM");
                bool trocaFluidoCambio = (dgvCostumer.Rows[e.RowIndex].Cells[30].Value.ToString() == "SIM");
                bool trocaPinos = (dgvCostumer.Rows[e.RowIndex].Cells[31].Value.ToString() == "SIM");

                CostumerModuleForm costumerModule = new CostumerModuleForm();
                costumerModule.txtPlaca.Text = dgvCostumer.Rows[e.RowIndex].Cells[1].Value.ToString();
                costumerModule.txtCName.Text = dgvCostumer.Rows[e.RowIndex].Cells[2].Value.ToString();
                costumerModule.txtCPhone.Text = dgvCostumer.Rows[e.RowIndex].Cells[3].Value.ToString();
                costumerModule.txtMontadora.Text = dgvCostumer.Rows[e.RowIndex].Cells[4].Value.ToString();
                costumerModule.txtCarro.Text = dgvCostumer.Rows[e.RowIndex].Cells[5].Value.ToString();
                costumerModule.txtAno.Text = dgvCostumer.Rows[e.RowIndex].Cells[6].Value.ToString();
                costumerModule.txtOleoOriginal.Text = dgvCostumer.Rows[e.RowIndex].Cells[7].Value.ToString();
                costumerModule.txtOleoUsado.Text = dgvCostumer.Rows[e.RowIndex].Cells[8].Value.ToString();
                costumerModule.txtQuantidadeOleo.Text = dgvCostumer.Rows[e.RowIndex].Cells[9].Value.ToString();
                costumerModule.txtFiltroOleo.Text = dgvCostumer.Rows[e.RowIndex].Cells[10].Value.ToString();
                costumerModule.txtFiltroAr.Text = dgvCostumer.Rows[e.RowIndex].Cells[11].Value.ToString();
                costumerModule.txtCombustivel.Text = dgvCostumer.Rows[e.RowIndex].Cells[12].Value.ToString();
                costumerModule.txtFiltroCabine.Text = dgvCostumer.Rows[e.RowIndex].Cells[13].Value.ToString();
                costumerModule.txtPalheta.Text = dgvCostumer.Rows[e.RowIndex].Cells[14].Value.ToString();
                costumerModule.txtBujao.Text = dgvCostumer.Rows[e.RowIndex].Cells[15].Value.ToString();              
                costumerModule.txtFluidoDirecao.Text = dgvCostumer.Rows[e.RowIndex].Cells[16].Value.ToString();
                costumerModule.txtFluidoCambio.Text = dgvCostumer.Rows[e.RowIndex].Cells[17].Value.ToString();                
                costumerModule.txtPinos.Text = dgvCostumer.Rows[e.RowIndex].Cells[18].Value.ToString();
                costumerModule.txtObservacao.Text = dgvCostumer.Rows[e.RowIndex].Cells[19].Value.ToString();
                costumerModule.mtxDataTroca.Text = dgvCostumer.Rows[e.RowIndex].Cells[20].Value.ToString();
                costumerModule.txtKm.Text = dgvCostumer.Rows[e.RowIndex].Cells[21].Value.ToString();

                costumerModule.cbxOleo.Checked = trocaOleo;
                costumerModule.cbxFiltroOleo.Checked = trocaFiltroOleo;
                costumerModule.cbxFiltroAr.Checked = trocaFiltroAr;
                costumerModule.cbxFiltroComb.Checked = trocaFiltroComb;
                costumerModule.cbxFiltroCabine.Checked = trocaFiltroCabine;
                costumerModule.cbxPalheta.Checked = trocaPalheta;
                costumerModule.cbxBujao.Checked = trocaBujao;
                costumerModule.cbxFluidoDirecao.Checked = trocaFluidoDirecao;
                costumerModule.cbxFluidoCambio.Checked = trocaFluidoCambio;
                costumerModule.cbxPinos.Checked = trocaPinos;




                costumerModule.btnSave.Enabled = false;              
                costumerModule.ShowDialog();
            }
            /*else if (colName == "Delete")
            {
                if (MessageBox.Show("Tem certeza que deseja excluir esse Cliente?", "Excluir Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM tbCostumer WHERE Placa LIKE '" + dgvCostumer.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Cliente excluído!");
                }            
            }*/
            LoadCostumer();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCostumer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            dgvCostumer.Rows.Clear();
            cmd = new SqlCommand($"SELECT * FROM Clientes$ WHERE Placa LIKE '%{txtSearch.Text}%' OR Nome LIKE '%{txtSearch.Text}%' OR Telefone LIKE '%{txtSearch.Text}%'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCostumer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString(), dr[14].ToString(), dr[15].ToString(), dr[16].ToString(), dr[17].ToString(), dr[18].ToString(), dr[19].ToString(), dr[20].ToString(), dr[21].ToString(), dr[22].ToString(), dr[23].ToString(), dr[24].ToString(), dr[25].ToString(), dr[26].ToString(), dr[27].ToString(), dr[28].ToString(), dr[29].ToString(), dr[30].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void txtSearchPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnBuscar.Select();            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            dgvCostumer.Rows.Clear();
            cmd = new SqlCommand($"SELECT TOP {dupQtdeClientes.Text} * FROM Clientes$ ORDER BY DataTroca DESC", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCostumer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString(), dr[14].ToString(), dr[15].ToString(), dr[16].ToString(), dr[17].ToString(), dr[18].ToString(), dr[19].ToString(), dr[20].ToString(), dr[21].ToString(), dr[22].ToString(), dr[23].ToString(), dr[24].ToString(), dr[25].ToString(), dr[26].ToString(), dr[27].ToString(), dr[28].ToString(), dr[29].ToString(), dr[30].ToString());
            }
            dr.Close();
            con.Close();
        }
    }
}
