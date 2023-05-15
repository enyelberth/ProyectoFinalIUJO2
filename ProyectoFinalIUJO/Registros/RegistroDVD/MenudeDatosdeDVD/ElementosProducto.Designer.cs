/*
 * Creado por SharpDevelop.
 * Usuario: Enyelbrth
 * Fecha: 13/05/2023
 * Hora: 07:33 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD
{
	partial class ElementosProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElementosProducto));
            this.labelcantidad = new System.Windows.Forms.Label();
            this.pictureBoxproducto = new System.Windows.Forms.PictureBox();
            this.labelcodigo = new System.Windows.Forms.Label();
            this.labelproducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelcantidad
            // 
            this.labelcantidad.AutoSize = true;
            this.labelcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.labelcantidad.Location = new System.Drawing.Point(140, 168);
            this.labelcantidad.Name = "labelcantidad";
            this.labelcantidad.Size = new System.Drawing.Size(15, 16);
            this.labelcantidad.TabIndex = 7;
            this.labelcantidad.Text = "0";
            // 
            // pictureBoxproducto
            // 
            this.pictureBoxproducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxproducto.BackgroundImage")));
            this.pictureBoxproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxproducto.Location = new System.Drawing.Point(50, 22);
            this.pictureBoxproducto.Name = "pictureBoxproducto";
            this.pictureBoxproducto.Size = new System.Drawing.Size(105, 120);
            this.pictureBoxproducto.TabIndex = 6;
            this.pictureBoxproducto.TabStop = false;
            this.pictureBoxproducto.Click += new System.EventHandler(this.pictureBoxproducto_Click);
            // 
            // labelcodigo
            // 
            this.labelcodigo.AutoSize = true;
            this.labelcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.labelcodigo.Location = new System.Drawing.Point(39, 168);
            this.labelcodigo.Name = "labelcodigo";
            this.labelcodigo.Size = new System.Drawing.Size(50, 16);
            this.labelcodigo.TabIndex = 5;
            this.labelcodigo.Text = "000000";
            // 
            // labelproducto
            // 
            this.labelproducto.AutoSize = true;
            this.labelproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelproducto.Location = new System.Drawing.Point(35, 192);
            this.labelproducto.Name = "labelproducto";
            this.labelproducto.Size = new System.Drawing.Size(0, 20);
            this.labelproducto.TabIndex = 4;
            // 
            // ElementosProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelcantidad);
            this.Controls.Add(this.pictureBoxproducto);
            this.Controls.Add(this.labelcodigo);
            this.Controls.Add(this.labelproducto);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ElementosProducto";
            this.Size = new System.Drawing.Size(202, 234);
            this.Click += new System.EventHandler(this.ElementosProducto_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxproducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label labelproducto;
		private System.Windows.Forms.Label labelcodigo;
		private System.Windows.Forms.PictureBox pictureBoxproducto;
		private System.Windows.Forms.Label labelcantidad;
	}
}
