Pra deixar os valores de um objeto inalteráveis, você pode usar modificadores de acesso e transformar as propriedades em readonly. Assim, você só pode definir esses valores no construtor. Olha como ficaria:

csharp
using System;

namespace MyApplication
{
  class Car // Criando classe
  {
    public readonly string color; // variável color
    public readonly string model; // variável model
    public readonly int year; // variável year

    // Construtor
    public Car(string carColor, string carModel, int carYear) {
        color = carColor; // atribui a cor passada
        model = carModel; // atribui o modelo passado
        year = carYear; // atribui o ano passado
    }

    static void Main(string[] args)
    {
      Car myObj1 = new Car("red", "sedan", 2020); // Criando um objeto

      // Mostra os dados
      Console.WriteLine(myObj1.color); // Mostra 'red'
      Console.WriteLine(myObj1.model); // Mostra 'sedan'
      Console.WriteLine(myObj1.year); // Mostra '2020'

      // Qualquer tentativa de alterar essas propriedades aqui gerará um erro de compilação
      // myObj1.color = "blue"; // Isso não vai funcionar
    }
  }
}

/*
Ao utilizar readonly, você garante que as propriedades não possam ser alteradas depois de criadas. Se precisar de mais alguma coisa ou tiver dúvidas, só avisar!
*/