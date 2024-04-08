namespace InventoryManagementSystem
{
    partial class CostumerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostumerForm));
            this.dgvCostumer = new System.Windows.Forms.DataGridView();
            this.pnlManageUsers = new System.Windows.Forms.Panel();
            this.btnBuscarQtde = new System.Windows.Forms.Button();
            this.lblClientes = new System.Windows.Forms.Label();
            this.dupQtdeClientes = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddCostumer = new InventoryManagementSystem.CostumerButton();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OleoOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OleoUsado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiltroOleo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiltroAr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combustivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiltroCabine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Palheta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bujao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OleoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FluidoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataTroca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostumer)).BeginInit();
            this.pnlManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCostumer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCostumer
            // 
            this.dgvCostumer.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dgvCostumer.AllowUserToAddRows = false;
            this.dgvCostumer.AllowUserToOrderColumns = true;
            this.dgvCostumer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCostumer.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.Column11,
            this.Placa,
            this.Nome,
            this.Telefone,
            this.Montadora,
            this.Carro,
            this.Ano,
            this.OleoOriginal,
            this.OleoUsado,
            this.Quantidade,
            this.FiltroOleo,
            this.FiltroAr,
            this.Combustivel,
            this.FiltroCabine,
            this.Palheta,
            this.Bujao,
            this.OleoCambio,
            this.FluidoCambio,
            this.Pinos,
            this.obs,
            this.DataTroca,
            this.km,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Edit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCostumer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCostumer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCostumer.EnableHeadersVisualStyles = false;
            this.dgvCostumer.Location = new System.Drawing.Point(0, 0);
            this.dgvCostumer.Name = "dgvCostumer";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCostumer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCostumer.RowHeadersWidth = 51;
            this.dgvCostumer.RowTemplate.Height = 24;
            this.dgvCostumer.Size = new System.Drawing.Size(1324, 534);
            this.dgvCostumer.TabIndex = 4;
            this.dgvCostumer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCostumer_CellContentClick_1);
            // 
            // pnlManageUsers
            // 
            this.pnlManageUsers.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlManageUsers.Controls.Add(this.btnBuscarQtde);
            this.pnlManageUsers.Controls.Add(this.lblClientes);
            this.pnlManageUsers.Controls.Add(this.dupQtdeClientes);
            this.pnlManageUsers.Controls.Add(this.label1);
            this.pnlManageUsers.Controls.Add(this.btnBuscar);
            this.pnlManageUsers.Controls.Add(this.txtSearch);
            this.pnlManageUsers.Controls.Add(this.btnAddCostumer);
            this.pnlManageUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlManageUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlManageUsers.Location = new System.Drawing.Point(0, 534);
            this.pnlManageUsers.Name = "pnlManageUsers";
            this.pnlManageUsers.Size = new System.Drawing.Size(1324, 73);
            this.pnlManageUsers.TabIndex = 3;
            // 
            // btnBuscarQtde
            // 
            this.btnBuscarQtde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnBuscarQtde.BackColor = System.Drawing.Color.White;
            this.btnBuscarQtde.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscarQtde.FlatAppearance.BorderSize = 0;
            this.btnBuscarQtde.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarQtde.Location = new System.Drawing.Point(1154, 17);
            this.btnBuscarQtde.Name = "btnBuscarQtde";
            this.btnBuscarQtde.Size = new System.Drawing.Size(90, 37);
            this.btnBuscarQtde.TabIndex = 15;
            this.btnBuscarQtde.Text = "Buscar";
            this.btnBuscarQtde.UseVisualStyleBackColor = false;
            this.btnBuscarQtde.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblClientes
            // 
            this.lblClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.Black;
            this.lblClientes.Location = new System.Drawing.Point(1068, 10);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(80, 22);
            this.lblClientes.TabIndex = 14;
            this.lblClientes.Text = "Clientes";
            // 
            // dupQtdeClientes
            // 
            this.dupQtdeClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dupQtdeClientes.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dupQtdeClientes.Location = new System.Drawing.Point(1066, 36);
            this.dupQtdeClientes.Name = "dupQtdeClientes";
            this.dupQtdeClientes.Size = new System.Drawing.Size(82, 28);
            this.dupQtdeClientes.TabIndex = 13;
            this.dupQtdeClientes.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(138, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(335, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 37);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(17, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(312, 26);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchPlaca_KeyDown);
            // 
            // btnAddCostumer
            // 
            this.btnAddCostumer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCostumer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCostumer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCostumer.Image")));
            this.btnAddCostumer.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnAddCostumer.ImageHover")));
            this.btnAddCostumer.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnAddCostumer.ImageNormal")));
            this.btnAddCostumer.Location = new System.Drawing.Point(1287, 26);
            this.btnAddCostumer.Name = "btnAddCostumer";
            this.btnAddCostumer.Size = new System.Drawing.Size(25, 25);
            this.btnAddCostumer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddCostumer.TabIndex = 4;
            this.btnAddCostumer.TabStop = false;
            this.btnAddCostumer.Click += new System.EventHandler(this.btnAddCostumer_Click_1);
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column11.HeaderText = "Nº";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 51;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.MinimumWidth = 6;
            this.Placa.Name = "Placa";
            this.Placa.Width = 77;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.Width = 80;
            // 
            // Telefone
            // 
            this.Telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.MinimumWidth = 6;
            this.Telefone.Name = "Telefone";
            this.Telefone.Width = 98;
            // 
            // Montadora
            // 
            this.Montadora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Montadora.HeaderText = "Montadora";
            this.Montadora.MinimumWidth = 6;
            this.Montadora.Name = "Montadora";
            this.Montadora.Width = 117;
            // 
            // Carro
            // 
            this.Carro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Carro.HeaderText = "Carro";
            this.Carro.MinimumWidth = 6;
            this.Carro.Name = "Carro";
            this.Carro.Width = 77;
            // 
            // Ano
            // 
            this.Ano.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ano.HeaderText = "Ano";
            this.Ano.MinimumWidth = 6;
            this.Ano.Name = "Ano";
            this.Ano.Width = 65;
            // 
            // OleoOriginal
            // 
            this.OleoOriginal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OleoOriginal.HeaderText = "Óleo Original";
            this.OleoOriginal.MinimumWidth = 6;
            this.OleoOriginal.Name = "OleoOriginal";
            this.OleoOriginal.Width = 135;
            // 
            // OleoUsado
            // 
            this.OleoUsado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OleoUsado.HeaderText = "Óleo Usado";
            this.OleoUsado.MinimumWidth = 6;
            this.OleoUsado.Name = "OleoUsado";
            this.OleoUsado.Width = 122;
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Quantidade.HeaderText = "Qtd (Litros)";
            this.Quantidade.MinimumWidth = 6;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 114;
            // 
            // FiltroOleo
            // 
            this.FiltroOleo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FiltroOleo.HeaderText = "Filtro de Óleo";
            this.FiltroOleo.MinimumWidth = 6;
            this.FiltroOleo.Name = "FiltroOleo";
            this.FiltroOleo.Width = 134;
            // 
            // FiltroAr
            // 
            this.FiltroAr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FiltroAr.HeaderText = "Filtro de Ar";
            this.FiltroAr.MinimumWidth = 6;
            this.FiltroAr.Name = "FiltroAr";
            this.FiltroAr.Width = 113;
            // 
            // Combustivel
            // 
            this.Combustivel.HeaderText = "Combustivel";
            this.Combustivel.MinimumWidth = 6;
            this.Combustivel.Name = "Combustivel";
            this.Combustivel.Width = 126;
            // 
            // FiltroCabine
            // 
            this.FiltroCabine.HeaderText = "Filtro de Cabine";
            this.FiltroCabine.MinimumWidth = 6;
            this.FiltroCabine.Name = "FiltroCabine";
            this.FiltroCabine.Width = 125;
            // 
            // Palheta
            // 
            this.Palheta.HeaderText = "Palheta";
            this.Palheta.MinimumWidth = 6;
            this.Palheta.Name = "Palheta";
            this.Palheta.Width = 90;
            // 
            // Bujao
            // 
            this.Bujao.HeaderText = "Bujão";
            this.Bujao.MinimumWidth = 6;
            this.Bujao.Name = "Bujao";
            this.Bujao.Width = 77;
            // 
            // OleoCambio
            // 
            this.OleoCambio.HeaderText = "Fluído de Direção";
            this.OleoCambio.MinimumWidth = 6;
            this.OleoCambio.Name = "OleoCambio";
            this.OleoCambio.Width = 143;
            // 
            // FluidoCambio
            // 
            this.FluidoCambio.HeaderText = "Fluído de Câmbio";
            this.FluidoCambio.MinimumWidth = 6;
            this.FluidoCambio.Name = "FluidoCambio";
            this.FluidoCambio.Width = 143;
            // 
            // Pinos
            // 
            this.Pinos.HeaderText = "Pinos";
            this.Pinos.MinimumWidth = 6;
            this.Pinos.Name = "Pinos";
            this.Pinos.Width = 125;
            // 
            // obs
            // 
            this.obs.HeaderText = "Observação";
            this.obs.MinimumWidth = 6;
            this.obs.Name = "obs";
            this.obs.Width = 125;
            // 
            // DataTroca
            // 
            this.DataTroca.HeaderText = "Data da Troca";
            this.DataTroca.MinimumWidth = 6;
            this.DataTroca.Name = "DataTroca";
            this.DataTroca.Width = 125;
            // 
            // km
            // 
            this.km.HeaderText = "KM";
            this.km.MinimumWidth = 6;
            this.km.Name = "km";
            this.km.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Óleo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Filtro de Óleo";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Filtro de Ar";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Filtro de Combustível";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Filtro de Cabine";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Palheta";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Bujão";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Fluído de Direção";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Fluído de Câmbio";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Pinos";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Width = 6;
            // 
            // CostumerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1324, 607);
            this.Controls.Add(this.dgvCostumer);
            this.Controls.Add(this.pnlManageUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CostumerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Costumer Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostumer)).EndInit();
            this.pnlManageUsers.ResumeLayout(false);
            this.pnlManageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCostumer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCostumer;
        private System.Windows.Forms.Panel pnlManageUsers;
        private CostumerButton btnAddCostumer;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Button btnBuscarQtde;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.DomainUpDown dupQtdeClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn OleoOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn OleoUsado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiltroOleo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiltroAr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Combustivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiltroCabine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Palheta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bujao;
        private System.Windows.Forms.DataGridViewTextBoxColumn OleoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FluidoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataTroca;
        private System.Windows.Forms.DataGridViewTextBoxColumn km;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}