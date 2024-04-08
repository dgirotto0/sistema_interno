using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //mostrar os subforms no form principal

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlMainForm.Controls.Add(childForm);
                pnlMainForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            
        }

        private void btnCostumers_Click(object sender, EventArgs e)
        {            
            openChildForm(new CostumerForm());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductForm());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderForm());
        }
    }
}
