using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
	  Console.WriteLine("Laços While (Enquanto)");    		Console.WriteLine("Contando de 0 até 5 começando com 0 usando While");
      int i = 0;
      while (i <= 5) 
      {
        Console.WriteLine(i);
        i++;
      }
      Console.WriteLine("Começa no 0, amostra na tela o valor de i que é 0, depois soma + 1, até i for igual a 5");
      Console.WriteLine("");
      
      Console.WriteLine("Laço loop Do / While");
      Console.WriteLine("Contando de 5 até 0 começando com 5 usando do ... while");
      int j = 5;
      do
      {
      	Console.WriteLine(j);
        j--;
      }
      while (j >= 0);
      Console.WriteLine("Começa no 5, amostra na tela o valor de j que é 5, depois diminui em 1 até j for igual a 0");
      Console.WriteLine("");
      
      Console.WriteLine("C# para Laço ( for )");
      Console.WriteLine("Contando de 1 até 3 começando com 1 usando for");
      for ( int k = 1; k <= 3; k++)
      {
      	Console.WriteLine(k);
      }
      Console.WriteLine("Sendo k igual 1, enquanto k for menos ou igual que 3, ele vai somar + 1");
      Console.WriteLine("Por isso ele mostra na tela até o 3, mas o valor de k foi até 4");
      Console.WriteLine("");
      
      Console.WriteLine("Loop Aninhado : ");
      for (int l = 1; l <= 2; ++l)
      {
      	Console.WriteLine("Loop Externo : " + l);
        for (int m = 1; m <= 3; m++)
        {
        	Console.WriteLine(" Loop Interno : " + m);
        }
      }
      Console.WriteLine("Explicando : ");
      Console.WriteLine("1-Loop Externo é executado");
      Console.WriteLine("2-Loop Interno é executado é executado até completar");
      Console.WriteLine("3- Loop Interno é executado novamente");
      Console.WriteLine("4- Loop Externo é exexcutado novamente até completar");
      Console.WriteLine("Ou seja : O que manda é o Loop externo, se ele ter que realizar 2 operações, o Loop interno irá ser realizado 2x");
      Console.WriteLine("");
      
      Console.WriteLine("Laço foreach");
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      foreach ( string n in cars)
      {
      	Console.WriteLine(n);
      }
      Console.WriteLine("Explicando : ");
      Console.WriteLine("Variável n está recebendo o valor de cada carro um a um dentro do loop foreach");
      Console.WriteLine("ou");
      Console.WriteLine("Selecionando somente 2 entre 4 : ");
      string [] comidas = {"Hamburguer", "Lasanha", "Pizza", "Pudim" };
      int count = 0;
      foreach ( string n in comidas)
      {
      	if (count < 2)
      {
      	Console.WriteLine(n);
        count++;
      }
      else
      {
      	break;
      }
      }
      Console.WriteLine("");
    }
  }
}