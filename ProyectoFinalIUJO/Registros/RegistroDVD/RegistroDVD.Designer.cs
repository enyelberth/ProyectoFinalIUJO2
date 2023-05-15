/*
 * Creado por SharpDevelop.
 * Usuario: Enyelbrth
 * Fecha: 13/05/2023
 * Hora: 07:20 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoFinalIUJO.Registros.RegistroDVD
{
	partial class RegistroDVD
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.dateTimeFechaingreso = new System.Windows.Forms.DateTimePicker();
            this.labelArchivo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonexaminararchivo = new System.Windows.Forms.Button();
            this.textBoxarchivo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonarchivoimagen = new System.Windows.Forms.Button();
            this.textBoximagen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNO = new System.Windows.Forms.RadioButton();
            this.radioButtonSI = new System.Windows.Forms.RadioButton();
            this.comboBoxtipoDVD = new System.Windows.Forms.ComboBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxdescripcion = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxcodigo = new System.Windows.Forms.TextBox();
            this.textBoxAñoemision = new System.Windows.Forms.TextBox();
            this.buttonregistro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeFechaingreso
            // 
            this.dateTimeFechaingreso.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFechaingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFechaingreso.Location = new System.Drawing.Point(59, 354);
            this.dateTimeFechaingreso.Name = "dateTimeFechaingreso";
            this.dateTimeFechaingreso.Size = new System.Drawing.Size(267, 21);
            this.dateTimeFechaingreso.TabIndex = 53;
            // 
            // labelArchivo
            // 
            this.labelArchivo.AutoSize = true;
            this.labelArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArchivo.Location = new System.Drawing.Point(577, 173);
            this.labelArchivo.Name = "labelArchivo";
            this.labelArchivo.Size = new System.Drawing.Size(64, 18);
            this.labelArchivo.TabIndex = 52;
            this.labelArchivo.Text = "Archivo";
            this.labelArchivo.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(488, 459);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 18);
            this.label14.TabIndex = 51;
            this.label14.Text = "Imagen";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(142, 459);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 18);
            this.label13.TabIndex = 50;
            this.label13.Text = "Descripcion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(580, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 18);
            this.label12.TabIndex = 49;
            // 
            // buttonexaminararchivo
            // 
            this.buttonexaminararchivo.Location = new System.Drawing.Point(712, 213);
            this.buttonexaminararchivo.Name = "buttonexaminararchivo";
            this.buttonexaminararchivo.Size = new System.Drawing.Size(75, 23);
            this.buttonexaminararchivo.TabIndex = 48;
            this.buttonexaminararchivo.Text = "Buscar";
            this.buttonexaminararchivo.UseVisualStyleBackColor = true;
            this.buttonexaminararchivo.Visible = false;
            this.buttonexaminararchivo.Click += new System.EventHandler(this.buttonexaminararchivo_Click);
            // 
            // textBoxarchivo
            // 
            this.textBoxarchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxarchivo.Location = new System.Drawing.Point(491, 216);
            this.textBoxarchivo.Name = "textBoxarchivo";
            this.textBoxarchivo.ReadOnly = true;
            this.textBoxarchivo.Size = new System.Drawing.Size(206, 21);
            this.textBoxarchivo.TabIndex = 47;
            this.textBoxarchivo.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(444, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 18);
            this.label11.TabIndex = 42;
            this.label11.Text = "Disponible a prestamo?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(122, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 18);
            this.label7.TabIndex = 46;
            this.label7.Text = "Fecha de Ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 45;
            this.label6.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "Año de Emision";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(589, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Titulo";
            // 
            // buttonarchivoimagen
            // 
            this.buttonarchivoimagen.Location = new System.Drawing.Point(652, 507);
            this.buttonarchivoimagen.Name = "buttonarchivoimagen";
            this.buttonarchivoimagen.Size = new System.Drawing.Size(75, 23);
            this.buttonarchivoimagen.TabIndex = 39;
            this.buttonarchivoimagen.Text = "Buscar";
            this.buttonarchivoimagen.UseVisualStyleBackColor = true;
            this.buttonarchivoimagen.Click += new System.EventHandler(this.buttonarchivo_Click_1);
            // 
            // textBoximagen
            // 
            this.textBoximagen.Location = new System.Drawing.Point(395, 507);
            this.textBoximagen.Name = "textBoximagen";
            this.textBoximagen.ReadOnly = true;
            this.textBoximagen.Size = new System.Drawing.Size(236, 20);
            this.textBoximagen.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNO);
            this.groupBox1.Controls.Add(this.radioButtonSI);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(485, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(94, 67);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonNO
            // 
            this.radioButtonNO.AutoSize = true;
            this.radioButtonNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNO.Location = new System.Drawing.Point(3, 39);
            this.radioButtonNO.Name = "radioButtonNO";
            this.radioButtonNO.Size = new System.Drawing.Size(45, 19);
            this.radioButtonNO.TabIndex = 1;
            this.radioButtonNO.Text = "NO";
            this.radioButtonNO.UseVisualStyleBackColor = true;
            // 
            // radioButtonSI
            // 
            this.radioButtonSI.AutoSize = true;
            this.radioButtonSI.Checked = true;
            this.radioButtonSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSI.Location = new System.Drawing.Point(3, 16);
            this.radioButtonSI.Name = "radioButtonSI";
            this.radioButtonSI.Size = new System.Drawing.Size(38, 19);
            this.radioButtonSI.TabIndex = 0;
            this.radioButtonSI.TabStop = true;
            this.radioButtonSI.Text = "SI";
            this.radioButtonSI.UseVisualStyleBackColor = true;
            // 
            // comboBoxtipoDVD
            // 
            this.comboBoxtipoDVD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxtipoDVD.FormattingEnabled = true;
            this.comboBoxtipoDVD.Items.AddRange(new object[] {
            "Mp3",
            "Pelicula",
            "Videojuego"});
            this.comboBoxtipoDVD.Location = new System.Drawing.Point(570, 107);
            this.comboBoxtipoDVD.Name = "comboBoxtipoDVD";
            this.comboBoxtipoDVD.Size = new System.Drawing.Size(94, 21);
            this.comboBoxtipoDVD.TabIndex = 36;
            this.comboBoxtipoDVD.SelectedIndexChanged += new System.EventHandler(this.comboBoxtipoDVD_SelectedIndexChanged);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(319, 216);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 21);
            this.textBoxCantidad.TabIndex = 35;
            this.textBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidad_KeyPress);
            // 
            // textBoxdescripcion
            // 
            this.textBoxdescripcion.Location = new System.Drawing.Point(51, 489);
            this.textBoxdescripcion.Multiline = true;
            this.textBoxdescripcion.Name = "textBoxdescripcion";
            this.textBoxdescripcion.Size = new System.Drawing.Size(280, 83);
            this.textBoxdescripcion.TabIndex = 34;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitulo.Location = new System.Drawing.Point(51, 108);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(126, 21);
            this.textBoxTitulo.TabIndex = 33;
            this.textBoxTitulo.TextChanged += new System.EventHandler(this.textBoxTitulo_TextChanged);
            // 
            // textBoxcodigo
            // 
            this.textBoxcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcodigo.Location = new System.Drawing.Point(310, 108);
            this.textBoxcodigo.Name = "textBoxcodigo";
            this.textBoxcodigo.ReadOnly = true;
            this.textBoxcodigo.Size = new System.Drawing.Size(121, 21);
            this.textBoxcodigo.TabIndex = 32;
            // 
            // textBoxAñoemision
            // 
            this.textBoxAñoemision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAñoemision.Location = new System.Drawing.Point(51, 216);
            this.textBoxAñoemision.Name = "textBoxAñoemision";
            this.textBoxAñoemision.Size = new System.Drawing.Size(126, 21);
            this.textBoxAñoemision.TabIndex = 31;
            this.textBoxAñoemision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAñoemision_KeyPress);
            // 
            // buttonregistro
            // 
            this.buttonregistro.Location = new System.Drawing.Point(408, 600);
            this.buttonregistro.Name = "buttonregistro";
            this.buttonregistro.Size = new System.Drawing.Size(100, 34);
            this.buttonregistro.TabIndex = 54;
            this.buttonregistro.Text = "Registrar";
            this.buttonregistro.UseVisualStyleBackColor = true;
            this.buttonregistro.Click += new System.EventHandler(this.buttonregistro_Click);
            // 
            // RegistroDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 646);
            this.Controls.Add(this.buttonregistro);
            this.Controls.Add(this.dateTimeFechaingreso);
            this.Controls.Add(this.labelArchivo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonexaminararchivo);
            this.Controls.Add(this.textBoxarchivo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonarchivoimagen);
            this.Controls.Add(this.textBoximagen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxtipoDVD);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxdescripcion);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.textBoxcodigo);
            this.Controls.Add(this.textBoxAñoemision);
            this.Name = "RegistroDVD";
            this.Text = "RegistroDVD";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button buttonregistro;
		private System.Windows.Forms.TextBox textBoxAñoemision;
		private System.Windows.Forms.TextBox textBoxcodigo;
		private System.Windows.Forms.TextBox textBoxTitulo;
		private System.Windows.Forms.TextBox textBoxdescripcion;
		private System.Windows.Forms.TextBox textBoxCantidad;
		private System.Windows.Forms.ComboBox comboBoxtipoDVD;
		private System.Windows.Forms.RadioButton radioButtonSI;
		private System.Windows.Forms.RadioButton radioButtonNO;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBoximagen;
		private System.Windows.Forms.Button buttonarchivoimagen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBoxarchivo;
		private System.Windows.Forms.Button buttonexaminararchivo;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label labelArchivo;
		private System.Windows.Forms.DateTimePicker dateTimeFechaingreso;
	}
}
