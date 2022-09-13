using Example.Domain.PessoaAggregate;

namespace Example.Domain.CidadeAggregate
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }

        public ICollection<Pessoa> Pessoas { get; set; }


        public static Cidade Create(string Nome, string UF)
        {
            Validate(Nome, UF);

            return new Cidade { Nome = Nome, UF = UF };
        }

        public void Update(string Nome, string UF)
        {
            Validate(Nome, UF);

            this.Nome = Nome;
            this.UF = UF;
        }

        static void Validate(string Nome, string UF)
        {
            if (string.IsNullOrWhiteSpace(Nome))
                throw new ArgumentNullException(nameof(Nome));
            if (string.IsNullOrWhiteSpace(UF))
                throw new ArgumentNullException(nameof(UF));
        }

    }
}
