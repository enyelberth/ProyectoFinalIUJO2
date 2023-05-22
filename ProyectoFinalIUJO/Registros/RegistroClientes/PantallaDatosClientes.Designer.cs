/*
 * Creado por SharpDevelop.
 * Usuario: Enyelbrth
 * Fecha: 13/05/2023
 * Hora: 07:16 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoFinalIUJO.Registros.RegistroClientes
{
	partial class PantallaDatosClientes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaDatosClientes));
			this.Base_D = new System.Windows.Forms.DataGridView();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.Base_D)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Base_D
			// 
			this.Base_D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Base_D.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column2,
									this.Column3,
									this.Column4,
									this.Column5});
			this.Base_D.Location = new System.Drawing.Point(99, 116);
			this.Base_D.Name = "Base_D";
			this.Base_D.Size = new System.Drawing.Size(544, 262);
			this.Base_D.TabIndex = 2;
			this.Base_D.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Base_DCellContentClick);
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Nombre";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Apellido";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Cedula";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Sexo";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(139)))));
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.linkLabel1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(744, 79);
			this.panel1.TabIndex = 3;
			//this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(543, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 50);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Enabled = false;
			this.linkLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabel1.LinkColor = System.Drawing.Color.White;
			this.linkLabel1.Location = new System.Drawing.Point(265, 13);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(212, 49);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Datos Cliente";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(99, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(155)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 79);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(65, 324);
			this.panel2.TabIndex = 4;
			//this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2Paint);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(139)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 403);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(744, 34);
			this.panel3.TabIndex = 4;
			//this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3Paint);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(155)))));
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(676, 79);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(68, 324);
			this.panel4.TabIndex = 4;
			//this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4Paint);
			// 
			// PantallaDatosClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(87)))), ((int)(((byte)(104)))));
			this.ClientSize = new System.Drawing.Size(744, 437);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Base_D);
			this.Controls.Add(this.panel3);
			this.Name = "PantallaDatosClientes";
			this.Text = "PantallaDatosClientes";
			((System.ComponentModel.ISupportInitialize)(this.Base_D)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridView Base_D;
	}
}
