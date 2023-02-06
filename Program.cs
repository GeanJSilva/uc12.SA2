using ProjetoBackEnd.Classes;


PessoaJuridica novaPJ = new PessoaJuridica();
novaPJ.Nome = "VelhaAnglo";
novaPJ.cnpj = "1234123412341324";
novaPJ.rendimentos = 8000;


PessoaFisica novaPf = new PessoaFisica();
novaPf.Nome = "Gean";
novaPf.cpf ="123456789";
novaPf.rendimentos = 5000;

// Console.WriteLine(novaPf.Nome);
// Console.WriteLine(novaPf.cpf);

// //Interpolacao $:
// Console.WriteLine($"Bem vindo, {novaPf.Nome} de cpf {novaPf.cpf}");

// //Concatenação:
// Console.WriteLine("Bem vindo, "+ novaPf.Nome);


//Aula calcular imposto:
    //pessoa fisica:
    float ImpostoPagarPF = novaPf.CalcularImposto(novaPf.rendimentos);
    Console.WriteLine(ImpostoPagarPF);


    //pessoa juridica
    float ImpostoPagarPJ = novaPJ.CalcularImposto(novaPJ.rendimentos);
     Console.WriteLine(ImpostoPagarPJ);

