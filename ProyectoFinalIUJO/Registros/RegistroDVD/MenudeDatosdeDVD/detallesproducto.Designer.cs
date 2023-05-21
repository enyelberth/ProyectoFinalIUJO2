/*
 * Creado por SharpDevelop.
 * Usuario: Enyelbrth
 * Fecha: 13/05/2023
 * Hora: 07:31 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD
{
	partial class detallesproducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detallesproducto));
            this.buttonrentar = new System.Windows.Forms.Button();
            this.buttonDemo = new System.Windows.Forms.Button();
            this.buttonReproducir = new System.Windows.Forms.Button();
            this.buttonmodificar = new System.Windows.Forms.Button();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.textBoxdescripcion = new System.Windows.Forms.TextBox();
            this.labelprestamo = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labelingreso = new System.Windows.Forms.Label();
            this.labelcantidad = new System.Windows.Forms.Label();
            this.labelañoemision = new System.Windows.Forms.Label();
            this.labeltipo = new System.Windows.Forms.Label();
            this.labelcodigo = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.pictureBoxproductodetalles = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxproductodetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonrentar
            // 
            this.buttonrentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonrentar.Location = new System.Drawing.Point(626, 481);
            this.buttonrentar.Name = "buttonrentar";
            this.buttonrentar.Size = new System.Drawing.Size(101, 38);
            this.buttonrentar.TabIndex = 20;
            this.buttonrentar.Text = "Rentar";
            this.buttonrentar.UseVisualStyleBackColor = true;
            // 
            // buttonDemo
            // 
            this.buttonDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDemo.Location = new System.Drawing.Point(478, 481);
            this.buttonDemo.Name = "buttonDemo";
            this.buttonDemo.Size = new System.Drawing.Size(101, 38);
            this.buttonDemo.TabIndex = 19;
            this.buttonDemo.Text = "Probar";
            this.buttonDemo.UseVisualStyleBackColor = true;
            this.buttonDemo.Visible = false;
            // 
            // buttonReproducir
            // 
            this.buttonReproducir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReproducir.Location = new System.Drawing.Point(359, 481);
            this.buttonReproducir.Name = "buttonReproducir";
            this.buttonReproducir.Size = new System.Drawing.Size(101, 38);
            this.buttonReproducir.TabIndex = 18;
            this.buttonReproducir.Text = "Reproducir";
            this.buttonReproducir.UseVisualStyleBackColor = true;
            this.buttonReproducir.Visible = false;
            this.buttonReproducir.Click += new System.EventHandler(this.ButtonReproducirClick);
            // 
            // buttonmodificar
            // 
            this.buttonmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmodificar.Location = new System.Drawing.Point(199, 481);
            this.buttonmodificar.Name = "buttonmodificar";
            this.buttonmodificar.Size = new System.Drawing.Size(101, 38);
            this.buttonmodificar.TabIndex = 17;
            this.buttonmodificar.Text = "Modificar";
            this.buttonmodificar.UseVisualStyleBackColor = true;
            this.buttonmodificar.Click += new System.EventHandler(this.buttonmodificar_Click);
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEliminar.Location = new System.Drawing.Point(63, 481);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(101, 38);
            this.ButtonEliminar.TabIndex = 16;
            this.ButtonEliminar.Text = "Eliminar";
            this.ButtonEliminar.UseVisualStyleBackColor = true;
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // textBoxdescripcion
            // 
            this.textBoxdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdescripcion.Location = new System.Drawing.Point(27, 300);
            this.textBoxdescripcion.Multiline = true;
            this.textBoxdescripcion.Name = "textBoxdescripcion";
            this.textBoxdescripcion.ReadOnly = true;
            this.textBoxdescripcion.Size = new System.Drawing.Size(700, 154);
            this.textBoxdescripcion.TabIndex = 15;
            // 
            // labelprestamo
            // 
            this.labelprestamo.AutoSize = true;
            this.labelprestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprestamo.Location = new System.Drawing.Point(338, 257);
            this.labelprestamo.Name = "labelprestamo";
            this.labelprestamo.Size = new System.Drawing.Size(88, 18);
            this.labelprestamo.TabIndex = 28;
            this.labelprestamo.Text = "Respuesta";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(296, 234);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(186, 18);
            this.label.TabIndex = 27;
            this.label.Text = "Disponible a prestamo?";
            // 
            // labelingreso
            // 
            this.labelingreso.AutoSize = true;
            this.labelingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelingreso.Location = new System.Drawing.Point(297, 201);
            this.labelingreso.Name = "labelingreso";
            this.labelingreso.Size = new System.Drawing.Size(115, 18);
            this.labelingreso.TabIndex = 26;
            this.labelingreso.Text = "Fecha ingreso";
            // 
            // labelcantidad
            // 
            this.labelcantidad.AutoSize = true;
            this.labelcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcantidad.Location = new System.Drawing.Point(296, 164);
            this.labelcantidad.Name = "labelcantidad";
            this.labelcantidad.Size = new System.Drawing.Size(158, 18);
            this.labelcantidad.TabIndex = 25;
            this.labelcantidad.Text = "Cantidad Disponible";
            // 
            // labelañoemision
            // 
            this.labelañoemision.AutoSize = true;
            this.labelañoemision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelañoemision.Location = new System.Drawing.Point(297, 129);
            this.labelañoemision.Name = "labelañoemision";
            this.labelañoemision.Size = new System.Drawing.Size(124, 18);
            this.labelañoemision.TabIndex = 24;
            this.labelañoemision.Text = "Año de emision";
            // 
            // labeltipo
            // 
            this.labeltipo.AutoSize = true;
            this.labeltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltipo.Location = new System.Drawing.Point(297, 93);
            this.labeltipo.Name = "labeltipo";
            this.labeltipo.Size = new System.Drawing.Size(95, 18);
            this.labeltipo.TabIndex = 23;
            this.labeltipo.Text = "Tipo de dvd";
            // 
            // labelcodigo
            // 
            this.labelcodigo.AutoSize = true;
            this.labelcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcodigo.Location = new System.Drawing.Point(297, 56);
            this.labelcodigo.Name = "labelcodigo";
            this.labelcodigo.Size = new System.Drawing.Size(62, 18);
            this.labelcodigo.TabIndex = 22;
            this.labelcodigo.Text = "Codigo";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.Location = new System.Drawing.Point(297, 21);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(68, 18);
            this.labelnombre.TabIndex = 21;
            this.labelnombre.Text = "Nombre";
            // 
            // pictureBoxproductodetalles
            // 
            this.pictureBoxproductodetalles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxproductodetalles.BackgroundImage")));
            this.pictureBoxproductodetalles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxproductodetalles.Location = new System.Drawing.Point(50, 21);
            this.pictureBoxproductodetalles.Name = "pictureBoxproductodetalles";
            this.pictureBoxproductodetalles.Size = new System.Drawing.Size(194, 234);
            this.pictureBoxproductodetalles.TabIndex = 29;
            this.pictureBoxproductodetalles.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(735, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 27);
            this.button1.TabIndex = 30;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // detallesproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxproductodetalles);
            this.Controls.Add(this.labelprestamo);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelingreso);
            this.Controls.Add(this.labelcantidad);
            this.Controls.Add(this.labelañoemision);
            this.Controls.Add(this.labeltipo);
            this.Controls.Add(this.labelcodigo);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.buttonrentar);
            this.Controls.Add(this.buttonDemo);
            this.Controls.Add(this.buttonReproducir);
            this.Controls.Add(this.buttonmodificar);
            this.Controls.Add(this.ButtonEliminar);
            this.Controls.Add(this.textBoxdescripcion);
            this.Name = "detallesproducto";
            this.Text = "detallesproducto";
            this.Deactivate += new System.EventHandler(this.detallesproducto_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.detallesproducto_FormClosing);
            this.Load += new System.EventHandler(this.detallesproducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxproductodetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.PictureBox pictureBoxproductodetalles;
		private System.Windows.Forms.Label labelnombre;
		private System.Windows.Forms.Label labelcodigo;
		private System.Windows.Forms.Label labeltipo;
		private System.Windows.Forms.Label labelañoemision;
		private System.Windows.Forms.Label labelcantidad;
		private System.Windows.Forms.Label labelingreso;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label labelprestamo;
		private System.Windows.Forms.TextBox textBoxdescripcion;
		private System.Windows.Forms.Button ButtonEliminar;
		private System.Windows.Forms.Button buttonmodificar;
		private System.Windows.Forms.Button buttonReproducir;
		private System.Windows.Forms.Button buttonDemo;
		private System.Windows.Forms.Button buttonrentar;
        private System.Windows.Forms.Button button1;
    }
}
