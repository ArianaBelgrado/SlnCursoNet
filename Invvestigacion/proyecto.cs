using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invvestigacion.Entidades;

namespace Invvestigacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AvionComercial avion1 = new AvionComercial()
            {
                Piloto = "Hernán\n",
                Copiloto = "Leandro\n",
                Azafata = "Magali\n",
                Capacidad = "500\n",
                LineaAerea = "Aerolineas\n"
            };

            MessageBox.Show(avion1.ToString());
        }

    }
}
