using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnCursoNet.entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace slnCursoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarCliente(object sender, EventArgs e)
        {
            ClienteIndividuo persona1 = new ClienteIndividuo("Ariana", "Belgrado", "27447554688", "belgradoariana@gmail.com", "5491131694875", "Avenida San Juan 3400");

            MessageBox.Show($"{persona1.Nombre}\n"+
                            $"{persona1.Apellido}\n"+
                            $"{persona1.Cuit}\n" +
                            $"{persona1.Email}\n" +
                            $"{persona1.Telefono}\n" +
                            $"{persona1.Direccion}\n");

        }

        private void MostrarClienteEmpresa(object sender, EventArgs e)
        {
            Empresa aerolineas = new Empresa("Aerolineas", "00112233445566", "Ariana Belgrado", "aerolienasargentinas@gmail.com", "5491155447788", "9 de Julio y Corrientes");

            MessageBox.Show($"{aerolineas.Nombre}\n" +
                            $"{aerolineas.Cuit}\n" +
                            $"{aerolineas.Contacto}\n" +
                            $"{aerolineas.Email}\n" +
                            $"{aerolineas.Telefono}\n" +
                            $"{aerolineas.Direccion}\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MostrarProducto(object sender, EventArgs e)
        {
            Producto producto1 = new Producto("Front-end", "Aeroparque", 10000, 10000, 0.21, "Viajes", "Avion");

            MessageBox.Show($"{producto1.Nombre}\n" +
                            $"{producto1.Descripcion}\n" +
                            $"{producto1.PrecioCosto}\n" +
                            $"{producto1.Margen}\n" +
                            $"{producto1.IVA}\n" +
                            $"{producto1.Categoria}\n" +
                            $"{producto1.SubCategoria}\n");
        }

        private void Factura(object sender, EventArgs e)
        {
            Factura factura = new Factura("1", new DateTime(2023,01,24),"Mica", "Gral.paz", "0.21", "40", "el mejor producto", 25.4m, "A");
            

            MessageBox.Show($"{factura.Tipo}\n" +
                           $"{factura.Numero}\n" +
                           $"{factura.Fecha}\n" +
                           $"{factura.Cliente}\n" +
                           $"{factura.Direccion}\n" +
                           $"{factura.CondicionIVA}\n" +
                           $"{factura.CondicionVenta}\n" +
                           $"{factura.Detalle}\n" +
                           $"{factura.Total}\n");
        }

        private void Empresa(object sender, EventArgs e)
        {
            Empresa proovedor1 = new Empresa("Ariana", "2744755468", "Ariana Belgrado",
                                   "belgradoariana@gmail.com", "5491131694875", "Gral.paz 8");


            MessageBox.Show($"{proovedor1.Nombre}\n" +
                            $"{proovedor1.Cuit}\n" +
                            $"{proovedor1.Contacto}\n" +
                            $"{proovedor1.Email}\n" +
                            $"{proovedor1.Telefono}\n" +
                            $"{proovedor1.Direccion}\n");
        }

        private void Remito(object sender, EventArgs e)
        {
            Remito remito1 = new Remito("1", new DateTime(2022, 12 , 22), "Tomas", "Gral.Paz 8", "8", "vender", "ruinpawnfpaw", "Lunes", 15.2m);

            MessageBox.Show($"{remito1.Numero}\n" +
                            $"{remito1.Fecha}\n" +
                            $"{remito1.Cliente}\n" +
                            $"{remito1.Direccion}\n" +
                            $"{remito1.CondicionIVA}\n" +
                            $"{remito1.CondicionVenta}\n" +
                            $"{remito1.Detalle}\n" +
                            $"{remito1.FechaEntrega}\n" +
                            $"{remito1.Total}\n");
        }

        private void Vendendor(object sender, EventArgs e)
        {
            Vendedor vendedor1 = new Vendedor("Ariana", "Belgrado", "44755468", "aribelgrado@gmail.com", "5491131694875", "Olavarria 668");
                

            MessageBox.Show($"{vendedor1.Nombre}\n" +
                            $"{vendedor1.Apellido}\n" +
                            $"{vendedor1.DNI}\n" +
                            $"{vendedor1.Email}\n" +
                            $"{vendedor1.Telefono}\n" +
                            $"{vendedor1.Direccion}\n");

        }
    }
}

