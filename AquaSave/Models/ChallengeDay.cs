using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaSave.Models
{
    public class ChallengeDay: Challenge
    {
        public override string ObtenerInformacion() => $"Reto diario: {titulo} - {puntos} pts";
    }
}
