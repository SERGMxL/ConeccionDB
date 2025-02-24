using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBases_De_Datos
{
    internal class Conectividad
    {

        public DataSet conectarMySQL()
        {
            OdbcConnection ConexionMySQL;
            ConexionMySQL = new OdbcConnection(
                "DRIVER={MySQL ODBC 9.2 ANSI Driver};" +
                "SERVER=localhost;" +
                "DATABASE=esc;" +
                "UID=root;" +
                "PWD="
            );
            ConexionMySQL.Open();

            String SQL = "select * from alumno";
            OdbcDataAdapter adaptador = new OdbcDataAdapter(
                SQL, ConexionMySQL
            );
            DataSet resultado = new DataSet();
            adaptador.Fill(resultado);
            return resultado;
        }
        public DataSet conectarPostgreSQL()
        {
            OdbcConnection Conexion;
            Conexion = new OdbcConnection(
                "DRIVER={PostgreSQL ANSI};" +
                "SERVER=localhost;" +
                "DATABASE=escuela;" +
                "UID=postgres;" +
                "PWD=1338"
            );
            Conexion.Open();

            String SQL = "select * from asignatura";
            OdbcDataAdapter adaptador = new OdbcDataAdapter(
                SQL, Conexion
            );
            DataSet resultado = new DataSet();
            adaptador.Fill(resultado);
            return resultado;
        }
        public DataSet conectarSQLite()
        {
            OdbcConnection Conexion;
            Conexion = new OdbcConnection(
                "DRIVER={SQLite3 ODBC dRIVER};" +
                "SERVER=localhost;" +
                "DATABASE=C:\\Users\\elosw\\Desktop\\escuela.db;"
            );
            Conexion.Open();

            String SQL = "select * from profesor";
            OdbcDataAdapter adaptador = new OdbcDataAdapter(
                SQL, Conexion
            );
            DataSet resultado = new DataSet();
            adaptador.Fill(resultado);
            return resultado;
        }

    }
}
