using AquaSave.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaSave.Factories
{
    //Interfaz Factory Challenge
    public interface IChallengeFactory
    {
        Challenge Agregar(int id,string titulo, string descripcion, int puntos, string tipo, string dificultad, string usuarioAsig);
    }
}
