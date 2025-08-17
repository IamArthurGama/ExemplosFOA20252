//byte idade;
//string nome;
//Console.Write("Digite seu nome: ");
//nome = Console.ReadLine();
//Console.Write("Digite sua idade: ");
//idade = Convert.ToByte(Console.ReadLine());
//Console.WriteLine("Olá " + nome + ". A idade informada foi {0}", idade);
//Console.WriteLine($"A nova idade é {idade++}.");    
//Console.WriteLine($"A nova idade é {++idade}.");    

//altere o programa para que solicite ao usuário informar o seu salario e ao final informe o desconto
//de IRPF de acordo com o salario informado. Utilize a tabela oficial de descontos do IRPF do Basil.


class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        byte idade = Convert.ToByte(Console.ReadLine());

        Console.Write("Digite seu salário bruto (R$): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal salario))
        {
            Console.WriteLine("Valor de salário inválido.");
            return;
        }

        decimal ir = CalcularIRRF(salario);

        Console.WriteLine($"Olá {nome}. A idade informada foi {idade}.");
        Console.WriteLine($"O desconto de IRRF sobre o salário de R$ {salario:F2} é R$ {ir:F2}.");
    }

    static decimal CalcularIRRF(decimal salario)
    {
        decimal aliquota = 0m;
        decimal deducao = 0m;

        if (salario <= 2428.80m)
        {
            aliquota = 0m;
            deducao = 0m;
        }
        else if (salario <= 2826.65m)
        {
            aliquota = 0.075m;
            deducao = 182.16m;
        }
        else if (salario <= 3751.05m)
        {
            aliquota = 0.15m;
            deducao = 394.16m;
        }
        else if (salario <= 4664.68m)
        {
            aliquota = 0.225m;
            deducao = 675.49m;
        }
        else
        {
            aliquota = 0.275m;
            deducao = 908.73m;
        }

        decimal imposto = (salario * aliquota) - deducao;
        return imposto < 0 ? 0 : imposto;
    }
}
