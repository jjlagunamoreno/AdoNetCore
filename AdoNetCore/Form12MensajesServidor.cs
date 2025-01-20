using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

#region STORED PROCEDURES
/*
CREATE PROCEDURE SP_ALL_DEPARTAMENTOS
AS
    SELECT DEPT_NO, DNOMBRE, LOC
    FROM DEPT
GO

CREATE PROCEDURE SP_INSERT_DEPARTAMENTO
    @numero INT,
    @nombre NVARCHAR(50),
    @localidad NVARCHAR(50)
AS
    IF @localidad = 'TERUEL'
    BEGIN
        PRINT 'TERUEL NO EXISTE';
    END
    ELSE
    BEGIN
        INSERT INTO DEPT (DEPT_NO, DNOMBRE, LOC)
        VALUES (@numero, @nombre, @localidad);
    END
GO
*/
#endregion

namespace AdoNetCore
{
    public partial class Form12MensajesServidor : Form
    {
        string connectionString; // DEFINIMOS EL CAMPO PRIVADO
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form12MensajesServidor()
        {
            InitializeComponent();

            // ASIGNAMOS LA CADENA DE CONEXIÓN
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;TrustServerCertificate=True";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;

            // ASOCIAMOS EL EVENTO PARA CAPTURAR MENSAJES DEL SERVIDOR
            this.cn.InfoMessage += Cn_InfoMessage;

            // CARGAMOS LOS DEPARTAMENTOS INICIALES
            this.LoadDepartamentos();
        }

        // EVENTO PARA CAPTURAR LOS MENSAJES DEL SERVIDOR
        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            // MOSTRAMOS EL MENSAJE EN EL LABEL
            this.lblMensaje.Text = e.Message;
        }

        // MÉTODO PARA INSERTAR UN NUEVO DEPARTAMENTO
        private async void btnInsertar_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.lblMensaje.Text = ""; // LIMPIAMOS EL MENSAJE
                int id = int.Parse(this.txtNumero.Text);
                string nombre = this.txtNombre.Text;
                string localidad = this.txtLocalidad.Text;

                string sql = "SP_INSERT_DEPARTAMENTO";
                this.com.Parameters.AddWithValue("@numero", id);
                this.com.Parameters.AddWithValue("@nombre", nombre);
                this.com.Parameters.AddWithValue("@localidad", localidad);
                this.com.CommandType = CommandType.StoredProcedure;
                this.com.CommandText = sql;

                // VERIFICAMOS EL ESTADO DE LA CONEXIÓN ANTES DE ABRIRLA
                if (this.cn.State == ConnectionState.Closed)
                {
                    this.cn.Open();
                }

                int afectados = this.com.ExecuteNonQuery();
                MessageBox.Show("Insertados: " + afectados);

                // ACTUALIZAMOS EL LISTBOX DESPUÉS DE LA INSERCIÓN
                await this.LoadDepartamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
            finally
            {
                if (this.cn.State == ConnectionState.Open)
                {
                    this.cn.Close();
                }
                this.com.Parameters.Clear();
            }
        }

        // MÉTODO ASÍNCRONO PARA CARGAR LOS DEPARTAMENTOS EN EL LISTBOX
        public async Task LoadDepartamentos()
        {
            try
            {
                string sql = "SP_ALL_DEPARTAMENTOS";
                this.com.CommandType = CommandType.StoredProcedure;
                this.com.CommandText = sql;

                // VERIFICAMOS EL ESTADO DE LA CONEXIÓN ANTES DE ABRIRLA
                if (this.cn.State == ConnectionState.Closed)
                {
                    await this.cn.OpenAsync();
                }

                this.reader = await this.com.ExecuteReaderAsync();
                this.lstDepartamentos.Items.Clear();
                while (await this.reader.ReadAsync())
                {
                    string id = this.reader["DEPT_NO"].ToString();
                    string nombre = this.reader["DNOMBRE"].ToString();
                    string localidad = this.reader["LOC"].ToString();
                    this.lstDepartamentos.Items.Add($"{id} - {nombre} - {localidad}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar departamentos: " + ex.Message);
            }
            finally
            {
                if (this.reader != null && !this.reader.IsClosed)
                {
                    await this.reader.CloseAsync();
                }
                if (this.cn.State == ConnectionState.Open)
                {
                    await this.cn.CloseAsync();
                }
            }
        }
    }
}
