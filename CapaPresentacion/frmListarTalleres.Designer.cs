namespace CapaPresentacion
{
    partial class frmListarTalleres
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
            this.dgContratista = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgContratista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgContratista
            // 
            this.dgContratista.AllowUserToAddRows = false;
            this.dgContratista.AllowUserToDeleteRows = false;
            this.dgContratista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContratista.Location = new System.Drawing.Point(17, 69);
            this.dgContratista.Name = "dgContratista";
            this.dgContratista.ReadOnly = true;
            this.dgContratista.RowHeadersWidth = 51;
            this.dgContratista.RowTemplate.Height = 24;
            this.dgContratista.Size = new System.Drawing.Size(893, 369);
            this.dgContratista.TabIndex = 110;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 25);
            this.label9.TabIndex = 109;
            this.label9.Text = "LISTA DE TALLERES";
            // 
            // frmListarTalleres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 522);
            this.Controls.Add(this.dgContratista);
            this.Controls.Add(this.label9);
            this.Name = "frmListarTalleres";
            this.Text = "frmListarTalleres";
            ((System.ComponentModel.ISupportInitialize)(this.dgContratista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgContratista;
        private System.Windows.Forms.Label label9;
    }
}