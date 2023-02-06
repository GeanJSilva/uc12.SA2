using ProjetoBackEnd.Classes;

PessoaFisica novaPf = new PessoaFisica();
novaPf.Nome = "Gean";
novaPf.cpf ="123456789";

Console.WriteLine(novaPf.Nome);
Console.WriteLine(novaPf.cpf);

//Interpolacao $:
Console.WriteLine($"Bem vindo, {novaPf.Nome} de cpf {novaPf.cpf}");

//Concatenação:
Console.WriteLine("Bem vindo, "+ novaPf.Nome);