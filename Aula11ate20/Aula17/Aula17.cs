using System;

namespace MyApplication
{
  class Car // Criando classe 
  {
    public string color = "red"; // váriavel color
	public string model = " sedan ";
    public int year = 2020;
	int maxSpeed;
    
    static void Main(string[] args)
    {
      Console.WriteLine("POO");
      Console.WriteLine("Programação Orientada a Objetos");
      Console.WriteLine("Escrever procedimentos / métodos que realizam");
      Console.WriteLine("operações nos dados");
      Console.WriteLine("DRY");
      Console.WriteLine("Dont Repeat Yourself");
      Console.WriteLine("");
      
      Console.WriteLine("Classe : Fruta");
      Console.WriteLine("Objetos : Maça, Banana e Manga");
      Console.WriteLine("Classe : Carro");
      Console.WriteLine("Volvo, Audi e Toyota");
      Console.WriteLine("");
      
      Car myObj1 = new Car();// Criando um objeto chamado myObj1
      Car myObj2 = new Car();
      Car myObj3 = new Car();
      myObj1.maxSpeed = 200;
      
      Console.WriteLine(myObj1.color);
      Console.WriteLine(myObj1.color + myObj2.model);
      Console.WriteLine(myObj2.model + myObj3.year);
      Console.WriteLine(myObj1.color + myObj2.model + myObj3.year);
      Console.WriteLine(myObj1.color + myObj2.model + myObj1.maxSpeed);
    }
  }
}

/*
prog.cs(28,20): error CS1729: The type `MyApplication.Car' does not 
contain a constructor that takes `1' arguments
prog.cs(5,9): (Location of the symbol related to previous error)
Compilation failed: 1 error(s), 0 warnings

O erro que tá dizendo que não tem um construtor que aceita 1 argumento é 
por conta de que você provavelmente tá chamando o construtor errado. 
Certifique-se de que tá passando os 3 parâmetros corretos: color, 
model, e year. 

*/