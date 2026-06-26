using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestonDeCobroEstacionamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int horas = Convert.ToInt32(txtHoras.Text);

            Vehiculo vehiculo;

            if (cmbVehiculo.Text == "Motocicleta")
            {
                vehiculo = new Motocicleta(horas, 150);
            }
            else if (cmbVehiculo.Text == "Automóvil")
            {
                vehiculo = new Automovil(horas, "ABC123");
            }
            else
            {
                vehiculo = new Camioneta(horas, 2);
            }

            lblTotal.Text = "Total: $" + vehiculo.CalcularTarifa();
        }
    }
}
