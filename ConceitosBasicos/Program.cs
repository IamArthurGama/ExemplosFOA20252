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
/*

class Program
{
    static void Main()
    {


        try
        {
            decimal irpfDevido, salario;
            Console.Write("Informe o salário: ");
            salario = decimal.Parse(Console.ReadLine());

            if (salario <= 2428.8m)
                irpfDevido = 0;
            else if (salario <= 2826.65m)
                irpfDevido = salario * 0.075m - 182.16m;
            else if (salario <= 3751.05m)
                irpfDevido = salario * 0.15m - 394.16m;
            else if (salario <= 4664.68m)
                irpfDevido = salario * 0.225m - 675.49m;
            else
                irpfDevido = salario * 0.275m - 908.73m;

            Console.WriteLine($"Para o salario {salario} o IRPF a ser pago é {irpfDevido}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Digite apenas valores numericos.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocorreu um erro entre em contato com o suporte.");
            Console.WriteLine(e.ToString());
        }




    }
}
*/


using ConceitosBasicos.uteis;

SomaDoisNumeros somaDoisNumeros;

somaDoisNumeros = new SomaDoisNumeros();

int result;

result = somaDoisNumeros.Somar(20, 30);
Console.WriteLine(result);


double result2;

result2 = MetrosMilimetros.Converter(5);
Console.WriteLine(result2);