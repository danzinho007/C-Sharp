using System;

namespace MyApplication
{
    class Car
    {
        private string model = "Mustang";

        public void ShowModel() // Método para acessar o modelo
        {
            Console.WriteLine("Modificador Privado : ");
            Console.WriteLine("Acessando dentro da classe Car");
            Console.WriteLine(model);
        }
    }

    class Person
    {
        private string name; // campo
        public string Name // propriedade
        {
            get { return name; } // pega método
            set { name = value; } // envia método
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.ShowModel(); // Chama o método para mostrar modelo

            Person myObjPerson = new Person();
            myObjPerson.Name = "Liam"; // Corrigido pra acessar o setter
            Console.WriteLine("");
            Console.WriteLine("Propriedades e Encapsulamento");
            Console.WriteLine("Encapsulamento : private, public, get e set");
            Console.WriteLine(myObjPerson.Name); // Corrigido o nome da variável
        }
    }
}
/*
Se acessar fora da classe com o método privado :

class Car
{
  private string model = "Mustang";
}

class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.model);
  }
}

Erro : 
'Car.model' is inaccessible due to its protection level
The field 'Car.model' is assigned but its value is never used

---------------------------
Acessando fora da classe com o método público :
class Car
{
  public string model = "Mustang";
}

class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.model);
  }
}
Saída = Mustang
----------------------------

Erro 
prog.cs(22,10): error CS1043: Invalid accessor body `(', expecting `;', `{', or `=>'
prog.cs(23,10): error CS1043: Invalid accessor body `(', expecting `;', `{', or `=>'
Compilation failed: 2 error(s), 0 warnings

Pelo erro que você tá recebendo, parece que tem algo errado na estrutura das suas classes ou métodos no código. O erro CS1043 geralmente aparece quando você tem um método ou propriedade com o corpo mal formado, como parênteses ou chaves faltando. A mensagem fala em "Invalid accessor body", o que sugere que você não está usando os acessadores (getters e setters) corretamente.

*/