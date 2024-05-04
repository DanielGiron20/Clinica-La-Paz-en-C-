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
    public partial class pagoArriendo : Form
    {

        public String nombreDoc = "", idCon = "";
        public pagoArriendo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CalcularCambio()
        {
            if (!string.IsNullOrEmpty(total.Text) && !string.IsNullOrEmpty(monto.Text))
            {
                if (decimal.TryParse(total.Text, out decimal total1) && decimal.TryParse(monto.Text, out decimal monto1))
                {
                    decimal cambio1 = monto1 - total1;
                    cambio.Text = cambio1.ToString();
                }
                else
                {
                    // Mostrar un mensaje de error si los valores no son numéricos válidos
                    MessageBox.Show("Por favor, ingresa valores numéricos válidos en los campos.");
                }
            }
        }
        private void Calculartotal()
        {
            if (!string.IsNullOrEmpty(costo_c.Text) && !string.IsNullOrEmpty(meses.Text))
            {
                if (decimal.TryParse(costo_c.Text, out decimal total1) && decimal.TryParse(meses.Text, out decimal monto1))
                {
                    decimal cambio1 = (total1 * monto1);
                    total.Text = cambio1.ToString();
                }
                else
                {
                    // Mostrar un mensaje de error si los valores no son numéricos válidos
                    MessageBox.Show("Por favor, ingresa valores numéricos válidos en los campos.");
                }
            }
        }

        private void monto_TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }

        private void meses_TextChanged(object sender, EventArgs e)
        {
            Calculartotal();
        }

        private void pagoArriendo_Load(object sender, EventArgs e)
        {
            nombre_d.Text = nombreDoc;
            id_c.Text = idCon;


            if (id_c.Text != null)
            {
                Class1 ob = new Class1();
                SqlConnection cnx = ob.establecerConexion();
                decimal costoC = 0;
                int idC = Convert.ToInt32(id_c.Text);
                string consultaCosto = "SELECT costo FROM consultorios WHERE id_consultorio = @idC";


                using (SqlCommand comandoCosto = new SqlCommand(consultaCosto, cnx))
                {
                    comandoCosto.Parameters.AddWithValue("@idC", idC);

                    try
                    {
                        object resultadoConsulta = comandoCosto.ExecuteScalar();

                        // Verificar si se obtuvo algún resultado y asignar el costo por consulta
                        if (resultadoConsulta != null && resultadoConsulta != DBNull.Value)
                        {
                            costoC = Convert.ToDecimal(resultadoConsulta);
                            costo_c.Text = costoC.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al obtener el costo del consultorio: " + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago realizado con Exito");
            Form3 form = new Form3();
            form.nombreDoc = nombre_d.Text;
            form.costoCon = costo_c.Text;
            form.totalPago = total.Text;
            form.idCon = id_c.Text;
            form.mesesp = meses.Text;
            form.Show();    
            this.Close();

        }
    }
}
