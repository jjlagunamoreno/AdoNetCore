using AdoNetCore.Repositories;
using ADONETCORE.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetCore
{
    public partial class Form13ParametrosSalidaModelsyRepos : Form
    {
        private RepositoryParametrosOut repo;

        public Form13ParametrosSalidaModelsyRepos()
        {
            InitializeComponent();

            // INICIALIZAMOS EL REPOSITORIO
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;TrustServerCertificate=True";
            this.repo = new RepositoryParametrosOut(connectionString);

            // CARGAMOS LOS DEPARTAMENTOS AL INICIO
            _ = this.LoadDepartamentos();
        }

        private async Task LoadDepartamentos()
        {
            try
            {
                List<Departamento> departamentos = await this.repo.GetDepartamentosAsync();
                this.cmbDepartamentos.Items.Clear();
                foreach (Departamento dept in departamentos)
                {
                    this.cmbDepartamentos.Items.Add(dept.Nombre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar departamentos: " + ex.Message);
            }
        }

        private async void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            if (this.cmbDepartamentos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un departamento.");
                return;
            }

            string nombreDepartamento = this.cmbDepartamentos.SelectedItem.ToString();

            try
            {
                var result = await this.repo.GetEmpleadosYParametrosAsync(nombreDepartamento);

                // MOSTRAMOS LOS EMPLEADOS EN EL LISTBOX
                this.lstEmpleados.Items.Clear();
                foreach (Empleado emp in result.Item1)
                {
                    this.lstEmpleados.Items.Add(emp.Apellido);
                }

                // MOSTRAMOS LOS PARÁMETROS EN LOS TEXTBOX
                this.txtSumaSalarial.Text = result.suma.ToString();
                this.txtMediaSalarial.Text = result.media.ToString();
                this.txtPersonas.Text = result.personas.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar datos: " + ex.Message);
            }
        }
    }
}
