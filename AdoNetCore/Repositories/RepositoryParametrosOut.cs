using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADONETCORE.Models;
using Microsoft.Data.SqlClient;

namespace AdoNetCore.Repositories
{
    public class RepositoryParametrosOut
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryParametrosOut(string connectionString)
        {
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        // MÉTODO PARA OBTENER TODOS LOS DEPARTAMENTOS
        public async Task<List<Departamento>> GetDepartamentosAsync()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            List<Departamento> departamentos = new List<Departamento>();

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            while (await this.reader.ReadAsync())
            {
                Departamento dept = new Departamento
                {
                    IdDepartamento = int.Parse(this.reader["DEPT_NO"].ToString()),
                    Nombre = this.reader["DNOMBRE"].ToString(),
                    Localidad = this.reader["LOC"].ToString()
                };
                departamentos.Add(dept);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

        // MÉTODO PARA OBTENER EMPLEADOS Y PARÁMETROS OUT
        public async Task<(List<Empleado>, int suma, int media, int personas)> GetEmpleadosYParametrosAsync(string nombreDepartamento)
        {
            string sql = "SP_EMPLEADOS_DEPT_OUT";
            this.com.Parameters.Clear();
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            // PARAMETROS DE ENTRADA
            this.com.Parameters.AddWithValue("@nombre", nombreDepartamento);

            // PARAMETROS DE SALIDA
            SqlParameter pamSuma = new SqlParameter("@suma", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            this.com.Parameters.Add(pamSuma);

            SqlParameter pamMedia = new SqlParameter("@media", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            this.com.Parameters.Add(pamMedia);

            SqlParameter pamPersonas = new SqlParameter("@personas", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            this.com.Parameters.Add(pamPersonas);

            List<Empleado> empleados = new List<Empleado>();

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            while (await this.reader.ReadAsync())
            {
                Empleado emp = new Empleado
                {
                    IdEmpleado = int.Parse(this.reader["EMP_NO"].ToString()),
                    Apellido = this.reader["APELLIDO"].ToString(),
                    Salario = int.Parse(this.reader["SALARIO"].ToString()),
                    DepartamentoId = int.Parse(this.reader["DEPT_NO"].ToString())
                };
                empleados.Add(emp);
            }

            await this.reader.CloseAsync();

            // OBTENEMOS LOS PARÁMETROS DE SALIDA
            int suma = (int)this.com.Parameters["@suma"].Value;
            int media = (int)this.com.Parameters["@media"].Value;
            int personas = (int)this.com.Parameters["@personas"].Value;

            await this.cn.CloseAsync();

            return (empleados, suma, media, personas);
        }
    }
}