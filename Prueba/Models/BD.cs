using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
namespace Prueba.Models
{
    public static class BD
    {
        private static string _connectionString = @"Server=localhost;Database=Prueba;Trusted_Connection=True;";
        
        public static List<Alumno> SeleccionarAlumnos()
        {
            List<Alumno> ListaAlumnos;
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Alumnos";
                ListaAlumnos = db.Query<Alumno>(sql).ToList();
            }
            return ListaAlumnos;
        }
    
        public static Alumno AlumnoElegido(int IdAlumno)
        {
            Alumno Seleccionado = null;
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string SQL = "SELECT * FROM Alumnos WHERE IdAlumno = @Alumno";
                Seleccionado = db.QueryFirstOrDefault<Alumno>(SQL, new { Alumno = IdAlumno });
            }
            return Seleccionado;
        }


public static  List<Alumno>  ElegirAlumnoAprobado(){
        List<Alumno> ListaAlumnosAprobados;
    using(SqlConnection db = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM Alumnos WHERE Promedio < 6";
        ListaAlumnosAprobados = db.Query<Alumno>(sql).ToList();
    }
    return ListaAlumnosAprobados;
 }

public static List<Alumno> ElegirAlumnoDesaprobado()
{
    List<Alumno> ListaAlumnosDesaprobados;
    using(SqlConnection db = new SqlConnection(_connectionString))
    {
        string sql = "SELECT * FROM Alumnos WHERE Promedio >6";
        ListaAlumnosDesaprobados = db.Query<Alumno>(sql).ToList();
    }
    return ListaAlumnosDesaprobados;
}
        public static void InsertarAlumno(Alumno alumno)
{
    string SQL = "INSERT INTO Alumnos(Nombre, Apellido, Curso, Edad)";
    SQL += " VALUES (@pNombre, @pApellido, @pCurso, @pEdad)";

    using (SqlConnection db = new SqlConnection(_connectionString))
    {
        db.Execute(SQL, new
        {
            pNombre = alumno.Nombre,
            pApellido = alumno.Apellido,
            pCurso = alumno.Curso,
            pEdad = alumno.Edad
        });
    }
}


    
    }
}
  