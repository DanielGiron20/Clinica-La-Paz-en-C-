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
    public partial class FormAdminPrecio : Form
    {
        SqlDataAdapter adaHabitaciones;
        DataTable dtHabitaciones;

        SqlDataAdapter adaConsultorios;
        DataTable dtConsultorios;

        public FormAdminPrecio()
        {
            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            adaHabitaciones = new SqlDataAdapter();
            adaHabitaciones.SelectCommand = new SqlCommand("select * from clinica.habitaciones", cnx);
            adaConsultorios = new SqlDataAdapter();
            adaConsultorios.SelectCommand = new SqlCommand("select * from consultorios", cnx);

            adaHabitaciones.UpdateCommand = new SqlCommand("update clinica.habitaciones set  tipo_habitacion=@nom, n_camas=@ap, costo=@date WHERE  id_habitacion = @idH", cnx);
            adaHabitaciones.UpdateCommand.Parameters.Add("@idH", SqlDbType.Int, 4, "id_habitacion");
            adaHabitaciones.UpdateCommand.Parameters.Add("@nom", SqlDbType.VarChar, 50, "tipo_habitacion");
            adaHabitaciones.UpdateCommand.Parameters.Add("@ap", SqlDbType.Int, 4, "n_camas");
            adaHabitaciones.UpdateCommand.Parameters.Add("@date", SqlDbType.Int, 4, "costo");


            adaConsultorios.UpdateCommand = new SqlCommand("update consultorios set  costo = @costo, estado=@estado where id_consultorio=@id", cnx);
            adaConsultorios.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id_consultorio");
            adaConsultorios.UpdateCommand.Parameters.Add("@costo", SqlDbType.Int, 4, "costo");
            adaConsultorios.UpdateCommand.Parameters.Add("@estado", SqlDbType.VarChar, 50, "estado");


        }

        private void FormAdminPrecio_Load(object sender, EventArgs e)
        {
           

            dtHabitaciones = new DataTable();
            adaHabitaciones.Fill(dtHabitaciones);
            dataGridView1.DataSource = dtHabitaciones;

            dtConsultorios = new DataTable();
            adaConsultorios.Fill(dtConsultorios);
            dataGridView2.DataSource = dtConsultorios;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                adaHabitaciones.Update(dtHabitaciones);
                MessageBox.Show("Informacion salvada satisfactoriamente ", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                adaConsultorios.Update(dtConsultorios);
                MessageBox.Show("Informacion salvada satisfactoriamente ", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
