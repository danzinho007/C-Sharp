/* Beleza, aqui vai um exemplo básico pra ficar mais claro:

csharp
class ExemploMetodo {
    // Método principal
    public void MetodoPrincipal() {
        Console.WriteLine("Esse é o método principal.");
        
        // Chamando outro método
        MetodoSecundario();
    }

    // Outro método que é chamado pelo principal
    public void MetodoSecundario() {
        Console.WriteLine("Esse é o método secundário.");
    }
}

// Usando a classe
class Program {
    static void Main(string[] args) {
        ExemploMetodo exemplo = new ExemploMetodo();
        exemplo.MetodoPrincipal(); // Aqui você chama o método principal
    }
}


No código acima, MetodoSecundario é chamado dentro do MetodoPrincipal, 
mas ele não tá "dentro" dele, ou seja, eles são métodos separados na 
mesma classe. 
Se tiver mais dúvidas ou se precisar de mais exemplos, manda ver!

A saída do código que você mandou vai ser:


Esse é o método principal.
Esse é o método secundário.


Quando você executar exemplo.MetodoPrincipal(), ele vai primeiro 
imprimir a mensagem do método principal e, em seguida, 
chamar MetodoSecundario(), que por sua vez imprime a mensagem do 
método secundário. Se precisar de mais alguma coisa, só avisar!


Dá pra chamar o método já com a mensagem, mas a ideia de separar 
os métodos é deixar o código mais organizado e reutilizável. Assim, 
se precisar da mesma mensagem em outros lugares, é só chamar o 
método sem precisar repetir a lógica. Mas se você quiser 
simplificar tudo dentro de um só método, ficaria assim:

csharp
class ExemploMetodo {
    public void MetodoUnico() {
        // Mensagens em um só método
        Console.WriteLine("Esse é o método principal.");
        Console.WriteLine("Esse é o método secundário.");
    }
}

// Usando a classe
class Program {
    static void Main(string[] args) {
        ExemploMetodo exemplo = new ExemploMetodo();
        exemplo.MetodoUnico(); // Chama o método único
    }
}


Nesse caso, a saída ainda seria:


Esse é o método principal.
Esse é o método secundário.


No final das contas, a forma como você organiza depende do que você 
precisa. Saca? Se tiver mais alguma dúvida, tô aqui!

O certo é que a classe principal, que geralmente é a que contém a 
função Main, deve vir depois da definição da classe ou classes que 
você criou. Assim, o código fica mais organizado e a lógica é mais 
fácil de entender. 

No exemplo que passei, a classe ExemploMetodo vem antes da 
classe Program, que é onde está o método Main. Isso permite que a 
classe Program utilize os métodos da ExemploMetodo. Se precisar de 
mais detalhes, só me falar!

==================

Sim, cê pode criar várias classes e vários namespaces em C#. 
Isso ajuda a organizar seu código de um jeito mais limpo e compreensível. 

- *Várias Classes*: Dentro de um único arquivo ou em arquivos separados, 
cê pode ter quantas classes quiser. Cada classe pode ter seus métodos e propriedades. 
- *Múltiplos Namespaces*: É super comum ter múltiplos namespaces pra 
evitar conflitos de nomes e organizar seu código. Pra definir 
um namespace, é só usar a palavra-chave namespace seguida do nome 
que você deseja.

### Exemplo de Como Fazer:
csharp
using System;

namespace MeuAplicativo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello from Program!");
            MinhaClasse obj = new MinhaClasse();
            obj.ExibirMensagem();
        }
    }
    
    class MinhaClasse
    {
        public void ExibirMensagem()
        {
            Console.WriteLine("Hello from MinhaClasse!");
        }
    }
}

namespace OutroNamespace
{
    class OutraClasse
    {
        public void AlgumaCoisa()
        {
            Console.WriteLine("Hello from OutraClasse!");
        }
    }
}


Dando uma olhada nas referências que encontrei:

- [Namespaces - Microsoft Learn]
(https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/namespaces)
- [C# Namespaces com Exemplos - Programiz]
(https://www.programiz.com/csharp-programming/namespaces)

Se precisar de mais ajuda é só falar!

==================

Sim, dá pra chamar uma classe de outro namespace em C#. 
Pra isso, você usa a palavra-chave using no começo do seu 
arquivo de código pra importar o namespace que contém 
a classe que você quer usar. 

### Exemplo:
csharp
using System;

namespace MeuAplicativo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello from Program!");
            MinhaClasse obj = new MinhaClasse(); // Chama MinhaClasse do OutroNamespace
            obj.ExibirMensagem();
        }
    }

    class MinhaClasse
    {
        public void ExibirMensagem()
        {
            Console.WriteLine("Hello from MinhaClasse!");
        }
    }
}

namespace OutroNamespace
{
    public class OutraClasse
    {
        public void AlgumaCoisa()
        {
            Console.WriteLine("Hello from OutraClasse!");
        }
    }
}


### Chamar OutraClasse no Program:
Pra usar OutraClasse dentro de Program, só precisa adicionar:
csharp
using OutroNamespace;

Assim, fica bem tranquilo de chamar classes entre namespaces.

Se precisar de mais detalhes ou exemplos, só falar!

=============

Exato! O modificador public significa que a classe ou método 
pode ser acessado de qualquer lugar, mesmo de outras assemblies. 
Já o static é um pouco diferente. Quando você declara uma 
classe ou método como static, você não precisa instanciar a 
classe pra acessar os métodos dela. O acesso pode ser feito 
diretamente pelo nome da classe.

### Exemplo:
csharp
namespace MeuAplicativo
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello from Program!");
            OutraClasse.AlgumaCoisa(); // Chamando um método static diretamente
        }
    }
}

namespace OutroNamespace
{
    public static class OutraClasse
    {
        public static void AlgumaCoisa()
        {
            Console.WriteLine("Hello from OutraClasse!");
        }
    }
}


Nesse caso, você pode chamar o método AlgumaCoisa() sem precisar criar 
uma instância de OutraClasse. 

===

Se você quiser chamar outro arquivo .cs na mesma pasta, é bem tranquilo. 
Primeiro, você só precisa garantir que o namespace do arquivo que você 
quer acessar seja o mesmo ou que você tenha o using correto no 
arquivo onde tá chamando.

### Exemplo:
Digamos que você tenha dois arquivos na mesma pasta: 
Program.cs e OutraClasse.cs.

*Program.cs*
csharp
using System;

namespace MeuAplicativo
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello from Program!");
            OutraClasse.AlgumaCoisa(); // Chamando um método de OutraClasse
        }
    }
}


*OutraClasse.cs*
csharp
namespace MeuAplicativo
{
    public class OutraClasse
    {
        public static void AlgumaCoisa()
        {
            Console.WriteLine("Hello from OutraClasse!");
        }
    }
}


Nesse caso, OutraClasse pode ser chamada diretamente 
em Program.cs porque ambas estão no mesmo namespace. 
Se os namespaces forem diferentes, você precisa 
ajustar o using no topo do seu arquivo. 

===

Pra fazer conexão com SQL em C#, você normalmente usa 
o namespace System.Data.SqlClient. A conexão é feita 
usando a classe SqlConnection. Aqui vai um exemplo 
básico de como fazer isso:

### Exemplo de Conexão com SQL Server:
csharp
using System;
using System.Data.SqlClient;

namespace MeuAplicativo
{
    public class Program
    {
        static void Main()
        {
            string connectionString = "Data Source=seu_servidor;Initial Catalog=seu_banco;User ID=seu_usuario;Password=sua_senha;";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexão aberta com sucesso!");

                    // Execute suas consultas aqui, por exemplo:
                    SqlCommand command = new SqlCommand("SELECT * FROM sua_tabela", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["sua_coluna"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }
        }
    }
}


### Coisas a Configurar:
1. *Connection String*: Altere os valores seu_servidor, 
seu_banco, seu_usuario, e sua_senha conforme seu ambiente.
2. *Consultas*: Troque sua_tabela e sua_coluna com os nomes 
reais da sua tabela e coluna no banco de dados.

    
*/