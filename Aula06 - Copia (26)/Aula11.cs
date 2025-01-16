# Aula 03 ate 11 

using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Bom dia");
            Console.WriteLine("Boa tarde");
            Console.WriteLine("Boa noite");

            double x;
            x = 2.3456;
            System.Console.WriteLine(x);
            System.Console.WriteLine(x.ToString("F2"));
            System.Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            System.Console.WriteLine(x.ToString("F2", CI));

            int idade;
            double salario;
            string nome;
            char sexo;

            idade = 32;
            salario = 4560.9;
            nome = "Maria Silva";
            sexo = 'F';
            ConsoleWrite("A funcionária " + nome);
            ConsoleWrite(" sexo " + sexo);
            ConsoleWrite(" ganha " + salario.ToString("F2", CI));
            ConsoleWriteline(" tem " + idade + "anos.");

            int x, y;
            x = 10;
            y = 20;
            double z = x * y;
            ConsoleWriteline(x);
            ConsoleWrite(z);
            ConsoleWriteline(z.ToString("F2", Ci));

            int a, b;
            a = 5;
            b = 2;
            resultado1 = a / b;
            resultado2 = (double)a / b;
            ConsoleWriteline(resultado1);
            ConsoleWriteline(resultado2);

            double salario1, salario2;
            string nome1, nome2;
            int idade;
            char sexo;

            ConsoleWrite("Digite o nome da 1° pessoa : ");
            nome1 = Console.Readline();
            ConsoleWrite("Digite o salário : ");
            salario1 = double.Parse(Console.Readline());

            Console.WriteLine("Digite o nome da 2° pessoa : ");
            nome2 = Console.Readline();
            ConsoleWrite("Digite o salário : ");
            salario2 = double.Parse(Console.Readline());

            ConsoleWriteline("Estrutura CondicionaL : Se e senão se")
            int hora;
            Console.Write("Digite uma hora do dia : ");
            hora = int.Parse(Console.Readline());

            Console.Writeline("Estrutura Condicional : Enquanto")

            Console.WriteLine("Estrutura Condicional : Para")

            Console.WriteLine("Vetores")
            int N;
            Console.Write("Quantos números você vai digitar ? ");
            N = int.parse(Console.Readline());

            double[] vet = new double[N];

            # Todo vetor começa na posição 0
            for (int i = 0; i < N; i++) {
                Console.Write("Digite um número : ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }
            Console.WriteLine();
            Console.WriteLine("Número digitados : ");
            for ( int i = 0; i < N; i++) {
                Console.WriteLine(vet[i].ToString("F1", CI));
            }

            # Variáveis : 
        }
    }
}

Atalhos :
cw + tab = System.ConsoleWriteline

Operadores

Adição
Subtração
Multiplicação
Divisão
Módulo ( resto da Divisão )

Console.Write
Console.WriteLine