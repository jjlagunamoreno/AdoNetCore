﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AdoNetCore
{
    public partial class Form05UpdateSalas : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form05UpdateSalas()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.CargarSalas();
        }
        private async void CargarSalas()
        {
            string sql = "select distinct NOMBRE from SALA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstSalas.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.lstSalas.Items.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private async void btnModificarSalas_Click(object sender, EventArgs e)
        {
            string sql =
                "update SALA set NOMBRE=@nuevonombre where NOMBRE=@antiguonombre";
            string newName = this.txtSala.Text;
            string oldName = this.lstSalas.SelectedItem.ToString();
            SqlParameter pamOld =
                new SqlParameter("@antiguonombre", oldName);
            this.com.Parameters.Add(pamOld);
            SqlParameter pamNew =
                new SqlParameter("@nuevonombre", newName);
            this.com.Parameters.Add(pamNew);
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int modificados =
                await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            // Recargamos las salas después de modificar
            this.CargarSalas();
            MessageBox.Show("Salas modificadas " + modificados);           
        }
    }
}
