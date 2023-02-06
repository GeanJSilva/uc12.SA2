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
            
            float CalcImpostos = (rendimentos /100);

            if (rendimentos <1500) { return 0;}
            else if (rendimentos >=1500 && rendimentos < 3500) {return CalcImpostos * 2; }
            else if (rendimentos >=3500 && rendimentos < 6000) {return CalcImpostos * 3.5f;  }
            else{return CalcImpostos * 5;}
            
        }

        public bool ValidarDataNasc(DateTime DataNasc)
        {
            throw new NotImplementedException();
        }
    }
}