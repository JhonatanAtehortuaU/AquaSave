using AquaSave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaSave.Factories
{
    public class UserFactory : IUserFactory
    {
        public User Crear(int id, string nombreCompleto, string correo, string contrasena, string rol)
        {
            if (string.IsNullOrWhiteSpace(nombreCompleto))
                throw new ArgumentException("El nombre no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(correo) || !correo.Contains("@"))
                throw new ArgumentException("Debe proporcionar un correo válido.");

            if (string.IsNullOrWhiteSpace(contrasena))
                throw new ArgumentException("Debe establecer una contraseña.");

            if (string.IsNullOrWhiteSpace(rol))
                rol = "user"; // Valor por defecto

            return new User
            {
                id = id,
                nombreCompleto = nombreCompleto,
                correo = correo,
                contrasena = contrasena,
                rol = rol
            };
        }
    }
}
