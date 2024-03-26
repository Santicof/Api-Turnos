using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTurnos.Modelo
{
    public class Turno
    {
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Fecha { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Hora { get; set; }

        [Column(TypeName = "int")]
        public int PacienteId { get; set; }

        [Column(TypeName = "int")]
        public int MedicoId { get; set; }
    }
}
