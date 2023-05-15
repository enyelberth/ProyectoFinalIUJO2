﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD
{
    internal partial class detallesproducto : Form
    {
        public detallesproducto()
        {
            InitializeComponent();
        }

        private void detallesproducto_Load(object sender, EventArgs e)
        {
          
        }

        public void llenardatos(DVD dvd)
        {
            labelnombre.Text = dvd.producto;
            labelcodigo.Text = dvd.codigo;
            labeltipo.Text = dvd.tipo_DVD;
            labelañoemision.Text = Convert.ToString(dvd.año_emision);
            labelcantidad.Text = Convert.ToString(dvd.cantidad);
            labelingreso.Text = dvd.fechaingreso.ToString("dd/MM/yyyy");
            labelprestamo.Text = (dvd.prestamo == true) ? "Si" : "No";
            textBoxdescripcion.Text = dvd.descripcion;
            

            this.Show();



        }

        private void detallesproducto_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}