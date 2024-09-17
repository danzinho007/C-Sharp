using System;

namespace aula05
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Função Implícita");
      int myInt = 9;
      double myDouble = myInt; // Convertendo Inteiro para Duplo
      Console.WriteLine("Número Inteiro " + myInt);
      Console.WriteLine("Número Dubplo " + myDouble);
      Console.WriteLine("");
      Console.WriteLine("Função Explícita");
      double myDouble1 = 9.78;
      int myInt1 = (int) myDouble1; // Convertendo Duplo para Inteiro
      Console.WriteLine("Número Duplo " + myDouble1);
      Console.WriteLine("Número Inteiro " + myInt1);
      Console.WriteLine("");
      Console.WriteLine("Método Integrado");
      int myInt2 = 10;
      double myDouble2 = 5.25;
      bool myBool2 = true;
      Console.WriteLine("Convertendo Inteiro para Texto");
      Console.WriteLine(Convert.ToString(myInt2));
      Console.WriteLine("Convertendo Inteiro para Duplo");
      Console.WriteLine(Convert.ToDouble(myDouble2));
      Console.WriteLine("Convertendo Duplo para Inteiro");
      Console.WriteLine(Convert.ToInt32(myDouble2));
      Console.WriteLine("Convertendo Boleano para Texto");
      Console.WriteLine(Convert.ToString(myBool2));
    }
  }
}

// Tipos de Dados
// Tipo - Tamanho - Descrição
// int - 4 bytes - Stores whole numbers from -2,147,483,648 to 2,147,483,647 
// Exemplo : int myNum = 100000
// long - 8 - Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
// Exemplo : long myNum = 15000000000L
// float - 4 - Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
// Exemplo : float myNum = 5.75F
//                       = 35e3F
// double - 8 - Stores fractional numbers. Sufficient for storing 15 decimal digits
// Exemplo : double myNum = 19.99D
//                          12E4D
// bool - 1 - Stores true or false values
// Exemplo : bool isCharpFun = true 
//                           = false
// char - 2 - Stores a single character/letter, surrounded by single quotes
// Exemplo : char myGrade = 8 
// string - 2 por letra - Stores a sequence of characters, surrounded by double quotes
// Exemplo : string greeting = "Hello World"

// Números : int e long ou float e double

// Conversão :
// Conversão implícita (automaticamente) - convertendo um tipo menor em um tamanho de tipo maior
// char-> int-> long-> float->double
// Conversão explícita (manual) - convertendo um tipo maior em um tipo de tamanho menor
// double-> float-> long-> int->char
