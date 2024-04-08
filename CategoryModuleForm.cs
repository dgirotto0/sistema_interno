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
    public partial class CategoryModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""C:\USERS\DANIEL.GIROTTO\ONEDRIVE - INFORDOC SERVICOS DE INFORMATICA LTDA\DOCUMENTS\DBMS.MDF"";Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        public CategoryModuleForm()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza que quer salvar essa categoria?", "Salvando Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tbCategory(catname) VALUES(@catname)", con);
                    cmd.Parameters.AddWithValue("@catname", txtCatName.Text);                    
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Categoria salva!");
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
            txtCatName.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUptade.Enabled = false;
        }

        private void btnUptade_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza que quer atuliazar essa categoria?", "Atualizando Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPTADE tbCategory SET catname = @catname WHERE catId LIKE '" + lblCategoryId.Text + "' ", con);
                    cmd.Parameters.AddWithValue("@catname", txtCatName.Text);
                    con.Open();
                    //cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Categoria atualizada!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
