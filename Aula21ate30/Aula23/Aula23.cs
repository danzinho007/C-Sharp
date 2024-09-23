
/* 
prog.cs(19,5): error CS9010: Primary constructor body is not allowed
Compilation failed: 1 error(s), 0 warnings

Esse erro *CS9010: Primary constructor body is not allowed* acontece quando você tenta usar um corpo de construtor em um construtor primário, que não é permitido no C#. Aqui vão algumas dicas pra resolver:

1. *Verifica seu construtor*: Em vez de criar um corpo para o construtor, apenas declare os parâmetros e deixe o C# inicializar os campos diretamente. Exemplo:
   csharp
   public class MinhaClasse(int parametro1, string parametro2) 
   {
       // não adicione código aqui
   }
   

2. *Cuidado com a sintaxe*: Se estiver usando C# 12 ou superior, certifique-se de estar usando a sintaxe correta dos construtores primários, que é mais concisa.

3. *Referências úteis*:
   - [Documentação sobre construtores primários](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/primary-constructors)
   - [Discussões sobre o erro](https://stackoverflow.com/questions/31757953/what-does-primary-constructor-body-not-allowed-mean)

Dá uma olhada nisso e vê se resolve o seu problema! Se precisar de mais ajuda, só falar.

----------------
prog.cs(19,6): error CS9010: Primary constructor body is not allowed
prog.cs(65,1): error CS1035: End-of-file found, '*/' 

/*Compilation failed: 2 error(s), 0 warnings

Esse erro *CS9010: Primary constructor body is not allowed* já discutimos, mas agora tem outro erro, *CS1035: End-of-file found, '/' expected**, que indica que o compilador esperava um fechamento de comentário. Esse erro geralmente ocorre quando tem algum comentário não fechado.

Aqui estão algumas dicas pra resolver os erros:

1. *Erro CS9010*: 
   - Verifica novamente a definição do construtor. Lembre-se que um construtor primário não pode ter um corpo. A solução é manter a construção simples, sem código no corpo.

2. *Erro CS1035*: 
   - Isso geralmente é causado por um comentário que não foi fechado. Se você usou /* pra começar um comentário, precisa ter um  correspondente. Verifica se em algum /*lugar código tem um comentário que não foi fechado.

Aqui vai um exemplo simples de como deve ser o código pra evitar esses erros:

csharp
using System;

namespace MyApplication
{
    class Car
    {
        public string model;

        // Construtor correto sem corpo
        public Car(string modelName)
        {
            model = modelName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang");
            Console.WriteLine(Ford.model);
        }
    }
}


Dá uma conferida no seu código e faz esses ajustes. Se os erros persistirem, manda o trecho relacionado e vamos revisar juntos!

Beleza, vamos decifrar esses erros:

1. *Erro CS9010: Primary constructor body is not allowed*:
   - Já falamos sobre isso. Certifica que o construtor primário não tem corpo. Se tu tá usando o construtor primário, não deve ter código ali dentro. 

2. *Erro CS1012: Too many characters in character literal*:
   - Esse erro geralmente acontece quando você usa aspas simples para definir um caractere, mas acabou colocando mais de um caractere dentro. Por exemplo, isso causaria o erro: char c = 'ab';. Verifica se não tem uma definição assim no seu código e troca por uma string com aspas duplas string.

3. *Erro CS1035: End-of-file found, '/' expected**:
   - Como já discutimos, esse erro geralmente indica que tem um comentário não fechado. Garanta que todos os comentários que começam com /* tenham o fechamento */. 
/* Também, verifica se não tem chaves ou parênteses abertos que não foram fechados.

Faz uma olhada nessas partes do seu código e tenta corrigir. Se tu precisar de mais ajuda, manda o trecho específico onde estão os erros!
*/