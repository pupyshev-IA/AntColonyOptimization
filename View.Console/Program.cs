using AntAlgorithm;

class Program
{
    static void Main(string[] args)
    {
        int places;
        int tspStartPlace, startPlace, endPlace;

        Console.Write("Введите количество мест: ");
        int.TryParse(Console.ReadLine(), out places);
        Console.WriteLine();

        double[,] distances = CreateRandomMatrix(places);
        DisplayMatrix(distances);

        var colony = new AntColony(distances);

        Console.WriteLine("\n\n-----РЕШЕНИЕ ЗАДАЧИ КОММИВОЯЖЁРА-----");
        Console.Write($"Введите отправную позицию: ");
        int.TryParse(Console.ReadLine(), out tspStartPlace);

        var tspTour = colony.SolveTSP(iterations: 100, ants: 10, tspStartPlace - 1);
        Console.WriteLine("Лучший маршрут: " + string.Join(" -> ", tspTour.Select(n => n + 1)));
        Console.WriteLine($"Длина маршрута: {colony.CalculatePathLength(tspTour)}");

        Console.WriteLine("\n\n-----НАХОЖДЕНИЕ КРАТЧАЙШЕГО ПУТИ МЕЖДУ ДВУМЯ ТОЧКАМИ-----");
        Console.Write($"Введите начальную позицию: ");
        int.TryParse(Console.ReadLine(), out startPlace);
        Console.Write("Введите конечную позицию: ");
        int.TryParse(Console.ReadLine(), out endPlace);

        var optimalRoute = colony.FindOptimalRoute(startPlace - 1, endPlace - 1, iterations: 100, ants: 10, numBestRoutes: 1);
        Console.WriteLine("\nЛучший маршрут для двух точек: " + string.Join(" -> ", optimalRoute.First().Select(n => n + 1)));
        Console.WriteLine($"Длина маршрута: {colony.CalculatePathLength(optimalRoute.First())}");

        Console.ReadLine();
    }

    private static double[,] CreateRandomMatrix(int matrixSize)
    {
        var random = new Random();
        double[,] distances = new double[matrixSize, matrixSize];

        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = i; j < matrixSize; j++)
            {
                if (i == j)
                {
                    distances[i, j] = 0;
                }
                else
                {
                    double randomValue = random.Next(1, 15);
                    distances[i, j] = randomValue;
                    distances[j, i] = randomValue;
                }
            }
        }

        return distances;
    }

    private static void DisplayMatrix(Array matrix)
    {
        int size = matrix.GetLength(0);
        int columnWidth = 10;

        Console.Write(new string(' ', columnWidth));
        for (int i = 1; i <= size; i++)
            Console.Write($"Точка {i}".PadRight(columnWidth));
        Console.WriteLine();

        Console.WriteLine(new string('-', columnWidth * (size + 1)));

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Точка {i + 1}".PadRight(columnWidth));

            for (int j = 0; j < size; j++)
                Console.Write(matrix.GetValue(i, j).ToString().PadRight(columnWidth));

            Console.WriteLine();
        }
    }
}
