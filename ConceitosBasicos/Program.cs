byte idade;
string nome;
Console.Write("Digite seu nome: ");
nome = Console.ReadLine();
Console.Write("Digite sua idade: ");
idade = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Olá " + nome + ". A idade informada foi {0}", idade);
