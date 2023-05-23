namespace ProyectoFinalIUJO.Registros.RegistroPrestamo
{
    partial class PantallaPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrestamo));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeFechaingreso = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewclientes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewproductos = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxapellido = new System.Windows.Forms.TextBox();
            this.textBoxcodigo = new System.Windows.Forms.TextBox();
            this.textBoxnombreDVD = new System.Windows.Forms.TextBox();
            this.textBoxcantidad = new System.Windows.Forms.TextBox();
            this.textBoxTipodvd = new System.Windows.Forms.TextBox();
            this.buttonmenos = new System.Windows.Forms.Button();
            this.buttonmas = new System.Windows.Forms.Button();
            this.textBoxcantidadtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonregistrar = new System.Windows.Forms.Button();
            this.labelfechahoy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registros de Prestamos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 669);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 21);
            this.dateTimePicker1.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 669);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Fecha Devolucion";
            // 
            // dateTimeFechaingreso
            // 
            this.dateTimeFechaingreso.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFechaingreso.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimeFechaingreso.Enabled = false;
            this.dateTimeFechaingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFechaingreso.Location = new System.Drawing.Point(527, 21);
            this.dateTimeFechaingreso.Name = "dateTimeFechaingreso";
            this.dateTimeFechaingreso.Size = new System.Drawing.Size(267, 21);
            this.dateTimeFechaingreso.TabIndex = 54;
            this.dateTimeFechaingreso.Visible = false;
            // 
            // dataGridViewclientes
            // 
            this.dataGridViewclientes.AllowUserToAddRows = false;
            this.dataGridViewclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Codigo});
            this.dataGridViewclientes.Location = new System.Drawing.Point(90, 97);
            this.dataGridViewclientes.Name = "dataGridViewclientes";
            this.dataGridViewclientes.ReadOnly = true;
            this.dataGridViewclientes.Size = new System.Drawing.Size(346, 414);
            this.dataGridViewclientes.TabIndex = 58;
            this.dataGridViewclientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewclientes_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Cedula";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // dataGridViewproductos
            // 
            this.dataGridViewproductos.AllowUserToAddRows = false;
            this.dataGridViewproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.NombreDVD,
            this.Cantidad});
            this.dataGridViewproductos.Location = new System.Drawing.Point(537, 97);
            this.dataGridViewproductos.Name = "dataGridViewproductos";
            this.dataGridViewproductos.ReadOnly = true;
            this.dataGridViewproductos.Size = new System.Drawing.Size(359, 414);
            this.dataGridViewproductos.TabIndex = 59;
            this.dataGridViewproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewproductos_CellClick);
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // NombreDVD
            // 
            this.NombreDVD.HeaderText = "NombreDVD";
            this.NombreDVD.Name = "NombreDVD";
            this.NombreDVD.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnombre.Location = new System.Drawing.Point(70, 552);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.ReadOnly = true;
            this.textBoxnombre.Size = new System.Drawing.Size(168, 21);
            this.textBoxnombre.TabIndex = 60;
            // 
            // textBoxapellido
            // 
            this.textBoxapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxapellido.Location = new System.Drawing.Point(271, 552);
            this.textBoxapellido.Name = "textBoxapellido";
            this.textBoxapellido.ReadOnly = true;
            this.textBoxapellido.Size = new System.Drawing.Size(168, 21);
            this.textBoxapellido.TabIndex = 61;
            // 
            // textBoxcodigo
            // 
            this.textBoxcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcodigo.Location = new System.Drawing.Point(172, 599);
            this.textBoxcodigo.Name = "textBoxcodigo";
            this.textBoxcodigo.ReadOnly = true;
            this.textBoxcodigo.Size = new System.Drawing.Size(168, 21);
            this.textBoxcodigo.TabIndex = 62;
            // 
            // textBoxnombreDVD
            // 
            this.textBoxnombreDVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnombreDVD.Location = new System.Drawing.Point(728, 550);
            this.textBoxnombreDVD.Name = "textBoxnombreDVD";
            this.textBoxnombreDVD.ReadOnly = true;
            this.textBoxnombreDVD.Size = new System.Drawing.Size(168, 21);
            this.textBoxnombreDVD.TabIndex = 63;
            // 
            // textBoxcantidad
            // 
            this.textBoxcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcantidad.Location = new System.Drawing.Point(644, 596);
            this.textBoxcantidad.Name = "textBoxcantidad";
            this.textBoxcantidad.ReadOnly = true;
            this.textBoxcantidad.Size = new System.Drawing.Size(35, 21);
            this.textBoxcantidad.TabIndex = 64;
            this.textBoxcantidad.Text = "1";
            // 
            // textBoxTipodvd
            // 
            this.textBoxTipodvd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTipodvd.Location = new System.Drawing.Point(528, 550);
            this.textBoxTipodvd.Name = "textBoxTipodvd";
            this.textBoxTipodvd.ReadOnly = true;
            this.textBoxTipodvd.Size = new System.Drawing.Size(168, 21);
            this.textBoxTipodvd.TabIndex = 65;
            // 
            // buttonmenos
            // 
            this.buttonmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmenos.Location = new System.Drawing.Point(610, 596);
            this.buttonmenos.Name = "buttonmenos";
            this.buttonmenos.Size = new System.Drawing.Size(25, 22);
            this.buttonmenos.TabIndex = 68;
            this.buttonmenos.Text = "-";
            this.buttonmenos.UseVisualStyleBackColor = true;
            this.buttonmenos.Click += new System.EventHandler(this.buttonmenos_Click);
            // 
            // buttonmas
            // 
            this.buttonmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmas.Location = new System.Drawing.Point(690, 596);
            this.buttonmas.Name = "buttonmas";
            this.buttonmas.Size = new System.Drawing.Size(26, 22);
            this.buttonmas.TabIndex = 69;
            this.buttonmas.Text = "+";
            this.buttonmas.UseVisualStyleBackColor = true;
            this.buttonmas.Click += new System.EventHandler(this.buttonmas_Click);
            // 
            // textBoxcantidadtotal
            // 
            this.textBoxcantidadtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcantidadtotal.Location = new System.Drawing.Point(759, 597);
            this.textBoxcantidadtotal.Name = "textBoxcantidadtotal";
            this.textBoxcantidadtotal.ReadOnly = true;
            this.textBoxcantidadtotal.Size = new System.Drawing.Size(35, 21);
            this.textBoxcantidadtotal.TabIndex = 70;
            this.textBoxcantidadtotal.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(732, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 24);
            this.label2.TabIndex = 71;
            this.label2.Text = "/";
            // 
            // buttonregistrar
            // 
            this.buttonregistrar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonregistrar.Location = new System.Drawing.Point(903, 674);
            this.buttonregistrar.Name = "buttonregistrar";
            this.buttonregistrar.Size = new System.Drawing.Size(100, 40);
            this.buttonregistrar.TabIndex = 72;
            this.buttonregistrar.Text = "Registrar";
            this.buttonregistrar.UseVisualStyleBackColor = true;
            this.buttonregistrar.Click += new System.EventHandler(this.buttonregistrar_Click);
            // 
            // labelfechahoy
            // 
            this.labelfechahoy.AutoSize = true;
            this.labelfechahoy.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfechahoy.ForeColor = System.Drawing.Color.White;
            this.labelfechahoy.Location = new System.Drawing.Point(933, 17);
            this.labelfechahoy.Name = "labelfechahoy";
            this.labelfechahoy.Size = new System.Drawing.Size(69, 25);
            this.labelfechahoy.TabIndex = 73;
            this.labelfechahoy.Text = "fecha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // PantallaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(1026, 742);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelfechahoy);
            this.Controls.Add(this.buttonregistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxcantidadtotal);
            this.Controls.Add(this.buttonmas);
            this.Controls.Add(this.buttonmenos);
            this.Controls.Add(this.textBoxTipodvd);
            this.Controls.Add(this.textBoxcantidad);
            this.Controls.Add(this.textBoxnombreDVD);
            this.Controls.Add(this.textBoxcodigo);
            this.Controls.Add(this.textBoxapellido);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.dataGridViewproductos);
            this.Controls.Add(this.dataGridViewclientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimeFechaingreso);
            this.Controls.Add(this.label1);
            this.Name = "PantallaPrestamo";
            this.Text = "PantallaPrestamo";
            this.Load += new System.EventHandler(this.PantallaPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeFechaingreso;
        private System.Windows.Forms.DataGridView dataGridViewclientes;
        private System.Windows.Forms.DataGridView dataGridViewproductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textBoxapellido;
        private System.Windows.Forms.TextBox textBoxcodigo;
        private System.Windows.Forms.TextBox textBoxnombreDVD;
        private System.Windows.Forms.TextBox textBoxcantidad;
        private System.Windows.Forms.TextBox textBoxTipodvd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.Button buttonmenos;
        private System.Windows.Forms.Button buttonmas;
        private System.Windows.Forms.TextBox textBoxcantidadtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonregistrar;
        private System.Windows.Forms.Label labelfechahoy;
    }
}