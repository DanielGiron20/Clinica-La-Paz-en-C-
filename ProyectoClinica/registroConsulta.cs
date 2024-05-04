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
    public partial class registroConsulta : Form
    {
        public String nombreDoc = "", idDoc = "";
        public registroConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void registroConsulta_Load(object sender, EventArgs e)
        {
            nombre.Text = nombreDoc;
            id_d.Text = idDoc;

            if (id_d.Text != null)
            {
                try
                {
                    Class1 ob = new Class1();
                    SqlConnection cnx = ob.establecerConexion();
                    int id = Convert.ToInt32(id_d.Text);
                    string query = "SELECT * FROM clinica.pacientes WHERE id_doctor = @ID_doctor";
                    SqlCommand command = new SqlCommand(query, cnx);
                    command.Parameters.AddWithValue("@ID_doctor", id);

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
    }
}
