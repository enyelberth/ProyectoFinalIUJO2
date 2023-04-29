/*
 * Creado por SharpDevelop.
 * Usuario: enyelberth
 * Fecha: 28/4/2023
 * Hora: 7:20 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace menuavanzado.Datos.Pantallas
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
			this.Base_D = new System.Windows.Forms.DataGridView();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.Base_D)).BeginInit();
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
			this.Base_D.Location = new System.Drawing.Point(107, 94);
			this.Base_D.Name = "Base_D";
			this.Base_D.Size = new System.Drawing.Size(544, 262);
			this.Base_D.TabIndex = 1;
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
			// PantallaDatosClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(744, 437);
			this.Controls.Add(this.Base_D);
			this.Name = "PantallaDatosClientes";
			this.Text = "PantallaDatosClientes";
			((System.ComponentModel.ISupportInitialize)(this.Base_D)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridView Base_D;
	}
}
