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
    public partial class FormAgenda : Form
    {
        SqlDataAdapter adaAgenda;
        DataTable dtAgenda;
        public FormAgenda()
        {
            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            adaAgenda = new SqlDataAdapter();
            adaAgenda.SelectCommand = new SqlCommand("select * from clinica.agendaquirofano", cnx);


        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtAgenda = new DataTable();
            adaAgenda.Fill(dtAgenda);
            dataGridView1.DataSource = dtAgenda;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            int nuevoID = 0;
            string consulta = "SELECT ISNULL(MAX(id_operacion), 0) + 1 AS NuevoID FROM clinica.operaciones";


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

            long id = nuevoID;
            int idp = Convert.ToInt32(dataGridView1.SelectedCells[2].Value);
            string desc = dataGridView1.SelectedCells[4].Value.ToString();
            int idc = Convert.ToInt32(dataGridView1.SelectedCells[1].Value);
            string name = dataGridView1.SelectedCells[5].Value.ToString();
            string consultaInsert = "INSERT INTO clinica.operaciones (id_operacion, id_paciente, descripcion, id_quirofano, nombre_paciente) " +
                                    "VALUES (@id, @id_paciente, @descripcion, @id_quirofano, @nombre_paciente)";

            using (SqlCommand comando2 = new SqlCommand(consultaInsert, cnx))
            {
                // Agregar parámetros a la consulta SQL
                comando2.Parameters.AddWithValue("@id", id);
                comando2.Parameters.AddWithValue("@id_paciente", idp);
                comando2.Parameters.AddWithValue("@descripcion", desc);
                comando2.Parameters.AddWithValue("@id_quirofano", idc);
                comando2.Parameters.AddWithValue("@nombre_paciente", name);


                try
                {
                    comando2.ExecuteNonQuery();
                    MessageBox.Show("Paciente enviado al quirofano con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al enviar al paciente a operacion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            int ida = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
            string query = "DELETE FROM clinica.agendaquirofano WHERE id_agenda = @ID_a";
            SqlCommand command = new SqlCommand(query, cnx);
            command.Parameters.AddWithValue("@ID_a", ida);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Paciente retirado con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error al retirar el paciente.", "Érror", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int ido = Convert.ToInt32(dataGridView1.SelectedCells[1].Value);
            string query2 = "UPDATE clinica.quirofano SET estado = 'No disponible' WHERE id_quirofano = @ID_q";
            SqlCommand command2 = new SqlCommand(query2, cnx);
            command2.Parameters.AddWithValue("@ID_q", ido);
            try
            {
                command2.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Error al actualizar el quirofano." + e, "Érror", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
