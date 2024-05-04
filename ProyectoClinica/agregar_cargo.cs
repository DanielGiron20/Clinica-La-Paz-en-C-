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


    public partial class agregar_cargo : Form
    {
        public String idPa = "", idD = "", nombre = "";

        public agregar_cargo()
        {
            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            idp_c.Text = idPa;
            idd_c.Text = idD;
            name.Text = nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            long idP = Convert.ToInt64(idp_c.Text);
            long idD = Convert.ToInt64(idd_c.Text);
            string desc = descripcion_c.Text;
            string tipo = tipocargo.Text;
            decimal precio = Convert.ToDecimal(costo_c.Text);
            string nom = name.Text;

            string consultaInsert2 = "INSERT INTO cargos (id_paciente, id_doctor, descripcion_cargo, tipo_cargo, costo, nombre_paciente) " +
                                   "VALUES (@id, @id_d, @desc, @tipocargo, @costo, @name)";
            using (SqlCommand comando = new SqlCommand(consultaInsert2, cnx))
            {
                comando.Parameters.AddWithValue("@id", idP);
                comando.Parameters.AddWithValue("@id_d", idD);
                comando.Parameters.AddWithValue("@desc", desc);
                comando.Parameters.AddWithValue("@tipocargo", tipo);
                comando.Parameters.AddWithValue("@costo", precio);
                comando.Parameters.AddWithValue("@name", nom);


                if (tipocargo.Text == "Consulta Medica" || tipocargo.Text == "Visita del doctor")
                {
                    string consultaInsert3 = "INSERT INTO cargos_doctores (id_paciente, id_doctor, descripcion_cargo, costo) " +
                                       "VALUES (@id_q, @id_d_d, @desc_d, @costo_d)";

                    using (SqlCommand comando2 = new SqlCommand(consultaInsert3, cnx))
                    {
                        comando2.Parameters.AddWithValue("@id_q", idP);
                        comando2.Parameters.AddWithValue("@id_d_d", idD);
                        comando2.Parameters.AddWithValue("@desc_d", desc);
                        comando2.Parameters.AddWithValue("@costo_d", precio);

                        try
                        {
                            comando2.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al insertar cargo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }

                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cargo asignado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar cargo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tipocargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipocargo.Text.Equals("Medicamento "))
            {
                medicamentos form = new medicamentos();
                form.forma = this;
                form.Show();
            }

            if (tipocargo.Text.Equals("Cirugia"))
            {
                agendar_cirugia form = new agendar_cirugia();
                form.nombrePasar = nombre;
                form.idPasar = idPa;
                form.Show();
            }
        }
        public void costo_cSetText(String texto)
        {
            costo_c.Text = texto;
        }
        public void descripcion_cSetText(String texto)
        {
            descripcion_c.Text = texto;
        }
    }
}
