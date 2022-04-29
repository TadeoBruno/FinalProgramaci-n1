using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Tadeo_Bruno
{
    public partial class DatosDueño : Form
    {
        public DatosDueño(Form1.Dato Nombre)
        {
            InitializeComponent();
            lblNombreMascota.Text = "Dueño de: " + Nombre.NombreMascota;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //COMUN.MetodosComunes.KeyPressSoloLetras(e, "");
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            //COMUN.MetodosComunes.KeyPressSoloLetras(e, "");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool nombre = Verificar(txtNombre);
            bool apellido = Verificar(txtApellido);
            bool dni = Verificar(txtDNI);
            //bool rta = COMUN.MetodosComunes.ValidacionEMAIL (txtMail);
            //if (rta == true)
            {
                MessageBox.Show("Gracias por registrarse a " ); //Nombre, "Exito");
            }
            //else
            //{
            //  MessageBox.Show("El Mail ingresa no es valido", "Error");
            //}
            MailMessage msg = new MailMessage();

            msg.To.Add(txtMail.Text);
            msg.Subject = "Bienvenido" + txtNombre.ToString();
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Body = ("Podes escribirnos a este mail para turnos o cualquier duda que tengas sobre tu mascota. Saludos!");
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new MailAddress("");
            NetworkCredential loginInfo = new NetworkCredential("", ""); //rellenar con sus datos privados

            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = loginInfo;
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
            try
            {
                cliente.Send(msg);
                MessageBox.Show("El mail ha sido enviado con exito!");
            }
            catch (Exception a)
            {
            }

            //private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
            {
            }

            //private void label5_Click(object sender, EventArgs e)
            {

            }
        }
        private bool Verificar(TextBox textbox)
        {
            if (!string.IsNullOrEmpty(textbox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 v2 = new Form1();
            v2.Show();
        }

        private void DatosDueño_Load(object sender, EventArgs e)
        {
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
