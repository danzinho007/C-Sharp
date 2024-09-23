Sim, você pode criar uma classe dentro de um objeto em C#. Na verdade, isso é conhecido como *classe aninhada*. Uma classe aninhada é uma classe definida dentro de outra classe. Ela pode ser útil quando você quer agrupar classes que têm uma relação lógica entre si. Olha um exemplo:

csharp
using System;

namespace MyApplication
{
    class Car  // Classe externa
    {
        public string color; 
        public string model; 

        public Car(string carColor, string carModel) {
            color = carColor;
            model = carModel;
        }

        // Classe aninhada
        public class Engine
        {
            public int horsepower;

            public Engine(int hp) {
                horsepower = hp;
            }
        }

        static void Main(string[] args)
        {
            Car myCar = new Car("red", "sedan");
            Engine myEngine = new Engine(150);

            Console.WriteLine($"Carro: {myCar.color} {myCar.model}");
            Console.WriteLine($"Potência do motor: {myEngine.horsepower} HP");
        }
    }
}


Neste exemplo, a classe Engine é aninhada dentro da classe Car. Você pode acessar e criar instâncias da classe interna normalmente. Se precisar de mais alguma coisa, é só avisar!