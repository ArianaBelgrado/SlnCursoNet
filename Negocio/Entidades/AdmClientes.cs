using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using slnCursoNet.entidades;

namespace Negocio.Entidades
{
    
    public class AdmClientes
    {
        public static List<ClienteIndividuo> clienteIndividuos = new List<ClienteIndividuo>();
        public static List<Empresa> clienteEmpresa = new List<Empresa>();
        public static List<ClienteIndividuo> ListarClienteIndividuo()
        {
            
            return clienteIndividuos ;

        }

        public static ClienteIndividuo ListarClienteIndividuo(string Cuit)
        {
            ClienteIndividuo clienteIndividuos = new ClienteIndividuo("Ariana", "Belgrado",
                "27447554688", "email" ,  "15241546",  "9 de Julio") ;
            return clienteIndividuos;
        }

        public static List<Empresa> ListarClienteEmpresa()
        {
            return clienteEmpresa;
        }

        public static List<Empresa> ListarClienteEmpresa(string Cuit)
        {
            Empresa clienteEmrpresa = new Empresa("Nicolo", "123456789", "145789325", "mail ", "15426983", "olavarruia 1456");
            return clienteEmpresa;
        }
    }
}
