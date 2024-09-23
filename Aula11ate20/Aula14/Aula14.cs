using System;

namespace MyApplication
{
  class Program
  {
    static void MyMethod()
    {
      Console.WriteLine("Métodos C#");
      Console.WriteLine("Parâmetros são dados do método");
      Console.WriteLine("static significa que pertence a classe Program");
      Console.WriteLine("logo não é um objeto");
      Console.WriteLine("void significa que não tem valor de retorno");
      Console.WriteLine("I just got executed!");
      Console.WriteLine("");
    }
		
    static void Main(string[] args)
    {
      Console.WriteLine("Criei um método acima e agora to chamando ele 2x : ");
      Console.WriteLine("");
      MyMethod();
      MyMethod();
      Console.WriteLine("Parâmetros e Argumentos");
      Console.WriteLine("Quando um parâmetro é passado para o método");
      Console.WriteLine("ele é chamado de Argumento");
      Console.WriteLine("No código abaixo eu criei mais um método e chamei ele");
      Console.WriteLine("");
      Console.WriteLine("Exemplo 1 :");
      Metodo("Liam");
      Metodo("Jenny");
      Metodo("Anja");
      Console.WriteLine("");
      Console.WriteLine("Exemplo 2 : ");
      meuMetodo("João", 5);
      meuMetodo("Jenny", 15);
      meuMetodo("Anja", 30);
      Console.WriteLine("");
      Console.WriteLine("Exemplo 3 : ");
      metodU("Sweden");
      metodU("India");
      metodU();
      Console.WriteLine("");
      Console.WriteLine("Exemplo 4 : ");
      Console.WriteLine(Exemplo(3));
      Console.WriteLine("");
      Console.WriteLine("Exemplo 5 : ");
      int z = Teste(5, 5);
      Console.WriteLine(z);
    }
    
    static void Metodo(string fname)
    {
      Console.WriteLine(fname + " Refsnes");
    }
    static void meuMetodo(string fname, int age)
    {
      Console.WriteLine(fname + " is " + age);
    }
    static void metodU(string country = "Noruega")
    {
      Console.WriteLine(country);
    }
    static int Exemplo(int x)
    {
      return 5 + x;
    }
    static int Teste(int x, int y)
    {
      return x + y;
    }
  }
}