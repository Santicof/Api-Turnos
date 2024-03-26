using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTurnos.Modelo
{
    public class Medico
    {
        [Key]
        public int IdMedico { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }
        [Column(TypeName = "char(6)")]
        public string Matricula { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaNacimiento { get; set; }

        [Column(TypeName = "int")]
        public int EspecialdadId { get; set; }
    }
}
