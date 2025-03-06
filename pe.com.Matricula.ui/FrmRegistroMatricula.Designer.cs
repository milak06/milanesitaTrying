using pe.com.Matricula.bo;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace pe.com.Matricula.ui
{
    partial class FrmRegistroMatricula
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
            this.txtfechanacimiento_alu = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdireccion_alu = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtdocumentoidentidad_alu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDistrito_alu = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtTelf_est = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtCorreo_est = new System.Windows.Forms.TextBox();
            this.txtidalumno = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbosexo_alu = new System.Windows.Forms.ComboBox();
            this.txtapellidos_alu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombres_alu = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.txtNivelAca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboRepitente = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProcedencia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbosituacion = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCorreo_Apo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelf_Apo = new System.Windows.Forms.TextBox();
            this.txtnombres_apo = new System.Windows.Forms.TextBox();
            this.txtdocumentoidentidad_apo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtapellidos_apo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtfechanacimiento_apo = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.txtdireccion_apo = new System.Windows.Forms.TextBox();
            this.txtcodigomatricula = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtfechanacimiento_alu
            // 
            this.txtfechanacimiento_alu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtfechanacimiento_alu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechanacimiento_alu.Location = new System.Drawing.Point(9, 76);
            this.txtfechanacimiento_alu.Name = "txtfechanacimiento_alu";
            this.txtfechanacimiento_alu.Size = new System.Drawing.Size(129, 20);
            this.txtfechanacimiento_alu.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fecha Nacimiento:";
            // 
            // txtdireccion_alu
            // 
            this.txtdireccion_alu.Location = new System.Drawing.Point(332, 75);
            this.txtdireccion_alu.Name = "txtdireccion_alu";
            this.txtdireccion_alu.Size = new System.Drawing.Size(261, 20);
            this.txtdireccion_alu.TabIndex = 10;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Red;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(725, 504);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(104, 23);
            this.btnsalir.TabIndex = 125;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click_1);
            // 
            // txtdocumentoidentidad_alu
            // 
            this.txtdocumentoidentidad_alu.Location = new System.Drawing.Point(9, 34);
            this.txtdocumentoidentidad_alu.Name = "txtdocumentoidentidad_alu";
            this.txtdocumentoidentidad_alu.Size = new System.Drawing.Size(129, 20);
            this.txtdocumentoidentidad_alu.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(329, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Direccion:";
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.Green;
            this.btnregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.ForeColor = System.Drawing.Color.White;
            this.btnregistrar.Location = new System.Drawing.Point(537, 504);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(160, 23);
            this.btnregistrar.TabIndex = 124;
            this.btnregistrar.Text = "Registrar Matricula";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboDistrito_alu);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtTelf_est);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.txtCorreo_est);
            this.groupBox1.Controls.Add(this.txtidalumno);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtdocumentoidentidad_alu);
            this.groupBox1.Controls.Add(this.cbosexo_alu);
            this.groupBox1.Controls.Add(this.txtapellidos_alu);
            this.groupBox1.Controls.Add(this.txtfechanacimiento_alu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtdireccion_alu);
            this.groupBox1.Controls.Add(this.txtnombres_alu);
            this.groupBox1.Location = new System.Drawing.Point(10, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 144);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Alumno";
            // 
            // cboDistrito_alu
            // 
            this.cboDistrito_alu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDistrito_alu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito_alu.FormattingEnabled = true;
            this.cboDistrito_alu.Location = new System.Drawing.Point(614, 75);
            this.cboDistrito_alu.Name = "cboDistrito_alu";
            this.cboDistrito_alu.Size = new System.Drawing.Size(167, 21);
            this.cboDistrito_alu.TabIndex = 109;
            this.cboDistrito_alu.SelectedIndexChanged += new System.EventHandler(this.cboDistrito_alu_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(614, 60);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 13);
            this.label22.TabIndex = 110;
            this.label22.Text = "Distrito:";
            // 
            // txtTelf_est
            // 
            this.txtTelf_est.Location = new System.Drawing.Point(10, 118);
            this.txtTelf_est.Name = "txtTelf_est";
            this.txtTelf_est.Size = new System.Drawing.Size(150, 20);
            this.txtTelf_est.TabIndex = 105;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(199, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 13);
            this.label18.TabIndex = 108;
            this.label18.Text = "Correo Electronico:";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.LightGray;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.No;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.Location = new System.Drawing.Point(657, 32);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(103, 23);
            this.btnlimpiar.TabIndex = 100;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click_1);
            // 
            // txtCorreo_est
            // 
            this.txtCorreo_est.Location = new System.Drawing.Point(202, 118);
            this.txtCorreo_est.Name = "txtCorreo_est";
            this.txtCorreo_est.Size = new System.Drawing.Size(253, 20);
            this.txtCorreo_est.TabIndex = 107;
            // 
            // txtidalumno
            // 
            this.txtidalumno.Location = new System.Drawing.Point(766, 34);
            this.txtidalumno.Name = "txtidalumno";
            this.txtidalumno.Size = new System.Drawing.Size(25, 20);
            this.txtidalumno.TabIndex = 29;
            this.txtidalumno.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(10, 102);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 106;
            this.label20.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Documento Identidad:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.LightGray;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.No;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(547, 32);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(103, 23);
            this.btnbuscar.TabIndex = 100;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(149, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombres:";
            // 
            // cbosexo_alu
            // 
            this.cbosexo_alu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbosexo_alu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosexo_alu.FormattingEnabled = true;
            this.cbosexo_alu.Location = new System.Drawing.Point(152, 75);
            this.cbosexo_alu.Name = "cbosexo_alu";
            this.cbosexo_alu.Size = new System.Drawing.Size(167, 21);
            this.cbosexo_alu.TabIndex = 8;
            // 
            // txtapellidos_alu
            // 
            this.txtapellidos_alu.Location = new System.Drawing.Point(332, 34);
            this.txtapellidos_alu.Name = "txtapellidos_alu";
            this.txtapellidos_alu.Size = new System.Drawing.Size(199, 20);
            this.txtapellidos_alu.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(152, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(329, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Apellidos:";
            // 
            // txtnombres_alu
            // 
            this.txtnombres_alu.Location = new System.Drawing.Point(152, 34);
            this.txtnombres_alu.Name = "txtnombres_alu";
            this.txtnombres_alu.Size = new System.Drawing.Size(167, 20);
            this.txtnombres_alu.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGrado);
            this.groupBox2.Controls.Add(this.txtNivelAca);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboRepitente);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtProcedencia);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(816, 67);
            this.groupBox2.TabIndex = 126;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Academicos";
            // 
            // txtGrado
            // 
            this.txtGrado.Location = new System.Drawing.Point(562, 33);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.ReadOnly = true;
            this.txtGrado.Size = new System.Drawing.Size(152, 20);
            this.txtGrado.TabIndex = 100;
            // 
            // txtNivelAca
            // 
            this.txtNivelAca.Location = new System.Drawing.Point(387, 33);
            this.txtNivelAca.Name = "txtNivelAca";
            this.txtNivelAca.ReadOnly = true;
            this.txtNivelAca.Size = new System.Drawing.Size(152, 20);
            this.txtNivelAca.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Grado Sección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nivel Academico:";
            // 
            // cboRepitente
            // 
            this.cboRepitente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboRepitente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRepitente.FormattingEnabled = true;
            this.cboRepitente.Location = new System.Drawing.Point(224, 32);
            this.cboRepitente.Name = "cboRepitente";
            this.cboRepitente.Size = new System.Drawing.Size(150, 21);
            this.cboRepitente.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Es Repitente:";
            // 
            // txtProcedencia
            // 
            this.txtProcedencia.Location = new System.Drawing.Point(8, 33);
            this.txtProcedencia.Name = "txtProcedencia";
            this.txtProcedencia.Size = new System.Drawing.Size(202, 20);
            this.txtProcedencia.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Institución procedencia:";
            // 
            // cbosituacion
            // 
            this.cbosituacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbosituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosituacion.FormattingEnabled = true;
            this.cbosituacion.Location = new System.Drawing.Point(110, 93);
            this.cbosituacion.Name = "cbosituacion";
            this.cbosituacion.Size = new System.Drawing.Size(149, 21);
            this.cbosituacion.TabIndex = 127;
            this.cbosituacion.SelectedIndexChanged += new System.EventHandler(this.cbosituacion_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 128;
            this.label12.Text = "Situación Alumno:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label13.Location = new System.Drawing.Point(255, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(340, 31);
            this.label13.TabIndex = 129;
            this.label13.Text = "REGISTRO MATRICULA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtCorreo_Apo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtTelf_Apo);
            this.groupBox3.Controls.Add(this.txtnombres_apo);
            this.groupBox3.Controls.Add(this.txtdocumentoidentidad_apo);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtapellidos_apo);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtfechanacimiento_apo);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txtdireccion_apo);
            this.groupBox3.Location = new System.Drawing.Point(10, 381);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(834, 117);
            this.groupBox3.TabIndex = 130;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Apoderado";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(337, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 13);
            this.label16.TabIndex = 104;
            this.label16.Text = "Correo Electronico:";
            // 
            // txtCorreo_Apo
            // 
            this.txtCorreo_Apo.Location = new System.Drawing.Point(340, 81);
            this.txtCorreo_Apo.Name = "txtCorreo_Apo";
            this.txtCorreo_Apo.Size = new System.Drawing.Size(253, 20);
            this.txtCorreo_Apo.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(596, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "Telefono:";
            // 
            // txtTelf_Apo
            // 
            this.txtTelf_Apo.Location = new System.Drawing.Point(599, 81);
            this.txtTelf_Apo.Name = "txtTelf_Apo";
            this.txtTelf_Apo.Size = new System.Drawing.Size(199, 20);
            this.txtTelf_Apo.TabIndex = 101;
            // 
            // txtnombres_apo
            // 
            this.txtnombres_apo.Location = new System.Drawing.Point(202, 37);
            this.txtnombres_apo.Name = "txtnombres_apo";
            this.txtnombres_apo.Size = new System.Drawing.Size(162, 20);
            this.txtnombres_apo.TabIndex = 13;
            // 
            // txtdocumentoidentidad_apo
            // 
            this.txtdocumentoidentidad_apo.Location = new System.Drawing.Point(10, 37);
            this.txtdocumentoidentidad_apo.Name = "txtdocumentoidentidad_apo";
            this.txtdocumentoidentidad_apo.Size = new System.Drawing.Size(150, 20);
            this.txtdocumentoidentidad_apo.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(576, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Fecha Nacimiento:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(7, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Documento Identidad:";
            // 
            // txtapellidos_apo
            // 
            this.txtapellidos_apo.Location = new System.Drawing.Point(389, 37);
            this.txtapellidos_apo.Name = "txtapellidos_apo";
            this.txtapellidos_apo.Size = new System.Drawing.Size(160, 20);
            this.txtapellidos_apo.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(199, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Nombres:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(384, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "Apellidos:";
            // 
            // txtfechanacimiento_apo
            // 
            this.txtfechanacimiento_apo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtfechanacimiento_apo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechanacimiento_apo.Location = new System.Drawing.Point(579, 37);
            this.txtfechanacimiento_apo.Name = "txtfechanacimiento_apo";
            this.txtfechanacimiento_apo.Size = new System.Drawing.Size(143, 20);
            this.txtfechanacimiento_apo.TabIndex = 15;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(7, 65);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "Direccion:";
            // 
            // txtdireccion_apo
            // 
            this.txtdireccion_apo.Location = new System.Drawing.Point(9, 81);
            this.txtdireccion_apo.Name = "txtdireccion_apo";
            this.txtdireccion_apo.Size = new System.Drawing.Size(318, 20);
            this.txtdireccion_apo.TabIndex = 19;
            // 
            // txtcodigomatricula
            // 
            this.txtcodigomatricula.ForeColor = System.Drawing.Color.Red;
            this.txtcodigomatricula.Location = new System.Drawing.Point(704, 93);
            this.txtcodigomatricula.Name = "txtcodigomatricula";
            this.txtcodigomatricula.ReadOnly = true;
            this.txtcodigomatricula.Size = new System.Drawing.Size(125, 20);
            this.txtcodigomatricula.TabIndex = 132;
            this.txtcodigomatricula.Text = "Autogenerado";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(608, 96);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(89, 13);
            this.label23.TabIndex = 131;
            this.label23.Text = "Codigo Matricula:";
            // 
            // FrmRegistroMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(856, 539);
            this.Controls.Add(this.txtcodigomatricula);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbosituacion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistroMatricula";
            this.Text = "FrmRegistroMatricula";
            this.Load += new System.EventHandler(this.FrmRegistroMatricula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cbosituacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Obtener el valor seleccionado del ComboBox
                string situacionSeleccionada = ((ComboBoxItem)cbosituacion.SelectedItem).Value.ToString();

                // Si la situación es "Antiguo"
                if (situacionSeleccionada == "Antiguo")
                {
                    // Habilitar/deshabilitar botones según la situación
                    btnbuscar.BackColor = Color.DodgerBlue;
                    btnlimpiar.BackColor = Color.DodgerBlue;
                    btnbuscar.Cursor = Cursors.Hand;
                    btnlimpiar.Cursor = Cursors.Hand;

                    // Deshabilitar los controles de los datos del apoderado
                    txtProcedencia.Enabled = false;
                    cboRepitente.Enabled = false;
                    txtNivelAca.Enabled = false;
                    txtGrado.Enabled = false;
                    txtdocumentoidentidad_apo.Enabled = false;
                    txtnombres_apo.Enabled = false;
                    txtapellidos_apo.Enabled = false;
                    txtdireccion_apo.Enabled = false;
                    txtTelf_Apo.Enabled = false;
                    txtCorreo_Apo.Enabled = false;
                    txtfechanacimiento_apo.Enabled = false;
                    // Si tienes más campos relacionados a datos académicos, deshabilítalos aquí
                }
                else
                {
                    // Si la situación no es "Antiguo" (por ejemplo, "Nuevo")
                    btnbuscar.BackColor = Color.LightGray;
                    btnlimpiar.BackColor = Color.LightGray;
                    btnbuscar.Cursor = Cursors.No;
                    btnlimpiar.Cursor = Cursors.No;

                    // Habilitar los controles de los datos del apoderado
                    txtdocumentoidentidad_apo.Enabled = true;
                    txtnombres_apo.Enabled = true;
                    txtapellidos_apo.Enabled = true;
                    txtdireccion_apo.Enabled = true;
                    txtTelf_Apo.Enabled = true;
                    txtCorreo_Apo.Enabled = true;
                    txtfechanacimiento_apo.Enabled = true;

                    // Si tienes más campos relacionados a datos académicos, habilítalos aquí
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar la situación: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        #endregion

        private System.Windows.Forms.DateTimePicker txtfechanacimiento_alu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdireccion_alu;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtdocumentoidentidad_alu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox txtidalumno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbosexo_alu;
        private System.Windows.Forms.TextBox txtapellidos_alu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombres_alu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.TextBox txtNivelAca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboRepitente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProcedencia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbosituacion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtapellidos_apo;
        private System.Windows.Forms.TextBox txtnombres_apo;
        private System.Windows.Forms.TextBox txtdocumentoidentidad_apo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker txtfechanacimiento_apo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtdireccion_apo;
        private System.Windows.Forms.TextBox txtcodigomatricula;
        private System.Windows.Forms.Label label23;
        private EventHandler groupBox2_Enter;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCorreo_est;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTelf_est;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCorreo_Apo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelf_Apo;
        private System.Windows.Forms.ComboBox cboDistrito_alu;
        private System.Windows.Forms.Label label22;
    }
}