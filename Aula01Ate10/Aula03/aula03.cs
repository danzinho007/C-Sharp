using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string name = "John";
      Console.WriteLine(name);
      int number = 15;
      Console.WriteLine(number);
      int n1;
      n1 = 20;
      Console.WriteLine(n1);
      int n2 = 30;
      n2 = 50;
      Console.WriteLine("N2 era 30, agora é " + n2);
      double n3 = 3.14;
      Console.WriteLine("N3 é um número decimal " + n3);
      char letter = 'A';
      Console.WriteLine("Caracter única " + letter);
      bool myBool = true;
      Console.WriteLine("Aqui é Falso ou " + myBool);
      int x = 5;
      int y = 10;
      int z = x + y;
      Console.WriteLine("Sendo x igual a " + x + " e y igual a " + y + " é igual a  " + z);
      int a = 10, b = 20, c = 30;
      Console.WriteLine(a + "+" + b + "+" + c + " é " + (a + b + c));
     }
  }
}
/* 
Explicando :
    string name = "John";
Declarando uma variável do tipo string e guardando ela no contêiner name, como é texto deve ficar entre " "
    int number = 15;
Declarando uma variável do tipo int e guardando ela no contêiner number, como é número não fica entre " " 
Se tentar converter vai dar :
error CS0029: Não é possível converter implicitamente o tipo 'string' em 'int'

Variáveis ​​são contêineres para armazenar valores de dados.
Em C#, existem diferentes tipos de variáveis ​​(definidas com diferentes palavras-chave), por exemplo:

int- armazena números inteiros (números inteiros), sem decimais, como 123 ou -123
double- armazena números de ponto flutuante, com decimais, como 19,99 ou -19,99
char- armazena caracteres únicos, como 'a' ou 'B'. Os valores char são cercados por aspas simples
string- armazena texto, como "Olá Mundo". Valores de string são cercados por aspas duplas
bool- armazena valores com dois estados: verdadeiro ou falso
*/