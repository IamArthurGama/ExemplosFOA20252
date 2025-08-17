byte idade;
string nome;
Console.Write("Digite seu nome: ");
nome = Console.ReadLine();
Console.Write("Digite sua idade: ");
idade = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Olá " + nome + ". A idade informada foi {0}", idade);
Console.WriteLine($"A nova idade é {idade++}.");    
Console.WriteLine($"A nova idade é {++idade}.");    

//altere o programa para que solicite ao usuário informar o seu salario e ao final informe o desconto
//de IRPF de acordo com o salario informado. Utilize a tabela oficial de descontos do IRPF do Basil.

