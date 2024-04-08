using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class OrderForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=172.16.1.208;Initial Catalog=Excel;User ID=sa;Password=Infordoc01");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public OrderForm()
        {
            InitializeComponent();
            LoadOrder();
        }

        private void LoadOrder()
        {
            double total = 0;
            int i = 0;
            dgvOrder.Rows.Clear();
            cmd = new SqlCommand("SELECT orderid, odate, O.pid, P.productname, O.cid, C.cname, cty, oprice, total  FROM tbOrder AS O JOIN tbCostumer AS C ON O.cid=C.cId JOIN tbProduct AS P ON O.pid=P.prodid WHERE CONCAT (orderid, odate, O.pid, P.productname, O.cid, C.cname, cty, oprice) LIKE '%" + txtSearch.Text + "%'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvOrder.Rows.Add(i, dr[0].ToString(), Convert.ToDateTime(dr[1].ToString()).ToString("dd/MM/yyyy"), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                total += Convert.ToInt32(dr[8].ToString());
            }
            dr.Close();
            con.Close();

            lblQty.Text = i.ToString();
            lblTotal.Text = total.ToString();

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            OrderModuleForm moduleForm = new OrderModuleForm();
            moduleForm.ShowDialog();
            LoadOrder();
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvOrder.Columns[e.ColumnIndex].Name;          
            
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this order?", "Delete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM tbOrder WHERE orderid LIKE '" + dgvOrder.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");

                    cmd = new SqlCommand("UPTADE tbProduct SET quantity = (quantity + @quantity) WHERE prodid LIKE '" + dgvOrder.Rows[e.RowIndex].Cells[3].Value.ToString() + "' ", con);
                    cmd.Parameters.AddWithValue("@quantity", Convert.ToInt16(dgvOrder.Rows[e.RowIndex].Cells[5].Value.ToString()));
                    con.Open();
                    //cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            LoadOrder();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadOrder();
        }
    }
}
