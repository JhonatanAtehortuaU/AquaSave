using AquaSave.Models;
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
    public partial class FrmLogin : Form
    {
        private readonly InMemoryRepository _repo;

        public FrmLogin(InMemoryRepository repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Obtener varlor formulario correo
            string correo = txCorreo.Text;
            //Obtener varlor formulario contraseña
            string contrasena = txContrasena.Text;

            //Valir que los campos de correo y contraseña no estan vacios
            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasena))
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

            //Validar que los credenciales del usuario si estan registrados en el arreglo que esta funcionando como base de datos
            User usuario = _repo.Login(correo, contrasena);

            //Validar si retorna algun resultado del usuario
            if (usuario != null) 
            {
                //Enviar mensaje que el login fue exitor y redireccionar al formulario principal donde se encuentran los retos del usuario
                MessageBox.Show($"Bienvenido, {usuario.nombreCompleto}", "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMain frm = new FormMain(usuario,_repo);
                frm.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Nos permite validar si el correo ingresado es valido, que sea @ y no un texto cualquiera
        private bool CorreoValido(string correo) {
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

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegistro frm = new FormRegistro(_repo, this);
            frm.Show();
            this.Hide();
        }
    }
}
