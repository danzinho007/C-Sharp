using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    { 
      Console.WriteLine("Condições Lógicas : ");
      Console.WriteLine("Maior >, Menor <, Igual =");
      Console.WriteLine("");
      
      Console.WriteLine("Maior ou igual >=, Menor ou igual <=, diferente !=");
      Console.WriteLine("Tipo Booleano tem 2 saídas : Verdade ou Falsa");
      bool isCSharpFun = true;
      bool isFishTasty = false;
      Console.WriteLine("Saida Verdadeira : " + isCSharpFun);   
      Console.WriteLine("Saida Falsa : " + isFishTasty);  
      int x = 25;
      int y = 18;
      int z = 15;
      Console.WriteLine("Sendo x = 25 e y = 18, temos :");
      Console.WriteLine("X é maior que Y ? " + (x>y));
      Console.WriteLine("X é menor que Y ? " + (x<y));
      Console.WriteLine("X é igual a Y ? " + (x=y));
      Console.WriteLine("");
      
      Console.WriteLine("Estrutura : Se");
      Console.WriteLine("João tem 25 anos e Ana 15");
      Console.WriteLine("Sabendo que somente 18 ou + podem votar, temos :");
      if (x >= y) 
      {
        Console.WriteLine("João pode votar");
      } 
      else 
      {
        Console.WriteLine("João não pode votar");
      }
      if (z >= y) 
      {
        Console.WriteLine("Maria pode votar");
      } 
      else 
      {
        Console.WriteLine("Maria não pode votar");
      }
      Console.WriteLine("");
      
      Console.WriteLine("Estruturas Condicionais : ");
      Console.WriteLine("if = Se ");
      Console.WriteLine("else = senão");
      Console.WriteLine("else if = senão ... se");
      Console.WriteLine("switch = escolha");
      Console.WriteLine("");
      
      Console.Write("17 horas é : ");
      int time = 17;
      if (time <= 12 )
      {
      	Console.WriteLine("Bom dia");
      }
      else if (time <= 20)
      {
       Console.WriteLine("Boa tarde");
      }
      else
      {
      	Console.WriteLine("Boa noite");
      }
      Console.WriteLine("Operador Ternário : Se ... Else");
      Console.WriteLine("Sintaxe : tipo variável = condição ? verdade : mentira");
      string result = (time <= 20) ? "Boa tarde" : "Boa noite";
      Console.WriteLine("17 horas é : " + result);
      int time1 = 21;
      string result1 = (time1 <= 20) ? "Boa tarde" : "Boa noite";
      Console.WriteLine("21 horas é : " + result1);
      Console.WriteLine("Operador Switch");
      Console.Write("Sendo Domingo = dia 1, dia 5 é : ");
	  int day = 5;
      switch (day)
      {
      	case 1:
        Console.WriteLine("Domingo");
        break;
        case 3:
        Console.WriteLine("Terça");
        break;
        case 5:
        Console.WriteLine("Quinta");
        break;
        default:
        Console.WriteLine("Erro");
        break;
      }
      Console.WriteLine("");
      
      Console.WriteLine("Laço while ( enquanto )");
      Console.WriteLine("Contando de 0 até 5");
      int i = 0;
      while (i < 5)
      {
      	Console.WriteLine(i);
        i++;
      }
      Console.WriteLine("Explicando : Enquanto i for menor 5, o programa vai : ");
      Console.WriteLine("l° Monstrar o conteúdo da variável i");
      Console.WriteLine("2° Somar + 1");
      Console.WriteLine("Assim que chegar a 5, ele vai parar");
    }
  }
}
// O warning CS0642 significa que o compilador encontrou uma instrução vazia, ou seja, uma linha de código que não faz nada. Isso pode ser um problema se você quiser que seu código seja mais eficiente.

// Já o error CS1525 ocorre quando o compilador encontra um símbolo inesperado, no caso, o símbolo else. Isso pode ser devido a um problema de sintaxe em seu código.
