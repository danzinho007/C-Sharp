using System;
namespace Dia07
{
class Principal{
    static void Main(){
      Console.WriteLine("Dia07");
      Console.WriteLine("");
      Console.WriteLine("Matemática");
      Console.WriteLine("Maior valor entre 5 e 10 é : " + Math.Max(5, 10));
      Console.WriteLine("Menor valor entre 5 e 10 é : " + Math.Min(5,10));
      Console.WriteLine("Raiz quadrada de 64 é : " + Math.Sqrt(64));
      Console.WriteLine("Valor absoluto de -4.7 é " + Math.Abs(-4.7));
      Console.WriteLine("Valor absoluto de 4.7 é " + Math.Abs(4.7));
      Console.WriteLine("Arredondando 9.7 é " + Math.Round(9.7));
      Console.WriteLine("");
      
      Console.WriteLine("Strings ( objeto ) são usadas para armazenas textos");
      string greeting = "Hello";
      Console.WriteLine(greeting);
      string greeting1 = "Nice to meet you";
      Console.WriteLine(greeting1);
      string txt = "0123456789";
      Console.WriteLine("Contando de 0 até 9 temos : " + txt.Length + " números");
      string txt1 = "Testando";
      Console.WriteLine("Testando em maiúsculo : " + txt1.ToUpper());
      Console.WriteLine("Testando em minúsculo : " + txt1.ToLower());
      string firstName = "Daniel ";
      Console.WriteLine("Coloquei um espaço depois do nome pra criar um espaço na concatenação");
      string lastName = "Rocha";
      string name = firstName + lastName;
	  string name1 = "Meu nome é : {firstName} {lastName}";
      Console.WriteLine(name);
      Console.WriteLine(name1);
      int x = 10;
      int y = 20;
      int z = x + y;
	  Console.WriteLine("A soma de 10 e 20 é " + z);
      string x1 = "10";
      string y1 = "20";
      Console.WriteLine("10 com 20 é " + x1 + y1);
      int x2 = 10;
      string teste = "Oi";
      Console.WriteLine("Inteiro com string");
      Console.WriteLine("10 com Oi é " + x2 + teste);
      Console.WriteLine("");
      
      Console.WriteLine("Acessando caracteres");
      Console.WriteLine("O 1° é 0, o 2° é 1, assim por diante");
      string myString = "Hello World";
      Console.WriteLine("A 1° letra de Hello é " + (myString[0]));
      Console.WriteLine("A posição da letra o em Hello é a : " + (myString.IndexOf("o") + 1));
      Console.WriteLine(" ");
      
      Console.WriteLine("Juntando caracteres através de posições : ");
      Console.WriteLine("1-Aqui eu pego a posição do W em Hello World, que é a 7° ( na teoria é a 6° )");
      int charPos = myString.IndexOf("W");
      Console.WriteLine(charPos);
      Console.WriteLine("2-Logo em seguida eu pego em Hello Word a string que começa na 7° posição que é :");
      Console.Write("World, ficando : ");
      Console.WriteLine("Hello " + (myString.Substring(charPos)));
      Console.WriteLine("");
      
      string pronomes = "\\Pronomes\\";
      string txt2 = "Eu \'Tu\' Ele";
      string txt3 = "Nós \"Vós\" Eles";
      Console.WriteLine(pronomes);
      Console.WriteLine(txt2);
      Console.WriteLine(txt3);
      Console.WriteLine("Pulando\nLinha");
      Console.WriteLine("Espa\tçamento");
      Console.WriteLine("Espa\bço");
    }
  }
}
// O erro CS1010: Newline in constant significa que há uma quebra de linha dentro de uma constante. Isso pode acontecer se você tiver uma string que contenha uma quebra de linha dentro de uma constante.
// o erro CS1525: Unexpected symbol `string' significa que o compilador encontrou uma palavra-chave string em um lugar inesperado.
// CS0128: A local variable named 'x' is already defined in this scope significa que você está tentando declarar uma variável local chamada x em um escopo onde já existe uma variável com o mesmo nome.
// erro CS0029: Cannot implicitly convert type `int' to `string' significa que você está tentando atribuir um valor do tipo int a uma variável do tipo string, o que não é permitido.
//  erro CS1502: The best overloaded method match for `string.Substring(int)' has some invalid arguments significa que você está chamando o método Substring com um argumento que não é válido.
// erro CS1503: Argument `#1' cannot convert `string' expression to type `int' significa que você está tentando passar um valor do tipo string como parâmetro para um método que espera um valor do tipo int.
// erro CS1056 Caractere '$' inesperado" significa que o compilador encontrou um caractere $ em um lugar onde não é esperado.