using System;

namespace MyApplication
{
  class Animal  // Base class (parent) 
  {
    public virtual void animalSound()
    {
      Console.WriteLine("The animal makes a sound");
    }
  }

  class Pig : Animal  // Derived class (child) 
  {
    public override void animalSound()
    {
      Console.WriteLine("The pig says: wee wee");
    }
  }

  class Dog : Animal  // Derived class (child) 
  {
    public override void animalSound()
    {
      Console.WriteLine("The dog says: bow wow");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Animal myAnimal = new Animal();  // Create a Animal object
      Animal myPig = new Pig();  // Create a Pig object
      Animal myDog = new Dog();  // Create a Dog object
      
      Console.WriteLine("Herança = Herda campos e métodos");
      Console.WriteLine("Polimorfismo = Usa método para executar tarefas diferentes");
      Console.WriteLine("");
      Console.WriteLine("Método da classe base substituído por um método");
      Console.WriteLine("na classe derivada usando virtual e override : ");
      Console.WriteLine("");
      myAnimal.animalSound();
      myPig.animalSound();
      myDog.animalSound();
      Console.WriteLine("");
      Console.WriteLine("Resumindo : ");
      Console.WriteLine("Se chamar o método a partir de um objeto da classe derivada");
      Console.WriteLine("o método da classe derivado será executado");
      Console.WriteLine("Se chamar o método a partir de uma referência da classe base");
      Console.WriteLine("o método da classe base será executado");
    }
  }
}