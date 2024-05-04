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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoClinica
{
    public partial class medicamentos : Form
    {
        public agregar_cargo forma;
        SqlDataAdapter adaFarmacia;
        DataTable dtFarmacia;
        public medicamentos()
        {
            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            adaFarmacia = new SqlDataAdapter();
            adaFarmacia.SelectCommand = new SqlCommand("select * from clinica.farmacia", cnx);


        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dtFarmacia = new DataTable();
            adaFarmacia.Fill(dtFarmacia);
            dataGridView1.DataSource = dtFarmacia;
        }

        private void can_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(can.Text, out decimal cantidad) && dataGridView1.SelectedRows.Count > 0)
            {
                int indiceFilaSeleccionada = dataGridView1.SelectedRows[0].Index;
                if (dataGridView1.Rows[indiceFilaSeleccionada].Cells[4].Value != null &&
                    decimal.TryParse(dataGridView1.Rows[indiceFilaSeleccionada].Cells[4].Value.ToString(), out decimal precio))
                {
                    decimal costoTotal = cantidad * precio;
                    tot.Text = costoTotal.ToString();
                }
                else
                {
                    MessageBox.Show("El precio del medicamento no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                tot.Text = ""; // Limpiar si la cantidad es inválida o no hay fila seleccionada
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                forma.costo_cSetText(tot.Text);
                forma.descripcion_cSetText("Medicamento recetado");
            }
            this.Close();
        }
    }
}
