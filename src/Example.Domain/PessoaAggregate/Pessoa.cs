using Example.Domain.CidadeAggregate;
using System.ComponentModel.DataAnnotations;

namespace Example.Domain.PessoaAggregate
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [MinLength(11),MaxLength(11)] // Fiz usando DataAnnotation pois o fluentAPI não disponibiliza minLenght
        public string CPF { get; set; }
        public int Idade { get; set; }
        public int Id_Cidade { get; set; }

        public Cidade Cidade { get; set; }
    }
}
