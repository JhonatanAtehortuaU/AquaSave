using AquaSave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaSave.Factories
{
    public class ChallengeFactory: IChallengeFactory
    {
        public Challenge Agregar(int id, string titulo, string descripcion, int puntos, string tipo, string dificultad, string usuarioAsig)
        {
            if (string.IsNullOrWhiteSpace(titulo)) throw new ArgumentException("El título no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(descripcion)) throw new ArgumentException("La descripción no puede estar vacía.");
            if (puntos < 0) throw new ArgumentException("Los puntos debe ser >= 0");

            if (puntos <= 10)
            {
                dificultad = "facil";
            } 
            else if (puntos <= 20)
            {
                dificultad = "media";
            }
            else
            {
                dificultad = "dificil";
            }
            switch (tipo?.ToLower())
            {
                case "diario":
                case "daily":
                    return new ChallengeDay
                    {
                        id = id,
                        titulo = titulo,
                        descripcion = descripcion,
                        puntos = puntos,
                        tipo = "diario",
                        dificulta = dificultad,
                        usuarioAsig = usuarioAsig
                    };

                case "semanal":
                case "weekly":
                    return new WeeklyChallenge
                    {
                        id = id,
                        titulo = titulo,
                        descripcion = descripcion,
                        puntos = puntos,
                        tipo = "semanal",
                        dificulta = dificultad,
                        usuarioAsig = usuarioAsig
                    };

                case "especial":
                case "special":
                    return new ChallengeSpecial
                    {
                        id = id,
                        titulo = titulo,
                        descripcion = descripcion,
                        puntos = puntos,
                        tipo = "semanal",
                        dificulta = dificultad,
                        usuarioAsig = usuarioAsig
                    };

                default:
                    throw new ArgumentException($"Tipo de reto desconocido: {tipo}");
            }
        }
    }
}
