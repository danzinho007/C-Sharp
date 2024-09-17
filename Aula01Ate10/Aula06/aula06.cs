using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Digite seu nome :");
//Console.WriteLine(""); = Imprime valores
      string userName = Console.ReadLine();
// Console.ReadLine(); = Obter entrada do usuário, somente texto
      Console.WriteLine("Quanto anos você tem ?");
      
      int age = Convert.ToInt32(Console.ReadLine());
// Convertendo String para Inteiro
      Console.Write("Bem vindo " + userName);
      Console.Write(" você tem " + age + " anos");
      Console.WriteLine("");
      Console.WriteLine("Operadores Aritméticos");
      int x = 5;
      int y = 10;
      Console.WriteLine("Adição " + (x + y));
      Console.WriteLine("Subtração " + (x - y));
      Console.WriteLine("Multiplicação " + (x * y));
      Console.WriteLine("Divisão " + (y / x));
      Console.WriteLine("Módulo " + (y % x));
      x++; // Somando    1, também pode ser escrito x = x + 1
      y--; // Diminuindo 1
      Console.WriteLine("Incremento " + x); // Resultado 6
      Console.WriteLine("Decremento " + y); // Resultado 9
      x+=5; // Somando 5
      y-=5; // Diminuindo 5
      Console.WriteLine("Atribuindo adição " + x); // Resulta 11, pois 6 + 5
      Console.WriteLine("Atribuindo subtração " + y); // Resulta 4, pois 9 - 5
      Console.WriteLine("Operadores de Comparação");
      Console.WriteLine("x = " + x + " e y = " + y);
      Console.WriteLine("x é igual a y ? " + (x==y)); 
      Console.WriteLine("x é diferente de y ? " + (x != y));
// Atribuição :
// =	x = 5	x = 5	
// +=	x += 3	x = x + 3	
// -=	x -= 3	x = x - 3
// *=	x *= 3	x = x * 3	
// /=	x /= 3	x = x / 3	
// %=	x %= 3	x = x % 3	
// &=	x &= 3	x = x & 3	
// |=	x |= 3	x = x | 3	
// ^=	x ^= 3	x = x ^ 3	
// >>=	x >>= 3	x = x >> 3	
// <<=	x <<= 3	x = x << 3
// Comparação :
// ==	Equal to	x == y	
// !=	Not equal	x != y	
// >	Greater than	x > y	
// <	Less than	x < y	
// >=	Greater than or equal to	x >= y	
// <=	Less than or equal to	x <= y
// Lógico :
// && 	Logical and	Returns True if both statements are true	x < 5 &&  x < 10	
// || 	Logical or	Returns True if one of the statements is true	x < 5 || x < 4	
// !	Logical not	Reverse the result, returns False if the result is true	!(x < 5 && x < 10)
     }
  }
}
