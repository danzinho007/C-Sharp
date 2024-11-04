using System;

namespace MyApplication
{
  class Vehicle // Classe base ( parente )
  {
  	public string brand = "Ford"; // Marca do Veículo
    public void honk()           // Método do Veículo
    {
      Console.WriteLine("Herança classe derivada e base");
      Console.WriteLine("Nesse exemplo abaixo, a classe derivada filho Car");
      Console.WriteLine("herda os campos e métodos da classe  base Veículo pai");
      Console.WriteLine("");
      Console.WriteLine("Tuut, tuut!");
    }
  }
  
  class Car : Vehicle // Classe derivada ( Filho )
  {
  	public string modelName = "Mustang"; // Modelo do Veículo
  }
  
  class Animal // Classe base ( parente )
  {
    public void animalSound()
    {
      Console.WriteLine("O animal emite um som");
    }
  }
  
  class Dog : Animal // Classe derivada ( Filho )
  {
    public void animalSound()
    {
      Console.WriteLine("O cachorro late : Au au");
    }
  }
  
  class Cat : Animal // Classe derivada ( Filho )
  {
    public void animalSound()
    {
      Console.WriteLine("O gato mia : Miau");
    }
  }
  
  class Program
  {
  	static void Main(string[] args)
    {
      Car myCar = new Car(); // Criando objeto do Carro
      myCar.honk(); // Chama o método honk
      Console.WriteLine("Monstrando a marca do Veículo + ");
      Console.WriteLine("            Modelo do Veículo");
      Console.WriteLine(myCar.brand + " " + myCar.modelName); 
      Console.WriteLine("");
      Console.WriteLine("Caso não queria que herde, basta usar : ");
      Console.WriteLine("sealed antes da classe");
      Console.WriteLine("sealend class Veículo { ... } ");
      Console.WriteLine("");
      
      Console.WriteLine("Método da classe substituindo o");
      Console.WriteLine("Método da classe derivada : ");
      Animal myAnimal = new Animal(); // Criando objeto animal
      Animal myDog = new Dog();
      Animal myCat = new Cat();
      myAnimal.animalSound();
      myDog.animalSound();
      myCat.animalSound();
    }
  }
}