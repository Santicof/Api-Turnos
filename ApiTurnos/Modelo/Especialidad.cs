using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTurnos.Modelo
{
    public class Especialidad
    {
        [Key]

        public int IdEspecialidad {  get; set; }
        [Column(TypeName="varchar(50)")]
        public string Nombre { get; set; }
    }
}
