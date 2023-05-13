namespace menuavanzado.Registros.RegistroDVDs.Menu_de_Datos_de_DVD
{
    partial class ElementosProducto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElementosProducto));
            this.labelproducto = new System.Windows.Forms.Label();
            this.labelcodigo = new System.Windows.Forms.Label();
            this.pictureBoxproducto = new System.Windows.Forms.PictureBox();
            this.labelcantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelproducto
            // 
            this.labelproducto.AutoSize = true;
            this.labelproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproducto.Location = new System.Drawing.Point(21, 201);
            this.labelproducto.Name = "labelproducto";
            this.labelproducto.Size = new System.Drawing.Size(0, 20);
            this.labelproducto.TabIndex = 0;
            // 
            // labelcodigo
            // 
            this.labelcodigo.AutoSize = true;
            this.labelcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcodigo.Location = new System.Drawing.Point(25, 177);
            this.labelcodigo.Name = "labelcodigo";
            this.labelcodigo.Size = new System.Drawing.Size(49, 16);
            this.labelcodigo.TabIndex = 1;
            this.labelcodigo.Text = "000000";
            // 
            // pictureBoxproducto
            // 
            this.pictureBoxproducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxproducto.BackgroundImage")));
            this.pictureBoxproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxproducto.Location = new System.Drawing.Point(48, 31);
            this.pictureBoxproducto.Name = "pictureBoxproducto";
            this.pictureBoxproducto.Size = new System.Drawing.Size(105, 120);
            this.pictureBoxproducto.TabIndex = 2;
            this.pictureBoxproducto.TabStop = false;
            // 
            // labelcantidad
            // 
            this.labelcantidad.AutoSize = true;
            this.labelcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcantidad.Location = new System.Drawing.Point(126, 177);
            this.labelcantidad.Name = "labelcantidad";
            this.labelcantidad.Size = new System.Drawing.Size(14, 16);
            this.labelcantidad.TabIndex = 3;
            this.labelcantidad.Text = "0";
            // 
            // ElementosProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelcantidad);
            this.Controls.Add(this.pictureBoxproducto);
            this.Controls.Add(this.labelcodigo);
            this.Controls.Add(this.labelproducto);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ElementosProducto";
            this.Size = new System.Drawing.Size(202, 234);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxproducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelproducto;
        private System.Windows.Forms.Label labelcodigo;
        private System.Windows.Forms.PictureBox pictureBoxproducto;
        private System.Windows.Forms.Label labelcantidad;
    }
}
