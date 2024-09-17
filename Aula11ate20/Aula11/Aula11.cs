using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Matriz");
      Console.WriteLine("Armazenar vários valores em 1 variável, ao invés de declarar várias variáveis");
      Console.WriteLine("Declarando um array do tipo strings ");
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      Console.WriteLine("Sendo 4 marcas : Volvo, BMW, Ford e Mazda, selecione o 1° elemento : ");
      Console.WriteLine(cars[0]);
      Console.WriteLine("Caso eu seleciona alguma posição que não tenha, vai dar erro");
      Console.WriteLine("");
      
      Console.WriteLine("Selecionando o último elemento de um array que contém : 10, 20, 30 e 40 : ");
      int[] myNum = {10, 20, 30, 40};
      Console.WriteLine(myNum[3]);
      Console.WriteLine("");
      
      Console.WriteLine("Alterando elementos de Matriz : ");
      Console.WriteLine("Sendo as comidas : Arroz, Feijão e Carne, ") ;
      Console.WriteLine("se eu quiser altera algum, eu preciso indicar a posição do elemento");
      Console.WriteLine("Trocando Arroz por Coxa temos que o 1° elemento agora é : ");
      string[] foods = {"Arroz", "Feijão", "Carne"};
      foods[0] = "Coxa";
      Console.WriteLine(foods[0]);
      Console.WriteLine("");
      
      Console.WriteLine("Comprimento da Matriz");
      Console.WriteLine("Eu tenho os seguintes jogos : ");
      Console.WriteLine("Minecraft, Terraria e Stardew Valley");
      Console.WriteLine("Quantos jogos eu tenho ? ");
      string [] games = {"Minecraft", "Terraria", "Stardew Valley"};
      Console.WriteLine(games.Length);
      Console.WriteLine("");
      
      Console.WriteLine("Outras maneiras de criar matriz : ");
      Console.WriteLine("Ver o código");
      string[] cars1 = new string[4];
      string[] cars2 = new string[4] {"Volvo","BMW","Ford","Mazda"};
      string[] cars3 = new string[] {"Volvo", "BMW", "Ford","Mazda"};
      string[] cars4 = {"Volvo", "BMW", "Ford", "Mazda"};
      Console.WriteLine("");
      
      Console.WriteLine("Declarando um array e atribuindo valores : ");
      Console.WriteLine("Ver o código");
      string[] cars5;
      cars5 = new string[] {"Volvo", "BMW", "Ford"};
      Console.WriteLine(cars5);
    }
  }
}