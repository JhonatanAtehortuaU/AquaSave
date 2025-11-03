using AquaSave.Factories;
using AquaSave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaSave.Repositories
{
    public class InMemoryRepository
    {
        private readonly IUserFactory _userFactory;
        private readonly IChallengeFactory _challengeFactory;

        public readonly List<User> _users = new List<User>();
        public readonly List<Challenge> _challenges = new List<Challenge>();

        public InMemoryRepository()
        {
            _userFactory = new UserFactory();
            _challengeFactory = new ChallengeFactory();

            _users.Add(_userFactory.Crear(1,"admin AquaSave","admin@aquasave.com","admin","admin"));
            _users.Add(_userFactory.Crear(2, "demo usere", "demo@aquasave.com", "12345", "user"));

            _challenges.Add(_challengeFactory.Agregar(
                1,
                "Ducha de 5 minutos",
                "Reducir el tiempo de baño a 5 minutos",
                10,
                "diario",
                "facil",
                "admin@aquasave.com"
            ));

            _challenges.Add(_challengeFactory.Agregar(
                2,
                "Lavado de ropa 3 dias por semana",
                "Reducir el tiempo de lavado a 3 dias por semana",
                30,
                "semanal",
                "facil",
                "admin@aquasave.com"
            ));
        }

        //Validar que un usuario este registrado y permitir el login
        public User Login(string correo, string contrasena)
        {
            return _users.Find(u => u.correo == correo && u.contrasena==contrasena);
        }

        //Obtener los retos semanales de un usuario en especifico
        public List<Challenge> RetoSemanales(string correo)
        {
            return _challenges
                .Where(c => c.usuarioAsig == correo && c.tipo=="semanal")
                .ToList();
        }

        //Obtener los retos diarios de un usuario en especifico
        public List<Challenge> RetoDiarios(string correo)
        {
            return _challenges
                .Where(c => c.usuarioAsig == correo && c.tipo == "diario")
                .ToList();
        }

        public User AgregarUsuario(string nombreCompleto, string correo, string contrasena, string rol)
        {
            int nuevoId = _challenges.Count > 0 ? _challenges.Max(c => c.id) + 1 : 1;
            var nuevoUser = _userFactory.Crear(nuevoId, nombreCompleto, correo, contrasena, rol);
            _users.Add(nuevoUser);
            return nuevoUser;
        }

        public List<User> ObtenerUsuarios()
        {
            return _users;
        }

    }
}
