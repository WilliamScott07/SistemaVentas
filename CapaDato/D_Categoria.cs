using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDato
{
    public class D_Categoria
    {
        private int _IdCatgeoria;
        private string _Nombre;
        private string _Descripcion;
        private string _TextoBuscar;

        public int IdCatgeoria { get => _IdCatgeoria; set => _IdCatgeoria = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }


        public D_Categoria() { }

        public D_Categoria(int idcategoria,string nombre,string descripcion,string textobuscar)
        {
            this.IdCatgeoria = idcategoria;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.TextoBuscar = textobuscar;
        }

        public string Insertar(D_Categoria Categoria)
        {
            string MensajeReturn="";

            SqlConnection Sqlcon = new SqlConnection(Conexion.Cn);
            try
            {
                Sqlcon.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = Sqlcon;
                sqlCmd.CommandText = "ProInsert_Categoria";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 256;
                ParNombre.Value = Categoria.Nombre;
                sqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 1024;
                ParDescripcion.Value = Categoria.Descripcion;

                sqlCmd.Parameters.Add(ParDescripcion);


                MensajeReturn = sqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se inserto";
            }
            catch (Exception ex)
            {
                MensajeReturn = ex.Message;
            }

            return MensajeReturn;
        }
    }
}
