using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Diplomado_MVC_UASD_Estudiante_ImageUpload.Models
{
    public class Estudiante
    {
        public int EstudianteId { get; }

        [Required(ErrorMessage = "Debes Introducir un nombre")]
        [MinLength(3, ErrorMessage = "El nombre debe tener un minimo de 3 letras")]
        [MaxLength(50)]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Debes introducir un apellido")]
        [MinLength(3, ErrorMessage = "El apellido debe un minimo de 3 letras")]
        [MaxLength(50)]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Debes introducir una direccion")]
        [MinLength(5, ErrorMessage = "debes insertar al menos 8 letras para la direccion")]
        [MaxLength(50)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Debes introducir un numero de telefono")]
        [MinLength(10, ErrorMessage = "Asegurese de que el telefono tenga exactamente 10 digitos")]
        [MaxLength(50)]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Debes introducir un numero de cedula")]
        [MinLength(11, ErrorMessage = "la cantidad de numeros para la cedula es 11")]
        [MaxLength(50)]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Debes introducir una imagen")]
        public string ImageUrl { get; set; }
    }
}





//using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Web;

//namespace Diplomado_MVC_UASD_Estudiante_ImageUpload.Models
//{
//    public class RegistroEstudiantes
//    {
//        private SqlConnection con;
//        //Conectarse a DB
//        private void Conectar()
//        {
//            string constr = ConfigurationManager.ConnectionStrings["ConexionDB"].ToString();
//            con = new SqlConnection(constr);
//        }
//        //Grabar un registro en la DB
//        public int GrabarProducto(EstudianteDBEntities estud)
//        {
//            Conectar();
//            SqlCommand comando = new SqlCommand("Insert into Estudiantes (EstudianteId=@, Nombres, Apellidos, Direccion, Telefono, Cedula, ImageUrl)" +
//                                                "Values @EstudianteId=@, @Nombres,@Apellidos,@Direccion,@Telefono, @Cedula,@ImageUrl)", con);
//            comando.Parameters.Add("@EstudianteId", SqlDbType.Int);
//            comando.Parameters.Add("@Nombres", SqlDbType.VarChar);
//            comando.Parameters.Add("Apellidos", SqlDbType.VarChar);
//            comando.Parameters.Add("@Direccion", SqlDbType.VarChar);
//            comando.Parameters.Add("@Telefono", SqlDbType.VarChar);
//            comando.Parameters.Add("@Cedula", SqlDbType.VarChar);

//            comando.Parameters["@Nombres"].Value = estud.tblEstudiantes;
//            comando.Parameters["@Apellidos"].Value = estud.tblEstudiantes;
//            comando.Parameters["@Direccion"].Value = estud.tblEstudiantes;
//            comando.Parameters["@Telefono"].Value = estud.tblEstudiantes;
//            comando.Parameters["@Cedula"].Value = estud.tblEstudiantes;
//            comando.Parameters["@Image"].Value = estud.tblEstudiantes;
//            con.Open();
//            int i = comando.ExecuteNonQuery();
//            con.Close();
//            return i;
//        }
//        // Mostrar todos los registros de la DB
//        public List<EstudianteDBEntities> RecuperarTodos()
//        {
//            Conectar();
//            List<EstudianteDBEntities> estudiantes = new List<EstudianteDBEntities>();
//            SqlCommand com = new SqlCommand("Select EstudianteId, Nombre, Apellidos,Direccion, Telefono,Cedula,ImageUrl From Estudiante", con);
//            con.Open();
//            SqlDataReader registros = com.ExecuteReader();
//            while (registros.Read())
//            {
//                //Producto produ = new Producto
//                EstudianteDBEntities estudiante = new EstudianteDBEntities
//                {
//                    EstudianteId = int.Parse(registros["EstudianteId"].ToString()),
//                    Nombres = registros["Nombres"].ToString(),
//                    Apellidos = registros["Apellidos"].ToString(),
//                    Direccion = registros["Direccion"].ToString(),
//                    Telefono = registros["Telefono"].ToString(),
//                    //Cedula = registros["Cedula"].ToString(),

//                  ImageUrl = registros["ImageUrl"].ToString(),
//              };
//               estudiantes.Add(estudiante);
//            }
//            con.Close();
//            return estudiantes;
//        }
//        //mostrar un registro especifico de la DB
//        //public Estudiante Recuperar(int EstudianteId)
//        //{
//        //    Conectar();
//        //    SqlCommand comando = new SqlCommand("Select EstudianteId, Nombres, Apellidos, Direccion, Telefono,Cedula,ImageUrl" +
//        //                                        "From Productos where Estudiante=@EstudianteId", con);
//        //    comando.Parameters.Add("@EstudianteId", SqlDbType.Int);
//        //    comando.Parameters["@EstudianteId"].Value = EstudianteId;
//        //    con.Open();
//        //    SqlDataReader registros = comando.ExecuteReader();
//        //   Estudiante estudiante = new Estudiante();
//        //    if (registros.Read())
//        //    {

//        //       estudiante. registros["Nombres"].ToString();
//        //        producto.Tipo = registros["Tipo"].ToString();
//        //        producto.Precio = decimal.Parse(registros["Precio"].ToString());
//        //    }
//        //    con.Close();
//        //    return producto;
//        //}
//        //Crear un registro de la DB
//        public int Crear(EstudianteDBEntities estud)
//        {
//            Conectar();
//            SqlCommand comando = new SqlCommand("Update Estudiantes set EstudianteId=@EstudianteId, Nombres=@Nombres, Apellidos=@Apellidos,Direccion=@Direccion,Telefono=@Telefono,Cedula=@Cedula,ImageUrl=@ImageUrl, where Estudiante=@EstudianteId", con);


//            comando.Parameters.Add("@Nombres", SqlDbType.VarChar);
//            comando.Parameters["@Nombres"].Value = estud.tblEstudiantes;
//            comando.Parameters.Add("Apellidos", SqlDbType.VarChar);
//            comando.Parameters["@Apellidos"].Value = estud.tblEstudiantes;
//            comando.Parameters.Add("@Direccion", SqlDbType.VarChar);
//            comando.Parameters["@Direccion"].Value = estud.tblEstudiantes;
//            comando.Parameters.Add("@Cedula", SqlDbType.VarChar);
//            comando.Parameters["@Cedula"].Value = estud.tblEstudiantes;
//            comando.Parameters.Add("@ImageUrl", SqlDbType.VarChar);
//            comando.Parameters["@Image"].Value = estud.tblEstudiantes;


//            con.Open();
//            int i = comando.ExecuteNonQuery();
//            con.Close();
//            return i;
//        }

//        //Modificar un registro especifico de la DB
//        public int Modificar(EstudianteDBEntities estud)
//        {
//            Conectar();
//            SqlCommand comando = new SqlCommand("Update Estudiantes set EstudianteId=@EstudianteId, Nombres=@Nombres, Apellidos=@Apellidos,Direccion=@Direccion,Telefono=@Telefono,Cedula=@Cedula,ImageUrl=@ImageUrl, where Estudiante=@EstudianteId", con);



//            comando.Parameters.Add("@Nombres", SqlDbType.VarChar);
//            comando.Parameters["@Nombres"].Value = estud.tblEstudiantes;
//            comando.Parameters.Add("Apellidos", SqlDbType.VarChar);
//            comando.Parameters["@Apellidos"].Value = estud.tblEstudiantes;
//            comando.Parameters.Add("@Direccion", SqlDbType.VarChar);
//            comando.Parameters["@Direccion"].Value = estud.tblEstudiantes;
//            comando.Parameters.Add("@Cedula", SqlDbType.VarChar);
//            comando.Parameters["@Cedula"].Value = estud.tblEstudiantes;
//            comando.Parameters.Add("@ImageUrl", SqlDbType.VarChar);
//            comando.Parameters["@Image"].Value = estud.tblEstudiantes;



//            con.Open();
//            int i = comando.ExecuteNonQuery();
//            con.Close();
//            return i;
//        }
//        // borrar un registro especifico de la DB
//        public int Borrar(int id)
//        {
//            SqlCommand comando = new SqlCommand("delete from Estudiante where EstudianteId=@EstudianteId", con);
//            comando.Parameters.Add("@EstudianteId", SqlDbType.Int);
//            comando.Parameters["@EstudianteId"].Value = id;
//            con.Open();
//            int i = comando.ExecuteNonQuery();
//            con.Close();
//            return i;
//        }

//    }
//}

