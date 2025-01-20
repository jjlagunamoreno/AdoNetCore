using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCore.Models;
using AdoNetCore.Repositories;
using ADONETCORE.Models;

namespace AdoNetCore
{
    public partial class Form09CrudHospitales : Form
    {
        RepositoryHospitales repo;
        public Form09CrudHospitales()
        {
            InitializeComponent();
            this.repo = new RepositoryHospitales();
            this.LoadHospitales();
        }

        private async void LoadHospitales()
        {
            List<Hospital> hospitales =
                await this.repo.GetHospitalesAsync();
            this.lstHospitales.Items.Clear();
            foreach (Hospital hosp in hospitales)
            {
                this.lstHospitales.Items.Add(hosp.HospitalCod
                    + " - " + hosp.Nombre + " - " + hosp.Direccion);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }
    }
}
