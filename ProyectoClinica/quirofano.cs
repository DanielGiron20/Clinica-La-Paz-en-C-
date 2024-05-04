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
    public partial class quirofano : Form
    {
        SqlDataAdapter adaOperaciones;
        DataTable dtOperaciones;
        public quirofano()
        {
            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            adaOperaciones = new SqlDataAdapter();
            adaOperaciones.SelectCommand = new SqlCommand("select * from clinica.operaciones", cnx);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dtOperaciones = new DataTable();
            adaOperaciones.Fill(dtOperaciones);
            dataGridView1.DataSource = dtOperaciones;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
            int idq = Convert.ToInt32(dataGridView1.SelectedCells[3].Value);
            string query = "DELETE FROM clinica.operaciones WHERE id_operacion = @ID_OP";
            SqlCommand command = new SqlCommand(query, cnx);
            command.Parameters.AddWithValue("@ID_OP", id);
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

            string query2 = "UPDATE clinica.quirofano SET estado = 'Disponible' WHERE id_quirofano = @ID_q";
            SqlCommand command2 = new SqlCommand(query2, cnx);
            command2.Parameters.AddWithValue("@ID_q", idq);
            try
            {
                command2.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Error al retirar al actualizar el quirofano." + e, "Érror", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }
    }
}
