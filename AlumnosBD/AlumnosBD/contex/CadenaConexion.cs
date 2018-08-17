using AlumnosBD.Models;
using System.Data.Entity;

namespace AlumnosBD.contex
{
    public class CadenaConexion:DbContext
    {
        public DbSet<AlumnosModel> AlunosModel { get; set; }
    }
}