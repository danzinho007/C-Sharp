using System;	
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Dia04");
      // Erro prog.cs(8,15): error CS0117: `System.Console' does not contain a definition for `Writeline'
       // WriteLine é diferente de Writeline
      const int myNum = 15;
      // myNum = 20 Se eu alterar vai dar ERRO, constante não pode ser alterada
      Console.WriteLine(myNum);
      const double pi = 3.14159;
      // const double pi = Math.pi;
      // rog.cs(14,30): error CS0117: `System.Math' does not contain a definition for `pi'
      // Não poosso usar Math.pi
      Console.WriteLine(pi);
      // prog.cs(14,25): error CS0103: The name `pi' does not exist in the current context
      // pi precisa ser declarado
      string firstName = "Daniel";
      Console.WriteLine("Olá " + firstName);
      string lastName = "Rocha";
      string fullName = firstName + lastName;
      Console.WriteLine("Nome + Sobrenome : " + fullName);
      //. O primeiro erro, error CS1010: Newline in constant, significa que você tem uma quebra de linha dentro de uma constante. Isso não é permitido em C#. 
	  //O segundo erro, error CS1525: Unexpected symbol `string', significa que o compilador encontrou a palavra-chave string em um lugar onde não era esperado. Isso pode ser causado por um erro de sintaxe no seu código. 
      int x, y, z;
      x = y = z = 5;
      Console.WriteLine("3 x 5 é " + (x *3));
      // prog.cs(30,43): error CS1525: Unexpected symbol `;', expecting `)' or `,'
      // Variáveis :
      //Os nomes podem conter letras, dígitos e o caractere sublinhado (_)
	  //Os nomes devem começar com uma letra ou sublinhado
      //Os nomes devem começar com uma letra minúscula e não podem conter espaços em branco
      //Os nomes diferenciam maiúsculas de minúsculas ("myVar" e "myvar" são variáveis ​​diferentes)
      //Palavras reservadas (como palavras-chave C#, como intou double) não podem ser usadas como nomes
    }
  }
}