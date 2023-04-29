/*
 * Creado por SharpDevelop.
 * Usuario: enyelberth
 * Fecha: 28/4/2023
 * Hora: 6:32 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace menuavanzado.Datos.Pantallas
{
	partial class PantallaCliente
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
			this.InputTelefonoCelular = new System.Windows.Forms.TextBox();
			this.inputCedula = new System.Windows.Forms.TextBox();
			this.inputApellido = new System.Windows.Forms.TextBox();
			this.InputNombre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.InputTelefonoResidencial = new System.Windows.Forms.TextBox();
			this.inputCorreo = new System.Windows.Forms.TextBox();
			this.InputDireccion = new System.Windows.Forms.TextBox();
			this.Btn_Registro = new System.Windows.Forms.Button();
			this.InputFechaNacimiento = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// InputTelefonoCelular
			// 
			this.InputTelefonoCelular.Location = new System.Drawing.Point(339, 224);
			this.InputTelefonoCelular.Name = "InputTelefonoCelular";
			this.InputTelefonoCelular.Size = new System.Drawing.Size(100, 20);
			this.InputTelefonoCelular.TabIndex = 19;
			// 
			// inputCedula
			// 
			this.inputCedula.Location = new System.Drawing.Point(281, 158);
			this.inputCedula.Name = "inputCedula";
			this.inputCedula.Size = new System.Drawing.Size(100, 20);
			this.inputCedula.TabIndex = 18;
			// 
			// inputApellido
			// 
			this.inputApellido.Location = new System.Drawing.Point(281, 126);
			this.inputApellido.Name = "inputApellido";
			this.inputApellido.Size = new System.Drawing.Size(100, 20);
			this.inputApellido.TabIndex = 17;
			// 
			// InputNombre
			// 
			this.InputNombre.Location = new System.Drawing.Point(281, 100);
			this.InputNombre.Name = "InputNombre";
			this.InputNombre.Size = new System.Drawing.Size(100, 20);
			this.InputNombre.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(207, 181);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 23);
			this.label5.TabIndex = 15;
			this.label5.Text = "Sexo";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(207, 204);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 23);
			this.label4.TabIndex = 14;
			this.label4.Text = "Fecha de nacimiento";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(207, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 23);
			this.label3.TabIndex = 13;
			this.label3.Text = "Cedula";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(207, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 23);
			this.label2.TabIndex = 12;
			this.label2.Text = "Nombre";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(207, 126);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 23);
			this.label1.TabIndex = 11;
			this.label1.Text = "Apellido";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(241, 29);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(212, 51);
			this.label6.TabIndex = 21;
			this.label6.Text = "Prueba";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(207, 227);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(110, 23);
			this.label7.TabIndex = 22;
			this.label7.Text = "Telefono Celular";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(207, 250);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(110, 23);
			this.label8.TabIndex = 23;
			this.label8.Text = "Telefono Residencial";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(207, 273);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(110, 23);
			this.label9.TabIndex = 24;
			this.label9.Text = "Correo electronico";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(207, 302);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(110, 23);
			this.label10.TabIndex = 25;
			this.label10.Text = "Direccion";
			// 
			// InputTelefonoResidencial
			// 
			this.InputTelefonoResidencial.Location = new System.Drawing.Point(339, 250);
			this.InputTelefonoResidencial.Name = "InputTelefonoResidencial";
			this.InputTelefonoResidencial.Size = new System.Drawing.Size(100, 20);
			this.InputTelefonoResidencial.TabIndex = 26;
			// 
			// inputCorreo
			// 
			this.inputCorreo.Location = new System.Drawing.Point(339, 273);
			this.inputCorreo.Name = "inputCorreo";
			this.inputCorreo.Size = new System.Drawing.Size(100, 20);
			this.inputCorreo.TabIndex = 27;
			// 
			// InputDireccion
			// 
			this.InputDireccion.Location = new System.Drawing.Point(339, 299);
			this.InputDireccion.Name = "InputDireccion";
			this.InputDireccion.Size = new System.Drawing.Size(100, 20);
			this.InputDireccion.TabIndex = 28;
			// 
			// Btn_Registro
			// 
			this.Btn_Registro.Location = new System.Drawing.Point(281, 337);
			this.Btn_Registro.Name = "Btn_Registro";
			this.Btn_Registro.Size = new System.Drawing.Size(75, 23);
			this.Btn_Registro.TabIndex = 29;
			this.Btn_Registro.Text = "Registrar";
			this.Btn_Registro.UseVisualStyleBackColor = true;
			// 
			// InputFechaNacimiento
			// 
			this.InputFechaNacimiento.Location = new System.Drawing.Point(339, 198);
			this.InputFechaNacimiento.Name = "InputFechaNacimiento";
			this.InputFechaNacimiento.Size = new System.Drawing.Size(200, 20);
			this.InputFechaNacimiento.TabIndex = 30;
			// 
			// PantallaCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 409);
			this.Controls.Add(this.InputFechaNacimiento);
			this.Controls.Add(this.Btn_Registro);
			this.Controls.Add(this.InputDireccion);
			this.Controls.Add(this.inputCorreo);
			this.Controls.Add(this.InputTelefonoResidencial);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.InputTelefonoCelular);
			this.Controls.Add(this.inputCedula);
			this.Controls.Add(this.inputApellido);
			this.Controls.Add(this.InputNombre);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "PantallaCliente";
			this.Text = "PantallaCliente";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DateTimePicker InputFechaNacimiento;
		private System.Windows.Forms.Button Btn_Registro;
		private System.Windows.Forms.TextBox InputDireccion;
		private System.Windows.Forms.TextBox inputCorreo;
		private System.Windows.Forms.TextBox InputTelefonoResidencial;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox InputNombre;
		private System.Windows.Forms.TextBox inputApellido;
		private System.Windows.Forms.TextBox inputCedula;
		private System.Windows.Forms.TextBox InputTelefonoCelular;
	}
}
