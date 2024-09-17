/*
1. Matriz Bidimensional* (2D):
   csharp
   int[,] matriz2D = { { 1, 2, 3 }, { 4, 5, 6 } };
   // Acessando o elemento na linha 0, coluna 2
   Console.WriteLine(matriz2D[0, 2]); // Imprime 3
   
2. *Matriz Multidimensional* (3D):
   csharp
   int[,,] matriz3D = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
   // Acessando o elemento na primeira "camada", segunda linha, primeiro coluna
   Console.WriteLine(matriz3D[0, 1, 0]); // Imprime 3

Sim, dá pra falar sobre matrizes tridimensionais (3D). Uma matriz 3D pode ser vista como um "cubo" de dados, onde cada elemento é acessado através de três índices. Aqui vai um exemplo em C#:

csharp
int[,,] matriz3D = { 
    { 
        { 1, 2 }, 
        { 3, 4 } 
    }, 
    { 
        { 5, 6 }, 
        { 7, 8 } 
    } 
};
// Acessando um elemento: primeira "camada", segunda linha, primeira coluna
Console.WriteLine(matriz3D[0, 1, 0]); // Imprime 3


Nesse caso, a matriz tem 2 "camadas" (ou planos) com 2 linhas e 2 colunas cada um. Assim, você consegue organizar dados de um jeito mais complexo e pode trabalhar com informações que precisam das 3 dimensões. Se quiser mais detalhes ou outro exemplo, só avisar!

4. "Matriz Multidimensional" (4D)
   csharp
int[,,,] matriz4D = { 
    { 
        { { 1, 2 }, { 3, 4 } }, 
        { { 5, 6 }, { 7, 8 } } 
    }, 
    { 
        { { 9, 10 }, { 11, 12 } }, 
        { { 13, 14 }, { 15, 16 } } 
    } 
};
// Acessando o elemento na primeira "camada", segunda "subcamada", primeira linha, segunda coluna
Console.WriteLine(matriz4D[0, 1, 0, 1]); // Imprime 4

5. "Matriz Muldimensional" (5D)
    int[,,,,] matriz5D = { 
    { 
        { 
            { { 1, 2 }, { 3, 4 } }, 
            { { 5, 6 }, { 7, 8 } } 
        }, 
        { 
            { { 9, 10 }, { 11, 12 } }, 
            { { 13, 14 }, { 15, 16 } } 
        } 
    }, 
    { 
        { 
            { { 17, 18 }, { 19, 20 } }, 
            { { 21, 22 }, { 23, 24 } } 
        }, 
        { 
            { { 25, 26 }, { 27, 28 } }, 
            { { 29, 30 }, { 31, 32 } } 
        } 
    } 
};
// Acessando o elemento na primeira "camada", segunda "subcamada", primeira linha, segunda coluna
Console.WriteLine(matriz5D[0, 1, 0, 1, 1]); // Imprime 12

Resumo :
Aquantidade de grupos em uma matriz de dimensões diferentes é relacionada a 2 elevado à potência do número de dimensões. Assim:

- Bidimensional (2D) = 2¹ = 2 grupos
- Multidimensional (3D) = 2² = 4 grupos
- 4D / Quadridimensional = 2³ = 8 grupos
- 5D / - quintidimensional. = 2⁴ = 16 grupos
- 6D / sextidimensional. = 2⁵ = 32 grupos
7D é septidimensional
8D é octodimensional

Portanto, tudo que você listou tá certo até 6D. Esse padrão continua, ou seja, a cada nova dimensão, você duplica a quantidade de grupos. 
*/