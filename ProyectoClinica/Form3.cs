using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoClinica
{
    public partial class Form3 : Form
    {
        public String mesesp = "", nombreDoc = "", idCon = "", costoCon = "", totalPago;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            doctor_c.Text = nombreDoc;
            costo.Text = costoCon;
            total.Text = totalPago;
            consultorio.Text = idCon;
            can_meses.Text = mesesp;
        }
    }
}
