namespace CapaPresentacion
{
    partial class frmListarAlumnos
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
            this.label9 = new System.Windows.Forms.Label();
            this.dgContratista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgContratista)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 25);
            this.label9.TabIndex = 107;
            this.label9.Text = "LISTA DE ALUMNOS";
            // 
            // dgContratista
            // 
            this.dgContratista.AllowUserToAddRows = false;
            this.dgContratista.AllowUserToDeleteRows = false;
            this.dgContratista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContratista.Location = new System.Drawing.Point(31, 79);
            this.dgContratista.Name = "dgContratista";
            this.dgContratista.ReadOnly = true;
            this.dgContratista.RowHeadersWidth = 51;
            this.dgContratista.RowTemplate.Height = 24;
            this.dgContratista.Size = new System.Drawing.Size(862, 369);
            this.dgContratista.TabIndex = 108;
            // 
            // frmListarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 492);
            this.Controls.Add(this.dgContratista);
            this.Controls.Add(this.label9);
            this.Name = "frmListarAlumnos";
            this.Text = "frmListarAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.dgContratista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgContratista;
    }
}