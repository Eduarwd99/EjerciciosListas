﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjerciciosListas.modelo;

namespace EjerciciosListas
{
    public partial class Form1 : Form
    {
        private List<Asignatura> lista = new List<Asignatura>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar el codigo de la asignatura");
                this.txtCodigo.Focus();
            }
            if (this.txtAsignatura.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre de la asignatura");
                this.txtAsignatura.Focus();
            }
            if (!(int.TryParse(this.txtCreditos.Text, out int creditos)))
            {
                MessageBox.Show("Creditos no validos");
                this.txtCreditos.Focus();
            }

            Asignatura materia = new Asignatura();
            materia.codigo = this.txtCodigo.Text;
            materia.asignatura = this.txtCodigo.Text;
            materia.creditos = creditos;
            materia.carrera = this.cmbCarrera.Text;

            lista.Add(materia);

            this.gridAsignaturas.DataSource = null;
            this.gridAsignaturas.DataSource = lista;

            this.txtAsignatura.Text = "";
            this.txtCreditos.Text = "";
            this.txtCodigo.Text = "";
            this.cmbCarrera.Text = "";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.gridAsignaturas.DataSource = null;
            this.gridAsignaturas.DataSource = lista.Where( data => data.carrera == this.txtCarrera.Text).ToList();

            this.txtCredMax.Text = lista.Max(data => data.creditos).ToString();
            this.txtCredMin.Text = lista.Min(data => data.creditos).ToString();
        }
    }
}
