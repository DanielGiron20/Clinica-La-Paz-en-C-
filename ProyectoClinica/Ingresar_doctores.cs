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
    public partial class Ingresar_doctores : Form
    {
        public string id = "", nombre = "", apellido = "", cedula = "", telefono = "", correo = "", salario = "", idconsultorio = "", estado = "", fecha = "", precio = "";
        public Boolean modificar = false;
        public Ingresar_doctores()
        {
            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();

            int nuevoID = 0;
            string consulta = "SELECT ISNULL(MAX(id_doctor), 0) + 1 AS NuevoID FROM clinica.doctores";


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

            id_doctor.Text = nuevoID.ToString();


            string consulta1 = "SELECT id_consultorio FROM consultorios where estado = 'disponible'";

            SqlCommand comando1 = new SqlCommand(consulta1, cnx);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando1);
            DataTable tablaC = new DataTable();

            try
            {

                adaptador.Fill(tablaC);
                consultorio.DataSource = tablaC;
                consultorio.DisplayMember = "id_consultorio";
                consultorio.DropDownStyle = ComboBoxStyle.DropDownList;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar los consultorios: " + ex.Message);
            }



        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                label1.Text = "Modificar paciente";
                id_doctor.Text = id;
                nombre_doctor.Text = nombre;
                apellido_doctor.Text = apellido;
                cedula_doctor.Text = cedula;
                telefono_doctor.Text = telefono;
                correo_doctor.Text = correo;
                estado_doctor.Text = estado;
                salario_doctor.Text = salario;
                precioC_doctor.Text = precio;
                consultorio.Text = idconsultorio;
                button1.Text = "Modificar";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();

            long id = Convert.ToInt64(id_doctor.Text);
            string nombre = nombre_doctor.Text;
            string apellido = apellido_doctor.Text;
            long numeroCedula = Convert.ToInt64(cedula_doctor.Text);
            string telefono = telefono_doctor.Text;
            string correo = correo_doctor.Text;
            string estado = estado_doctor.SelectedItem.ToString();
            decimal salario = Convert.ToDecimal(salario_doctor.Text);
            decimal costo = Convert.ToDecimal(precioC_doctor.Text);
            int cons = Convert.ToInt32(consultorio.Text);
            if (!modificar)
            {


                string consultaInsert = "INSERT INTO clinica.doctores (id_doctor, nombre, apellido, nnumero_cedula, telefono, correo_electronico, salario, id_consultorio, estado_laboral, fecha_registro, precio_consulta) " +
                                        "VALUES (@id, @nombre, @apellido, @numeroCedula, @telefono, @correo, @salario, @id_consultorio, @estado, GETDATE(), @precio)";


                using (SqlCommand comando = new SqlCommand(consultaInsert, cnx))
                {
                    // Agregar parámetros a la consulta SQL
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@apellido", apellido);
                    comando.Parameters.AddWithValue("@numeroCedula", numeroCedula);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@correo", correo);
                    comando.Parameters.AddWithValue("@salario", salario);
                    comando.Parameters.AddWithValue("@id_consultorio", cons);
                    comando.Parameters.AddWithValue("@estado", estado);
                    comando.Parameters.AddWithValue("@precio", costo);

                    try
                    {
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Datos del doctor guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar los datos del doctor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    string consultaInsert2 = "UPDATE consultorios SET estado = 'no disponible' WHERE id_consultorio = @id;";
                    using (SqlCommand comando3 = new SqlCommand(consultaInsert2, cnx))
                    {
                        try
                        {
                            comando3.Parameters.AddWithValue("@id", cons);
                            comando3.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex);
                        }
                    }   

                }
            }
            else
            {

                string consultaInsert = "UPDATE clinica.doctores SET nombre = @nombre, apellido = @apellido, nnumero_cedula = @numeroCedula, telefono = @telefono, correo_electronico = @correo, salario = @salario, id_consultorio = @id_consultorio, estado_laboral = @estado, precio_consulta =  @precio WHERE id_doctor = @id;";


                using (SqlCommand comando = new SqlCommand(consultaInsert, cnx))
                {
                    // Agregar parámetros a la consulta SQL
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@apellido", apellido);
                    comando.Parameters.AddWithValue("@numeroCedula", numeroCedula);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@correo", correo);
                    comando.Parameters.AddWithValue("@salario", salario);
                    comando.Parameters.AddWithValue("@id_consultorio", cons);
                    comando.Parameters.AddWithValue("@estado", estado);
                    comando.Parameters.AddWithValue("@precio", costo);

                    try
                    {
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Datos del doctor guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar los datos del doctor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                string consultaInsert2 = "UPDATE consultorios SET estado = 'no disponible' WHERE id_consultorio = @id;";
                using (SqlCommand comando3 = new SqlCommand(consultaInsert2, cnx))
                {
                    try
                    {
                        comando3.Parameters.AddWithValue("@id", cons);
                        comando3.ExecuteNonQuery();
                    }
                   catch(Exception ex) {
                        MessageBox.Show("Error" + ex);
                            }    
                }

            }
            this.Close();
        }

        }
    } 
