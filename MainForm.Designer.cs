namespace InventoryManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlTools = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAtiel = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMainForm = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCostumers = new InventoryManagementSystem.CostumerButton();
            this.pnlTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCostumers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.Color.White;
            this.pnlTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTools.Controls.Add(this.label2);
            this.pnlTools.Controls.Add(this.btnCostumers);
            this.pnlTools.Controls.Add(this.lblAtiel);
            this.pnlTools.Controls.Add(this.lblTitulo);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTools.Location = new System.Drawing.Point(0, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(982, 112);
            this.pnlTools.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(351, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "CLIENTES";
            // 
            // lblAtiel
            // 
            this.lblAtiel.AutoSize = true;
            this.lblAtiel.BackColor = System.Drawing.Color.White;
            this.lblAtiel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtiel.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAtiel.Location = new System.Drawing.Point(12, 9);
            this.lblAtiel.Name = "lblAtiel";
            this.lblAtiel.Size = new System.Drawing.Size(131, 34);
            this.lblAtiel.TabIndex = 10;
            this.lblAtiel.Text = "ITAOLEO";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(12, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(270, 19);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "SISTEMA DE CONTROLE INTERNO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 571);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 32);
            this.panel1.TabIndex = 1;
            // 
            // pnlMainForm
            // 
            this.pnlMainForm.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainForm.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMainForm.Location = new System.Drawing.Point(0, 112);
            this.pnlMainForm.Name = "pnlMainForm";
            this.pnlMainForm.Size = new System.Drawing.Size(982, 459);
            this.pnlMainForm.TabIndex = 2;
            // 
            // btnCostumers
            // 
            this.btnCostumers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCostumers.Image = ((System.Drawing.Image)(resources.GetObject("btnCostumers.Image")));
            this.btnCostumers.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnCostumers.ImageHover")));
            this.btnCostumers.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnCostumers.ImageNormal")));
            this.btnCostumers.Location = new System.Drawing.Point(370, 12);
            this.btnCostumers.Name = "btnCostumers";
            this.btnCostumers.Size = new System.Drawing.Size(35, 35);
            this.btnCostumers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCostumers.TabIndex = 11;
            this.btnCostumers.TabStop = false;
            this.btnCostumers.Click += new System.EventHandler(this.btnCostumers_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.pnlMainForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCostumers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMainForm;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAtiel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CostumerButton btnCostumers;
        private System.Windows.Forms.Label label2;
    }
}