﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetCore
{
    public partial class Form03EliminarEnfermos : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form03EliminarEnfermos()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.CargarEnfermos();
        }
        public void CargarEnfermos()
        {
            string sql = "select * from ENFERMO";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEnfermos.Items.Clear();
            while (this.reader.Read())
            {
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEnfermos.Items.Add(inscripcion + " - " + apellido);
            }
            this.reader.Close();
            this.cn.Close();
        }
        private void btnEliminarEnfermos_Click(object sender, EventArgs e)
        {
            //DEBEMOS INDICAR EL TIPO DE DATOS A ENVIAR COM PARAMETRO
            //INSCRIPCION ES UN NÚMERO, POR LO QUE DEBEMOS HACER UN
            //CASTING PARA int
            int inscripcion = int.Parse(this.txtInscripcion.Text);

            string sql =
                "delete from ENFERMO where INSCRIPCION=@inscripcion";
            //CREAMOS EL PARÁMETRO PARA LA INSCRIPCIÓN
            SqlParameter pamInscripcion = 
                new SqlParameter("@inscripcion",inscripcion);
            pamInscripcion.ParameterName = "@inscripcion";
            //Value DEBE SER DEL MISMO TIPO QUE EL PARAMETRO (int)
            //pamInscripcion.Value = inscripcion;
            //pamInscripcion.DbType = DbType.Int32;
            //Direction INDICA SI EL PARAMETRO ES ENTRADA O SALIDA
            //POR DEFECTO, ES Input.
            //pamInscripcion.Direction = ParameterDirection.Input;
            //AÑADIMOS EL PARÁMETRO AL COMMAND
            this.com.Parameters.Add(pamInscripcion);

            this.com.Connection = this.cn;
            this.com.CommandType= CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.CargarEnfermos();
            MessageBox.Show("Enfermos eliminados " + eliminados);
        }
    }
}
