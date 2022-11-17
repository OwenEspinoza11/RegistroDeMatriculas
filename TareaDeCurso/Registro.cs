using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaDeCurso
{
    public partial class Registro : Form
    {


        public Registro()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }


        // Capturar los datos del formulario
        private void CapturaDatos()
        {


            DatosEstudiante.NTelefono = int.Parse(txtTelefono.Text);
            DatosEstudiante.FechaNacimiento = int.Parse(txtFechaNacimiento.Text);
            DatosEstudiante.Nombre = txtNombre.Text;
            DatosEstudiante.Apellido = txtApellido.Text;
            DatosEstudiante.Sexo = txtSexo.Text;
            DatosEstudiante.Direccion = txtDireccion.Text;
            DatosEstudiante.Cedula = txtCedula.Text;
            DatosEstudiante.Correo = txtCorreo.Text;
            DatosEstudiante.Departamento = txtDepartamento.Text;
            DatosEstudiante.Colegio = txtColegio.Text;

            DatosExamen.FechaExamen = int.Parse(mtxtFechaExamen.Text);
            DatosExamen.Aula = int.Parse(txtAula.Text);
            DatosExamen.Lugar = txtLugar.Text;
            DatosExamen.Carrera = txtCarrera.Text;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Valida() == "")
            {
                CapturaDatos();

                ImprimirDatos();
            }
            else
                MessageBox.Show("El error se encuentra en " + Valida());

        }



        private void ImprimirDatos()
        {

            ListViewItem fila = new ListViewItem(DatosEstudiante.Nombre.ToString());
            fila.SubItems.Add(DatosEstudiante.Apellido);
            fila.SubItems.Add(DatosEstudiante.Sexo);
            fila.SubItems.Add(DatosEstudiante.FechaNacimiento.ToString("00-00-0000"));
            fila.SubItems.Add(DatosEstudiante.Direccion);
            fila.SubItems.Add(DatosEstudiante.NTelefono.ToString("00000000"));
            fila.SubItems.Add(DatosEstudiante.Cedula);
            fila.SubItems.Add(DatosEstudiante.Correo);
            fila.SubItems.Add(DatosEstudiante.Departamento);
            fila.SubItems.Add(DatosEstudiante.Colegio);
            fila.SubItems.Add(DatosExamen.FechaExamen.ToString("00-00-0000 00:00"));
            fila.SubItems.Add(DatosExamen.Lugar);
            fila.SubItems.Add(DatosExamen.Aula.ToString("0000"));
            fila.SubItems.Add(DatosExamen.Carrera);
            lvDatos.Items.Add(fila);
        }


        //Validación de los datos
        private string Valida()
        {
            if (txtNombre.Text.Trim().Length == 0)
            {
                txtNombre.Focus();
                return "nombre estudiante";
            }
            else if (txtApellido.Text.Trim().Length == 0)
            {
                txtApellido.Focus();
                return "apellido del estudiante";
            }
            else if (txtCedula.Text.Trim().Length == 0)
            {
                txtCedula.Focus();
                return "cédula del estudiante";
            }
            else if (txtSexo.Text.Trim().Length == 0)
            {
                txtSexo.Focus();
                return "sexo del estudiante";
            }
            else if (txtDireccion.Text.Trim().Length == 0)
            {
                txtDireccion.Focus();
                return "dirección del estudiante";
            }
            else if (txtCorreo.Text.Trim().Length == 0)
            {
                txtCorreo.Focus();
                return "correo del estudiante";
            }
            else if (txtTelefono.Text.Trim().Length == 0)
            {
                txtTelefono.Focus();
                return "numero telefonico del estudiante";
            }
            else if (txtDepartamento.Text.Trim().Length == 0)
            {
                txtDepartamento.Focus();
                return "departamento del estudiante";
            }
            else if (txtColegio.Text.Trim().Length == 0)
            {
                txtColegio.Focus();
                return "colegio del estudiante";
            }
            else if (txtFechaNacimiento.Text.Trim().Length == 0)
            {
                txtFechaNacimiento.Focus();
                return "fecha de nacimiento del estudiante";
            }
            else if (mtxtFechaExamen.Text.Trim().Length == 0)
            {
                mtxtFechaExamen.Focus();
                return "fecha de examen de admisión";
            }
            else if (txtLugar.Text.Trim().Length == 0)
            {
                txtLugar.Focus();
                return "lugar del examen";
            }
            else if (txtAula.Text.Trim().Length == 0)
            {
                txtAula.Focus();
                return "aula del examen";
            }
            else if (txtCarrera.Text.Trim().Length == 0)
            {
                txtCarrera.Focus();
                return "carrera a postular";
            }
            return "";
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Está seguro de salir?", "componentes",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (salir == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
