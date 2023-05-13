namespace menuavanzado.Registros.RegistroDVDs
{
    partial class DatosDVDs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosDVDs));
            this.buttonatras = new System.Windows.Forms.Button();
            this.buttonadelante = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelposicion1 = new System.Windows.Forms.Label();
            this.de = new System.Windows.Forms.Label();
            this.labelposicion2 = new System.Windows.Forms.Label();
            this.labelfiltro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.elementosProducto6 = new menuavanzado.Registros.RegistroDVDs.Menu_de_Datos_de_DVD.ElementosProducto();
            this.elementosProducto5 = new menuavanzado.Registros.RegistroDVDs.Menu_de_Datos_de_DVD.ElementosProducto();
            this.elementosProducto4 = new menuavanzado.Registros.RegistroDVDs.Menu_de_Datos_de_DVD.ElementosProducto();
            this.elementosProducto3 = new menuavanzado.Registros.RegistroDVDs.Menu_de_Datos_de_DVD.ElementosProducto();
            this.elementosProducto2 = new menuavanzado.Registros.RegistroDVDs.Menu_de_Datos_de_DVD.ElementosProducto();
            this.elementosProducto1 = new menuavanzado.Registros.RegistroDVDs.Menu_de_Datos_de_DVD.ElementosProducto();
            this.SuspendLayout();
            // 
            // buttonatras
            // 
            this.buttonatras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonatras.Location = new System.Drawing.Point(256, 616);
            this.buttonatras.Name = "buttonatras";
            this.buttonatras.Size = new System.Drawing.Size(75, 23);
            this.buttonatras.TabIndex = 4;
            this.buttonatras.Text = "Atras";
            this.buttonatras.UseVisualStyleBackColor = true;
            this.buttonatras.Click += new System.EventHandler(this.buttonatras_Click);
            // 
            // buttonadelante
            // 
            this.buttonadelante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadelante.Location = new System.Drawing.Point(486, 617);
            this.buttonadelante.Name = "buttonadelante";
            this.buttonadelante.Size = new System.Drawing.Size(75, 23);
            this.buttonadelante.TabIndex = 5;
            this.buttonadelante.Text = "adelante";
            this.buttonadelante.UseVisualStyleBackColor = true;
            this.buttonadelante.Click += new System.EventHandler(this.buttonadelante_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sin filtro",
            "Peliculas",
            "Mp3s",
            "Videojuegos"});
            this.comboBox1.Location = new System.Drawing.Point(150, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelposicion1
            // 
            this.labelposicion1.AutoSize = true;
            this.labelposicion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelposicion1.Location = new System.Drawing.Point(357, 617);
            this.labelposicion1.Name = "labelposicion1";
            this.labelposicion1.Size = new System.Drawing.Size(19, 20);
            this.labelposicion1.TabIndex = 20;
            this.labelposicion1.Text = "0";
            // 
            // de
            // 
            this.de.AutoSize = true;
            this.de.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de.Location = new System.Drawing.Point(393, 617);
            this.de.Name = "de";
            this.de.Size = new System.Drawing.Size(32, 20);
            this.de.TabIndex = 21;
            this.de.Text = "De";
            // 
            // labelposicion2
            // 
            this.labelposicion2.AutoSize = true;
            this.labelposicion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelposicion2.Location = new System.Drawing.Point(441, 617);
            this.labelposicion2.Name = "labelposicion2";
            this.labelposicion2.Size = new System.Drawing.Size(19, 20);
            this.labelposicion2.TabIndex = 22;
            this.labelposicion2.Text = "0";
            // 
            // labelfiltro
            // 
            this.labelfiltro.AutoSize = true;
            this.labelfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfiltro.Location = new System.Drawing.Point(56, 40);
            this.labelfiltro.Name = "labelfiltro";
            this.labelfiltro.Size = new System.Drawing.Size(88, 20);
            this.labelfiltro.TabIndex = 23;
            this.labelfiltro.Text = "Filtrar Por";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ordenar Por";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Peliculas",
            "Mp3",
            "Videojuegos",
            "Sin filtro"});
            this.comboBox2.Location = new System.Drawing.Point(393, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 24;
            // 
            // elementosProducto6
            // 
            this.elementosProducto6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elementosProducto6.cantidadproducto = "0";
            this.elementosProducto6.Codigoproducto = "000000";
            this.elementosProducto6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elementosProducto6.Imagenproducto = ((System.Drawing.Image)(resources.GetObject("elementosProducto6.Imagenproducto")));
            this.elementosProducto6.Location = new System.Drawing.Point(581, 345);
            this.elementosProducto6.Name = "elementosProducto6";
            this.elementosProducto6.Nombreproducto = "";
            this.elementosProducto6.Size = new System.Drawing.Size(204, 236);
            this.elementosProducto6.TabIndex = 19;
            // 
            // elementosProducto5
            // 
            this.elementosProducto5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elementosProducto5.cantidadproducto = "0";
            this.elementosProducto5.Codigoproducto = "000000";
            this.elementosProducto5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elementosProducto5.Imagenproducto = ((System.Drawing.Image)(resources.GetObject("elementosProducto5.Imagenproducto")));
            this.elementosProducto5.Location = new System.Drawing.Point(321, 345);
            this.elementosProducto5.Name = "elementosProducto5";
            this.elementosProducto5.Nombreproducto = "";
            this.elementosProducto5.Size = new System.Drawing.Size(204, 236);
            this.elementosProducto5.TabIndex = 18;
            // 
            // elementosProducto4
            // 
            this.elementosProducto4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elementosProducto4.cantidadproducto = "0";
            this.elementosProducto4.Codigoproducto = "000000";
            this.elementosProducto4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elementosProducto4.Imagenproducto = ((System.Drawing.Image)(resources.GetObject("elementosProducto4.Imagenproducto")));
            this.elementosProducto4.Location = new System.Drawing.Point(60, 345);
            this.elementosProducto4.Name = "elementosProducto4";
            this.elementosProducto4.Nombreproducto = "";
            this.elementosProducto4.Size = new System.Drawing.Size(204, 236);
            this.elementosProducto4.TabIndex = 4;
            // 
            // elementosProducto3
            // 
            this.elementosProducto3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elementosProducto3.cantidadproducto = "0";
            this.elementosProducto3.Codigoproducto = "000000";
            this.elementosProducto3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elementosProducto3.Imagenproducto = ((System.Drawing.Image)(resources.GetObject("elementosProducto3.Imagenproducto")));
            this.elementosProducto3.Location = new System.Drawing.Point(581, 85);
            this.elementosProducto3.Name = "elementosProducto3";
            this.elementosProducto3.Nombreproducto = "";
            this.elementosProducto3.Size = new System.Drawing.Size(204, 236);
            this.elementosProducto3.TabIndex = 17;
            // 
            // elementosProducto2
            // 
            this.elementosProducto2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elementosProducto2.cantidadproducto = "0";
            this.elementosProducto2.Codigoproducto = "000000";
            this.elementosProducto2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elementosProducto2.Imagenproducto = ((System.Drawing.Image)(resources.GetObject("elementosProducto2.Imagenproducto")));
            this.elementosProducto2.Location = new System.Drawing.Point(321, 85);
            this.elementosProducto2.Name = "elementosProducto2";
            this.elementosProducto2.Nombreproducto = "";
            this.elementosProducto2.Size = new System.Drawing.Size(204, 236);
            this.elementosProducto2.TabIndex = 4;
            // 
            // elementosProducto1
            // 
            this.elementosProducto1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elementosProducto1.cantidadproducto = "0";
            this.elementosProducto1.Codigoproducto = "000000";
            this.elementosProducto1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elementosProducto1.Imagenproducto = ((System.Drawing.Image)(resources.GetObject("elementosProducto1.Imagenproducto")));
            this.elementosProducto1.Location = new System.Drawing.Point(60, 85);
            this.elementosProducto1.Name = "elementosProducto1";
            this.elementosProducto1.Nombreproducto = "";
            this.elementosProducto1.Size = new System.Drawing.Size(204, 236);
            this.elementosProducto1.TabIndex = 16;
            // 
            // DatosDVDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 667);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelfiltro);
            this.Controls.Add(this.labelposicion2);
            this.Controls.Add(this.de);
            this.Controls.Add(this.labelposicion1);
            this.Controls.Add(this.elementosProducto6);
            this.Controls.Add(this.elementosProducto5);
            this.Controls.Add(this.elementosProducto4);
            this.Controls.Add(this.elementosProducto3);
            this.Controls.Add(this.elementosProducto2);
            this.Controls.Add(this.elementosProducto1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonatras);
            this.Controls.Add(this.buttonadelante);
            this.Name = "DatosDVDs";
            this.Text = "DatosDVDs";
            this.Load += new System.EventHandler(this.DatosDVDs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonatras;
        private System.Windows.Forms.Button buttonadelante;
        private System.Windows.Forms.ComboBox comboBox1;
        private Menu_de_Datos_de_DVD.ElementosProducto elementosProducto1;
        private Menu_de_Datos_de_DVD.ElementosProducto elementosProducto2;
        private Menu_de_Datos_de_DVD.ElementosProducto elementosProducto3;
        private Menu_de_Datos_de_DVD.ElementosProducto elementosProducto4;
        private Menu_de_Datos_de_DVD.ElementosProducto elementosProducto5;
        private Menu_de_Datos_de_DVD.ElementosProducto elementosProducto6;
        private System.Windows.Forms.Label labelposicion1;
        private System.Windows.Forms.Label de;
        private System.Windows.Forms.Label labelposicion2;
        private System.Windows.Forms.Label labelfiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}