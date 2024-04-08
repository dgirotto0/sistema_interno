namespace InventoryManagementSystem
{
    partial class CostumerButton
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CostumerButton
            // 
            this.Name = "CostumerButton";
            this.MouseLeave += new System.EventHandler(this.CostumerButton_MouseLeave);
            this.MouseHover += new System.EventHandler(this.CostumerButton_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
