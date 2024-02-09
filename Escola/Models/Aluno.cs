using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Escola.Models
{
    [Table("Aluno")]
    public class Aluno
    {
        [Key] 
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int IdTurma  { get; set; }
        public int IdLocal {  get; set; }
        public DateTime DataMatricula { get; set; }

        

        


    }
}
