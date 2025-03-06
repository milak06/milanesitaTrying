namespace pe.com.Matricula.ui
{
    partial class FrmCrearMatricula
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
            this.btncontinuar = new System.Windows.Forms.Button();
            this.txtvacantes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cbogrado = new System.Windows.Forms.ComboBox();
            this.cbonivel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btncontinuar
            // 
            this.btncontinuar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btncontinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncontinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncontinuar.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontinuar.ForeColor = System.Drawing.Color.White;
            this.btncontinuar.Location = new System.Drawing.Point(281, 184);
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Size = new System.Drawing.Size(121, 25);
            this.btncontinuar.TabIndex = 27;
            this.btncontinuar.Text = "Continuar";
            this.btncontinuar.UseVisualStyleBackColor = false;
            this.btncontinuar.Click += new System.EventHandler(this.btncontinuar_Click);
            // 
            // txtvacantes
            // 
            this.txtvacantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvacantes.Location = new System.Drawing.Point(148, 136);
            this.txtvacantes.Name = "txtvacantes";
            this.txtvacantes.ReadOnly = true;
            this.txtvacantes.Size = new System.Drawing.Size(94, 21);
            this.txtvacantes.TabIndex = 26;
            this.txtvacantes.TextChanged += new System.EventHandler(this.txtvacantes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Total Vacantes:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscar.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(281, 136);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(121, 23);
            this.btnbuscar.TabIndex = 24;
            this.btnbuscar.Text = "Buscar Vacantes";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(267, 45);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(117, 16);
            this.label22.TabIndex = 20;
            this.label22.Text = "Grado Sección:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(38, 45);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(136, 16);
            this.label21.TabIndex = 18;
            this.label21.Text = "Nivel Academico:";
            // 
            // cbogrado
            // 
            this.cbogrado.AccessibleDescription = "";
            this.cbogrado.BackColor = System.Drawing.Color.LightCyan;
            this.cbogrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbogrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbogrado.FormattingEnabled = true;
            this.cbogrado.Location = new System.Drawing.Point(242, 76);
            this.cbogrado.Name = "cbogrado";
            this.cbogrado.Size = new System.Drawing.Size(160, 23);
            this.cbogrado.TabIndex = 29;
            this.cbogrado.SelectedIndexChanged += new System.EventHandler(this.cbogrado_SelectedIndexChanged);
            // 
            // cbonivel
            // 
            this.cbonivel.BackColor = System.Drawing.Color.LightCyan;
            this.cbonivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbonivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbonivel.FormattingEnabled = true;
            this.cbonivel.Location = new System.Drawing.Point(26, 76);
            this.cbonivel.Name = "cbonivel";
            this.cbonivel.Size = new System.Drawing.Size(162, 23);
            this.cbonivel.TabIndex = 28;
            this.cbonivel.SelectedIndexChanged += new System.EventHandler(this.cbonivel_SelectedIndexChanged);
            // 
            // FrmCrearMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 221);
            this.Controls.Add(this.cbogrado);
            this.Controls.Add(this.cbonivel);
            this.Controls.Add(this.btncontinuar);
            this.Controls.Add(this.txtvacantes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Name = "FrmCrearMatricula";
            this.Text = "FrmCrearMatricula";
            this.Load += new System.EventHandler(this.FrmCrearMatricula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncontinuar;
        private System.Windows.Forms.TextBox txtvacantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbogrado;
        private System.Windows.Forms.ComboBox cbonivel;
    }
}