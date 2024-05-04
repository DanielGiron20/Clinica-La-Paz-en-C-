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
    public partial class altaMedica : Form
    {
        public String idP = "", idHab = "", nombrePac = "", nombreDoc = "";

        public altaMedica()
        {
            InitializeComponent();
            id_p.Visible = false;
            idH.Visible = false;
            label11.Visible = false;    

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            id_p.Text = idP;
            pac.Text = nombrePac;
            idH.Text = idHab;
            doc.Text = nombreDoc;

            if (!string.IsNullOrEmpty(idH.Text))
            {
                Class1 ob = new Class1();
                SqlConnection cnx = ob.establecerConexion();
                int idHabitacion = Convert.ToInt32(idH.Text);
                decimal precioHabitacion = 0;
                string consultaCosto = "SELECT costo FROM clinica.habitaciones WHERE id_habitacion = @idH";


                using (SqlCommand comandoCosto = new SqlCommand(consultaCosto, cnx))
                {
                    comandoCosto.Parameters.AddWithValue("@idH", idHabitacion);

                    try
                    {
                        object resultadoConsulta = comandoCosto.ExecuteScalar();

                        if (resultadoConsulta != null && resultadoConsulta != DBNull.Value)
                        {
                            precioHabitacion = Convert.ToDecimal(resultadoConsulta);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al obtener el costo por consulta: " + ex.Message);
                    }
                }


                if (precioHabitacion > 0)
                {
                    costodia.Text = precioHabitacion.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró el precio de la habitación para el ID proporcionado.");
                    costodia.Text = string.Empty;
                }
            }
            else
            {
                costodia.Text = string.Empty;
            }


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


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dias_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(costodia.Text) && !string.IsNullOrEmpty(dias.Text))
            {
                if (decimal.TryParse(costodia.Text, out decimal costoPorHabitacion) &&
                    int.TryParse(dias.Text, out int cantidadDias))
                {
                    decimal costoTotal = costoPorHabitacion * cantidadDias;
                    total_h.Text = costoTotal.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa valores numéricos válidos en los campos.");
                }
            }
            else
            {
                total_h.Text = string.Empty;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal suma = 0;
            decimal costoH = Convert.ToDecimal(total_h.Text);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[5].Value != null &&
                    decimal.TryParse(row.Cells[5].Value.ToString(), out decimal costo))
                {
                    suma += costo;
                }
                decimal totalT = (costoH + suma);
                total.Text = totalT.ToString();
            }
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

        private void monto_TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cambio.Text) && decimal.TryParse(cambio.Text, out decimal Cambio))
            {
                if (Cambio >= 0)
                {
                    Class1 ob = new Class1();
                    SqlConnection cnx = ob.establecerConexion();
                    int id = Convert.ToInt32(id_p.Text);
                    string query = "DELETE FROM cargos WHERE id_paciente = @ID_Paciente";
                    SqlCommand command = new SqlCommand(query, cnx);
                    command.Parameters.AddWithValue("@ID_Paciente", id);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cuenta saldada con Exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    total_h.Text = "";
                    dias.Text = "";
                    total.Text = "";
                    monto.Text = "";
                    cambio.Text = "";
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
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow) // Verifica que no sea la fila nueva (si la hay)
                {
                    string descripcion = row.Cells["descripcion_cargo"].Value.ToString(); // Reemplaza "Nombre_Columna_Descripcion" con el nombre real de la columna de descripción
                    decimal costo = Convert.ToDecimal(row.Cells["costo"].Value); // Reemplaza "Nombre_Columna_Costo" con el nombre real de la columna de costo
                    informacionOrdenada += $"{descripcion}................................{costo} Lps\n";

                }
                label11.Text = informacionOrdenada;

            }


            Form1 form = new Form1();
            form.idPac = id_p.Text;
            form.totalPagar = total.Text;
            form.nombrePac = pac.Text;
            form.cambio = cambio.Text;
            form.montoRecibido = monto.Text;
            form.cuenta = informacionOrdenada;
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool tieneDeudas = false;

            try
            {
                Class1 ob = new Class1();
                SqlConnection cnx = ob.establecerConexion();
                int id = Convert.ToInt32(id_p.Text);
                string query = "SELECT COUNT(*) FROM cargos WHERE id_paciente = @ID";
                SqlCommand command = new SqlCommand(query, cnx);
                command.Parameters.AddWithValue("@ID", id);
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    tieneDeudas = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar deudas: " + ex.Message);
            }

            if (tieneDeudas == true)
            {
                Class1 ob = new Class1();
                SqlConnection cnx = ob.establecerConexion();
                int id = Convert.ToInt32(id_p.Text);
                int iddoc = 1;
                string descript = "Costo por habitacion";
                string tipo = "Hospedaje";
                decimal costo = Convert.ToDecimal(total_h.Text);
                string consultaInsert3 = "INSERT INTO cargos (id_paciente, id_doctor, descripcion_cargo, tipo_cargo, costo) " +
                                           "VALUES (@id, @id_d, @desc,@tipo_cargo, @costo)";
                using (SqlCommand comando = new SqlCommand(consultaInsert3, cnx))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@id_d", iddoc);
                    comando.Parameters.AddWithValue("@desc", descript);
                    comando.Parameters.AddWithValue("@tipo_cargo", tipo);
                    comando.Parameters.AddWithValue("@costo", costo);
                    try
                    {
                        comando.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar cargo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                string query = "DELETE FROM clinica.hospitalizaciones WHERE id_paciente = @ID_Paciente";
                SqlCommand command = new SqlCommand(query, cnx);
                command.Parameters.AddWithValue("@ID_Paciente", id);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Paciente dado de alta con Exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                catch
                {
                    MessageBox.Show("Error al dar de alta al paciente.", "Érror", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int id1 = Convert.ToInt32(idH.Text);
                string query2 = "UPDATE clinica.habitaciones SET n_camas = n_camas + 1 WHERE id_habitacion = @ID_H";
                SqlCommand command2 = new SqlCommand(query2, cnx);
                command2.Parameters.AddWithValue("@ID_H", id1);


                try
                {
                    command2.ExecuteNonQuery();
                }

                catch
                {
                    MessageBox.Show("Error al actualizar los cupos de la habitacion.", "Érror", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }

            else
            {
                Class1 ob = new Class1();
                SqlConnection cnx = ob.establecerConexion();
                int id = Convert.ToInt32(id_p.Text);
                string query = "DELETE FROM clinica.hospitalizaciones WHERE id_paciente = @ID_Paciente";
                SqlCommand command = new SqlCommand(query, cnx);
                command.Parameters.AddWithValue("@ID_Paciente", id);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Paciente dado de alta con Exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                catch
                {
                    MessageBox.Show("Error al dar de alta al paciente.", "Érror", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int id1 = Convert.ToInt32(idH.Text);
                string query2 = "UPDATE clinica.habitaciones SET n_camas = n_camas + 1 WHERE id_habitacion = @ID_H";
                SqlCommand command2 = new SqlCommand(query2, cnx);
                command2.Parameters.AddWithValue("@ID_H", id1);


                try
                {
                    command2.ExecuteNonQuery();
                }

                catch
                {
                    MessageBox.Show("Error al actualizar los cupos de la habitacion.", "Érror", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }



        }
    }
}
