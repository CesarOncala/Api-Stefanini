﻿namespace Example.Application.PessoaService.Service
{
    public class CreatePessoaRequest
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }

        public int Id_Cidade { get; set; }
    }
}