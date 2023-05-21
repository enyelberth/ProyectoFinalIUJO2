/*
 * Creado por SharpDevelop.
 * Usuario: Enyelbrth
 * Fecha: 13/05/2023
 * Hora: 06:41 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoFinalIUJO
{
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.BTNMaximizarTamaño = new System.Windows.Forms.PictureBox();
            this.BTNRestaurarTamaño = new System.Windows.Forms.PictureBox();
            this.BTNMinimizar = new System.Windows.Forms.PictureBox();
            this.BTNCerrar = new System.Windows.Forms.PictureBox();
            this.PanelLateralIzquierdo = new System.Windows.Forms.Panel();
            this.Btn_Consulta_Ingresos = new System.Windows.Forms.Button();
            this.Btn_Consulta_Prestamos = new System.Windows.Forms.Button();
            this.Btn_Registro_Prestamo = new System.Windows.Forms.Button();
            this.Btn_Datos_Cliente = new System.Windows.Forms.Button();
            this.Btn_Registro_Cliente = new System.Windows.Forms.Button();
            this.Btn_Registro_DVD = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Gestion_DVD = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelContenidoPrincipal = new System.Windows.Forms.Panel();
            this.panelcontenido = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTNMaximizarTamaño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNRestaurarTamaño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNCerrar)).BeginInit();
            this.PanelLateralIzquierdo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelContenidoPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(27)))), ((int)(((byte)(117)))));
            this.BarraTitulo.Controls.Add(this.BTNMaximizarTamaño);
            this.BarraTitulo.Controls.Add(this.BTNRestaurarTamaño);
            this.BarraTitulo.Controls.Add(this.BTNMinimizar);
            this.BarraTitulo.Controls.Add(this.BTNCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1210, 35);
            this.BarraTitulo.TabIndex = 3;
            // 
            // BTNMaximizarTamaño
            // 
            this.BTNMaximizarTamaño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNMaximizarTamaño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNMaximizarTamaño.Image = ((System.Drawing.Image)(resources.GetObject("BTNMaximizarTamaño.Image")));
            this.BTNMaximizarTamaño.Location = new System.Drawing.Point(1160, 4);
            this.BTNMaximizarTamaño.Name = "BTNMaximizarTamaño";
            this.BTNMaximizarTamaño.Size = new System.Drawing.Size(25, 21);
            this.BTNMaximizarTamaño.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNMaximizarTamaño.TabIndex = 1;
            this.BTNMaximizarTamaño.TabStop = false;
            this.BTNMaximizarTamaño.Click += new System.EventHandler(this.BTNMaximizarTamaño_Click);
            // 
            // BTNRestaurarTamaño
            // 
            this.BTNRestaurarTamaño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNRestaurarTamaño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNRestaurarTamaño.Image = ((System.Drawing.Image)(resources.GetObject("BTNRestaurarTamaño.Image")));
            this.BTNRestaurarTamaño.Location = new System.Drawing.Point(1160, 4);
            this.BTNRestaurarTamaño.Name = "BTNRestaurarTamaño";
            this.BTNRestaurarTamaño.Size = new System.Drawing.Size(25, 21);
            this.BTNRestaurarTamaño.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNRestaurarTamaño.TabIndex = 3;
            this.BTNRestaurarTamaño.TabStop = false;
            this.BTNRestaurarTamaño.Click += new System.EventHandler(this.BTNRestaurarTamaño_Click);
            // 
            // BTNMinimizar
            // 
            this.BTNMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BTNMinimizar.Image")));
            this.BTNMinimizar.Location = new System.Drawing.Point(1138, 3);
            this.BTNMinimizar.Name = "BTNMinimizar";
            this.BTNMinimizar.Size = new System.Drawing.Size(25, 22);
            this.BTNMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNMinimizar.TabIndex = 2;
            this.BTNMinimizar.TabStop = false;
            this.BTNMinimizar.Click += new System.EventHandler(this.BTNMinimizar_Click);
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BTNCerrar.Image")));
            this.BTNCerrar.Location = new System.Drawing.Point(1182, 2);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(25, 25);
            this.BTNCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNCerrar.TabIndex = 0;
            this.BTNCerrar.TabStop = false;
            this.BTNCerrar.Click += new System.EventHandler(this.BTNCerrar_Click_1);
            // 
            // PanelLateralIzquierdo
            // 
            this.PanelLateralIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(65)))));
            this.PanelLateralIzquierdo.Controls.Add(this.Btn_Consulta_Ingresos);
            this.PanelLateralIzquierdo.Controls.Add(this.Btn_Consulta_Prestamos);
            this.PanelLateralIzquierdo.Controls.Add(this.Btn_Registro_Prestamo);
            this.PanelLateralIzquierdo.Controls.Add(this.Btn_Datos_Cliente);
            this.PanelLateralIzquierdo.Controls.Add(this.Btn_Registro_Cliente);
            this.PanelLateralIzquierdo.Controls.Add(this.Btn_Registro_DVD);
            this.PanelLateralIzquierdo.Controls.Add(this.panel2);
            this.PanelLateralIzquierdo.Controls.Add(this.panel1);
            this.PanelLateralIzquierdo.Controls.Add(this.Btn_Gestion_DVD);
            this.PanelLateralIzquierdo.Controls.Add(this.pictureBox1);
            this.PanelLateralIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateralIzquierdo.Location = new System.Drawing.Point(0, 35);
            this.PanelLateralIzquierdo.Name = "PanelLateralIzquierdo";
            this.PanelLateralIzquierdo.Size = new System.Drawing.Size(169, 749);
            this.PanelLateralIzquierdo.TabIndex = 2;
            // 
            // Btn_Consulta_Ingresos
            // 
            this.Btn_Consulta_Ingresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Consulta_Ingresos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Consulta_Ingresos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Consulta_Ingresos.FlatAppearance.BorderSize = 0;
            this.Btn_Consulta_Ingresos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Consulta_Ingresos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btn_Consulta_Ingresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Consulta_Ingresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consulta_Ingresos.ForeColor = System.Drawing.Color.White;
            this.Btn_Consulta_Ingresos.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Consulta_Ingresos.Image")));
            this.Btn_Consulta_Ingresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Consulta_Ingresos.Location = new System.Drawing.Point(3, 444);
            this.Btn_Consulta_Ingresos.Name = "Btn_Consulta_Ingresos";
            this.Btn_Consulta_Ingresos.Size = new System.Drawing.Size(162, 26);
            this.Btn_Consulta_Ingresos.TabIndex = 14;
            this.Btn_Consulta_Ingresos.Text = "Consulta Ingresos";
            this.Btn_Consulta_Ingresos.UseVisualStyleBackColor = false;
            this.Btn_Consulta_Ingresos.Click += new System.EventHandler(this.Btn_Consulta_Ingresos_Click);
            // 
            // Btn_Consulta_Prestamos
            // 
            this.Btn_Consulta_Prestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Consulta_Prestamos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Consulta_Prestamos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Consulta_Prestamos.FlatAppearance.BorderSize = 0;
            this.Btn_Consulta_Prestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Consulta_Prestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btn_Consulta_Prestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Consulta_Prestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consulta_Prestamos.ForeColor = System.Drawing.Color.White;
            this.Btn_Consulta_Prestamos.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Consulta_Prestamos.Image")));
            this.Btn_Consulta_Prestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Consulta_Prestamos.Location = new System.Drawing.Point(4, 335);
            this.Btn_Consulta_Prestamos.Name = "Btn_Consulta_Prestamos";
            this.Btn_Consulta_Prestamos.Size = new System.Drawing.Size(162, 26);
            this.Btn_Consulta_Prestamos.TabIndex = 13;
            this.Btn_Consulta_Prestamos.Text = "Consulta Prestamos";
            this.Btn_Consulta_Prestamos.UseVisualStyleBackColor = false;
            this.Btn_Consulta_Prestamos.Click += new System.EventHandler(this.Btn_Consulta_Prestamos_Click);
            // 
            // Btn_Registro_Prestamo
            // 
            this.Btn_Registro_Prestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Registro_Prestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Registro_Prestamo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Registro_Prestamo.FlatAppearance.BorderSize = 0;
            this.Btn_Registro_Prestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Registro_Prestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btn_Registro_Prestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Registro_Prestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Registro_Prestamo.ForeColor = System.Drawing.Color.White;
            this.Btn_Registro_Prestamo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Registro_Prestamo.Image")));
            this.Btn_Registro_Prestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Registro_Prestamo.Location = new System.Drawing.Point(4, 303);
            this.Btn_Registro_Prestamo.Name = "Btn_Registro_Prestamo";
            this.Btn_Registro_Prestamo.Size = new System.Drawing.Size(162, 26);
            this.Btn_Registro_Prestamo.TabIndex = 12;
            this.Btn_Registro_Prestamo.Text = "Registro Prestamo";
            this.Btn_Registro_Prestamo.UseVisualStyleBackColor = false;
            this.Btn_Registro_Prestamo.Click += new System.EventHandler(this.Btn_Registro_Prestamo_Click);
            // 
            // Btn_Datos_Cliente
            // 
            this.Btn_Datos_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Datos_Cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Datos_Cliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Datos_Cliente.FlatAppearance.BorderSize = 0;
            this.Btn_Datos_Cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Datos_Cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btn_Datos_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Datos_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Datos_Cliente.ForeColor = System.Drawing.Color.White;
            this.Btn_Datos_Cliente.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Datos_Cliente.Image")));
            this.Btn_Datos_Cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Datos_Cliente.Location = new System.Drawing.Point(7, 235);
            this.Btn_Datos_Cliente.Name = "Btn_Datos_Cliente";
            this.Btn_Datos_Cliente.Size = new System.Drawing.Size(162, 26);
            this.Btn_Datos_Cliente.TabIndex = 10;
            this.Btn_Datos_Cliente.Text = "Datos Cliente";
            this.Btn_Datos_Cliente.UseVisualStyleBackColor = false;
            this.Btn_Datos_Cliente.Click += new System.EventHandler(this.Btn_Datos_Cliente_Click);
            // 
            // Btn_Registro_Cliente
            // 
            this.Btn_Registro_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Registro_Cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Registro_Cliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Registro_Cliente.FlatAppearance.BorderSize = 0;
            this.Btn_Registro_Cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Registro_Cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btn_Registro_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Registro_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Registro_Cliente.ForeColor = System.Drawing.Color.White;
            this.Btn_Registro_Cliente.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Registro_Cliente.Image")));
            this.Btn_Registro_Cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Registro_Cliente.Location = new System.Drawing.Point(4, 208);
            this.Btn_Registro_Cliente.Name = "Btn_Registro_Cliente";
            this.Btn_Registro_Cliente.Size = new System.Drawing.Size(162, 26);
            this.Btn_Registro_Cliente.TabIndex = 9;
            this.Btn_Registro_Cliente.Text = "     Registro de Clientes";
            this.Btn_Registro_Cliente.UseVisualStyleBackColor = false;
            this.Btn_Registro_Cliente.Click += new System.EventHandler(this.Btn_Registro_Cliente_Click);
            // 
            // Btn_Registro_DVD
            // 
            this.Btn_Registro_DVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Registro_DVD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Registro_DVD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Registro_DVD.FlatAppearance.BorderSize = 0;
            this.Btn_Registro_DVD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Registro_DVD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btn_Registro_DVD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Registro_DVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.Btn_Registro_DVD.ForeColor = System.Drawing.Color.White;
            this.Btn_Registro_DVD.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Registro_DVD.Image")));
            this.Btn_Registro_DVD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Registro_DVD.Location = new System.Drawing.Point(2, 146);
            this.Btn_Registro_DVD.Name = "Btn_Registro_DVD";
            this.Btn_Registro_DVD.Size = new System.Drawing.Size(162, 26);
            this.Btn_Registro_DVD.TabIndex = 6;
            this.Btn_Registro_DVD.Text = "     Registro De DVD";
            this.Btn_Registro_DVD.UseVisualStyleBackColor = false;
            this.Btn_Registro_DVD.Click += new System.EventHandler(this.Btn_Registro_DVD_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(164, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 26);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 26);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(0, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 26);
            this.panel5.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 26);
            this.panel3.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(1, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 26);
            this.panel1.TabIndex = 2;
            // 
            // Btn_Gestion_DVD
            // 
            this.Btn_Gestion_DVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Gestion_DVD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Gestion_DVD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Gestion_DVD.FlatAppearance.BorderSize = 0;
            this.Btn_Gestion_DVD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Gestion_DVD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btn_Gestion_DVD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Gestion_DVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.Btn_Gestion_DVD.ForeColor = System.Drawing.Color.White;
            this.Btn_Gestion_DVD.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Gestion_DVD.Image")));
            this.Btn_Gestion_DVD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Gestion_DVD.Location = new System.Drawing.Point(4, 115);
            this.Btn_Gestion_DVD.Name = "Btn_Gestion_DVD";
            this.Btn_Gestion_DVD.Size = new System.Drawing.Size(162, 26);
            this.Btn_Gestion_DVD.TabIndex = 1;
            this.Btn_Gestion_DVD.Text = "  Gestion De DVD";
            this.Btn_Gestion_DVD.UseVisualStyleBackColor = false;
            this.Btn_Gestion_DVD.Click += new System.EventHandler(this.Btn_Gestion_DVD_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelContenidoPrincipal
            // 
            this.PanelContenidoPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(134)))));
            this.PanelContenidoPrincipal.Controls.Add(this.panelcontenido);
            this.PanelContenidoPrincipal.Controls.Add(this.PanelLateralIzquierdo);
            this.PanelContenidoPrincipal.Controls.Add(this.BarraTitulo);
            this.PanelContenidoPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenidoPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelContenidoPrincipal.Name = "PanelContenidoPrincipal";
            this.PanelContenidoPrincipal.Size = new System.Drawing.Size(1210, 784);
            this.PanelContenidoPrincipal.TabIndex = 3;
            this.PanelContenidoPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenidoPrincipalPaint);
            // 
            // panelcontenido
            // 
            this.panelcontenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenido.Location = new System.Drawing.Point(169, 35);
            this.panelcontenido.Name = "panelcontenido";
            this.panelcontenido.Size = new System.Drawing.Size(1041, 749);
            this.panelcontenido.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 784);
            this.ControlBox = false;
            this.Controls.Add(this.PanelContenidoPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "ProyectoFinalIUJO";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BTNMaximizarTamaño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNRestaurarTamaño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNCerrar)).EndInit();
            this.PanelLateralIzquierdo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelContenidoPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox BTNMaximizarTamaño;
        private System.Windows.Forms.PictureBox BTNRestaurarTamaño;
        private System.Windows.Forms.PictureBox BTNMinimizar;
        private System.Windows.Forms.PictureBox BTNCerrar;
        private System.Windows.Forms.Panel PanelLateralIzquierdo;
        private System.Windows.Forms.Button Btn_Registro_DVD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Gestion_DVD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelContenidoPrincipal;
        private System.Windows.Forms.Button Btn_Consulta_Ingresos;
        private System.Windows.Forms.Button Btn_Consulta_Prestamos;
        private System.Windows.Forms.Button Btn_Registro_Prestamo;
        private System.Windows.Forms.Button Btn_Datos_Cliente;
        private System.Windows.Forms.Button Btn_Registro_Cliente;
        
	}
}
