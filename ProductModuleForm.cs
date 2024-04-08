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
    public partial class ProductModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""C:\USERS\DANIEL.GIROTTO\ONEDRIVE - INFORDOC SERVICOS DE INFORMATICA LTDA\DOCUMENTS\DBMS.MDF"";Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public ProductModuleForm()
        {
            InitializeComponent();
            LoadProduct();
        }

        private void LoadProduct()
        {
            cbxCategory.Items.Clear();
            cmd = new SqlCommand("SELECT * FROM tbCategory", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbxCategory.Items.Add(dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza que deseja salvar?", "Salvando Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tbProduct(productname, quantity, price, description, category) VALUES(@productname, @quantity, @price, @description, @category)", con);
                    cmd.Parameters.AddWithValue("@productname", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@category", cbxCategory.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Produto salvo com sucesso!");
                    Clear();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void Clear()
        {
            txtProductName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtDescription.Clear();
            cbxCategory.Text = "";
        }

        private void btnUptade_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza que deseja atualizar esse produto?", "Atualização Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPTADE tbProduct SET productname = @productname, quantity = @quantity, price = @price, description = @description, category = @category WHERE prodid LIKE '" + txtProductName + "' ", con);
                    cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@description ", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@category ", cbxCategory.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Produto atualizado com sucesso!");
                    this.Dispose();
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUptade.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
