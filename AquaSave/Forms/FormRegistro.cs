using AquaSave.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquaSave.Forms
{
    public partial class FormRegistro : Form
    {
        private readonly InMemoryRepository _repo;
        private readonly FrmLogin _loginForm;

        public FormRegistro(InMemoryRepository repo, FrmLogin loginForm)
        {
            InitializeComponent();
            _repo = repo;
            _loginForm = loginForm;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            //Obtener varlor formulario nombre completo
            string nombreCompleto = txNombreCompleto.Text;
            //Obtener varlor formulario correo
            string correo = txCorreo.Text;
            //Obtener varlor formulario contraseña
            string contrasena = txContrasena.Text;

            //Valir que los campos de correo y contraseña no estan vacios
            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasena) || string.IsNullOrEmpty(nombreCompleto))
            {
                //Enviar mensaje donde se notifica que deben estar los campos 
                MessageBox.Show("Debe ingresar correo y contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validar que el correo sea valido con la funcion CorreoValido
            if (!CorreoValido(correo))
            {
                MessageBox.Show("Debe ingresar un correo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevoUsuario = _repo.AgregarUsuario(nombreCompleto, correo, contrasena, "user");

            MessageBox.Show($"Usuario agregado: {nuevoUsuario.nombreCompleto}");

            AbrirFormInicioSesion();
        }

        private bool CorreoValido(string correo)
        {
            try
            {
                var dirrecion = new MailAddress(correo);
                return dirrecion.Address == correo;
            }
            catch
            {
                return false;
            }
        }

        private void btnInicioSe_Click(object sender, EventArgs e)
        {
            AbrirFormInicioSesion();
        }

        private void AbrirFormInicioSesion()
        {
            _loginForm.Show();
            this.Close();
        }
    }
}
