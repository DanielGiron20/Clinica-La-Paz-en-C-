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
    public partial class Form2 : Form
    {
        public String idDoc = "", totalPagar = "", nombreDoc = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            doctor_f.Text = nombreDoc;
            pago.Text = totalPagar;
            id_f.Text = idDoc;
            DateTime fechaActual = DateTime.Now;
            fecha.Text = fechaActual.ToString("yyyy-MM-dd");
        }
    }
}
