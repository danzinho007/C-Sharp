using System;

namespace MyApplication
{
  class Program
  {
    static void MyMethod(string child1, string child2, string child3)
    {
      Console.WriteLine("The youngest child is: " + child3);
    }
    static int PlusMethodInt(int x, int y)
    {
      return x + y;
    }
	static double PlusMethodDouble(double x, double y)
    {
      return x + y;
    }
    static float PlusMethodFloat(float x, float y)
   	{
      return x + y;
    }
    static void Main(string[] args)
    {
      MyMethod(child3: "John", child1: "Liam", child2: "Liam");
      int myNum1 =    PlusMethodInt(8, 5);
      double myNum2 = PlusMethodDouble(4.3,6.26);
      float myNum3 =  PlusMethodFloat(5.25f, 6.35f);
      Console.WriteLine("Int : " + myNum1);
      Console.WriteLine("Double : " + myNum2);
      Console.WriteLine("Float : " + myNum3);
    }
  }
}

// Comentário
/*- *Classes e Objetos*: São a base do OOP, classes definem o molde e objetos são instâncias.
- *Construtores*: Métodos especiais pra inicializar objetos.
- *Modificadores de Acesso*: Controlam a visibilidade das classes e membros.
- *Propriedades*: Permitem encapsular campos, com getters e setters.
- *Herança*: Permite que uma classe herde membros de outra.
- *Polimorfismo*: Habilidade de uma classe usar métodos de uma superclasse.
- *Abstração*: Simplifica a complexidade escondendo detalhes.
- *Interfaces*: Contratos que as classes precisam implementar.
- *Enums*: Tipo especial que representa um conjunto de valores nomeados.
- *Exceções*: Manejo de erros pra deixar o código robusto.
*/

/*
Em C#, a ordem dos métodos estáticos não é específica, pois dependem do retorno que você deseja. Você pode declarar métodos estáticos de diferentes tipos de retorno, como void, int, double, float, entre outros. A forma como você os chama e a lógica na sua aplicação que define a sequência de execução.

Aqui estão alguns pontos importantes:

- *Métodos Estáticos*: Devem ser chamados através do nome da classe, não através de uma instância.
- *Métodos*: Podem ser declarados com qualquer tipo de retorno. Por exemplo:
  - static void (não retorna um valor)
  - static int (retorna um valor inteiro)
  - static double (retorna um valor double)
  - static float (retorna um valor float)

Aqui vão alguns links que podem te ajudar com mais detalhes:

- [Construtores Estáticos - Microsoft Learn](https://learn.microsoft.com/pt-pt/dotnet/csharp/programming-guide/classes-and-structs/static-constructors)
- [Modificador Estático - C# Reference](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/static)
- [Classes Estáticas e Membros de Classes Estáticas - Microsoft Learn](https://learn.microsoft.com/pt-pt/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members)
*/

/*
A diferença entre static int PlusMethodInt(int x, int y) e static int PlusMethod(int x, int y) tá no nome do método e na intenção que você quer passar. 

- *PlusMethodInt*: Esse nome sugere que o método é específico para somar inteiros (int). Funciona bem pra deixar claro que esse método lida apenas com esse tipo.

- *PlusMethod*: Esse nome é mais genérico. Se você tem um método com esse nome, pode ser que ele não dê uma dica clara de que ele é para somar inteiros, se não tiver um contexto que deixe isso evidente.

A escolha do nome é importante pra esclarecer a função do método e também ajuda na leitura do código. Em termos de funcionalidade, ambos podem fazer a mesma coisa, mas é sempre bom nomear de maneira que quem lê o código entenda o que ele faz de forma imediata. Se você tiver métodos diferentes pra tipos diferentes, ter um nome que reflete isso pode ajudar na manutenção do código no futuro. 
*/

/*
Se você quer que a soma seja "retornada" diretamente no Main, e não através de uma variável, isso não é possível, já que a função Main não pode retornar valores da mesma forma que um método normal. O Main deve retornar void ou um int, mas você pode usar a lógica de retornar o valor de PlusMethodInt e manipulá-lo no Main.

Se você tá tentando fazer algo específico, pode tentar explicar melhor? Assim eu consigo ajudar de forma mais precisa.
*/