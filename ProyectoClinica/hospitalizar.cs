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
    public partial class hospitalizar : Form
    {
        public String idP = "", idD = "", nombreP = "", nombreD = "";
        public hospitalizar()
        {

            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();

            int nuevoID = 0;
            string consulta = "SELECT ISNULL(MAX(id_hospitalizacion), 0) + 1 AS NuevoID FROM [clinica].[hospitalizaciones]";


            SqlCommand comando = new SqlCommand(consulta, cnx);

            try
            {
                var resultado = comando.ExecuteScalar();
                if (resultado != DBNull.Value)
                {
                    nuevoID = Convert.ToInt32(resultado);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el nuevo ID: " + ex.Message);
            }

            id_h.Text = nuevoID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seleccionar_habitacion form = new seleccionar_habitacion();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            long idH = Convert.ToInt64(id_h.Text);
            string nombre = nombre_h.Text;
            string nombreDoctor = doctor_h.Text;
            long H = Convert.ToInt64(habitacion.Text);
            string causa = motivo.Text;
            long id_pa = Convert.ToInt32(id_paciente_h.Text);
            long id_doc = Convert.ToInt32(id_doctor_h.Text);
            // Crear la consulta SQL INSERT
            string consultaInsert = "INSERT INTO [clinica].[hospitalizaciones] (id_hospitalizacion, id_paciente, nombre_paciente, id_doctor, causa_hopitalizacion, fecha_ingreso, id_habitacion, nombre_doctor) " +
                                    "VALUES (@id, @id_pa, @nombre, @id_doctor, @causa, GETDATE(), @id_h, @nombre_doctor)";


            using (SqlCommand comando = new SqlCommand(consultaInsert, cnx))
            {
                // Agregar parámetros a la consulta SQL
                comando.Parameters.AddWithValue("@id", idH);
                comando.Parameters.AddWithValue("@id_pa", id_pa);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@id_doctor", id_doc);
                comando.Parameters.AddWithValue("@causa", causa);
                comando.Parameters.AddWithValue("@id_h", H);
                comando.Parameters.AddWithValue("@nombre_doctor", nombreDoctor);

                try
                {
                    int nCamaHabitacion = 0;
                    string query = "SELECT n_camas FROM clinica.habitaciones WHERE id_habitacion = @id";

                    SqlCommand command = new SqlCommand(query, cnx);
                    command.Parameters.AddWithValue("@id", H);

                    try
                    {
                        nCamaHabitacion = (int)command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al obtener la cantidad de camas: " + ex.Message);
                    }


                    if (nCamaHabitacion == 0)
                    {

                        MessageBox.Show("La habitación seleccionada está llena. Elija otra habitación.", "Habitación llena", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos del paciente guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string consultaInsert2 = "UPDATE clinica.habitaciones SET n_camas = n_camas - 1 WHERE id_habitacion = @id_h";
                    using (SqlCommand comando2 = new SqlCommand(consultaInsert2, cnx))
                    {
                        comando2.Parameters.AddWithValue("@id_h", H);
                        comando2.ExecuteNonQuery();
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos del paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void hospitalizar_Load(object sender, EventArgs e)
        {
            nombre_h.Text = nombreP;
            doctor_h.Text = nombreD;
            id_doctor_h.Text = idD;
            id_paciente_h.Text = idP;


        }
    }
}
