namespace CapaPresentacion
{
    partial class frmListarCuotas
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
            this.label9 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadTalleres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoCuotasPagadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTalleresPagados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotalPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 25);
            this.label9.TabIndex = 107;
            this.label9.Text = "LISTAR CUOTAS";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.AllowUserToDeleteRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.Codigo,
            this.Nivel,
            this.CantidadCuotas,
            this.CantidadTalleres,
            this.MontoCuotasPagadas,
            this.MontoTalleresPagados,
            this.MontoTotalPagado});
            this.dgvdata.Location = new System.Drawing.Point(26, 72);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.Height = 35;
            this.dgvdata.Size = new System.Drawing.Size(913, 474);
            this.dgvdata.TabIndex = 108;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 8;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Visible = false;
            this.btnSeleccionar.Width = 50;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo del alumno";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Nivel
            // 
            this.Nivel.HeaderText = "Nivel Educativo";
            this.Nivel.MinimumWidth = 6;
            this.Nivel.Name = "Nivel";
            this.Nivel.ReadOnly = true;
            this.Nivel.Width = 125;
            // 
            // CantidadCuotas
            // 
            this.CantidadCuotas.HeaderText = "Cantidad cuotas pagadas";
            this.CantidadCuotas.MinimumWidth = 6;
            this.CantidadCuotas.Name = "CantidadCuotas";
            this.CantidadCuotas.ReadOnly = true;
            this.CantidadCuotas.Width = 125;
            // 
            // CantidadTalleres
            // 
            this.CantidadTalleres.HeaderText = "Cantidad Talleres inscritos al año";
            this.CantidadTalleres.MinimumWidth = 6;
            this.CantidadTalleres.Name = "CantidadTalleres";
            this.CantidadTalleres.ReadOnly = true;
            this.CantidadTalleres.Width = 125;
            // 
            // MontoCuotasPagadas
            // 
            this.MontoCuotasPagadas.HeaderText = "Monto de cuotas pagadas";
            this.MontoCuotasPagadas.MinimumWidth = 6;
            this.MontoCuotasPagadas.Name = "MontoCuotasPagadas";
            this.MontoCuotasPagadas.ReadOnly = true;
            this.MontoCuotasPagadas.Width = 125;
            // 
            // MontoTalleresPagados
            // 
            this.MontoTalleresPagados.HeaderText = "Monto de talleres pagados";
            this.MontoTalleresPagados.MinimumWidth = 6;
            this.MontoTalleresPagados.Name = "MontoTalleresPagados";
            this.MontoTalleresPagados.ReadOnly = true;
            this.MontoTalleresPagados.Width = 125;
            // 
            // MontoTotalPagado
            // 
            this.MontoTotalPagado.HeaderText = "Monto Total Pagado";
            this.MontoTotalPagado.MinimumWidth = 6;
            this.MontoTotalPagado.Name = "MontoTotalPagado";
            this.MontoTotalPagado.ReadOnly = true;
            this.MontoTotalPagado.Width = 125;
            // 
            // frmListarCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 572);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.label9);
            this.Name = "frmListarCuotas";
            this.Text = "frmListarCuoutas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadTalleres;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoCuotasPagadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTalleresPagados;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotalPagado;
    }
}