using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.entidades;

namespace slnCursoNet.entidades
{
    public class ClienteIndividuo : Persona
    {
        public ClienteIndividuo(string nombre, string apellido, string cUIT, string email,
            string telefono, string direccion) : base(nombre, apellido, email, telefono, direccion)
        {
            Cuit = cUIT;
        }
        public string Cuit { get; set; }
    }
}


