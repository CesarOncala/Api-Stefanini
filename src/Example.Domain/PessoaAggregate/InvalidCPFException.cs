using System;

namespace Example.Domain.PessoaAggregate
{
    public class InvalidCPFException : ArgumentException
    {
        public InvalidCPFException(): base("Invalid CPF.")
        {
        }
    }
}
