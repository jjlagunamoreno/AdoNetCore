using System;
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
    public partial class FormPrimerAdo : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        string connectionString;
        public FormPrimerAdo()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.cn.StateChange += Cn_StateChange;
        }
        //Función que salta en el momento que cambie de estado.
        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblMensaje.Text = "La conexion está pasando de "
                + e.OriginalState + " a " + e.CurrentState;

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
           if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
            }
            this.lblMensaje.BackColor = Color.LightGreen;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblMensaje.BackColor= Color.Red;
        }

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
            //CONSULTA A REALIZAR
            string sql = "select * from EMP";
            //CONFIGURAMOS NUESTRO COMMAND
            //INDICAMOS LA CONEXION DEL COMMAND
            this.com.Connection = this.cn;
            //TIPO DE CONSULTA A REALIZAR
            this.com.CommandType = CommandType.Text;
            //LA PROPIA CONSULTA
            this.com.CommandText = sql;
            //AQUI DEBERIAMOS ABRIR LA CONEXION
            //ES UNA CONSULTA DE SELECCION POR LO QUE DEBEMOS
            //UTILIZAR EL MÉTODO ExecuteReader() QUE NOS DEVUELVE 
            //UN DataReader
            this.reader = this.com.ExecuteReader();
            //LEEMOS LA PRIMERA COLUMNA
            for (int i = 0; i < this.reader.FieldCount; i++)
            {
                string columna = this.reader.GetName(i);
                string tipoDato = this.reader.GetDataTypeName(i);
                this.lstColumnas.Items.Add(columna);
                this.lstTiposDato.Items.Add(tipoDato);
            }
            
            //LEEMOS EL PRIMER REGISTRO
            //PARA LEER DATOS DEBEMOS UTILIZAR EL MÉTODO Read()
            //DEL LECTOR
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstApellidos.Items.Add(apellido);
            }
            //SIEMPRE DEBEMOS CERRAR TODO PARA REUTILIZARLO.
            this.reader.Close();
        }
    }
}
