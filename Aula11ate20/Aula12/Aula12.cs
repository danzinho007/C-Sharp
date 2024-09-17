using System;
using System.Linq;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Loop na matriz");
      Console.WriteLine("Nesse caso abaixo eu uso o tamanho");
      Console.WriteLine("da variável cars para especificar o loop : ");
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      for (int i = 0; i < cars.Length; i++) 
      {
        Console.WriteLine(cars[i]);
      }
      Console.WriteLine("");
      
      Console.WriteLine("Laço foreach");
      Console.WriteLine("Aqui eu percorro todos elementos");
      Console.WriteLine("da matriz :");
      string[] cars1 = { "Volvo", "BMW", "Ford", "Mazda"};
      foreach (string j in cars)
      {
      	Console.WriteLine(j);
      }
      Console.WriteLine("");
      
      Console.WriteLine("Classificar uma matriz");
      Console.WriteLine("Colocando uma matriz em ordem alfabética : ");
      string[] cars2 = {"Volto","BMW","Ford","Mazda"};
      Array.Sort(cars2);
      foreach(string k in cars2)
      {
      	Console.WriteLine(k);
      }
      Console.WriteLine("");
      
      Console.WriteLine("Espaço para nome System.Linq");
      Console.WriteLine("Aqui eu informo : ");
      int[] myNumbers = {5,1,8,9};
      Console.WriteLine("Maior número é : " + myNumbers.Max());
      Console.WriteLine("Menor número é : " + myNumbers.Min());
      Console.WriteLine("A soma de todos elementos é : " + myNumbers.Sum());
      Console.WriteLine("");
      
      Console.WriteLine("Matrizes Multidimensionais");
      Console.WriteLine("1-Matriz Bidimensional :");
      Console.WriteLine("Linha ! Col 0 ! Col 1 ! Col 2");
      Console.WriteLine("Linha 0 :   1 !   4 !   2");
      Console.WriteLine("Linha 1 :   3 !   6 !   8");
      Console.WriteLine("Aqui iremos pegar o valor na primeira linha");
      Console.WriteLine("e o valor na terceira coluna : ");
      int[,] numbers = {{1,4,2},{3,6,8}};
      Console.WriteLine(numbers[0,2]);
      Console.WriteLine("");
      
      Console.WriteLine("Alterando elementos de matriz 2D");
      Console.WriteLine("Alterando o valor da 1° linha e 1° coluna");
      Console.WriteLine("1 para 5 e exibindo na tela : ");
	  numbers[0,0] = 5;
      Console.WriteLine(numbers[0,0]);
      Console.WriteLine("");
      
      Console.WriteLine("Loop numa matriz 2D");
      Console.WriteLine("Aqui eu estou percorrendo a matriz alterada");
      Console.WriteLine("mostrando todos os elementos : ");
      foreach (int i in numbers)
      {
      	Console.WriteLine(i);
      }
      Console.WriteLine("");
      
      Console.WriteLine("Ou: Pode usar for para matriz multidimensionais");
      for (int i = 0; i < numbers.GetLength(0); i++)
      {
      	for (int j = 0; j < numbers.GetLength(1); j++)
        {
        	Console.WriteLine(numbers[i,j]);
        }
      }
    }
  }
}