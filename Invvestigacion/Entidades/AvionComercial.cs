using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invvestigacion.Entidades
{
    public class AvionComercial : Avion
    {
        public string Capacidad { get; set; }
        public string LineaAerea { get; set; }

        public override bool Aterriza()
        {
            return true;
        }

        public override bool Despegar()
        {
            return false;
        }

        public override string ToString()
        {

            return "Piloto: " + Piloto + "Copiloto: " + Copiloto + "Azafata: " + Azafata + "Capacidad: " + Capacidad + "LineaAerea: " + LineaAerea;
        }
    }
}

                                  