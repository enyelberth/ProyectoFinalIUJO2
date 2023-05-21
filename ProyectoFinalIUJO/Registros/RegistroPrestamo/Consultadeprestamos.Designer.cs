namespace ProyectoFinalIUJO.Registros.RegistroPrestamo
{
    partial class Consultadeprestamos
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
            this.dataGridViewprestamos = new System.Windows.Forms.DataGridView();
            this.textboxnombrecliente = new System.Windows.Forms.TextBox();
            this.textBoxapellidocliente = new System.Windows.Forms.TextBox();
            this.textBoxcedulacliente = new System.Windows.Forms.TextBox();
            this.textBoxcantidad = new System.Windows.Forms.TextBox();
            this.textBoxtipoDVD = new System.Windows.Forms.TextBox();
            this.textBoxproducto = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonmodificar = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.textBoxcodigo = new System.Windows.Forms.TextBox();
            this.CodigoPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadePrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadeDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipodeDVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewprestamos
            // 
            this.dataGridViewprestamos.AllowUserToAddRows = false;
            this.dataGridViewprestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewprestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoPrestamo,
            this.FechadePrestamo,
            this.FechadeDevolucion,
            this.Nombre,
            this.Apellido,
            this.Cedula,
            this.Cantidad,
            this.TipodeDVD,
            this.Producto,
            this.Monto});
            this.dataGridViewprestamos.Location = new System.Drawing.Point(25, 90);
            this.dataGridViewprestamos.Name = "dataGridViewprestamos";
            this.dataGridViewprestamos.ReadOnly = true;
            this.dataGridViewprestamos.Size = new System.Drawing.Size(991, 303);
            this.dataGridViewprestamos.TabIndex = 0;
            this.dataGridViewprestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewprestamos_CellClick);
            // 
            // textboxnombrecliente
            // 
            this.textboxnombrecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxnombrecliente.Location = new System.Drawing.Point(561, 553);
            this.textboxnombrecliente.Name = "textboxnombrecliente";
            this.textboxnombrecliente.Size = new System.Drawing.Size(145, 20);
            this.textboxnombrecliente.TabIndex = 1;
            // 
            // textBoxapellidocliente
            // 
            this.textBoxapellidocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxapellidocliente.Location = new System.Drawing.Point(561, 609);
            this.textBoxapellidocliente.Name = "textBoxapellidocliente";
            this.textBoxapellidocliente.Size = new System.Drawing.Size(145, 20);
            this.textBoxapellidocliente.TabIndex = 2;
            // 
            // textBoxcedulacliente
            // 
            this.textBoxcedulacliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcedulacliente.Location = new System.Drawing.Point(561, 663);
            this.textBoxcedulacliente.Name = "textBoxcedulacliente";
            this.textBoxcedulacliente.Size = new System.Drawing.Size(145, 20);
            this.textBoxcedulacliente.TabIndex = 3;
            // 
            // textBoxcantidad
            // 
            this.textBoxcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcantidad.Location = new System.Drawing.Point(791, 523);
            this.textBoxcantidad.Name = "textBoxcantidad";
            this.textBoxcantidad.Size = new System.Drawing.Size(145, 20);
            this.textBoxcantidad.TabIndex = 4;
            // 
            // textBoxtipoDVD
            // 
            this.textBoxtipoDVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtipoDVD.Location = new System.Drawing.Point(791, 579);
            this.textBoxtipoDVD.Name = "textBoxtipoDVD";
            this.textBoxtipoDVD.Size = new System.Drawing.Size(145, 20);
            this.textBoxtipoDVD.TabIndex = 5;
            // 
            // textBoxproducto
            // 
            this.textBoxproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproducto.Location = new System.Drawing.Point(791, 635);
            this.textBoxproducto.Name = "textBoxproducto";
            this.textBoxproducto.Size = new System.Drawing.Size(145, 20);
            this.textBoxproducto.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(231, 544);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 21);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(231, 632);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(236, 21);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha prestamo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 635);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha devolucion";
            // 
            // buttonmodificar
            // 
            this.buttonmodificar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonmodificar.Location = new System.Drawing.Point(25, 417);
            this.buttonmodificar.Name = "buttonmodificar";
            this.buttonmodificar.Size = new System.Drawing.Size(97, 36);
            this.buttonmodificar.TabIndex = 13;
            this.buttonmodificar.Text = "Modificar";
            this.buttonmodificar.UseVisualStyleBackColor = false;
            this.buttonmodificar.Visible = false;
            this.buttonmodificar.Click += new System.EventHandler(this.buttonmodificar_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.BackColor = System.Drawing.SystemColors.Control;
            this.buttoneliminar.Location = new System.Drawing.Point(169, 417);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(97, 36);
            this.buttoneliminar.TabIndex = 14;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = false;
            this.buttoneliminar.Visible = false;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // textBoxcodigo
            // 
            this.textBoxcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcodigo.Location = new System.Drawing.Point(561, 497);
            this.textBoxcodigo.Name = "textBoxcodigo";
            this.textBoxcodigo.ReadOnly = true;
            this.textBoxcodigo.Size = new System.Drawing.Size(145, 20);
            this.textBoxcodigo.TabIndex = 12;
            // 
            // CodigoPrestamo
            // 
            this.CodigoPrestamo.HeaderText = "CodigoPrestamo";
            this.CodigoPrestamo.Name = "CodigoPrestamo";
            this.CodigoPrestamo.ReadOnly = true;
            // 
            // FechadePrestamo
            // 
            this.FechadePrestamo.HeaderText = "FechadePrestamo";
            this.FechadePrestamo.Name = "FechadePrestamo";
            this.FechadePrestamo.ReadOnly = true;
            // 
            // FechadeDevolucion
            // 
            this.FechadeDevolucion.HeaderText = "FechadeDevolucion";
            this.FechadeDevolucion.Name = "FechadeDevolucion";
            this.FechadeDevolucion.ReadOnly = true;
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
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // TipodeDVD
            // 
            this.TipodeDVD.HeaderText = "TipodeDVD";
            this.TipodeDVD.Name = "TipodeDVD";
            this.TipodeDVD.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Monto
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Monto.DefaultCellStyle = dataGridViewCellStyle1;
            this.Monto.HeaderText = "Monto en $";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Consultadeprestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 741);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonmodificar);
            this.Controls.Add(this.textBoxcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxproducto);
            this.Controls.Add(this.textBoxtipoDVD);
            this.Controls.Add(this.textBoxcantidad);
            this.Controls.Add(this.textBoxcedulacliente);
            this.Controls.Add(this.textBoxapellidocliente);
            this.Controls.Add(this.textboxnombrecliente);
            this.Controls.Add(this.dataGridViewprestamos);
            this.Name = "Consultadeprestamos";
            this.Text = "Consultadeprestamos";
            this.Load += new System.EventHandler(this.Consultadeprestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewprestamos;
        private System.Windows.Forms.TextBox textboxnombrecliente;
        private System.Windows.Forms.TextBox textBoxapellidocliente;
        private System.Windows.Forms.TextBox textBoxcedulacliente;
        private System.Windows.Forms.TextBox textBoxcantidad;
        private System.Windows.Forms.TextBox textBoxtipoDVD;
        private System.Windows.Forms.TextBox textBoxproducto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonmodificar;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.TextBox textBoxcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadePrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadeDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipodeDVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
    }
}