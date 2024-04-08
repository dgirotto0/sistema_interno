using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class OrderModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=172.16.1.208;Initial Catalog=Excel;User ID=sa;Password=Infordoc01");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        int qty = 0;
        public OrderModuleForm()
        {
            InitializeComponent();
            LoadCostumer();
            LoadProduct();           
        }

        public void LoadCostumer()
        {
            int i = 0;
            dgvCostumer.Rows.Clear();
            cmd = new SqlCommand("SELECT cId, cname FROM tbCostumer WHERE CONCAT(cId, cname) LIKE '%" + txtSearchCus.Text + "%'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCostumer.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(prodid, productname, price, description, category) LIKE '%" + txtSearchProd.Text + "%'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {            
            this.Dispose();
            
        }
                      
        private void txtSearchCus_TextChanged(object sender, EventArgs e)
        {
            LoadCostumer();
        }

        private void txtSearchProd_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            GetQty();
            if (Convert.ToInt16(nupQty.Value) > qty)
            {
                MessageBox.Show("Instock quantity is not enough!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToInt16(nupQty.Value) > 0)
            {
                int total = Convert.ToInt16(txtPrice.Text) * Convert.ToInt16(nupQty.Value);
                txtTotal.Text = total.ToString();
            }

        }

        private void dgvCostumer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerId.Text = dgvCostumer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCustomerName.Text = dgvCostumer.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = dgvProduct.Rows.Count;

            if (e.RowIndex >= 0 && e.RowIndex < count)
            {
                txtProductId.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtProdName.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }

        private void btnOrderUptade_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerId.Text == "")
                {
                    MessageBox.Show("Please select customer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtProductId.Text == "")
                {
                    MessageBox.Show("Please select product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you ant to insert this order?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                   
                    cmd = new SqlCommand("INSERT INTO tbOrder(odate, pid, cid, cty, oprice, total) VALUES(@odate, @pid, @cid, @cty, @oprice, @total)", con);
                    cmd.Parameters.AddWithValue("@odate", dateOrder.Text);                  
                    cmd.Parameters.AddWithValue("@pid", Convert.ToInt16(txtProductId.Text));
                    cmd.Parameters.AddWithValue("@cid", Convert.ToInt16(txtCustomerId.Text));
                    cmd.Parameters.AddWithValue("@cty", Convert.ToInt16(nupQty.Value));
                    cmd.Parameters.AddWithValue("@oprice", Convert.ToInt16(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@total", Convert.ToInt16(txtTotal.Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Order has been successfully inserted!");                    

                    cmd = new SqlCommand("UPTADE tbProduct SET quantity = (quantity - @quantity) WHERE prodid LIKE '" + txtProductId.Text + "' ", con);
                    cmd.Parameters.AddWithValue("@quantity", Convert.ToInt16(nupQty.Value));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Clear();
                    LoadProduct();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void Clear()
        {
            txtCustomerId.Clear();
            txtCustomerName.Clear();

            txtProductId.Clear();
            txtProdName.Clear();
            txtPrice.Clear();
            nupQty.Value = 1;
            txtTotal.Clear();
            dateOrder.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void GetQty()
        {
            cmd = new SqlCommand("SELECT quantity FROM tbProduct WHERE prodid = '" + txtProductId.Text + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                qty = Convert.ToInt16(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }
    }
}
