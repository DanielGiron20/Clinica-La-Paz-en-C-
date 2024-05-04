using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoClinica
{
    public partial class FormPacientes : Form
    {

        SqlDataAdapter adaPacientes;
        DataTable dtPacientes;
        public FormPacientes()
        {

            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            adaPacientes = new SqlDataAdapter();
            adaPacientes.SelectCommand = new SqlCommand("select * from clinica.pacientes", cnx);


            adaPacientes.InsertCommand = new SqlCommand("insert into clinica.pacientes values(@id, @nom, @ap, @date, @cedula, @gen, @tel, @det, @idoctor, @consulta, @fechaR)", cnx);
            adaPacientes.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id_paciente");
            adaPacientes.InsertCommand.Parameters.Add("@nom", SqlDbType.VarChar, 50, "nombre");
            adaPacientes.InsertCommand.Parameters.Add("@ap", SqlDbType.VarChar, 50, "apellido");
            adaPacientes.InsertCommand.Parameters.Add("@date", SqlDbType.VarChar, 20, "fecha_nacimiento");
            adaPacientes.InsertCommand.Parameters.Add("@cedula", SqlDbType.BigInt, 20, "numero_cedula");
            adaPacientes.InsertCommand.Parameters.Add("@gen", SqlDbType.VarChar, 10, "genero");
            adaPacientes.InsertCommand.Parameters.Add("@tel", SqlDbType.VarChar, 20, "telefono");
            adaPacientes.InsertCommand.Parameters.Add("@det", SqlDbType.VarChar, 50, "detalles_del_paciente");
            adaPacientes.InsertCommand.Parameters.Add("@idoctor", SqlDbType.Int, 4, "id_doctor");
            adaPacientes.InsertCommand.Parameters.Add("@consulta", SqlDbType.VarChar, 30, "tipo_de_consulta");
            adaPacientes.InsertCommand.Parameters.Add("@fechaR", SqlDbType.VarChar, 50, "fecha_registro");

            adaPacientes.UpdateCommand = new SqlCommand("update clinica.pacientes set  nombre=@nom, apellido=@ap, fecha_nacimiento=@date, numero_cedula=@cedula, genero=@gen, telefono=@tel, detalles_del_paciente=@det, id_doctor=@idoctor, tipo_de_consulta=@consulta, fecha_registro=@fechaR where id_paciente=@id", cnx);
            adaPacientes.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id_paciente");
            adaPacientes.UpdateCommand.Parameters.Add("@nom", SqlDbType.VarChar, 50, "nombre");
            adaPacientes.UpdateCommand.Parameters.Add("@ap", SqlDbType.VarChar, 50, "apellido");
            adaPacientes.UpdateCommand.Parameters.Add("@date", SqlDbType.VarChar, 20, "fecha_nacimiento");
            adaPacientes.UpdateCommand.Parameters.Add("@cedula", SqlDbType.BigInt, 20, "numero_cedula");
            adaPacientes.UpdateCommand.Parameters.Add("@gen", SqlDbType.VarChar, 10, "genero");
            adaPacientes.UpdateCommand.Parameters.Add("@tel", SqlDbType.VarChar, 20, "telefono");
            adaPacientes.UpdateCommand.Parameters.Add("@det", SqlDbType.VarChar, 50, "detalles_del_paciente");
            adaPacientes.UpdateCommand.Parameters.Add("@idoctor", SqlDbType.Int, 4, "id_doctor");
            adaPacientes.UpdateCommand.Parameters.Add("@consulta", SqlDbType.VarChar, 30, "tipo_de_consulta");
            adaPacientes.UpdateCommand.Parameters.Add("@fechaR", SqlDbType.VarChar, 50, "fecha_registro");

            adaPacientes.DeleteCommand = new SqlCommand("delete from clinica.pacientes where id_paciente=@idp", cnx);
            adaPacientes.DeleteCommand.Parameters.Add("@idp", SqlDbType.Int, 4, "id_paciente");

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dtPacientes = new DataTable();
            adaPacientes.Fill(dtPacientes);
            dataGridView1.DataSource = dtPacientes;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
            string query = "DELETE FROM clinica.pacientes WHERE id_paciente = @ID_Paciente";
            SqlCommand command = new SqlCommand(query, cnx);
            command.Parameters.AddWithValue("@ID_Paciente", id);
           

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Paciente eliminado con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("No puede eliminarse a un paciente hospitalizado o con deudas pendientes", "ErroR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            Ingresar_pacientes form = new Ingresar_pacientes();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                hospitalizar form = new hospitalizar();
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];// primer paso
                form.idP = selectedRow.Cells[0].Value.ToString();
                form.nombreP = selectedRow.Cells[1].Value.ToString();
                form.nombreD = selectedRow.Cells[10].Value.ToString();
                form.idD = selectedRow.Cells[8].Value.ToString();
                form.Show();
            }
            else
            {
                MessageBox.Show("No selecciono ningun paciente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Ingresar_pacientes form = new Ingresar_pacientes();
                form.modificar = true;
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];// primer paso
                form.id = selectedRow.Cells[0].Value.ToString();
                form.nombre = selectedRow.Cells[1].Value.ToString();
                form.apellido = selectedRow.Cells[2].Value.ToString();
                form.fecha = selectedRow.Cells[3].Value.ToString();
                form.cedula = selectedRow.Cells[4].Value.ToString();
                form.genero = selectedRow.Cells[5].Value.ToString();
                form.telefono = selectedRow.Cells[6].Value.ToString();
                form.detalle = selectedRow.Cells[7].Value.ToString();
                form.doctor = selectedRow.Cells[8].Value.ToString();
                form.fecharegis = selectedRow.Cells[9].Value.ToString();
                form.nombreDoctor = selectedRow.Cells[10].Value.ToString();

                form.Show();
            }
            else
            {
                MessageBox.Show("No selecciono ningun paciente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                agregar_cargo form = new agregar_cargo();
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                form.nombre = selectedRow.Cells[1].Value.ToString() + " " + selectedRow.Cells[2].Value.ToString();
                form.idPa = selectedRow.Cells[0].Value.ToString();
                form.idD = selectedRow.Cells[8].Value.ToString();

                form.Show();
            }
            else
            {
                MessageBox.Show("No selecciono ningun paciente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                cobrar o = new cobrar();
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                o.nombre = row.Cells[1].Value?.ToString() + " " + row.Cells[2].Value?.ToString();
                o.id = row.Cells[0].Value?.ToString();
                o.Show();
            }
            else
            {
                MessageBox.Show("No selecciono ningun paciente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
