namespace AntAlgorithm;

public class AntColony
{
    private readonly double[,] _distances;    // Матрица расстояний
    private readonly double[,] _pheromones;   // Матрица феромонов
    private readonly int _numPlaces;          // Количество мест
    private readonly double _alpha;           // Влияние феромона
    private readonly double _beta;            // Влияние эвристики
    private readonly double _evaporation;     // Коэффициент испарения
    private readonly double Q;                // Количество феромона

    private readonly Random _random = new Random();

    public AntColony(double[,] distances, double alpha = 1.0, double beta = 2.0, double evaporation = 0.5, double Q = 100.0)
    {
        _distances = distances;
        _numPlaces = distances.GetLength(0);
        _pheromones = new double[_numPlaces, _numPlaces];
        _alpha = alpha;
        _beta = beta;
        _evaporation = evaporation;
        this.Q = Q;

        for (int i = 0; i < _numPlaces; i++)
            for (int j = 0; j < _numPlaces; j++)
                _pheromones[i, j] = 1.0;
    }

    public List<int> SolveTSP(int iterations, int ants, int startPlace)
    {
        List<int> bestTour = null;
        double bestTourLength = double.MaxValue;

        for (int iter = 0; iter < iterations; iter++)
        {
            List<List<int>> allTours = new List<List<int>>();
            for (int ant = 0; ant < ants; ant++)
            {
                List<int> tour = GenerateTour(startPlace);
                allTours.Add(tour);

                double tourLength = CalculatePathLength(tour);
                if (tourLength < bestTourLength)
                {
                    bestTourLength = tourLength;
                    bestTour = new List<int>(tour);
                }
            }

            UpdatePheromones(allTours);
        }

        return bestTour;
    }

    public List<List<int>> FindOptimalRoute(int start, int end, int iterations, int ants, int numBestRoutes)
    {
        List<int> bestRoute = null;
        double bestRouteLength = double.MaxValue;

        List<(List<int> Route, double Length)> topRoutes = new();

        for (int iter = 0; iter < iterations; iter++)
        {
            for (int ant = 0; ant < ants; ant++)
            {
                List<int> route = GenerateRoute(start, end);
                double routeLength = CalculatePathLength(route);

                if (routeLength < bestRouteLength)
                {
                    bestRouteLength = routeLength;
                    bestRoute = new List<int>(route);
                }

                topRoutes.Add((new List<int>(route), routeLength));
            }

            UpdatePheromones(new List<List<int>> { bestRoute });
        }

        topRoutes = topRoutes
            .OrderBy(r => r.Length)
            .GroupBy(r => string.Join(",", r.Route))
            .Select(g => g.First())
            .Take(numBestRoutes)
            .ToList();

        return topRoutes.Select(r => r.Route).ToList();
    }

    private List<int> GenerateTour(int startPlace)
    {
        List<int> tour = new List<int> { startPlace };
        HashSet<int> visited = new HashSet<int> { startPlace };

        while (tour.Count < _numPlaces)
        {
            int currentCity = tour.Last();
            int nextCity = SelectNextCity(currentCity, visited);
            tour.Add(nextCity);
            visited.Add(nextCity);
        }

        return tour;
    }

    private List<int> GenerateRoute(int start, int end)
    {
        List<int> route = new List<int> { start };
        HashSet<int> visited = new HashSet<int> { start };

        int currentCity = start;
        while (currentCity != end)
        {
            int nextCity = SelectNextCity(currentCity, visited);
            route.Add(nextCity);
            visited.Add(nextCity);
            currentCity = nextCity;
        }

        return route;
    }

    private int SelectNextCity(int currentCity, HashSet<int> visited)
    {
        double[] probabilities = new double[_numPlaces];
        double totalProbability = 0.0;

        for (int i = 0; i < _numPlaces; i++)
        {
            if (!visited.Contains(i))
            {
                double pheromone = Math.Pow(_pheromones[currentCity, i], _alpha);
                double heuristic = Math.Pow(1.0 / _distances[currentCity, i], _beta);
                probabilities[i] = pheromone * heuristic;
                totalProbability += probabilities[i];
            }
        }

        double randomValue = _random.NextDouble() * totalProbability;
        double cumulativeProbability = 0.0;

        for (int i = 0; i < _numPlaces; i++)
        {
            if (!visited.Contains(i))
            {
                cumulativeProbability += probabilities[i];
                if (cumulativeProbability >= randomValue)
                    return i;
            }
        }

        throw new Exception("Не удалось выбрать следующий город.");
    }

    private void UpdatePheromones(List<List<int>> allTours)
    {
        for (int i = 0; i < _numPlaces; i++)
            for (int j = 0; j < _numPlaces; j++)
                _pheromones[i, j] *= (1.0 - _evaporation);

        foreach (var tour in allTours)
        {
            double tourLength = CalculatePathLength(tour);
            double pheromoneDeposit = Q / tourLength;

            for (int i = 0; i < tour.Count - 1; i++)
            {
                int from = tour[i];
                int to = tour[i + 1];
                _pheromones[from, to] += pheromoneDeposit;
                _pheromones[to, from] += pheromoneDeposit;
            }
        }
    }

    public double CalculatePathLength(List<int> path)
    {
        double length = 0.0;
        for (int i = 0; i < path.Count - 1; i++)
        {
            length += _distances[path[i], path[i + 1]];
        }

        return length;
    }
}
