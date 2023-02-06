using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoBackEnd.Interfaces;

namespace ProjetoBackEnd.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj {get;set;}

        public string? razaoSocial {get;set;}

        public override float CalcularImposto(float rendimentos)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}