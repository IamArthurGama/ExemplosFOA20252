using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosBasicos.uteis
{
    public class CalculaAumento
    {
        
        public string Calcular(decimal salario, decimal porcent)
        {
            decimal valor_aumento = (salario * (porcent/100));
            decimal salario_final = salario + valor_aumento;

            return $"O salario sem o aumento: {salario:c2}\n" +
                $"A porcentagem do aumento: {porcent}%\n" +
                $"O valor do aumento: {valor_aumento:c2}\n" +
                $"O salário após o aumento: {salario_final:c2}";


        }
    }
}
