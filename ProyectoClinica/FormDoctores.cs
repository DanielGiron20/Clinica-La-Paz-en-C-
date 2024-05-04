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
    public partial class FormDoctores : Form
    {
        SqlDataAdapter adaDoctores;
        DataTable dtDoctores;

        public FormDoctores()
        {
            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            adaDoctores = new SqlDataAdapter();
            adaDoctores.SelectCommand = new SqlCommand("select * from clinica.doctores", cnx);

            adaDoctores.InsertCommand = new SqlCommand("insert into clinica.doctores values(@id, @nom, @ap, @cedula, @esp, @tel, @correo, @salario, @idConsultorio, @Estado, @fechaR, @precioConsulta)", cnx);
            adaDoctores.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id_doctor");
            adaDoctores.InsertCommand.Parameters.Add("@nom", SqlDbType.VarChar, 50, "nombre");
            adaDoctores.InsertCommand.Parameters.Add("@ap", SqlDbType.VarChar, 50, "apellido");
            adaDoctores.InsertCommand.Parameters.Add("@cedula", SqlDbType.BigInt, 20, "nnumero_cedula");
            adaDoctores.InsertCommand.Parameters.Add("@esp", SqlDbType.VarChar, 50, "especialidad");
            adaDoctores.InsertCommand.Parameters.Add("@tel", SqlDbType.VarChar, 20, "telefono");
            adaDoctores.InsertCommand.Parameters.Add("@correo", SqlDbType.VarChar, 100, "correo_electronico");
            adaDoctores.InsertCommand.Parameters.Add("@salario", SqlDbType.Decimal, 10, "salario");
            adaDoctores.InsertCommand.Parameters.Add("@idConsultorio", SqlDbType.Int, 4, "id_consultorio");
            adaDoctores.InsertCommand.Parameters.Add("@Estado", SqlDbType.VarChar, 20, "estado_laboral");
            adaDoctores.InsertCommand.Parameters.Add("@fechaR", SqlDbType.VarChar, 50, "fecha_registro");
            adaDoctores.InsertCommand.Parameters.Add("@precioConsulta", SqlDbType.BigInt, 20, "precio_consulta");

            adaDoctores.UpdateCommand = new SqlCommand("update clinica.doctores set id_doctor=@id, nombre=@nom, apellido=@ap, nnumero_cedula=@cedula, especialidad=@esp, telefono=@tel, correo_electronico=@correo, salario=@salario, id_consultorio=@idConsultorio, estado_laboral=@Estado, fecha_registro=@fechaR, precio_consulta=@precioConsulta where id_doctor=@id", cnx);
            adaDoctores.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id_doctor");
            adaDoctores.UpdateCommand.Parameters.Add("@nom", SqlDbType.VarChar, 50, "nombre");
            adaDoctores.UpdateCommand.Parameters.Add("@ap", SqlDbType.VarChar, 50, "apellido");
            adaDoctores.UpdateCommand.Parameters.Add("@cedula", SqlDbType.BigInt, 20, "nnumero_cedula");
            adaDoctores.UpdateCommand.Parameters.Add("@esp", SqlDbType.VarChar, 50, "especialidad");
            adaDoctores.UpdateCommand.Parameters.Add("@tel", SqlDbType.VarChar, 20, "telefono");
            adaDoctores.UpdateCommand.Parameters.Add("@correo", SqlDbType.VarChar, 100, "correo_electronico");
            adaDoctores.UpdateCommand.Parameters.Add("@salario", SqlDbType.Decimal, 10, "salario");
            adaDoctores.UpdateCommand.Parameters.Add("@idConsultorio", SqlDbType.Int, 4, "id_consultorio");
            adaDoctores.UpdateCommand.Parameters.Add("@Estado", SqlDbType.VarChar, 20, "estado_laboral");
            adaDoctores.UpdateCommand.Parameters.Add("@fechaR", SqlDbType.VarChar, 50, "fecha_registro");
            adaDoctores.UpdateCommand.Parameters.Add("@precioConsulta", SqlDbType.BigInt, 20, "precio_consulta");

            adaDoctores.DeleteCommand = new SqlCommand("delete from clinica.doctores where id_doctor=@idp", cnx);
            adaDoctores.DeleteCommand.Parameters.Add("@idp", SqlDbType.Int, 4, "id_doctor");


        }

        private void FormDoctores_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dtDoctores = new DataTable();
            adaDoctores.Fill(dtDoctores);
            dataGridView1.DataSource = dtDoctores;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
            string query = "DELETE FROM clinica.doctores WHERE id_doctor = @ID_Paciente";
            SqlCommand command = new SqlCommand(query, cnx);
            command.Parameters.AddWithValue("@ID_Paciente", id);


            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Doctor eliminado con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("No puede eliminarse a un doctor sin acreditarle su nomina", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                pagarDoctor form = new pagarDoctor();
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                form.idDoc = row.Cells[0].Value?.ToString();
                form.nombreDoc = row.Cells[1].Value?.ToString() + " " + row.Cells[2].Value?.ToString();
                form.estado = row.Cells[8].Value?.ToString();
                form.salarioDoc = row.Cells[6].Value?.ToString();
                form.precioCon = row.Cells[10].Value?.ToString();
                form.Show();
            }
            else
            {

                MessageBox.Show("No selecciono ningun Doctor ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedCells[8].Value.ToString() == "Arriendo")
                {
                    pagoArriendo form = new pagoArriendo();
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    form.nombreDoc = row.Cells[1].Value?.ToString() + " " + row.Cells[2].Value?.ToString();
                    form.idCon = row.Cells[7].Value?.ToString();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("El doctor que selecciono trabaja por contrato, no paga arriendo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No selecciono ningun Doctor ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Ingresar_doctores form = new Ingresar_doctores();
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                form.id = selectedRow.Cells[0].Value.ToString();
                form.nombre = selectedRow.Cells[1].Value.ToString();
                form.apellido = selectedRow.Cells[2].Value.ToString();
                form.cedula = selectedRow.Cells[3].Value.ToString();
                form.telefono = selectedRow.Cells[4].Value.ToString();
                form.correo = selectedRow.Cells[5].Value.ToString();
                form.salario = selectedRow.Cells[6].Value.ToString();
                form.idconsultorio = selectedRow.Cells[7].Value.ToString();
                form.estado = selectedRow.Cells[8].Value.ToString();
                form.fecha = selectedRow.Cells[9].Value.ToString();
                form.precio = selectedRow.Cells[10].Value.ToString();
                form.modificar = true;
                form.Show();
            }
            else
            {
                MessageBox.Show("No selecciono ningun Doctor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                registroConsulta form = new registroConsulta();
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                form.nombreDoc = row.Cells[1].Value?.ToString() + " " + row.Cells[2].Value?.ToString();
                form.idDoc = row.Cells[0].Value?.ToString();
                form.Show();
            }
            else
            {
                MessageBox.Show("No selecciono ningun Doctor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            Ingresar_doctores form = new Ingresar_doctores();
            form.Show();
        }
    }
}
