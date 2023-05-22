namespace ProyectoFinalIUJO.Registros
{
    partial class consultaIngresos
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultaIngresos));
        	this.label1 = new System.Windows.Forms.Label();
        	this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
        	this.dataGridViewprestamos = new System.Windows.Forms.DataGridView();
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
        	this.label2 = new System.Windows.Forms.Label();
        	this.labelmonto = new System.Windows.Forms.Label();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.pictureBox2 = new System.Windows.Forms.PictureBox();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.label3 = new System.Windows.Forms.Label();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridViewprestamos)).BeginInit();
        	this.panel1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.Color.White;
        	this.label1.Location = new System.Drawing.Point(48, 55);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(260, 20);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Seleccione la fecha a consultar";
        	// 
        	// dateTimePicker1
        	// 
        	this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.dateTimePicker1.Location = new System.Drawing.Point(77, 88);
        	this.dateTimePicker1.Name = "dateTimePicker1";
        	this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
        	this.dateTimePicker1.TabIndex = 1;
        	this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
        	this.dataGridViewprestamos.Location = new System.Drawing.Point(35, 133);
        	this.dataGridViewprestamos.Name = "dataGridViewprestamos";
        	this.dataGridViewprestamos.ReadOnly = true;
        	this.dataGridViewprestamos.Size = new System.Drawing.Size(905, 258);
        	this.dataGridViewprestamos.TabIndex = 2;
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
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.ForeColor = System.Drawing.Color.White;
        	this.label2.Location = new System.Drawing.Point(31, 472);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(312, 20);
        	this.label2.TabIndex = 3;
        	this.label2.Text = "Ingresos segun la fecha seleccionada";
        	// 
        	// labelmonto
        	// 
        	this.labelmonto.AutoSize = true;
        	this.labelmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.labelmonto.Location = new System.Drawing.Point(367, 472);
        	this.labelmonto.Name = "labelmonto";
        	this.labelmonto.Size = new System.Drawing.Size(17, 20);
        	this.labelmonto.TabIndex = 4;
        	this.labelmonto.Text = "x";
        	// 
        	// panel1
        	// 
        	this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(84)))), ((int)(((byte)(99)))));
        	this.panel1.Controls.Add(this.pictureBox2);
        	this.panel1.Controls.Add(this.pictureBox1);
        	this.panel1.Controls.Add(this.label3);
        	this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
        	this.panel1.Location = new System.Drawing.Point(0, 0);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(980, 52);
        	this.panel1.TabIndex = 5;
        	// 
        	// pictureBox2
        	// 
        	this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
        	this.pictureBox2.Location = new System.Drawing.Point(614, 0);
        	this.pictureBox2.Name = "pictureBox2";
        	this.pictureBox2.Size = new System.Drawing.Size(53, 50);
        	this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.pictureBox2.TabIndex = 7;
        	this.pictureBox2.TabStop = false;
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        	this.pictureBox1.Location = new System.Drawing.Point(308, 3);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(53, 50);
        	this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.pictureBox1.TabIndex = 6;
        	this.pictureBox1.TabStop = false;
        	// 
        	// label3
        	// 
        	this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.label3.Font = new System.Drawing.Font("Modern No. 20", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.ForeColor = System.Drawing.Color.White;
        	this.label3.Location = new System.Drawing.Point(367, 9);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(241, 39);
        	this.label3.TabIndex = 0;
        	this.label3.Text = "Consulta Ingresos";
        	// 
        	// consultaIngresos
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(171)))), ((int)(((byte)(192)))));
        	this.ClientSize = new System.Drawing.Size(980, 684);
        	this.Controls.Add(this.panel1);
        	this.Controls.Add(this.labelmonto);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.dataGridViewprestamos);
        	this.Controls.Add(this.dateTimePicker1);
        	this.Controls.Add(this.label1);
        	this.Name = "consultaIngresos";
        	this.Text = "consultaIngresos";
        	this.Load += new System.EventHandler(this.consultaIngresos_Load);
        	((System.ComponentModel.ISupportInitialize)(this.dataGridViewprestamos)).EndInit();
        	this.panel1.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridViewprestamos;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelmonto;
    }
}