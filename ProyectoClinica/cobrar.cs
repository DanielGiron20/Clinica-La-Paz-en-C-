using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoClinica
{
    public partial class cobrar : Form
    {
        public String id = "", nombre = "";
        public cobrar()
        {
            InitializeComponent();
            CargarDatosCargo();
            descripciones.Visible = false;

        }

        public void CargarDatosCargo()
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            id_p.Text = id;
            pac.Text = nombre;

            if (id_p.Text != null)
            {
                try
                {
                    Class1 ob = new Class1();
                    SqlConnection cnx = ob.establecerConexion();
                    int id = Convert.ToInt32(id_p.Text);
                    string query = "SELECT * FROM cargos WHERE id_paciente = @ID_Paciente";
                    SqlCommand command = new SqlCommand(query, cnx);
                    command.Parameters.AddWithValue("@ID_Paciente", id);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }

            decimal suma = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[5].Value != null &&
                    decimal.TryParse(row.Cells[5].Value.ToString(), out decimal costo))
                {
                    suma += costo;
                }
                total.Text = suma.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void Cambio_TextChanged(object sender, EventArgs e)
        {


        }

        private void monto_TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }
        private void CalcularCambio()
        {
            if (!string.IsNullOrEmpty(total.Text) && !string.IsNullOrEmpty(monto.Text))
            {
                if (decimal.TryParse(total.Text, out decimal total1) && decimal.TryParse(monto.Text, out decimal monto1))
                {
                    decimal cambio1 = monto1 - total1;
                    Cambio.Text = cambio1.ToString();
                }
                else
                {
                    // Mostrar un mensaje de error si los valores no son numéricos válidos
                    MessageBox.Show("Por favor, ingresa valores numéricos válidos en los campos.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Cambio.Text) && decimal.TryParse(Cambio.Text, out decimal cambio))
            {
                if (cambio >= 0)
                {
                    Class1 ob = new Class1();
                    SqlConnection cnx = ob.establecerConexion();
                    int id = Convert.ToInt32(id_p.Text);
                    string query = "DELETE FROM cargos WHERE id_paciente = @ID_Paciente";
                    SqlCommand command = new SqlCommand(query, cnx);
                    command.Parameters.AddWithValue("@ID_Paciente", id);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cuenta saldada con Exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("¡Monto insuficiente! El cambio es negativo. Por favor, ingresa un monto adecuado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, calcula el cambio antes de realizar el pago.");
            }


            string informacionOrdenada = "";

            // Recorre todas las filas del DataGridView y agrega la descripción y el costo de cada servicio a la cadena
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow) // Verifica que no sea la fila nueva (si la hay)
                {
                    string descripcion = row.Cells["descripcion_cargo"].Value.ToString(); // Reemplaza "Nombre_Columna_Descripcion" con el nombre real de la columna de descripción
                    decimal costo = Convert.ToDecimal(row.Cells["costo"].Value); // Reemplaza "Nombre_Columna_Costo" con el nombre real de la columna de costo
                    informacionOrdenada += $"{descripcion}................................{costo} Lps\n";
                   
                }
                descripciones.Text = informacionOrdenada;

            }

            Form1 form = new Form1();
            StringBuilder cuentaC = new StringBuilder();

            form.idPac = id_p.Text;
            form.totalPagar = total.Text;
            form.nombrePac = pac.Text;
            form.cambio = Cambio.Text;
            form.montoRecibido = monto.Text;
            form.cuenta = informacionOrdenada;
            form.Show();
            this.Close();

        }
    }
}
