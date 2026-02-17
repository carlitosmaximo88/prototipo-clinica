using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLINICA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListarPacientes();

        }
        void Limpiar()
        {
            txtDNI.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();

            dgvPacientes.ClearSelection();
            txtDNI.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                entPaciente p = new entPaciente();

                p.DNI = txtDNI.Text;
                p.Nombres = txtNombres.Text;
                p.Apellidos = txtApellidos.Text;
                p.FechaNacimiento = dtpFechaNacimiento.Value;
                p.Telefono = txtTelefono.Text;
                p.Email = txtEmail.Text;
                p.Direccion = txtDireccion.Text;

                logPaciente.Instancia.InsertarPaciente(p);

                MessageBox.Show("Paciente registrado");

                Limpiar();
                MessageBox.Show("Limpiando...");
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        public void ListarPacientes()
        {
            dgvPacientes.DataSource = logPaciente.Instancia.ListarPacientes();
        }

    }
}
