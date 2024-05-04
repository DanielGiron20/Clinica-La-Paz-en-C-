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
    public partial class FormHospitalizaciones : Form
    {
        SqlDataAdapter adaHospitalizaciones;
        DataTable dtHospitalizaciones;

        public FormHospitalizaciones()
        {
            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            adaHospitalizaciones = new SqlDataAdapter();
            adaHospitalizaciones.SelectCommand = new SqlCommand("select * from clinica.hospitalizaciones", cnx);
        }

        private void FormHospitalizaciones_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dtHospitalizaciones = new DataTable();
            adaHospitalizaciones.Fill(dtHospitalizaciones);
            dataGridView1.DataSource = dtHospitalizaciones;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            habitaciones formulario = new habitaciones();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                altaMedica form = new altaMedica();
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                form.idP = row.Cells[1].Value?.ToString();
                form.idHab = row.Cells[6].Value?.ToString();
                form.nombrePac = row.Cells[2].Value?.ToString();
                form.nombreDoc = row.Cells[7].Value?.ToString();
                form.Show();
            }
            else
            {
                MessageBox.Show("No selecciono ningun paciente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                agregar_cargo form = new agregar_cargo();
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                form.idD = row.Cells[3].Value?.ToString();
                form.nombre = row.Cells[2].Value?.ToString();
                form.idPa = row.Cells[1].Value?.ToString();
                form.Show();
            }
            else
            {
                MessageBox.Show("No selecciono ningun paciente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
