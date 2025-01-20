using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCore.Repositories;

namespace AdoNetCore
{
    public partial class Form07DepartamentosEmpleados : Form
    {
        RepositoryDepartamentosEmpleados repo;

        public Form07DepartamentosEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentosEmpleados();
            this.LoadDepartamentos();
        }

        private async void LoadDepartamentos()
        {
            List<string> departamentos =
                await this.repo.GetNombresDepartamentoAsync();
            this.lstDepartamentos.Items.Clear();
            foreach (string nombre in departamentos)
            {
                this.lstDepartamentos.Items.Add(nombre);
            }
        }

        public async void LoadEmpleados()
        {
            string nombreDepartamento =
                this.lstDepartamentos.SelectedItem.ToString();
            List<string> empleados =
                await this.repo
                .GetEmpleadosDepartamentoAsync(nombreDepartamento);
            this.lstEmpleados.Items.Clear();
            foreach (string apellido in empleados)
            {
                this.lstEmpleados.Items.Add(apellido);
            }
        }

        private void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadEmpleados();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            string apellido =
                this.lstEmpleados.SelectedItem.ToString();
            await this.repo.DeleteEmpleadoAsync(apellido);
            this.LoadEmpleados();
        }
    }
}