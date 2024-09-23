//filename: Car.cs
using System;

namespace MyApplication
{
  class Car // classe
  {
    string model; // campo
    string color; // campo
    int year;     // campo
    public void fullThrottle() // método
    {
      Console.WriteLine("Teste");
    }

    static void Main(string[] args) // método
    {
      Console.WriteLine("Podemos criar 2 arquivos : ");
      Console.WriteLine("Um pra Classes");
      Console.WriteLine("e outro pra classe do Programa");
      Console.WriteLine("");
      Console.WriteLine("Campos : ");
      Console.WriteLine("São as váriáveis dentro de uma classe");
      Console.WriteLine("Pode acessar criando objeto da classe");
      Car Ford = new Car(); // objeto Ford da Classe Car
      Ford.model = "Mustang";
      Ford.color = "red";
      Ford.year = 1969;

      Car Opel = new Car();
      Opel.model = "Astra";
      Opel.color = "white";
      Opel.year = 2005;

      Console.WriteLine(Ford.model);
      Console.WriteLine(Opel.model);
      Console.WriteLine("");
      Console.WriteLine("Método de Objeto : ");
      Console.WriteLine("Pertencem a uma classe"); 
      Console.WriteLine("definem como o objeto se comporta");
      Car myObj = new Car(); // Criando um objeto myObjda Classe Car
      myObj.fullThrottle(); // Chamando o método
    }
  }
}