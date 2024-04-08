namespace InventoryManagementSystem
{
    partial class CategoryModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryModuleForm));
            this.pnlUserModule = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblCategoryModule = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUptade = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.lblCatName = new System.Windows.Forms.Label();
            this.pnlUserModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUserModule
            // 
            this.pnlUserModule.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlUserModule.Controls.Add(this.pictureBox3);
            this.pnlUserModule.Controls.Add(this.lblCategoryModule);
            this.pnlUserModule.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserModule.Location = new System.Drawing.Point(0, 0);
            this.pnlUserModule.Name = "pnlUserModule";
            this.pnlUserModule.Size = new System.Drawing.Size(590, 46);
            this.pnlUserModule.TabIndex = 27;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(562, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblCategoryModule
            // 
            this.lblCategoryModule.AutoSize = true;
            this.lblCategoryModule.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryModule.ForeColor = System.Drawing.Color.Black;
            this.lblCategoryModule.Location = new System.Drawing.Point(3, 13);
            this.lblCategoryModule.Name = "lblCategoryModule";
            this.lblCategoryModule.Size = new System.Drawing.Size(185, 22);
            this.lblCategoryModule.TabIndex = 0;
            this.lblCategoryModule.Text = "Cadastro Categoria";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCategoryId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryId.Location = new System.Drawing.Point(70, 134);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(111, 21);
            this.lblCategoryId.TabIndex = 35;
            this.lblCategoryId.Text = "Category Id";
            this.lblCategoryId.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(445, 119);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 41);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUptade
            // 
            this.btnUptade.BackColor = System.Drawing.Color.Olive;
            this.btnUptade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUptade.FlatAppearance.BorderSize = 0;
            this.btnUptade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUptade.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnUptade.ForeColor = System.Drawing.Color.White;
            this.btnUptade.Location = new System.Drawing.Point(336, 119);
            this.btnUptade.Name = "btnUptade";
            this.btnUptade.Size = new System.Drawing.Size(103, 41);
            this.btnUptade.TabIndex = 32;
            this.btnUptade.Text = "Atualizar";
            this.btnUptade.UseVisualStyleBackColor = false;
            this.btnUptade.Click += new System.EventHandler(this.btnUptade_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(226, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 41);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCatName
            // 
            this.txtCatName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatName.Location = new System.Drawing.Point(144, 64);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(398, 28);
            this.txtCatName.TabIndex = 28;
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCatName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatName.Location = new System.Drawing.Point(73, 67);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(60, 21);
            this.lblCatName.TabIndex = 29;
            this.lblCatName.Text = "Nome";
            // 
            // CategoryModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 211);
            this.Controls.Add(this.pnlUserModule);
            this.Controls.Add(this.lblCategoryId);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUptade);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.lblCatName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CategoryModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryModuleForm";
            this.pnlUserModule.ResumeLayout(false);
            this.pnlUserModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUserModule;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblCategoryModule;
        public System.Windows.Forms.Label lblCategoryId;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnUptade;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtCatName;
        public System.Windows.Forms.Label lblCatName;
    }
}