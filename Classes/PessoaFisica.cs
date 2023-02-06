using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoBackEnd.Interfaces;

namespace ProjetoBackEnd.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf {get; set;}

        public DateTime DataNasc {get;set;}

        public override float CalcularImposto(float rendimentos)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime DataNasc)
        {
            throw new NotImplementedException();
        }
    }
}