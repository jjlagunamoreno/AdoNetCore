using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCore.Models;
using ADONETCORE.Models;
using Microsoft.Data.SqlClient;

namespace AdoNetCore.Repositories
{
    public class RepositoryHospitales
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;
        public RepositoryHospitales()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        //CREATE, READ, UPDATE, DELETE
        //DEVOLVER TODOS LOS Hospitales
        public async Task<List<Hospital>> GetHospitalesAsync()
        {
            string sql = "select * from HOSPITAL";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<Hospital> hospitales = new List<Hospital>();
            while (await this.reader.ReadAsync())
            {
                int hospital_cod = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                string nombre = this.reader["NOMBRE"].ToString();
                string direccion = this.reader["DIRECCION"].ToString();
                Hospital hosp = new Hospital();
                hosp.HospitalCod = hospital_cod;
                hosp.Nombre = nombre;
                hosp.Direccion = direccion;
                hospitales.Add(hosp);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return hospitales;
        }
    }
}
