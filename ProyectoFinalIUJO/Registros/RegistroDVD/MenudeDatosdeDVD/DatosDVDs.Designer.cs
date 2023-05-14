/*
 * Creado por SharpDevelop.
 * Usuario: Enyelbrth
 * Fecha: 13/05/2023
 * Hora: 07:26 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD
{
	partial class DatosDVDs
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosDVDs));
			this.labelposicion2 = new System.Windows.Forms.Label();
			this.de = new System.Windows.Forms.Label();
			this.labelposicion1 = new System.Windows.Forms.Label();
			this.buttonatras = new System.Windows.Forms.Button();
			this.buttonadelante = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.labelfiltro = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.elementosProducto1 = new ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD.ElementosProducto();
			this.elementosProducto2 = new ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD.ElementosProducto();
			this.elementosProducto3 = new ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD.ElementosProducto();
			this.elementosProducto4 = new ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD.ElementosProducto();
			this.elementosProducto5 = new ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD.ElementosProducto();
			this.elementosProducto6 = new ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD.ElementosProducto();
			this.elementosProducto7 = new ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD.ElementosProducto();
			this.elementosProducto8 = new ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD.ElementosProducto();
			this.SuspendLayout();
			// 
			// labelposicion2
			// 
			this.labelposicion2.AutoSize = true;
			this.labelposicion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelposicion2.Location = new System.Drawing.Point(414, 621);
			this.labelposicion2.Name = "labelposicion2";
			this.labelposicion2.Size = new System.Drawing.Size(19, 20);
			this.labelposicion2.TabIndex = 27;
			this.labelposicion2.Text = "0";
			// 
			// de
			// 
			this.de.AutoSize = true;
			this.de.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.de.Location = new System.Drawing.Point(366, 621);
			this.de.Name = "de";
			this.de.Size = new System.Drawing.Size(32, 20);
			this.de.TabIndex = 26;
			this.de.Text = "De";
			// 
			// labelposicion1
			// 
			this.labelposicion1.AutoSize = true;
			this.labelposicion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelposicion1.Location = new System.Drawing.Point(330, 621);
			this.labelposicion1.Name = "labelposicion1";
			this.labelposicion1.Size = new System.Drawing.Size(19, 20);
			this.labelposicion1.TabIndex = 25;
			this.labelposicion1.Text = "0";
			// 
			// buttonatras
			// 
			this.buttonatras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonatras.Location = new System.Drawing.Point(229, 620);
			this.buttonatras.Name = "buttonatras";
			this.buttonatras.Size = new System.Drawing.Size(75, 23);
			this.buttonatras.TabIndex = 23;
			this.buttonatras.Text = "Atras";
			this.buttonatras.UseVisualStyleBackColor = true;
			// 
			// buttonadelante
			// 
			this.buttonadelante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonadelante.Location = new System.Drawing.Point(459, 621);
			this.buttonadelante.Name = "buttonadelante";
			this.buttonadelante.Size = new System.Drawing.Size(75, 23);
			this.buttonadelante.TabIndex = 24;
			this.buttonadelante.Text = "adelante";
			this.buttonadelante.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(277, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 16);
			this.label2.TabIndex = 31;
			this.label2.Text = "Ordenar Por";
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
									"Peliculas",
									"Mp3",
									"Videojuegos",
									"Sin filtro"});
			this.comboBox2.Location = new System.Drawing.Point(372, 32);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 23);
			this.comboBox2.TabIndex = 30;
			// 
			// labelfiltro
			// 
			this.labelfiltro.AutoSize = true;
			this.labelfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelfiltro.Location = new System.Drawing.Point(35, 32);
			this.labelfiltro.Name = "labelfiltro";
			this.labelfiltro.Size = new System.Drawing.Size(88, 20);
			this.labelfiltro.TabIndex = 29;
			this.labelfiltro.Text = "Filtrar Por";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"Sin filtro",
									"Peliculas",
									"Mp3s",
									"Videojuegos"});
			this.comboBox1.Location = new System.Drawing.Point(129, 31);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 23);
			this.comboBox1.TabIndex = 28;
			// 
			// elementosProducto1
			// 
			this.elementosProducto1.cantidadproducto = "0";
			this.elementosProducto1.Codigoproducto = "000000";
			this.elementosProducto1.Imagenproducto = ((System.Drawing.Image)(resources.GetObject("elementosProducto1.Imagenproducto")));
			this.elementosProducto1.Location = new System.Drawing.Point(1, 83);
			this.elementosProducto1.Name = "elementosProducto1";
			this.elementosProducto1.Nombreproducto = "";
			this.elementosProducto1.Size = new System.Drawing.Size(202, 234);
			this.elementosProducto1.TabIndex = 32;
			// 
			// elementosProducto2
			// 
			this.elementosProducto2.cantidadproducto = "0";
			this.elementosProducto2.Codigoproducto = "000000";
			this.elementosProducto2.Imagenproducto = ((System.Drawing.Image)(resources.GetObject("elementosProducto2.Imagenproducto")));
			this.elementosProducto2.Location = new System.Drawing.Point(209, 83);
			this.elementosProducto2.Name = "elementosProducto2";
			this.elementosProducto2.Nombreproducto = "";
			this.elementosProducto2.Size = new System.Drawing.Size(202, 234);
			this.elementosProducto2.TabIndex = 33;
			// 
			// elementosProducto3
			// 
			this.elementosProducto3.cantidadproducto = "0";
			this.elementosProducto3.Codigoproducto = "000000";
			this.elementosProducto3.Imagenproducto = ((System.Drawing.Image)(resources.GetObject("elementosProducto3.Imagenproducto")));
			this.elementosProducto3.Location = new System.Drawing.Point(417, 83);
			this.elementosProducto3.Name = "elementosProducto3";
			this.elementosProducto3.Nombreproducto = "";
			this.elementosProducto3.Size = new System.Drawing.Size(202, 234);
			this.elementosProducto3.TabIndex = 34;
			// 
			// elementosProducto4
			// 
			this.elementosProducto4.cantidadproducto = "0";
			this.elementosProducto4.Codigoproducto = "000000";
			this.elementosProducto4.Imagenproducto = ((System.Drawing.Image)(resources.GetObject("elementosProducto4.Imagenproducto")));
			this.elementosProducto4.Location = new System.Drawing.Point(615, 83);
			this.elementosProducto4.Name = "elementosProducto4";
			this.elementosProducto4.Nombreproducto = "";
			this.elementosProducto4.Size = new System.Drawing.Size(202, 234);
			this.elementosProducto4.TabIndex = 35;
			// 
			// elementosProducto5
			// 
			this.elementosProducto5.cantidadproducto = "0";
			this.elementosProducto5.Codigoproducto = "000000";
			this.elementosProducto5.Imagenproducto = ((System.Drawing.Image)(resources.GetObject("elementosProducto5.Imagenproducto")));
			this.elementosProducto5.Location = new System.Drawing.Point(1, 299);
			this.elementosProducto5.Name = "elementosProducto5";
			this.elementosProducto5.Nombreproducto = "";
			this.elementosProducto5.Size = new System.Drawing.Size(202, 234);
			this.elementosProducto5.TabIndex = 36;
			// 
			// elementosProducto6
			// 
			this.elementosProducto6.cantidadproducto = "0";
			this.elementosProducto6.Codigoproducto = "000000";
			this.elementosProducto6.Imagenproducto = ((System.Drawing.Image)(resources.GetObject("elementosProducto6.Imagenproducto")));
			this.elementosProducto6.Location = new System.Drawing.Point(196, 299);
			this.elementosProducto6.Name = "elementosProducto6";
			this.elementosProducto6.Nombreproducto = "";
			this.elementosProducto6.Size = new System.Drawing.Size(202, 234);
			this.elementosProducto6.TabIndex = 37;
			// 
			// elementosProducto7
			// 
			this.elementosProducto7.cantidadproducto = "0";
			this.elementosProducto7.Codigoproducto = "000000";
			this.elementosProducto7.Imagenproducto = ((System.Drawing.Image)(resources.GetObject("elementosProducto7.Imagenproducto")));
			this.elementosProducto7.Location = new System.Drawing.Point(404, 299);
			this.elementosProducto7.Name = "elementosProducto7";
			this.elementosProducto7.Nombreproducto = "";
			this.elementosProducto7.Size = new System.Drawing.Size(202, 234);
			this.elementosProducto7.TabIndex = 38;
			// 
			// elementosProducto8
			// 
			this.elementosProducto8.cantidadproducto = "0";
			this.elementosProducto8.Codigoproducto = "000000";
			this.elementosProducto8.Imagenproducto = ((System.Drawing.Image)(resources.GetObject("elementosProducto8.Imagenproducto")));
			this.elementosProducto8.Location = new System.Drawing.Point(625, 299);
			this.elementosProducto8.Name = "elementosProducto8";
			this.elementosProducto8.Nombreproducto = "";
			this.elementosProducto8.Size = new System.Drawing.Size(202, 234);
			this.elementosProducto8.TabIndex = 39;
			// 
			// DatosDVDs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(839, 667);
			this.Controls.Add(this.elementosProducto8);
			this.Controls.Add(this.elementosProducto7);
			this.Controls.Add(this.elementosProducto6);
			this.Controls.Add(this.elementosProducto5);
			this.Controls.Add(this.elementosProducto4);
			this.Controls.Add(this.elementosProducto3);
			this.Controls.Add(this.elementosProducto2);
			this.Controls.Add(this.elementosProducto1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.labelfiltro);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.labelposicion2);
			this.Controls.Add(this.de);
			this.Controls.Add(this.labelposicion1);
			this.Controls.Add(this.buttonatras);
			this.Controls.Add(this.buttonadelante);
			this.Name = "DatosDVDs";
			this.Text = "DatosDVDs";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD.ElementosProducto elementosProducto8;
		private ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD.ElementosProducto elementosProducto7;
		private ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD.ElementosProducto elementosProducto6;
		private ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD.ElementosProducto elementosProducto5;
		private ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD.ElementosProducto elementosProducto4;
		private ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD.ElementosProducto elementosProducto3;
		private ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD.ElementosProducto elementosProducto2;
		private ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD.ElementosProducto elementosProducto1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label labelfiltro;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonadelante;
		private System.Windows.Forms.Button buttonatras;
		private System.Windows.Forms.Label labelposicion1;
		private System.Windows.Forms.Label de;
		private System.Windows.Forms.Label labelposicion2;
	}
}
