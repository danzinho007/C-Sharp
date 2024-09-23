Sim, dá pra alterar um objeto a qualquer hora. Você pode modificar suas propriedades depois que o objeto foi criado. Por exemplo, se você tiver um objeto da classe Car, você pode fazer algo assim:

csharp
using System;

namespace MyApplication
{
  class Car // Criando classe
  {
    public string color; // variável color
    public string model; // variável model
    public int year; // variável year

    public Car(string carColor, string carModel, int carYear) {
        color = carColor;
        model = carModel;
        year = carYear;
    }

    static void Main(string[] args)
    {
      Car myObj1 = new Car("red", "sedan", 2020);
      
      // Mostra os dados iniciais
      Console.WriteLine(myObj1.color);
      Console.WriteLine(myObj1.model);
      Console.WriteLine(myObj1.year);
      
      // Alterando os valores
      myObj1.color = "blue";
      myObj1.model = "hatchback";
      myObj1.year = 2021;

      // Mostra os dados alterados
      Console.WriteLine(myObj1.color); // Agora vai mostrar 'blue'
      Console.WriteLine(myObj1.model); // Agora vai mostrar 'hatchback'
      Console.WriteLine(myObj1.year); // Agora vai mostrar '2021'
    }
  }
}


Nesse exemplo, a gente cria um carro, mostra seus valores e depois altera as propriedades. Se precisar de mais ajuda, pode perguntar!