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
            lblDescripcionTarifa.Visible=false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int horas = Convert.ToInt32(txtHoras.Text);

            Vehiculo vehiculo;

            if (cmbVehiculo.Text == "Motocicleta")
            {
                vehiculo = new Motocicleta(horas, 150);
                lblDescripcionTarifa.Text = "La tarifa de la Motocicleta es de $15 por hora";
                lblDescripcionTarifa.Visible = true;
            }
            else if (cmbVehiculo.Text == "Automóvil")
            {
                vehiculo = new Automovil(horas, "ABC123");
                lblDescripcionTarifa.Text = "La tarifa del Automovil es de $30 por hora";
                lblDescripcionTarifa .Visible = true;
            }
            else
            {
                vehiculo = new Camioneta(horas, 2);
                lblDescripcionTarifa.Text = "La tarifa de la Camioneta es de $45 por hora";
                lblDescripcionTarifa.Visible=true;
            }

            lblTotal.Text = "Total: $" + vehiculo.CalcularTarifa();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
