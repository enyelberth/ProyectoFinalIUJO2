namespace menuavanzado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        	this.BarraTitulo = new System.Windows.Forms.Panel();
        	this.BTNMaximizarTamaño = new System.Windows.Forms.PictureBox();
        	this.BTNRestaurarTamaño = new System.Windows.Forms.PictureBox();
        	this.BTNMinimizar = new System.Windows.Forms.PictureBox();
        	this.BTNCerrar = new System.Windows.Forms.PictureBox();
        	this.PanelLateralIzquierdo = new System.Windows.Forms.Panel();
        	this.BtnDatosCliente = new System.Windows.Forms.Button();
        	this.Btn_Cliente = new System.Windows.Forms.Button();
        	this.panel2 = new System.Windows.Forms.Panel();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.button1 = new System.Windows.Forms.Button();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.PanelContenidoPrincipal = new System.Windows.Forms.Panel();
        	this.BarraTitulo.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.BTNMaximizarTamaño)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.BTNRestaurarTamaño)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.BTNMinimizar)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.BTNCerrar)).BeginInit();
        	this.PanelLateralIzquierdo.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
        	this.BarraTitulo.Size = new System.Drawing.Size(1024, 35);
        	this.BarraTitulo.TabIndex = 0;
        	// 
        	// BTNMaximizarTamaño
        	// 
        	this.BTNMaximizarTamaño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.BTNMaximizarTamaño.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.BTNMaximizarTamaño.Image = ((System.Drawing.Image)(resources.GetObject("BTNMaximizarTamaño.Image")));
        	this.BTNMaximizarTamaño.Location = new System.Drawing.Point(974, 4);
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
        	this.BTNRestaurarTamaño.Location = new System.Drawing.Point(974, 4);
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
        	this.BTNMinimizar.Location = new System.Drawing.Point(952, 3);
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
        	this.BTNCerrar.Location = new System.Drawing.Point(996, 3);
        	this.BTNCerrar.Name = "BTNCerrar";
        	this.BTNCerrar.Size = new System.Drawing.Size(25, 25);
        	this.BTNCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.BTNCerrar.TabIndex = 0;
        	this.BTNCerrar.TabStop = false;
        	this.BTNCerrar.Click += new System.EventHandler(this.BTNCerrar_Click);
        	// 
        	// PanelLateralIzquierdo
        	// 
        	this.PanelLateralIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(65)))));
        	this.PanelLateralIzquierdo.Controls.Add(this.BtnDatosCliente);
        	this.PanelLateralIzquierdo.Controls.Add(this.Btn_Cliente);
        	this.PanelLateralIzquierdo.Controls.Add(this.panel2);
        	this.PanelLateralIzquierdo.Controls.Add(this.panel1);
        	this.PanelLateralIzquierdo.Controls.Add(this.button1);
        	this.PanelLateralIzquierdo.Controls.Add(this.pictureBox1);
        	this.PanelLateralIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
        	this.PanelLateralIzquierdo.Location = new System.Drawing.Point(0, 35);
        	this.PanelLateralIzquierdo.Name = "PanelLateralIzquierdo";
        	this.PanelLateralIzquierdo.Size = new System.Drawing.Size(169, 685);
        	this.PanelLateralIzquierdo.TabIndex = 1;
        	// 
        	// BtnDatosCliente
        	// 
        	this.BtnDatosCliente.Location = new System.Drawing.Point(25, 223);
        	this.BtnDatosCliente.Name = "BtnDatosCliente";
        	this.BtnDatosCliente.Size = new System.Drawing.Size(138, 23);
        	this.BtnDatosCliente.TabIndex = 5;
        	this.BtnDatosCliente.Text = "Datos Clientes";
        	this.BtnDatosCliente.UseVisualStyleBackColor = true;
        	this.BtnDatosCliente.Click += new System.EventHandler(this.BtnDatosClienteClick);
        	// 
        	// Btn_Cliente
        	// 
        	this.Btn_Cliente.Location = new System.Drawing.Point(25, 175);
        	this.Btn_Cliente.Name = "Btn_Cliente";
        	this.Btn_Cliente.Size = new System.Drawing.Size(138, 23);
        	this.Btn_Cliente.TabIndex = 4;
        	this.Btn_Cliente.Text = "Clientes";
        	this.Btn_Cliente.UseVisualStyleBackColor = true;
        	this.Btn_Cliente.Click += new System.EventHandler(this.Btn_ClienteClick);
        	// 
        	// panel2
        	// 
        	this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
        	this.panel2.Location = new System.Drawing.Point(164, 115);
        	this.panel2.Name = "panel2";
        	this.panel2.Size = new System.Drawing.Size(5, 26);
        	this.panel2.TabIndex = 3;
        	// 
        	// panel1
        	// 
        	this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
        	this.panel1.Location = new System.Drawing.Point(1, 115);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(5, 26);
        	this.panel1.TabIndex = 2;
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
        	this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.button1.ForeColor = System.Drawing.Color.White;
        	this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
        	this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	this.button1.Location = new System.Drawing.Point(4, 115);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(162, 26);
        	this.button1.TabIndex = 1;
        	this.button1.Text = "  Gestion De DVD";
        	this.button1.UseVisualStyleBackColor = false;
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        	this.pictureBox1.Location = new System.Drawing.Point(0, 6);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(169, 91);
        	this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.pictureBox1.TabIndex = 0;
        	this.pictureBox1.TabStop = false;
        	// 
        	// PanelContenidoPrincipal
        	// 
        	this.PanelContenidoPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(197)))));
        	this.PanelContenidoPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.PanelContenidoPrincipal.Location = new System.Drawing.Point(169, 35);
        	this.PanelContenidoPrincipal.Name = "PanelContenidoPrincipal";
        	this.PanelContenidoPrincipal.Size = new System.Drawing.Size(855, 685);
        	this.PanelContenidoPrincipal.TabIndex = 2;
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(1024, 720);
        	this.Controls.Add(this.PanelContenidoPrincipal);
        	this.Controls.Add(this.PanelLateralIzquierdo);
        	this.Controls.Add(this.BarraTitulo);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.Name = "Form1";
        	this.Text = "Form1";
        	this.BarraTitulo.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.BTNMaximizarTamaño)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.BTNRestaurarTamaño)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.BTNMinimizar)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.BTNCerrar)).EndInit();
        	this.PanelLateralIzquierdo.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.Button BtnDatosCliente;
        private System.Windows.Forms.Button Btn_Cliente;

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox BTNCerrar;
        private System.Windows.Forms.Panel PanelLateralIzquierdo;
        private System.Windows.Forms.Panel PanelContenidoPrincipal;
        private System.Windows.Forms.PictureBox BTNRestaurarTamaño;
        private System.Windows.Forms.PictureBox BTNMinimizar;
        private System.Windows.Forms.PictureBox BTNMaximizarTamaño;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

