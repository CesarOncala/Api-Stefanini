using Example.Domain.CidadeAggregate;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Example.Domain.PessoaAggregate
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [MinLength(11), MaxLength(11)] // Fiz usando DataAnnotation pois o fluentAPI não disponibiliza minLenght
        public string CPF { get; set; }

        public int Idade { get; set; }
        public int Id_Cidade { get; set; }

        public virtual Cidade Cidade { get; set; }



        public static Pessoa Create(string Nome, string CPF, int Idade, int IdCidade)
        {
            Validate(Nome, CPF, Idade, IdCidade);

            return new Pessoa
            {
                CPF = CPF,
                Idade = Idade,
                Id_Cidade = IdCidade,
                Nome = Nome
            };
        }

        public void Update(string Nome, string CPF, int Idade, int IdCidade)
        {
            Validate(Nome, CPF, Idade, IdCidade);
         
            this.CPF = CPF;
            this.Nome = Nome;
            this.Idade = Idade;
            this.Id_Cidade = IdCidade;
        }

     


        static void Validate(string Nome, string CPF, int Idade, int IdCidade)
        {
            if (string.IsNullOrWhiteSpace(Nome))
                throw new ArgumentNullException(nameof(Nome));

            if (string.IsNullOrWhiteSpace(CPF))
                throw new ArgumentNullException(nameof(CPF));

            if (!Utils.IsCpf(CPF))
                throw new InvalidCPFException();

            if (Idade == 0)
                throw new InvalidIdadeException();
            if (IdCidade == 0)
                throw new ArgumentException(nameof(IdCidade));
        }


    }
}
