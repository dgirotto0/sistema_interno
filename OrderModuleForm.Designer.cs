namespace InventoryManagementSystem
{
    partial class OrderModuleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderModuleForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlUserModule = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblCostumerModule = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOid = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.dgvCostumer = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostumerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchCus = new System.Windows.Forms.TextBox();
            this.lblSearchCus = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nupQty = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOrderInsert = new System.Windows.Forms.Button();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.dateOrder = new System.Windows.Forms.DateTimePicker();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.lblProdName = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtSearchProd = new System.Windows.Forms.TextBox();
            this.lblSearchProd = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUserModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostumer)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUserModule
            // 
            this.pnlUserModule.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlUserModule.Controls.Add(this.pictureBox3);
            this.pnlUserModule.Controls.Add(this.lblCostumerModule);
            this.pnlUserModule.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserModule.Location = new System.Drawing.Point(0, 0);
            this.pnlUserModule.Name = "pnlUserModule";
            this.pnlUserModule.Size = new System.Drawing.Size(929, 48);
            this.pnlUserModule.TabIndex = 27;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(902, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblCostumerModule
            // 
            this.lblCostumerModule.AutoSize = true;
            this.lblCostumerModule.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostumerModule.ForeColor = System.Drawing.Color.White;
            this.lblCostumerModule.Location = new System.Drawing.Point(3, 13);
            this.lblCostumerModule.Name = "lblCostumerModule";
            this.lblCostumerModule.Size = new System.Drawing.Size(133, 22);
            this.lblCostumerModule.TabIndex = 0;
            this.lblCostumerModule.Text = "Order Module";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblOid);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtCustomerId);
            this.panel1.Controls.Add(this.lblCustomerId);
            this.panel1.Controls.Add(this.dgvCostumer);
            this.panel1.Controls.Add(this.txtSearchCus);
            this.panel1.Controls.Add(this.lblSearchCus);
            this.panel1.Controls.Add(this.lblCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 637);
            this.panel1.TabIndex = 28;
            // 
            // lblOid
            // 
            this.lblOid.AutoSize = true;
            this.lblOid.BackColor = System.Drawing.Color.White;
            this.lblOid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOid.ForeColor = System.Drawing.Color.Black;
            this.lblOid.Location = new System.Drawing.Point(27, 595);
            this.lblOid.Name = "lblOid";
            this.lblOid.Size = new System.Drawing.Size(66, 18);
            this.lblOid.TabIndex = 23;
            this.lblOid.Text = "order id";
            this.lblOid.Visible = false;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(30, 477);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(263, 24);
            this.txtCustomerName.TabIndex = 22;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(27, 456);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(127, 18);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Customer Name";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Enabled = false;
            this.txtCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerId.Location = new System.Drawing.Point(30, 415);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(263, 24);
            this.txtCustomerId.TabIndex = 20;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.BackColor = System.Drawing.Color.White;
            this.lblCustomerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCustomerId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerId.Location = new System.Drawing.Point(27, 394);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(97, 18);
            this.lblCustomerId.TabIndex = 19;
            this.lblCustomerId.Text = "Customer ID";
            // 
            // dgvCostumer
            // 
            this.dgvCostumer.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dgvCostumer.AllowUserToAddRows = false;
            this.dgvCostumer.AllowUserToOrderColumns = true;
            this.dgvCostumer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCostumer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCostumer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCostumer.ColumnHeadersHeight = 30;
            this.dgvCostumer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.CostumerId,
            this.Name1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCostumer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCostumer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCostumer.EnableHeadersVisualStyles = false;
            this.dgvCostumer.Location = new System.Drawing.Point(0, 0);
            this.dgvCostumer.Name = "dgvCostumer";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCostumer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCostumer.RowHeadersWidth = 51;
            this.dgvCostumer.RowTemplate.Height = 24;
            this.dgvCostumer.Size = new System.Drawing.Size(326, 282);
            this.dgvCostumer.TabIndex = 18;
            this.dgvCostumer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCostumer_CellClick);
            // 
            // numero
            // 
            this.numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numero.HeaderText = "Nº";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.Width = 51;
            // 
            // CostumerId
            // 
            this.CostumerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CostumerId.HeaderText = "Costumer ID";
            this.CostumerId.MinimumWidth = 6;
            this.CostumerId.Name = "CostumerId";
            this.CostumerId.Width = 124;
            // 
            // Name1
            // 
            this.Name1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name1.HeaderText = "Name";
            this.Name1.MinimumWidth = 6;
            this.Name1.Name = "Name1";
            // 
            // txtSearchCus
            // 
            this.txtSearchCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCus.Location = new System.Drawing.Point(93, 288);
            this.txtSearchCus.Name = "txtSearchCus";
            this.txtSearchCus.Size = new System.Drawing.Size(220, 24);
            this.txtSearchCus.TabIndex = 17;
            this.txtSearchCus.TextChanged += new System.EventHandler(this.txtSearchCus_TextChanged);
            // 
            // lblSearchCus
            // 
            this.lblSearchCus.AutoSize = true;
            this.lblSearchCus.BackColor = System.Drawing.Color.White;
            this.lblSearchCus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSearchCus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCus.ForeColor = System.Drawing.Color.Black;
            this.lblSearchCus.Location = new System.Drawing.Point(27, 292);
            this.lblSearchCus.Name = "lblSearchCus";
            this.lblSearchCus.Size = new System.Drawing.Size(57, 18);
            this.lblSearchCus.TabIndex = 16;
            this.lblSearchCus.Text = "Buscar";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCustomer.Location = new System.Drawing.Point(3, 341);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(76, 22);
            this.lblCustomer.TabIndex = 6;
            this.lblCustomer.Text = "CLIENTE";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nupQty);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnOrderInsert);
            this.panel2.Controls.Add(this.lblOrderDate);
            this.panel2.Controls.Add(this.dateOrder);
            this.panel2.Controls.Add(this.txtProdName);
            this.panel2.Controls.Add(this.lblProdName);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.txtProductId);
            this.panel2.Controls.Add(this.lblProductId);
            this.panel2.Controls.Add(this.lblQty);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.txtSearchProd);
            this.panel2.Controls.Add(this.lblSearchProd);
            this.panel2.Controls.Add(this.lblProduct);
            this.panel2.Controls.Add(this.dgvProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(332, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 637);
            this.panel2.TabIndex = 29;
            // 
            // nupQty
            // 
            this.nupQty.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupQty.Location = new System.Drawing.Point(424, 447);
            this.nupQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupQty.Name = "nupQty";
            this.nupQty.Size = new System.Drawing.Size(161, 23);
            this.nupQty.TabIndex = 38;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(456, 584);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 41);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOrderInsert
            // 
            this.btnOrderInsert.BackColor = System.Drawing.Color.Green;
            this.btnOrderInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderInsert.FlatAppearance.BorderSize = 0;
            this.btnOrderInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderInsert.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnOrderInsert.ForeColor = System.Drawing.Color.White;
            this.btnOrderInsert.Location = new System.Drawing.Point(305, 584);
            this.btnOrderInsert.Name = "btnOrderInsert";
            this.btnOrderInsert.Size = new System.Drawing.Size(128, 41);
            this.btnOrderInsert.TabIndex = 35;
            this.btnOrderInsert.Text = "Inserir Pedido";
            this.btnOrderInsert.UseVisualStyleBackColor = false;
            this.btnOrderInsert.Click += new System.EventHandler(this.btnOrderInsert_Click);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.BackColor = System.Drawing.Color.White;
            this.lblOrderDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOrderDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.ForeColor = System.Drawing.Color.Black;
            this.lblOrderDate.Location = new System.Drawing.Point(4, 501);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(90, 18);
            this.lblOrderDate.TabIndex = 34;
            this.lblOrderDate.Text = "Order Date";
            // 
            // dateOrder
            // 
            this.dateOrder.CalendarForeColor = System.Drawing.Color.Black;
            this.dateOrder.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dateOrder.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOrder.Location = new System.Drawing.Point(7, 527);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.Size = new System.Drawing.Size(128, 26);
            this.dateOrder.TabIndex = 33;
            // 
            // txtProdName
            // 
            this.txtProdName.Enabled = false;
            this.txtProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.Location = new System.Drawing.Point(7, 462);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(165, 24);
            this.txtProdName.TabIndex = 32;
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.BackColor = System.Drawing.Color.White;
            this.lblProdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblProdName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.ForeColor = System.Drawing.Color.Black;
            this.lblProdName.Location = new System.Drawing.Point(4, 441);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(113, 18);
            this.lblProdName.TabIndex = 31;
            this.lblProdName.Text = "Product Name";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(424, 475);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(161, 23);
            this.txtTotal.TabIndex = 30;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(373, 478);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 18);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "Total";
            // 
            // txtProductId
            // 
            this.txtProductId.Enabled = false;
            this.txtProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductId.Location = new System.Drawing.Point(7, 406);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(165, 24);
            this.txtProductId.TabIndex = 28;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.BackColor = System.Drawing.Color.White;
            this.lblProductId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblProductId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.ForeColor = System.Drawing.Color.Black;
            this.lblProductId.Location = new System.Drawing.Point(4, 385);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(83, 18);
            this.lblProductId.TabIndex = 27;
            this.lblProductId.Text = "Product ID";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.BackColor = System.Drawing.Color.White;
            this.lblQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblQty.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.Black;
            this.lblQty.Location = new System.Drawing.Point(373, 448);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(34, 18);
            this.lblQty.TabIndex = 25;
            this.lblQty.Text = "Qty";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(424, 415);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(161, 23);
            this.txtPrice.TabIndex = 24;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(373, 418);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(45, 18);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.Text = "Price";
            // 
            // txtSearchProd
            // 
            this.txtSearchProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProd.Location = new System.Drawing.Point(305, 288);
            this.txtSearchProd.Name = "txtSearchProd";
            this.txtSearchProd.Size = new System.Drawing.Size(266, 24);
            this.txtSearchProd.TabIndex = 18;
            this.txtSearchProd.TextChanged += new System.EventHandler(this.txtSearchProd_TextChanged);
            // 
            // lblSearchProd
            // 
            this.lblSearchProd.AutoSize = true;
            this.lblSearchProd.BackColor = System.Drawing.Color.White;
            this.lblSearchProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSearchProd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchProd.ForeColor = System.Drawing.Color.Black;
            this.lblSearchProd.Location = new System.Drawing.Point(239, 290);
            this.lblSearchProd.Name = "lblSearchProd";
            this.lblSearchProd.Size = new System.Drawing.Size(57, 18);
            this.lblSearchProd.TabIndex = 17;
            this.lblSearchProd.Text = "Buscar";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblProduct.Location = new System.Drawing.Point(3, 341);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(93, 22);
            this.lblProduct.TabIndex = 7;
            this.lblProduct.Text = "PRODUTO";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduct.ColumnHeadersHeight = 30;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ProductID,
            this.Name3,
            this.Price,
            this.Qty,
            this.Description,
            this.Column1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(597, 282);
            this.dgvProduct.TabIndex = 5;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nº";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 49;
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            // 
            // Name3
            // 
            this.Name3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Name3.HeaderText = "Name";
            this.Name3.MinimumWidth = 6;
            this.Name3.Name = "Name3";
            this.Name3.Width = 73;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 66;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 57;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Category";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 95;
            // 
            // OrderModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 685);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlUserModule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderModuleForm";
            this.pnlUserModule.ResumeLayout(false);
            this.pnlUserModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostumer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUserModule;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblCostumerModule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblSearchCus;
        private System.Windows.Forms.Label lblSearchProd;
        private System.Windows.Forms.DataGridView dgvCostumer;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostumerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Label lblOrderDate;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnOrderInsert;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtProductId;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtProdName;
        public System.Windows.Forms.NumericUpDown nupQty;
        public System.Windows.Forms.Label lblOid;
        public System.Windows.Forms.TextBox txtSearchCus;
        public System.Windows.Forms.TextBox txtSearchProd;
        public System.Windows.Forms.TextBox txtCustomerName;
        public System.Windows.Forms.TextBox txtCustomerId;
        public System.Windows.Forms.DateTimePicker dateOrder;
    }
}