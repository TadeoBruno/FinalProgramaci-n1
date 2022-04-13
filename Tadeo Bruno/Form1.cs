using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tadeo_Bruno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbTipoMascota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipoMascota.Items.Add("Tipo de mascota");
            cmbTipoMascota.Items.Add("Gato");
            cmbTipoMascota.Items.Add("Perro");
            cmbTipoMascota.Items.Add("Tortuga");
            cmbTipoMascota.Items.Add("Otro");
            cmbTipoMascota.SelectedIndex = 0;

            txtDescripcionMascota.Enabled = false;
            txtDescripcionOtroAnimal.Enabled = false;

            rbtnNo.Checked = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSi.Checked)
            txtDescripcionOtroAnimal.Enabled = true;
        }

        public void btnContinuar_Click(object sender, EventArgs e)
        {
            bool valido;
            valido = validar();

            if (!valido)
            {
                MessageBox.Show("Faltan completar algunos datos");
                return;
            }
            else
            {
                this.Hide();
                DatosDueño v1 = new DatosDueño();
                v1.Nombre = txtNombreMascota.Text;
                v1.Show();
            }
        }
            private bool validar()
            {
                bool validardatos = true;

                if (string.IsNullOrEmpty(txtNombreMascota.Text))
                {
                    validardatos = false;
                }
                //if (string.IsNullOrEmpty(txtDescripcionOtroAnimal.Text))
               // {
                //    validardatos = false;
               // }
                //if (string.IsNullOrEmpty(txtDescripcionMascota.Text))
               // {
                //    validardatos = false;
               // }
                if (cmbTipoMascota.SelectedIndex == 0)
                {
                    validardatos = false;
                }
                //if ()
                //{
                //    validardatos = false;
               // }
                return validardatos;
            }

        private void cmbTipoMascota_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbTipoMascota.SelectedIndex == 4)
            {
                txtDescripcionMascota.Enabled = true;
            }
        }
    }
}
    
