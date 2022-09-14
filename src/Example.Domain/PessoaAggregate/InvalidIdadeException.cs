using System;

namespace Example.Domain.PessoaAggregate
{
    public class InvalidIdadeException : ArgumentException
    {
        public InvalidIdadeException(): base("Invalid Idade, must be greather than zero.")
        {
        }
    }
}
