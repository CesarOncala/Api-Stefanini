using Example.Domain.PessoaAggregate;

namespace Example.Domain.CidadeAggregate
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }

        public ICollection<Pessoa> Pessoas { get; set; }
    }
}
