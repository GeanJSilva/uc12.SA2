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
        
            float CalcImpostos = (rendimentos /100);

            if (rendimentos <3000) { return CalcImpostos * 3;}
            else if (rendimentos >=3000 && rendimentos < 6000) {return CalcImpostos * 5; }
            else if (rendimentos >=6000 && rendimentos < 10000) {return CalcImpostos * 7;  }
            else{return CalcImpostos * 9;}
            
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}