using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoClinica
{
    public partial class seleccionar_habitacion : Form
    {

        SqlDataAdapter adaHabitaciones;
        DataTable dtHabitaciones;
        public seleccionar_habitacion()
        {
            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            adaHabitaciones = new SqlDataAdapter();
            adaHabitaciones.SelectCommand = new SqlCommand("select * from clinica.habitaciones", cnx);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dtHabitaciones = new DataTable();
            adaHabitaciones.Fill(dtHabitaciones);
            dataGridView1.DataSource = dtHabitaciones;
        }
    }
}
