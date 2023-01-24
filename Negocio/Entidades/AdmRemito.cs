using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using slnCursoNet.entidades;

namespace Negocio.Entidades
{
    public class AdmRemito
    {
        public static List<Producto> productos = new List<Producto>();
        public static List<ClienteIndividuo> clienteIndividuos = new List<ClienteIndividuo>();
        public static List<Empresa> proveedores = new List<Empresa>();
        public static List<Empresa> clienteIndividuo= new List<Empresa>();

        public void Generar (List<Producto> productos, ClienteIndividuo clienteIndividuo,Empresa proveedores ) { }

        public void Generar(List<Producto> productos, Empresa clienteIndividuo, Empresa proveedores ) { }
    }
}
