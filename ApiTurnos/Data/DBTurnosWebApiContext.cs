using ApiTurnos.Modelo;
using Microsoft.EntityFrameworkCore; //agregar

namespace ApiTurnos.Data
{
    public class DBTurnosWebApiContext : DbContext
    {
        public DBTurnosWebApiContext(DbContextOptions<DBTurnosWebApiContext> options) : base(options) 
        { 
       
        }

        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Especialidad> Especialidades { get; set; }

        public DbSet<Medico> Medicos { get; set; }

    
    
    }
}
