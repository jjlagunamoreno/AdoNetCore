using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AdoNetCore.Repositories
{
    public class RepositoryUpdateEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryUpdateEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetOficiosAsync()
        {
            string sql = "select distinct OFICIO from EMP";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> oficios = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficios.Add(oficio);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return oficios;
        }

        public async Task<List<string>> GetEmpleadosOficioAsync(string oficio)
        {
            string sql = "select * from EMP where OFICIO=@oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType= System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> empleados = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                empleados.Add(apellido);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return empleados;
        }

        public async Task<int> UpdateSalarioEmpleadosOficio
            (string oficio, int incremento)
        {
            string sql = "update EMP set SALARIO=SALARIO+@incremento "
                + " where OFICIO=@oficio";
            this.com.Parameters.AddWithValue("@incremento",incremento);
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int afectados = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return afectados;
        }

        public async Task UpdateOficioEmpleadosAsync(string oldOficio, string newOficio)
        {
            string sql = @"
        update EMP
        set OFICIO = @newOficio
        where OFICIO = @oldOficio";

            // Agregamos los parámetros
            this.com.Parameters.AddWithValue("@newOficio", newOficio);
            this.com.Parameters.AddWithValue("@oldOficio", oldOficio);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            // Ejecutamos la consulta
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();

            // Limpiamos los parámetros
            this.com.Parameters.Clear();
        }

        public async Task<(decimal Suma, decimal Media, decimal Maximo)> GetSalarialStatsAsync(string oficio)
        {
            string sql = @"
        select 
            SUM(SALARIO) as SumaSalarial,
            AVG(SALARIO) as MediaSalarial,
            MAX(SALARIO) as MaximoSalarial
        from EMP
        where OFICIO = @oficio";

            decimal suma = 0, media = 0, maximo = 0;

            using (SqlConnection connection = new SqlConnection(this.cn.ConnectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@oficio", oficio);
                command.CommandType = CommandType.Text;

                await connection.OpenAsync();
                SqlDataReader reader = await command.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    suma = reader["SumaSalarial"] != DBNull.Value ? Convert.ToDecimal(reader["SumaSalarial"]) : 0;
                    media = reader["MediaSalarial"] != DBNull.Value ? Convert.ToDecimal(reader["MediaSalarial"]) : 0;
                    maximo = reader["MaximoSalarial"] != DBNull.Value ? Convert.ToDecimal(reader["MaximoSalarial"]) : 0;
                }

                await reader.CloseAsync();
            }

            return (suma, media, maximo);
        }

    }
}
