using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaSave.Models
{
    public abstract class Challenge
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public int puntos { get; set; }
        public string tipo { get; set; }
        public string dificulta { get; set; }

        public string usuarioAsig {  get; set; }

    }
}
