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
            this.PanelContenidoPrincipal = new System.Windows.Forms.Panel();
            this.PanelLateralIzquierdo = new System.Windows.Forms.Panel();
            this.BtnDatosCliente = new System.Windows.Forms.Button();
            this.Btn_Cliente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.BTNMaximizarTamaño = new System.Windows.Forms.PictureBox();
            this.BTNRestaurarTamaño = new System.Windows.Forms.PictureBox();
            this.BTNMinimizar = new System.Windows.Forms.PictureBox();
            this.BTNCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelContenidoPrincipal.SuspendLayout();
            this.PanelLateralIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTNMaximizarTamaño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNRestaurarTamaño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContenidoPrincipal
            // 
            resources.ApplyResources(this.PanelContenidoPrincipal, "PanelContenidoPrincipal");
            this.PanelContenidoPrincipal.BackColor = System.Drawing.Color.LightGray;
            this.PanelContenidoPrincipal.Controls.Add(this.pictureBox2);
            this.PanelContenidoPrincipal.Controls.Add(this.PanelLateralIzquierdo);
            this.PanelContenidoPrincipal.Controls.Add(this.BarraTitulo);
            this.PanelContenidoPrincipal.Name = "PanelContenidoPrincipal";
            this.PanelContenidoPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenidoPrincipalPaint);
            // 
            // PanelLateralIzquierdo
            // 
            resources.ApplyResources(this.PanelLateralIzquierdo, "PanelLateralIzquierdo");
            this.PanelLateralIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(65)))));
            this.PanelLateralIzquierdo.Controls.Add(this.BtnDatosCliente);
            this.PanelLateralIzquierdo.Controls.Add(this.Btn_Cliente);
            this.PanelLateralIzquierdo.Controls.Add(this.panel2);
            this.PanelLateralIzquierdo.Controls.Add(this.panel1);
            this.PanelLateralIzquierdo.Controls.Add(this.button1);
            this.PanelLateralIzquierdo.Controls.Add(this.pictureBox1);
            this.PanelLateralIzquierdo.Name = "PanelLateralIzquierdo";
            // 
            // BtnDatosCliente
            // 
            resources.ApplyResources(this.BtnDatosCliente, "BtnDatosCliente");
            this.BtnDatosCliente.BackColor = System.Drawing.Color.Gray;
            this.BtnDatosCliente.Name = "BtnDatosCliente";
            this.BtnDatosCliente.UseVisualStyleBackColor = false;
            this.BtnDatosCliente.Click += new System.EventHandler(this.BtnDatosClienteClick);
            // 
            // Btn_Cliente
            // 
            resources.ApplyResources(this.Btn_Cliente, "Btn_Cliente");
            this.Btn_Cliente.Name = "Btn_Cliente";
            this.Btn_Cliente.UseVisualStyleBackColor = true;
            this.Btn_Cliente.Click += new System.EventHandler(this.Btn_ClienteClick);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Name = "panel2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Name = "panel1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // BarraTitulo
            // 
            resources.ApplyResources(this.BarraTitulo, "BarraTitulo");
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(27)))), ((int)(((byte)(117)))));
            this.BarraTitulo.Controls.Add(this.BTNMaximizarTamaño);
            this.BarraTitulo.Controls.Add(this.BTNRestaurarTamaño);
            this.BarraTitulo.Controls.Add(this.BTNMinimizar);
            this.BarraTitulo.Controls.Add(this.BTNCerrar);
            this.BarraTitulo.Name = "BarraTitulo";
            // 
            // BTNMaximizarTamaño
            // 
            resources.ApplyResources(this.BTNMaximizarTamaño, "BTNMaximizarTamaño");
            this.BTNMaximizarTamaño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNMaximizarTamaño.Name = "BTNMaximizarTamaño";
            this.BTNMaximizarTamaño.TabStop = false;
            this.BTNMaximizarTamaño.Click += new System.EventHandler(this.BTNMaximizarTamaño_Click);
            // 
            // BTNRestaurarTamaño
            // 
            resources.ApplyResources(this.BTNRestaurarTamaño, "BTNRestaurarTamaño");
            this.BTNRestaurarTamaño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNRestaurarTamaño.Name = "BTNRestaurarTamaño";
            this.BTNRestaurarTamaño.TabStop = false;
            this.BTNRestaurarTamaño.Click += new System.EventHandler(this.BTNRestaurarTamaño_Click);
            // 
            // BTNMinimizar
            // 
            resources.ApplyResources(this.BTNMinimizar, "BTNMinimizar");
            this.BTNMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNMinimizar.Name = "BTNMinimizar";
            this.BTNMinimizar.TabStop = false;
            this.BTNMinimizar.Click += new System.EventHandler(this.BTNMinimizar_Click);
            // 
            // BTNCerrar
            // 
            resources.ApplyResources(this.BTNCerrar, "BTNCerrar");
            this.BTNCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.TabStop = false;
            this.BTNCerrar.Click += new System.EventHandler(this.BTNCerrar_Click_1);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.PanelContenidoPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.PanelContenidoPrincipal.ResumeLayout(false);
            this.PanelLateralIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BTNMaximizarTamaño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNRestaurarTamaño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.PictureBox BTNCerrar;
		private System.Windows.Forms.PictureBox BTNMinimizar;
		private System.Windows.Forms.PictureBox BTNRestaurarTamaño;
		private System.Windows.Forms.PictureBox BTNMaximizarTamaño;
		private System.Windows.Forms.Panel BarraTitulo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button Btn_Cliente;
		private System.Windows.Forms.Button BtnDatosCliente;
		private System.Windows.Forms.Panel PanelLateralIzquierdo;
		private System.Windows.Forms.Panel PanelContenidoPrincipal;
        private System.Windows.Forms.PictureBox pictureBox2;
	}
}
