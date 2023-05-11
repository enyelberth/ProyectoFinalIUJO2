namespace menuavanzado.Registros.RegistroDVDs
{
    partial class RegistroDVD
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
            this.textBoxprestamo = new System.Windows.Forms.TextBox();
            this.textBoxAñoemision = new System.Windows.Forms.TextBox();
            this.textBoxDiaingreso = new System.Windows.Forms.TextBox();
            this.textBoxcodigo = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxdescripcion = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.comboBoxtipoDVD = new System.Windows.Forms.ComboBox();
            this.textBoxmesingreso = new System.Windows.Forms.TextBox();
            this.textBoxañoingreso = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonregistro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNO = new System.Windows.Forms.RadioButton();
            this.radioButtonSI = new System.Windows.Forms.RadioButton();
            this.textBoximagen = new System.Windows.Forms.TextBox();
            this.buttonarchivo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxprestamo
            // 
            this.textBoxprestamo.Location = new System.Drawing.Point(324, 141);
            this.textBoxprestamo.Name = "textBoxprestamo";
            this.textBoxprestamo.Size = new System.Drawing.Size(100, 20);
            this.textBoxprestamo.TabIndex = 0;
            // 
            // textBoxAñoemision
            // 
            this.textBoxAñoemision.Location = new System.Drawing.Point(108, 141);
            this.textBoxAñoemision.Name = "textBoxAñoemision";
            this.textBoxAñoemision.Size = new System.Drawing.Size(100, 20);
            this.textBoxAñoemision.TabIndex = 1;
            this.textBoxAñoemision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAñoemision_KeyPress);
            // 
            // textBoxDiaingreso
            // 
            this.textBoxDiaingreso.Location = new System.Drawing.Point(109, 213);
            this.textBoxDiaingreso.Name = "textBoxDiaingreso";
            this.textBoxDiaingreso.Size = new System.Drawing.Size(49, 20);
            this.textBoxDiaingreso.TabIndex = 2;
            this.textBoxDiaingreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDiaingreso_KeyPress);
            // 
            // textBoxcodigo
            // 
            this.textBoxcodigo.Location = new System.Drawing.Point(324, 84);
            this.textBoxcodigo.Name = "textBoxcodigo";
            this.textBoxcodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxcodigo.TabIndex = 3;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(108, 84);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitulo.TabIndex = 4;
            // 
            // textBoxdescripcion
            // 
            this.textBoxdescripcion.Location = new System.Drawing.Point(108, 291);
            this.textBoxdescripcion.Name = "textBoxdescripcion";
            this.textBoxdescripcion.Size = new System.Drawing.Size(280, 20);
            this.textBoxdescripcion.TabIndex = 5;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(534, 152);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantidad.TabIndex = 6;
            this.textBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidad_KeyPress);
            // 
            // comboBoxtipoDVD
            // 
            this.comboBoxtipoDVD.FormattingEnabled = true;
            this.comboBoxtipoDVD.Items.AddRange(new object[] {
            "Mp3",
            "Pelicula",
            "Videojuego"});
            this.comboBoxtipoDVD.Location = new System.Drawing.Point(534, 83);
            this.comboBoxtipoDVD.Name = "comboBoxtipoDVD";
            this.comboBoxtipoDVD.Size = new System.Drawing.Size(94, 21);
            this.comboBoxtipoDVD.TabIndex = 7;
            this.comboBoxtipoDVD.Text = "Mp3";
            // 
            // textBoxmesingreso
            // 
            this.textBoxmesingreso.Location = new System.Drawing.Point(180, 213);
            this.textBoxmesingreso.Name = "textBoxmesingreso";
            this.textBoxmesingreso.Size = new System.Drawing.Size(49, 20);
            this.textBoxmesingreso.TabIndex = 8;
            this.textBoxmesingreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxmesingreso_KeyPress);
            // 
            // textBoxañoingreso
            // 
            this.textBoxañoingreso.Location = new System.Drawing.Point(253, 213);
            this.textBoxañoingreso.Name = "textBoxañoingreso";
            this.textBoxañoingreso.Size = new System.Drawing.Size(49, 20);
            this.textBoxañoingreso.TabIndex = 9;
            this.textBoxañoingreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxañoingreso_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonregistro
            // 
            this.buttonregistro.Location = new System.Drawing.Point(315, 376);
            this.buttonregistro.Name = "buttonregistro";
            this.buttonregistro.Size = new System.Drawing.Size(75, 23);
            this.buttonregistro.TabIndex = 10;
            this.buttonregistro.Text = "Registrar";
            this.buttonregistro.UseVisualStyleBackColor = true;
            this.buttonregistro.Click += new System.EventHandler(this.buttonregistro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNO);
            this.groupBox1.Controls.Add(this.radioButtonSI);
            this.groupBox1.Location = new System.Drawing.Point(343, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(71, 67);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButtonNO
            // 
            this.radioButtonNO.AutoSize = true;
            this.radioButtonNO.Location = new System.Drawing.Point(3, 39);
            this.radioButtonNO.Name = "radioButtonNO";
            this.radioButtonNO.Size = new System.Drawing.Size(41, 17);
            this.radioButtonNO.TabIndex = 1;
            this.radioButtonNO.Text = "NO";
            this.radioButtonNO.UseVisualStyleBackColor = true;
            // 
            // radioButtonSI
            // 
            this.radioButtonSI.AutoSize = true;
            this.radioButtonSI.Checked = true;
            this.radioButtonSI.Location = new System.Drawing.Point(3, 16);
            this.radioButtonSI.Name = "radioButtonSI";
            this.radioButtonSI.Size = new System.Drawing.Size(35, 17);
            this.radioButtonSI.TabIndex = 0;
            this.radioButtonSI.TabStop = true;
            this.radioButtonSI.Text = "SI";
            this.radioButtonSI.UseVisualStyleBackColor = true;
            // 
            // textBoximagen
            // 
            this.textBoximagen.Location = new System.Drawing.Point(444, 291);
            this.textBoximagen.Name = "textBoximagen";
            this.textBoximagen.Size = new System.Drawing.Size(167, 20);
            this.textBoximagen.TabIndex = 12;
            // 
            // buttonarchivo
            // 
            this.buttonarchivo.Location = new System.Drawing.Point(487, 249);
            this.buttonarchivo.Name = "buttonarchivo";
            this.buttonarchivo.Size = new System.Drawing.Size(75, 23);
            this.buttonarchivo.TabIndex = 13;
            this.buttonarchivo.Text = "Registrar";
            this.buttonarchivo.UseVisualStyleBackColor = true;
            this.buttonarchivo.Click += new System.EventHandler(this.buttonarchivo_Click_1);
            // 
            // RegistroDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonarchivo);
            this.Controls.Add(this.textBoximagen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonregistro);
            this.Controls.Add(this.textBoxañoingreso);
            this.Controls.Add(this.textBoxmesingreso);
            this.Controls.Add(this.comboBoxtipoDVD);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxdescripcion);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.textBoxcodigo);
            this.Controls.Add(this.textBoxDiaingreso);
            this.Controls.Add(this.textBoxAñoemision);
            this.Controls.Add(this.textBoxprestamo);
            this.Name = "RegistroDVD";
            this.Text = "RegistroDVD";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxprestamo;
        private System.Windows.Forms.TextBox textBoxAñoemision;
        private System.Windows.Forms.TextBox textBoxDiaingreso;
        private System.Windows.Forms.TextBox textBoxcodigo;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxdescripcion;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.ComboBox comboBoxtipoDVD;
        private System.Windows.Forms.TextBox textBoxmesingreso;
        private System.Windows.Forms.TextBox textBoxañoingreso;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonregistro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNO;
        private System.Windows.Forms.RadioButton radioButtonSI;
        private System.Windows.Forms.TextBox textBoximagen;
        private System.Windows.Forms.Button buttonarchivo;
    }
}