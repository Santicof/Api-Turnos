using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTurnos.Modelo
{
    public class Paciente
    {
        [Key]
        public int Id {  get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaNacimiento { get; set; }
        [Column(TypeName = "char(8)")]
        public string Dni { get; set; }
        [Column(TypeName = "int")]
        public int NroMatricula {  get; set; }

    }
}
