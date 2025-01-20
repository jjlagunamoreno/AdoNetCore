using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AdoNetCore.Repositories
{
    public class RepositoryDepartamentosEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryDepartamentosEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        public async Task<List<string>> GetNombresDepartamentoAsync()
        {
            string sql = "select DNOMBRE from DEPT";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> nombres = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                nombres.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return nombres;
        }

        public async Task<List<string>> GetEmpleadosDepartamentoAsync
            (string nombreDepartamento)
        {
            string sql = "select EMP.APELLIDO from EMP "
                + " inner join DEPT "
                + " on EMP.DEPT_NO = DEPT.DEPT_NO "
                + " where DEPT.DNOMBRE=@departamento";
            SqlParameter pamDept =
                new SqlParameter("@departamento", nombreDepartamento);
            this.com.Parameters.Add(pamDept);
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
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

        public async Task DeleteEmpleadoAsync(string apellido)
        {
            string sql = "delete from EMP where APELLIDO=@apellido";
            SqlParameter pamApellido =
                new SqlParameter("@apellido", apellido);
            this.com.Parameters.Add(pamApellido);
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
