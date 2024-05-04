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
    public partial class pagarDoctor : Form
    {
        public String idDoc = "", nombreDoc = "", estado = "", salarioDoc = "", precioCon = "";
        public pagarDoctor()
        {
            InitializeComponent();
            label8.Visible = false; 
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            int id = Convert.ToInt32(id_d.Text);
            string query = "DELETE FROM cargos_doctores WHERE id_doctor = @ID_doctor";
            SqlCommand command = new SqlCommand(query, cnx);
            command.Parameters.AddWithValue("@ID_doctor", id);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Pago realizado con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Form2 form = new Form2();
                form.idDoc = id_d.Text;
                form.totalPagar = total.Text;
                form.nombreDoc = nombre_d.Text;
                form.Show();
                this.Close();
            }

            catch
            {
                MessageBox.Show("Error al emitir pago.", "Érror", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void pagarDoctor_Load(object sender, EventArgs e)
        {
            nombre_d.Text = nombreDoc;
            id_d.Text = idDoc;
            estado_d.Text = estado;
            salario_d.Text = salarioDoc;
            precioC.Text = precioCon;



            if (id_d.Text != null)
            {
                try
                {
                    Class1 ob = new Class1();
                    SqlConnection cnx = ob.establecerConexion();
                    int id = Convert.ToInt32(id_d.Text);
                    string query = "SELECT * FROM cargos_doctores WHERE id_doctor = @ID_Paciente";
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
                if (row.Cells[4].Value != null &&
                    decimal.TryParse(row.Cells[4].Value.ToString(), out decimal costo))
                {
                    suma += costo;
                }
            }

            if (estado_d.Text == "Contratado")
            {
                total.Text = salario_d.Text;
            }
            if (estado_d.Text == "Arriendo")
            {
                total.Text = suma.ToString();
            }
        }
    }
}
