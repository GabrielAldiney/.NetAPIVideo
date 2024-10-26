using System.ComponentModel.DataAnnotations;
using WebAPI_Video.Enums;

namespace WebAPI_Video.Models
{
    public class FuncionarioModel
    {

        [Key]
        public int Id { get; set; }

        public String Nome { get; set; }

        public String Sobrenome { get; set; }

        public DepartamentoEnum Departmento { get; set; }

        public bool Ativo { get; set; }

        public TurnoEnums Turno { get; set; }

        public DateTime DataDeCriacao { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataDeAlteracao { get; set; } = DateTime.Now.ToLocalTime();

        
    }
}
