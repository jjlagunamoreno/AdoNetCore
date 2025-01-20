using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCore.Repositories;

namespace AdoNetCore
{
    public partial class Form10UpdateEmpleadosOficios : Form
    {
        RepositoryUpdateEmpleados repo;
        public Form10UpdateEmpleadosOficios()
        {
            InitializeComponent();
            this.repo = new RepositoryUpdateEmpleados();
            this.LoadOficios();
            
        }

        private async void LoadOficios()
        {
            List<string> oficos = await this.repo.GetOficiosAsync();
            this.lstOficios.Items.Clear();
            foreach (string ofi in oficos)
            {
                this.lstOficios.Items.Add(ofi);
            }
        }

        private async void LoadEmpleados(string oficio)
        {
            List<string> empleados = await this.repo.GetEmpleadosOficioAsync(oficio);
            this.lstEmpleados.Items.Clear();
            foreach (string ape in empleados)
            {
                this.lstEmpleados.Items.Add(ape);
            }
        }

        private async void btnIncrementarSalarios_Click(object sender, EventArgs e)
        {
            // Validar que el usuario haya seleccionado un oficio
            if (this.lstOficios.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un oficio antes de incrementar los salarios.");
                return;
            }

            // Validar que el usuario haya ingresado un valor válido para el incremento
            if (string.IsNullOrEmpty(this.txtIncremento.Text) || !int.TryParse(this.txtIncremento.Text, out int incremento))
            {
                MessageBox.Show("Por favor, ingrese un incremento salarial válido.");
                return;
            }

            // Obtener el oficio seleccionado
            string oficio = this.lstOficios.SelectedItem.ToString();

            // Incrementar salarios
            int modificados = await this.repo.UpdateSalarioEmpleadosOficio(oficio, incremento);
            MessageBox.Show("Salarios incrementados para " + modificados + " empleados.");

            // Validar si se ingresó un nuevo nombre de oficio
            string nuevoOficio = this.txtOficio.Text;
            if (!string.IsNullOrEmpty(nuevoOficio))
            {
                await this.repo.UpdateOficioEmpleadosAsync(oficio, nuevoOficio);
                MessageBox.Show("Oficio actualizado correctamente a: " + nuevoOficio);
            }

            // Recargar las estadísticas salariales y oficios
            this.LoadOficios();
        }


        private async void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstOficios.SelectedIndex != -1)
            {
                string oficio = this.lstOficios.SelectedItem.ToString();
                this.LoadEmpleados(oficio);

                // Obtener estadísticas salariales del oficio seleccionado
                var stats = await this.repo.GetSalarialStatsAsync(oficio);

                // Mostrar las estadísticas en los Label
                this.lblSumaSalarial.Text = "Suma Salarial: " + stats.Suma.ToString("C");
                this.lblMediaSalarial.Text = "Media Salarial: " + stats.Media.ToString("C");
                this.lblMaximoSalarial.Text = "Máximo Salarial: " + stats.Maximo.ToString("C");
                
            }
        }
    }
}
