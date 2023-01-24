using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using slnCursoNet.entidades;

namespace Negocio.Entidades
{
    public class AdmFacturas
    {
        public static List<Producto> productos = new List<Producto>();
        public static List<ClienteIndividuo> clienteIndividuo = new List<ClienteIndividuo>();
        public static List<Empresa> cliente = new List<Empresa>();

        public void Generar(List<Producto> productos, ClienteIndividuo clienteIndividuo ) { }

        public void Generar(List<Producto> productos, Empresa cliente) { }
    }
}
