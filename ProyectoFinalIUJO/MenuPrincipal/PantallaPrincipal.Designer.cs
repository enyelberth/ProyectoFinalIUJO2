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
            this.BTNCerrar = new System.Windows.Forms.PictureBox();
            this.BTNMinimizar = new System.Windows.Forms.PictureBox();
            this.BTNRestaurarTamaño = new System.Windows.Forms.PictureBox();
            this.BTNMaximizarTamaño = new System.Windows.Forms.PictureBox();
            this.PanelLateralIzquierdo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Btn_Cliente = new System.Windows.Forms.Button();
            this.BtnDatosCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PanelContenidoPrincipal = new System.Windows.Forms.Panel();
            this.panelcontenido = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTNCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNRestaurarTamaño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNMaximizarTamaño)).BeginInit();
            this.PanelLateralIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.BarraTitulo.Size = new System.Drawing.Size(998, 35);
            this.BarraTitulo.TabIndex = 3;
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BTNCerrar.Image")));
            this.BTNCerrar.Location = new System.Drawing.Point(970, 2);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(25, 25);
            this.BTNCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNCerrar.TabIndex = 0;
            this.BTNCerrar.TabStop = false;
            this.BTNCerrar.Click += new System.EventHandler(this.BTNCerrar_Click_1);
            // 
            // BTNMinimizar
            // 
            this.BTNMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BTNMinimizar.Image")));
            this.BTNMinimizar.Location = new System.Drawing.Point(926, 3);
            this.BTNMinimizar.Name = "BTNMinimizar";
            this.BTNMinimizar.Size = new System.Drawing.Size(25, 22);
            this.BTNMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNMinimizar.TabIndex = 2;
            this.BTNMinimizar.TabStop = false;
            this.BTNMinimizar.Click += new System.EventHandler(this.BTNMinimizar_Click);
            // 
            // BTNRestaurarTamaño
            // 
            this.BTNRestaurarTamaño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNRestaurarTamaño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNRestaurarTamaño.Image = ((System.Drawing.Image)(resources.GetObject("BTNRestaurarTamaño.Image")));
            this.BTNRestaurarTamaño.Location = new System.Drawing.Point(948, 4);
            this.BTNRestaurarTamaño.Name = "BTNRestaurarTamaño";
            this.BTNRestaurarTamaño.Size = new System.Drawing.Size(25, 21);
            this.BTNRestaurarTamaño.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNRestaurarTamaño.TabIndex = 3;
            this.BTNRestaurarTamaño.TabStop = false;
            this.BTNRestaurarTamaño.Click += new System.EventHandler(this.BTNRestaurarTamaño_Click);
            // 
            // BTNMaximizarTamaño
            // 
            this.BTNMaximizarTamaño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNMaximizarTamaño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNMaximizarTamaño.Image = ((System.Drawing.Image)(resources.GetObject("BTNMaximizarTamaño.Image")));
            this.BTNMaximizarTamaño.Location = new System.Drawing.Point(948, 4);
            this.BTNMaximizarTamaño.Name = "BTNMaximizarTamaño";
            this.BTNMaximizarTamaño.Size = new System.Drawing.Size(25, 21);
            this.BTNMaximizarTamaño.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNMaximizarTamaño.TabIndex = 1;
            this.BTNMaximizarTamaño.TabStop = false;
            this.BTNMaximizarTamaño.Click += new System.EventHandler(this.BTNMaximizarTamaño_Click);
            // 
            // PanelLateralIzquierdo
            // 
            this.PanelLateralIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(65)))));
            this.PanelLateralIzquierdo.Controls.Add(this.button2);
            this.PanelLateralIzquierdo.Controls.Add(this.BtnDatosCliente);
            this.PanelLateralIzquierdo.Controls.Add(this.Btn_Cliente);
            this.PanelLateralIzquierdo.Controls.Add(this.panel2);
            this.PanelLateralIzquierdo.Controls.Add(this.panel1);
            this.PanelLateralIzquierdo.Controls.Add(this.button1);
            this.PanelLateralIzquierdo.Controls.Add(this.pictureBox1);
            this.PanelLateralIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateralIzquierdo.Location = new System.Drawing.Point(0, 35);
            this.PanelLateralIzquierdo.Name = "PanelLateralIzquierdo";
            this.PanelLateralIzquierdo.Size = new System.Drawing.Size(169, 651);
            this.PanelLateralIzquierdo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "  Gestion De DVD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(1, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 26);
            this.panel1.TabIndex = 2;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 26);
            this.panel3.TabIndex = 4;
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
            // Btn_Cliente
            // 
            this.Btn_Cliente.Location = new System.Drawing.Point(12, 197);
            this.Btn_Cliente.Name = "Btn_Cliente";
            this.Btn_Cliente.Size = new System.Drawing.Size(138, 23);
            this.Btn_Cliente.TabIndex = 4;
            this.Btn_Cliente.Text = "Clientes";
            this.Btn_Cliente.UseVisualStyleBackColor = true;
            this.Btn_Cliente.Click += new System.EventHandler(this.Btn_ClienteClick);
            // 
            // BtnDatosCliente
            // 
            this.BtnDatosCliente.Location = new System.Drawing.Point(12, 241);
            this.BtnDatosCliente.Name = "BtnDatosCliente";
            this.BtnDatosCliente.Size = new System.Drawing.Size(138, 23);
            this.BtnDatosCliente.TabIndex = 5;
            this.BtnDatosCliente.Text = "Datos Clientes";
            this.BtnDatosCliente.UseVisualStyleBackColor = true;
            this.BtnDatosCliente.Click += new System.EventHandler(this.BtnDatosClienteClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(2, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "     Registro De DVD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PanelContenidoPrincipal
            // 
            this.PanelContenidoPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(134)))));
            this.PanelContenidoPrincipal.Controls.Add(this.panelcontenido);
            this.PanelContenidoPrincipal.Controls.Add(this.PanelLateralIzquierdo);
            this.PanelContenidoPrincipal.Controls.Add(this.BarraTitulo);
            this.PanelContenidoPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelContenidoPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelContenidoPrincipal.Name = "PanelContenidoPrincipal";
            this.PanelContenidoPrincipal.Size = new System.Drawing.Size(998, 686);
            this.PanelContenidoPrincipal.TabIndex = 3;
            this.PanelContenidoPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenidoPrincipalPaint);
            // 
            // panelcontenido
            // 
            this.panelcontenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenido.Location = new System.Drawing.Point(169, 35);
            this.panelcontenido.Name = "panelcontenido";
            this.panelcontenido.Size = new System.Drawing.Size(829, 651);
            this.panelcontenido.TabIndex = 4;
            this.panelcontenido.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcontenido_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 686);
            this.ControlBox = false;
            this.Controls.Add(this.PanelContenidoPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "ProyectoFinalIUJO";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BTNCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNRestaurarTamaño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNMaximizarTamaño)).EndInit();
            this.PanelLateralIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.PanelContenidoPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox BTNMaximizarTamaño;
        private System.Windows.Forms.PictureBox BTNRestaurarTamaño;
        private System.Windows.Forms.PictureBox BTNMinimizar;
        private System.Windows.Forms.PictureBox BTNCerrar;
        private System.Windows.Forms.Panel PanelLateralIzquierdo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnDatosCliente;
        private System.Windows.Forms.Button Btn_Cliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelContenidoPrincipal;
        
	}
}
