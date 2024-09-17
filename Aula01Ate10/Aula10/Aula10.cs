using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Exercício 1 :");
      Console.WriteLine("Selecionando 2 carros aleatórios numa lista de 5");
      string[] cars = { "Mazda", "Volvo", "BMW", "Ford", "Volkswagen" };
      Random rnd = new Random();
      for (int i = 0; i < 2; i++)
      {
        int randomIndex = rnd.Next(cars.Length);
        Console.WriteLine(cars[randomIndex]);
      }
      Console.WriteLine("");
      
      Console.WriteLine("Exercício 2 : ");
      Console.WriteLine("Comando break (quebra)");
      Console.WriteLine("Contando até 3 começando do 0");
      for (int i = 0; i < 10; i++)
      {
        if (i == 4)
        {
          break;
        }
        Console.WriteLine(i);
      }
      Console.WriteLine("Quando i for igual a 4, sai de um loop");
      Console.WriteLine("");
      
      Console.WriteLine("Exercício 3 : ");
      Console.WriteLine("Comando continue (continuar)");
      Console.WriteLine("Contando até 5 começando do 0, pulando o 2");
      for ( int i = 0; i < 5; i++)
      {
      	if (i == 2)
        {
        	continue;
        }
        Console.WriteLine(i);
      }
      Console.WriteLine("O comando interrompe o loop e continua na próxima");
      Console.WriteLine("");
      
      Console.WriteLine("Exercício 4 : ");
      Console.WriteLine("Comando Interromper e Continuar");
      Console.WriteLine("Contando até 3 começando do 0 : ");
      int j = 0;
      while (j < 10)
      {
      	Console.WriteLine(j);
        j++;
        if (j == 4)
        {
        	break;
        }
      }
      Console.WriteLine("Aqui ele interrompe se a condição for verdadeira");
      Console.WriteLine("");
      
      Console.WriteLine("Exercício 5 : ");
      Console.WriteLine("Exemplo de Continuar :");
      Console.WriteLine("0 até 5 pulando o 2");
      int k = 0;
      while (k < 5)
      {
      	if (k == 2)
        {
        	k++;
            continue;
        }
        Console.WriteLine(k);
        k++;
      }
      Console.WriteLine("Aqui usamos o comando continue em while");
    }
  }
}
