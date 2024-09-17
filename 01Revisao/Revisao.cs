using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Revisão");
      Console.WriteLine("");
      Console.WriteLine("1- Qual a extensão do C# / C-Sharp ?");
      Console.WriteLine(".cs");
      Console.WriteLine("2- O que é using System no código ?");
      Console.WriteLine("Importando classes da Biblioteca do Sistema que contem os comandos de entrada e saída de dados");
      Console.WriteLine("");
      Console.WriteLine("3- O que é namespace HellowWord no código ?");
      Console.WriteLine("Conteiner para classes ( HelloWorld ) / namespaces");
      Console.WriteLine("");
      Console.WriteLine("4- O que é class Program no código ?");
      Console.WriteLine("Conteiner para dados e metodos que traz funcionalidade ao programa");
      Console.WriteLine("");
      Console.WriteLine("5- O que é static void Main(string[] args) no código ?");
      Console.WriteLine("Método que é chamado quando o programa é iniciado, e é onde você coloca o código que deseja que seja executado quando o programa é iniciado.");
      Console.WriteLine("static: significa que o método pode ser chamado sem criar uma instância da classe que o contém");
	  Console.WriteLine("* void: significa que o método não retorna nenhum valor.");
	  Console.WriteLine("* Main: é o nome do método, que é o ponto de entrada do programa.");
	  Console.WriteLine("* string[] args: é um array de strings que representa os argumentos de linha de comando passados para o programa quando ele é executado");
      Console.WriteLine("");
      Console.WriteLine("6- O que é Console.WriteLine");
      Console.WriteLine("Esse método permite escrever na tela alguma mensagem");
      Console.WriteLine("");
      Console.WriteLine("7- O que significam as chavas {} no código ?");
      Console.WriteLine("Marcar o início e o fim de um bloco de código");
      Console.WriteLine("");
      Console.WriteLine("8- Como executar um aquivo .cs ?");
      Console.WriteLine("Primeiro se deve complicar, depois se executa. Comando no Visual Studio Code ( Requer extensão C# da Microsoft): csc NomeDoArquivo.cs");
      Console.WriteLine("");
      Console.WriteLine("9- Como comentar um código em C# ?");
      Console.WriteLine("Comentário de 1 linha : // ");
      Console.WriteLine("Comentário de 2 ou mais : /* */");
      Console.WriteLine("");
      Console.WriteLine("10- ");
// int    variavel = numero; 
// -2,147,483,648 to 2,147,483,647 
// string variavel = "texto";
      Console.WriteLine("Console.ReadKey()");
      Console.WriteLine("Console.Write("Texto")");
      Console.WriteLine("Console.WriteLine("Texto")");
      Console.WriteLine("Console.WriteLine(Convert.ToDouble(variavel))");
      Console.WriteLine("Console.WriteLine(Convert.ToInt32(variavel))")
      Console.WriteLine("Console.WriteLine(Convert.ToStrin(Variavel))");
      
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
    }
  }
}
// Site 
// https://learn.microsoft.com/pt-pt/shows/csharp-for-beginners/
// https://learn.microsoft.com/en-us/dotnet/api/?view=net-6.0
// https://learn.microsoft.com/pt-pt/dotnet/csharp/tour-of-csharp/overview

/* System.Array: fornece métodos para manipular arrays.
* System.Boolean: representa um valor booleano (true ou false).
* System.Byte: representa um byte unsigned (0-255).
* System.Char: representa um caractere Unicode.
* System.Console: fornece métodos para ler e escrever na console.
* System.Convert: fornece métodos para converter entre tipos de dados.
* System.DateTime: representa uma data e hora.
* System.Decimal: representa um número decimal preciso.
* System.Double: representa um número de ponto flutuante de dupla precisão.
* System.Enum: fornece métodos para trabalhar com enumerações.
* System.Exception: é a classe base para exceções em C#.
* System_GC: fornece métodos para trabalhar com o coletor de lixo.
* System.Int16: representa um inteiro de 16 bits.
* System.Int32: representa um inteiro de 32 bits.
* System.Int64: representa um inteiro de 64 bits.
* System.Math: fornece métodos para realizar operações matemáticas.
* System.Object: é a classe base para todos os objetos em C#.
* System.Random: fornece métodos para gerar números aleatórios.
* System.String: representa uma cadeia de caracteres.
* System.Type: fornece métodos para trabalhar com tipos de dados.
* System.UInt16: representa um inteiro unsigned de 16 bits.
* System.UInt32: representa um inteiro unsigned de 32 bits.
* System.UInt64: representa um inteiro unsigned de 64 bits.

* using System.Collections;: fornece classes e interfaces para trabalhar com coleções de objetos.
* using System.Collections.Generic;: fornece classes e interfaces para trabalhar com coleções genéricas de objetos.
* using System.Data;: fornece classes e interfaces para trabalhar com dados e bancos de dados.
* using System.Diagnostics;: fornece classes e interfaces para depurar e diagnosticar aplicativos.
* using System.Drawing;: fornece classes e interfaces para trabalhar com gráficos e imagens.
* using System.IO;: fornece classes e interfaces para trabalhar com entrada e saída de arquivos e streams.
* using System.Linq;: fornece classes e interfaces para trabalhar com linguagens de consulta integradas (LINQ).
* using System.Net;: fornece classes e interfaces para trabalhar com redes e comunicação de rede.
* using System.Reflection;: fornece classes e interfaces para trabalhar com reflexão e metadata.
* using System.Runtime;: fornece classes e interfaces para trabalhar com runtime e segurança.
* using System.Security;: fornece classes e interfaces para trabalhar com segurança e autorização.
* using System.Text;: fornece classes e interfaces para trabalhar com strings e codificação de texto.
* using System.Threading;: fornece classes e interfaces para trabalhar com threads e sincronização.
* using System.Web;: fornece classes e interfaces para trabalhar com aplicativos web e ASP.NET.
* using System.Windows.Forms;: fornece classes e interfaces para trabalhar com formulários e interfaces de usuário em Windows Forms.

* using Microsoft.CSharp;: fornece classes e interfaces para trabalhar com a linguagem C#.
* using Microsoft.VisualBasic;: fornece classes e interfaces para trabalhar com a linguagem Visual Basic .NET.
* using Newtonsoft.Json;: fornece classes e interfaces para trabalhar com JSON e serialização de dados.
* using NUnit.Framework;: fornece classes e interfaces para trabalhar com testes unitários.
* using OpenTK;: fornece classes e interfaces para trabalhar com gráficos 3D e jogos.
* using Xamarin.Forms;: fornece classes e interfaces para trabalhar com aplicativos móveis cross-platform.

*/
