using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaSave.Models
{
    public class User
    {
        public int id { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
        public string nombreCompleto { get; set; }
        public string rol {  get; set; }
    }
}
