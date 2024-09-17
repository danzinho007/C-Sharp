// Executar com : .\aula01
using System;
namespace HelloWord
{
class Principal{
    static void Main(){
        Console.WriteLine("Ola Mundo!");
        Console.WriteLine("Me livrei da maldicao");
        Console.Write("Somando 3 com 3 da : ");
        Console.WriteLine(3 + 3);
        Console.Write("Isso");
        Console.Write(" escreve na mesma linha");
        Console.ReadKey(); // Espera o usuário pressionar uma tecla
        }
    }
}

// Explicando o código :
// Using System = Importando classes da Biblioteca do System que contém os comandos de entrada e saída
// namespace = usado para organizar o código e é um contêiner para classes e outros namespaces
// As chaves {} marcam o início e o fim de um bloco de código
// class = Container para dados e métodos que traz funcionalidade ao programa. Cada linha de código executada em C# deve estar dentro de uma classe
// Main = Método
// Console = Classe do System namspace que possui um WriteLine() método que é utilizado para saída/impressão de texto
// C# é Case Sensitive ou seja, diferencia Maúsculas de minúsculas
/*
    Comentário também
    Comandos : 
    cd .. = Volta pra pasta anterior
    cd C-Sharp = Vai pra pasta dos arquivos 
    cls = limpa a tela
    copy = copia arquivo para outra pasta
    csc = mostra a versão do compilador
    csc + nomedoarquivo.cs = compila o programa
    dir = mostra todos os arquivos da pasta
    dotnet new console
    md NomeDaPasta = cria uma pasta no local atual
    mkdir NomeDaPasta = cria uma pasta no local atual
    move = move arquivo para outra pasta
*/