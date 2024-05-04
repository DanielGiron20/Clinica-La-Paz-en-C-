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
    public partial class agendar_cirugia : Form
    {
        public String nombrePasar = "", idPasar = "";
        SqlDataAdapter adaQuirofano;
        DataTable dtQuirofano;
        public agendar_cirugia()
        {
            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            adaQuirofano = new SqlDataAdapter();

            adaQuirofano.SelectCommand = new SqlCommand("select * from clinica.quirofano", cnx);


            int nuevoID = 0;
            string consulta = "SELECT ISNULL(MAX(id_agenda), 0) + 1 AS NuevoID FROM clinica.agendaquirofano";


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

            id.Text = nuevoID.ToString();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dtQuirofano = new DataTable();
            adaQuirofano.Fill(dtQuirofano);
            dataGridView1.DataSource = dtQuirofano;
            nombre.Text = nombrePasar;
            id_pac.Text = idPasar;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            long ida = Convert.ToInt64(id.Text);
            string nombrep = nombre.Text;
            long idp = Convert.ToInt64(id_pac.Text);
            long idq = Convert.ToInt64(id_q.Text);
            string detalles = det.Text; // O también puedes usar el valor del DatePicker si lo prefieres
            string fechao = fecha.Text;
            // Crear la consulta SQL INSERT
            string consultaInsert = "INSERT INTO clinica.agendaquirofano (id_agenda, id_paciente, id_quirofano, fecha, descripcion, nombre_paciente) " +
                                    "VALUES (@id, @id_pac, @id_q, @fecha, @descrip, @nombre_paciente)";


            using (SqlCommand comando = new SqlCommand(consultaInsert, cnx))
            {
                // Agregar parámetros a la consulta SQL
                comando.Parameters.AddWithValue("@id", ida);
                comando.Parameters.AddWithValue("@id_pac", idp);
                comando.Parameters.AddWithValue("@id_q", idq);
                comando.Parameters.AddWithValue("@fecha", fechao);
                comando.Parameters.AddWithValue("@descrip", detalles);
                comando.Parameters.AddWithValue("@nombre_paciente", nombrep);
                try
                {
                       
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cirugia agendada con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos del paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}
