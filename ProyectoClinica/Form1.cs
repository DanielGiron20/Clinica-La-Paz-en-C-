using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoClinica
{
    public partial class Form1 : Form
    {
        public String idPac = "", totalPagar = "", nombrePac = "", cambio = "", montoRecibido = "", cuenta = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            paciente_f.Text = nombrePac;
            total_p.Text = totalPagar;
            id_f.Text = idPac;
            monto_p.Text = montoRecibido;
            cambio_p.Text = cambio;
            detalles.Text = cuenta;


            paciente_f.Text = nombrePac;
            total_p.Text = totalPagar;
            id_f.Text = idPac;
            monto_p.Text = montoRecibido;
            cambio_p.Text = cambio;

            DateTime fechaActual = DateTime.Now;
            fecha.Text = fechaActual.ToString("yyyy-MM-dd");
        }
    }
}
