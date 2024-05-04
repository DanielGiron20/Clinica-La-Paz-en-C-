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
    public partial class Ingresar_pacientes : Form
    {
        public Boolean modificar=false;
        public string id="", nombre="", apellido="", fecha = "", cedula = "", genero = "", telefono = "", detalle = "", doctor = "", fecharegis = "", nombreDoctor = "";
        public Ingresar_pacientes()
        {
            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();

            int nuevoID = 0;
            string consulta = "SELECT ISNULL(MAX(id_paciente), 0) + 1 AS NuevoID FROM clinica.pacientes";


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

            id_paciente.Text = nuevoID.ToString();


            string consulta1 = "SELECT nombre FROM clinica.doctores";


            SqlCommand comando1 = new SqlCommand(consulta1, cnx);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando1);
            DataTable tablaDoctores = new DataTable();

            try
            {

                adaptador.Fill(tablaDoctores);
                doctorR_paciente.DataSource = tablaDoctores;
                doctorR_paciente.DisplayMember = "nombre";
                doctorR_paciente.DropDownStyle = ComboBoxStyle.DropDownList;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar nombres de doctores: " + ex.Message);
            }


        }

        private void cmd_ingresar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                Class1 ob = new Class1();
                SqlConnection cnx = ob.establecerConexion();
                long id = Convert.ToInt64(id_paciente.Text);
                string nombre = nombre_paciente.Text;
                string apellido = apellido_paciente.Text;
                string fechaNacimiento = fechaN_paciente.Text; // O también puedes usar el valor del DatePicker si lo prefieres
                long numeroCedula = Convert.ToInt64(cedula_paciente.Text);
                string genero = genero_paciente.SelectedItem.ToString();
                string telefono = telefono_paciente.Text;
                string detallesPaciente = detalles_paciente.Text;
                string Nombre_doctor = doctorR_paciente.Text; // Asumiendo que el ComboBox tiene un DataSource vinculado con los doctores y el ValueMember es el id_doctor
                long id_doc = Convert.ToInt32(id_doctor.Text);
                // Crear la consulta SQL INSERT
                string consultaInsert = "UPDATE clinica.pacientes SET nombre=@nombre, apellido= @apellido, fecha_nacimiento= @fechaNacimiento, numero_cedula=@numeroCedula, genero= @genero, telefono= @telefono, detalles_del_paciente= @detallesPaciente, id_doctor= @idDoctor, nombre_doctor=@nombre_doctor WHERE id_paciente = @id ;";
                using (SqlCommand comando = new SqlCommand(consultaInsert, cnx))
                {
                    // Agregar parámetros a la consulta SQL
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@apellido", apellido);
                    comando.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                    comando.Parameters.AddWithValue("@numeroCedula", numeroCedula);
                    comando.Parameters.AddWithValue("@genero", genero);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@detallesPaciente", detallesPaciente);
                    comando.Parameters.AddWithValue("@idDoctor", id_doc);
                    comando.Parameters.AddWithValue("@nombre_doctor", Nombre_doctor);
                    try
                    {
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Datos del paciente guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar los datos del paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                Class1 ob = new Class1();
                SqlConnection cnx = ob.establecerConexion();
                long id = Convert.ToInt64(id_paciente.Text);
                string nombre = nombre_paciente.Text;
                string apellido = apellido_paciente.Text;
                string fechaNacimiento = fechaN_paciente.Text; // O también puedes usar el valor del DatePicker si lo prefieres
                long numeroCedula = Convert.ToInt64(cedula_paciente.Text);
                string genero = genero_paciente.SelectedItem.ToString();
                string telefono = telefono_paciente.Text;
                string detallesPaciente = detalles_paciente.Text;
                string Nombre_doctor = doctorR_paciente.Text; // Asumiendo que el ComboBox tiene un DataSource vinculado con los doctores y el ValueMember es el id_doctor
                long id_doc = Convert.ToInt32(id_doctor.Text);
                // Crear la consulta SQL INSERT
                string consultaInsert = "INSERT INTO clinica.pacientes (id_paciente, nombre, apellido, fecha_nacimiento, numero_cedula, genero, telefono, detalles_del_paciente, id_doctor, fecha_registro, nombre_doctor) " +
                                        "VALUES (@id, @nombre, @apellido, @fechaNacimiento, @numeroCedula, @genero, @telefono, @detallesPaciente, @idDoctor, GETDATE(), @nombre_doctor)";


                using (SqlCommand comando = new SqlCommand(consultaInsert, cnx))
                {
                    // Agregar parámetros a la consulta SQL
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@apellido", apellido);
                    comando.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                    comando.Parameters.AddWithValue("@numeroCedula", numeroCedula);
                    comando.Parameters.AddWithValue("@genero", genero);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@detallesPaciente", detallesPaciente);
                    comando.Parameters.AddWithValue("@idDoctor", id_doc);
                    comando.Parameters.AddWithValue("@nombre_doctor", Nombre_doctor);
                    try
                    {
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Datos del paciente guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar los datos del paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                string consultaInsert2 = "INSERT INTO cargos (id_paciente, id_doctor, descripcion_cargo, tipo_cargo, costo) " +
                                   "VALUES (@id, @id_d, @desc, @tipocargo, @costo)";
                using (SqlCommand comando = new SqlCommand(consultaInsert2, cnx))
                {
                    decimal costoConsulta = 0;
                    string consultaCosto = "SELECT precio_consulta FROM clinica.doctores WHERE id_doctor = @idDoctor";


                    using (SqlCommand comandoCosto = new SqlCommand(consultaCosto, cnx))
                    {
                        comandoCosto.Parameters.AddWithValue("@idDoctor", id_doc);

                        try
                        {
                            object resultadoConsulta = comandoCosto.ExecuteScalar();

                            // Verificar si se obtuvo algún resultado y asignar el costo por consulta
                            if (resultadoConsulta != null && resultadoConsulta != DBNull.Value)
                            {
                                costoConsulta = Convert.ToDecimal(resultadoConsulta);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error al obtener el costo por consulta: " + ex.Message);
                        }
                    }


                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@id_d", id_doc);
                    comando.Parameters.AddWithValue("@desc", "Consulta Medica");
                    comando.Parameters.AddWithValue("@tipocargo", "Consulta medica");
                    comando.Parameters.AddWithValue("@costo", costoConsulta);
                    try
                    {
                        comando.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar cargo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                string consultaInsert3 = "INSERT INTO cargos_doctores (id_paciente, id_doctor, descripcion_cargo, costo) " +
                                       "VALUES (@id, @id_d, @desc, @costo)";
                using (SqlCommand comando = new SqlCommand(consultaInsert3, cnx))
                {
                    decimal costoConsulta = 0;
                    string consultaCosto = "SELECT precio_consulta FROM clinica.doctores WHERE id_doctor = @idDoctor";


                    using (SqlCommand comandoCosto = new SqlCommand(consultaCosto, cnx))
                    {
                        comandoCosto.Parameters.AddWithValue("@idDoctor", id_doc);

                        try
                        {
                            object resultadoConsulta = comandoCosto.ExecuteScalar();

                            // Verificar si se obtuvo algún resultado y asignar el costo por consulta
                            if (resultadoConsulta != null && resultadoConsulta != DBNull.Value)
                            {
                                costoConsulta = Convert.ToDecimal(resultadoConsulta);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error al obtener el costo por consulta: " + ex.Message);
                        }
                    }


                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@id_d", id_doc);
                    comando.Parameters.AddWithValue("@desc", "Consulta Medica");
                    comando.Parameters.AddWithValue("@costo", costoConsulta);
                    try
                    {
                        comando.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar cargo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            this.Close();   
        }

        private void id_doctor_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctorR_paciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doctorR_paciente.SelectedIndex != -1)
            {
                Class1 ob = new Class1();
                SqlConnection cnx = ob.establecerConexion();
                string consulta3 = "SELECT id_doctor FROM clinica.doctores WHERE nombre = @nombreDoctor";
                string nom = doctorR_paciente.Text;
                SqlCommand comando3 = new SqlCommand(consulta3, cnx);
                comando3.Parameters.AddWithValue("@nombreDoctor", nom);

                try
                {
                    var idDoctor = comando3.ExecuteScalar();

                    if (idDoctor != null)
                    {
                        id_doctor.Text = idDoctor.ToString();
                    }
                    else
                    {
                        id_doctor.Text = "No se encontró el ID";
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    MessageBox.Show("Error al obtener el ID del doctor: " + ex.Message);
                }

            }


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                label1.Text = "Modificar Pacientes";
                id_paciente.Text = id;
                nombre_paciente.Text = nombre;
                apellido_paciente.Text = apellido;
                fechaN_paciente.Text = fecha;
                cedula_paciente.Text = cedula;
                genero_paciente.Text = genero;
                telefono_paciente.Text = telefono;
                doctorR_paciente.Text = nombreDoctor;
                id_doctor.Text = doctor;
                fehca_registro.Text = fecharegis;
                detalles_paciente.Text =detalle;
                cmd_ingresar.Text = "Modificar" ;
            }
        }
    }
}
