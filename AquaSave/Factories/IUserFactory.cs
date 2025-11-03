using AquaSave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaSave.Factories
{
    public interface IUserFactory
    {
        User Crear(int id, string nombreCompleto, string correo, string contrasena, string rol);
    }
}
