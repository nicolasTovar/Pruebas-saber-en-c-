using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PruebaSaberPro
{
    class Prueba
    {
        public DataSet Registro( string Nombre, string Apellido, string Correo, string Contraseña)
        {
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            SqlCommand comando = new SqlCommand("pa_Registro",conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter parametro = new SqlParameter("@Nombre", SqlDbType.Text);
            comando.Parameters.Add(parametro).Value=Nombre;
            SqlParameter parameter = new SqlParameter("@Apellido", SqlDbType.Text);
            comando.Parameters.Add(parameter).Value = Apellido;
            SqlParameter parame = new SqlParameter("@Correo", SqlDbType.Text);
            comando.Parameters.Add(parame).Value = Correo;
            SqlParameter parameters = new SqlParameter("@Contraseña", SqlDbType.Text);
            comando.Parameters.Add(parameters).Value = Contraseña;
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            adaptador.Fill(data,"Prueba");
            conexion.Close();
            return data;
        }

        public int LogingUsuario(string correo)
        {
            int usuario = 0;
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            SqlCommand comando = new SqlCommand("pa_LoginU", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter = new SqlParameter("@correo", SqlDbType.Text);
            comando.Parameters.Add(parameter).Value=correo;
            SqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                usuario = 1;

            }
             leer.Close();
            return usuario;
        }

        public int LogingContraseña(string contraseña)
        {
            int Lcontraseña = 0;
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            SqlCommand comando = new SqlCommand("pa_LoginC", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter = new SqlParameter("@contraseña", SqlDbType.Text);
            comando.Parameters.Add(parameter).Value= contraseña;
            SqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                Lcontraseña = 1;

            }
            leer.Close();
            return Lcontraseña;
        }

        public string MostrarEvaluador (string nombre)
        {
            string evaluado = "";
            SqlConnection conexion = ConexionBaseDatos.obtenerConexion();
            SqlCommand comando = new SqlCommand("pa_M", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            //SqlParameter parametro = new SqlParameter();
            comando.Parameters.Add("@Nombre", SqlDbType.Text).Value = nombre;
            SqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                evaluado = leer["Nombre"].ToString()+" "+leer["Apellido"].ToString();
            }
            leer.Close();
            return evaluado;
;        }


    }
}
