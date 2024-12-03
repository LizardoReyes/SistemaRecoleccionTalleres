namespace CapaPresentacion
{
    partial class frmRegistrarCuota
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdAlumno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuotaMensual = new System.Windows.Forms.Label();
            this.cboNivelEducativo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(26, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 103;
            this.label4.Text = "Código del alumno:";
            // 
            // txtIdAlumno
            // 
            this.txtIdAlumno.Location = new System.Drawing.Point(29, 118);
            this.txtIdAlumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdAlumno.MaxLength = 20;
            this.txtIdAlumno.Name = "txtIdAlumno";
            this.txtIdAlumno.Size = new System.Drawing.Size(175, 22);
            this.txtIdAlumno.TabIndex = 104;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 25);
            this.label9.TabIndex = 105;
            this.label9.Text = "Registrar Cuota";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(29, 390);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(175, 38);
            this.btnRegistrar.TabIndex = 110;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(26, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 111;
            this.label2.Text = "Precio Cuota:";
            // 
            // txtCuotaMensual
            // 
            this.txtCuotaMensual.AutoSize = true;
            this.txtCuotaMensual.BackColor = System.Drawing.SystemColors.Control;
            this.txtCuotaMensual.Location = new System.Drawing.Point(119, 172);
            this.txtCuotaMensual.Name = "txtCuotaMensual";
            this.txtCuotaMensual.Size = new System.Drawing.Size(42, 16);
            this.txtCuotaMensual.TabIndex = 112;
            this.txtCuotaMensual.Text = "S/ --.--";
            // 
            // cboNivelEducativo
            // 
            this.cboNivelEducativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNivelEducativo.FormattingEnabled = true;
            this.cboNivelEducativo.Location = new System.Drawing.Point(29, 255);
            this.cboNivelEducativo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNivelEducativo.Name = "cboNivelEducativo";
            this.cboNivelEducativo.Size = new System.Drawing.Size(175, 24);
            this.cboNivelEducativo.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(26, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 114;
            this.label1.Text = "Selecciona taller:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(26, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 116;
            this.label3.Text = "Numero de cuotas:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 333);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 117;
            // 
            // frmRegistrarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboNivelEducativo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCuotaMensual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdAlumno);
            this.Name = "frmRegistrarCuota";
            this.Text = "frmRegistrarCuota";
            this.Load += new System.EventHandler(this.frmRegistrarCuota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdAlumno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtCuotaMensual;
        private System.Windows.Forms.ComboBox cboNivelEducativo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}