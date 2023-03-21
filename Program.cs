using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_CriandoVariaveisPontoFltuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto - Criando Variáveis com ponto flutuante: \r\n");

            double salario;
            salario = 1200.70;

            Console.WriteLine("O salário do colaborador é de " + salario + ".");

            double idade;

            idade = 15 / 2;
            Console.WriteLine("A idade dessa pessoa arredondando o valor é de " + idade + " anos.");

            idade = 15.0 / 2.0;
            Console.WriteLine("A idade dessa pessoa com as casas decimais é de " + idade + " anos.");

            double valor;
            valor = 5 / 3;
            Console.WriteLine("O resultado da divisão arredondada de 5 por 3 é de " + valor + ".");

            valor = 5.0 / 3.0;
            Console.WriteLine("O resultado da divisão entre 5.0 e 3.0 é de " + valor + ". \r\n");


            Console.WriteLine("A execução terminou! Tecle enter para sair.");
            Console.ReadLine();
        }
    }
}
