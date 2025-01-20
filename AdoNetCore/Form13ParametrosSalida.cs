using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

#region STORED PROCEDURES
/*
create procedure SP_EMPLEADOS_DEPT_OUT
(@nombre nvarchar(50)
, @suma int OUT
, @media int OUT
, @personas int OUT)
as 
	declare @id int
	select @id = DEPT_NO from DEPT
	WHERE DNOMBRE=@nombre
	select * from EMP where DEPT_NO=@id
	select @suma = SUM(SALARIO), @media = AVG(SALARIO)
	, @personas = COUNT(EMP_NO) from EMP
	where DEPT_NO=@id
go
*/
#endregion

namespace AdoNetCore
{
    public partial class Form13ParametrosSalida : Form
    {
        private string connectionString; // DEFINIMOS EL CAMPO PRIVADO
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form13ParametrosSalida()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;TrustServerCertificate=True";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadDepartamentos();
        }

        private async Task LoadDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.cmbDepartamentos.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                this.cmbDepartamentos.Items.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private async void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string sql = "SP_EMPLEADOS_DEPT_OUT";
            string nombre = this.cmbDepartamentos.SelectedItem.ToString();
            //PARA LOS PARAMETROS DE ENTRADA PODEMOS UTILIZAR
            //AddWithValue SIN PROBLEMAS
            //PARA LOS PARAMETROS DE ENTRADA ES IMPRESCINDIBLE
            //UTILIZAR OBJETOS Parameter
            this.com.Parameters.AddWithValue("@nombre", nombre);
            SqlParameter pamSuma = new SqlParameter();
            pamSuma.ParameterName = "@suma";
            pamSuma.Value = 0;
            //INDICAMOS LA DIRECCION DEL PARAMETRO
            pamSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);
            SqlParameter pamMedia = new SqlParameter();
            pamMedia.ParameterName = "@media";
            pamMedia.Value = 0;
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);
            SqlParameter pamPersonas = new SqlParameter();
            pamPersonas.ParameterName = "@personas";
            pamPersonas.Value = 0;
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamPersonas);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstEmpleados.Items.Clear();
            while (await this.reader.ReadAsync())
            { 
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEmpleados.Items.Add(apellido);
            }
            await this.reader.CloseAsync();
            //DIBUJAMOS LOS PARAMETROS
            this.txtSumaSalarial.Text = pamSuma.Value.ToString();
            this.txtMediaSalarial.Text = pamMedia.Value.ToString();
            this.txtPersonas.Text = pamPersonas.Value.ToString();

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

        }
    }
}
