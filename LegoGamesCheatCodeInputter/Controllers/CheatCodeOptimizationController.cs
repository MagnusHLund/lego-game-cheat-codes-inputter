using LegoGamesCheatCodeInputter.Controllers.Interfaces;
using LegoGamesCheatCodeInputter.Models;

namespace LegoGamesCheatCodeInputter.Controllers;

public sealed class CheatCodeOptimizationController : ICheatCodeOptimizationController
{
    private const string Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

    private readonly Dictionary<char, int> _characterIndices;

    public CheatCodeOptimizationController()
    {
        _characterIndices = new Dictionary<char, int>(Characters.Length);

        for (int i = 0; i < Characters.Length; i++)
        {
            _characterIndices[Characters[i]] = i;
        }
    }

    public IReadOnlyList<CheatCode> Optimize(IReadOnlyList<CheatCode> cheatCodes)
    {
        ArgumentNullException.ThrowIfNull(cheatCodes);

        if (cheatCodes.Count <= 1)
            return cheatCodes.ToArray();

        ValidateCodes(cheatCodes);

        int[,] distances = BuildDistanceMatrix(cheatCodes);
        int[] initialDistances = BuildInitialDistances(cheatCodes);

        int[] route = FindRoute(cheatCodes.Count, distances, initialDistances);

        CheatCode[] optimizedCodes = new CheatCode[route.Length];

        for (int i = 0; i < route.Length; i++)
        {
            optimizedCodes[i] = cheatCodes[route[i]];
        }

        return optimizedCodes;
    }

    private static int[] FindRoute(int codeCount, int[,] distances, int[] initialDistances)
    {
        int[] bestRoute = [];
        int bestCost = int.MaxValue;

        /*
         * Try every code as the first code.
         *
         * This matters because the first code starts from AAAAAA.
         */
        for (int start = 0; start < codeCount; start++)
        {
            int[] route = BuildNearestNeighborRoute(codeCount, start, distances);

            ImproveWithTwoOpt(route, distances);

            int cost = CalculateRouteCost(route, distances, initialDistances);

            if (cost < bestCost)
            {
                bestCost = cost;
                bestRoute = route;
            }
        }

        return bestRoute;
    }

    private static int[] BuildNearestNeighborRoute(int codeCount, int start, int[,] distances)
    {
        int[] route = new int[codeCount];
        bool[] visited = new bool[codeCount];

        route[0] = start;
        visited[start] = true;

        for (int position = 1; position < codeCount; position++)
        {
            int current = route[position - 1];

            int closestCode = -1;
            int closestDistance = int.MaxValue;

            for (int candidate = 0; candidate < codeCount; candidate++)
            {
                if (visited[candidate])
                    continue;

                int distance = distances[current, candidate];

                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closestCode = candidate;
                }
            }

            route[position] = closestCode;
            visited[closestCode] = true;
        }

        return route;
    }

    private static void ImproveWithTwoOpt(int[] route, int[,] distances)
    {
        if (route.Length < 3)
            return;

        bool improved;

        do
        {
            improved = false;

            for (int i = 1; i < route.Length - 1; i++)
            {
                for (int j = i + 1; j < route.Length; j++)
                {
                    int before = route[i - 1];
                    int first = route[i];
                    int last = route[j];

                    int after = j + 1 < route.Length ? route[j + 1] : -1;

                    int oldCost = distances[before, first];

                    if (after >= 0)
                    {
                        oldCost += distances[last, after];
                    }

                    int newCost = distances[before, last];

                    if (after >= 0)
                    {
                        newCost += distances[first, after];
                    }

                    if (newCost >= oldCost)
                        continue;

                    Reverse(route, i, j);

                    improved = true;
                }
            }
        } while (improved);
    }

    private static void Reverse(int[] route, int start, int end)
    {
        while (start < end)
        {
            (route[start], route[end]) = (route[end], route[start]);

            start++;
            end--;
        }
    }

    private static int CalculateRouteCost(int[] route, int[,] distances, int[] initialDistances)
    {
        if (route.Length == 0)
            return 0;

        int cost = initialDistances[route[0]];

        for (int i = 1; i < route.Length; i++)
        {
            cost += distances[route[i - 1], route[i]];
        }

        return cost;
    }

    private int[,] BuildDistanceMatrix(IReadOnlyList<CheatCode> cheatCodes)
    {
        int count = cheatCodes.Count;
        int[,] distances = new int[count, count];

        for (int i = 0; i < count; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                int distance = CalculateDistance(cheatCodes[i].Code, cheatCodes[j].Code);

                distances[i, j] = distance;
                distances[j, i] = distance;
            }
        }

        return distances;
    }

    private int[] BuildInitialDistances(IReadOnlyList<CheatCode> cheatCodes)
    {
        int[] distances = new int[cheatCodes.Count];

        for (int i = 0; i < cheatCodes.Count; i++)
        {
            distances[i] = CalculateDistance(
                new string('A', cheatCodes[i].Code.Length),
                cheatCodes[i].Code
            );
        }

        return distances;
    }

    private int CalculateDistance(string from, string to)
    {
        if (from.Length != to.Length)
        {
            throw new ArgumentException("All cheat codes must have the same length.");
        }

        int distance = 0;

        for (int position = 0; position < from.Length; position++)
        {
            int fromIndex = _characterIndices[from[position]];
            int toIndex = _characterIndices[to[position]];

            int directDistance = Math.Abs(toIndex - fromIndex);

            int wrappedDistance = Characters.Length - directDistance;

            distance += Math.Min(directDistance, wrappedDistance);
        }

        return distance;
    }

    private static void ValidateCodes(IReadOnlyList<CheatCode> cheatCodes)
    {
        if (cheatCodes.Count == 0)
            return;

        int expectedLength = cheatCodes[0].Code.Length;

        for (int i = 0; i < cheatCodes.Count; i++)
        {
            CheatCode? cheatCode = cheatCodes[i];

            if (cheatCode is null)
            {
                throw new ArgumentException(
                    $"Cheat code at index {i} is null.",
                    nameof(cheatCodes)
                );
            }

            if (string.IsNullOrWhiteSpace(cheatCode.Code))
            {
                throw new ArgumentException(
                    $"Cheat code at index {i} is blank.",
                    nameof(cheatCodes)
                );
            }

            if (cheatCode.Code.Length != expectedLength)
            {
                throw new ArgumentException(
                    "All cheat codes must have the same length.",
                    nameof(cheatCodes)
                );
            }

            foreach (char character in cheatCode.Code)
            {
                if (!Characters.Contains(character))
                {
                    throw new ArgumentException(
                        $"Cheat code '{cheatCode.Code}' contains "
                            + $"unsupported character '{character}'. "
                            + "Codes must use A-Z and 0-9 uppercase.",
                        nameof(cheatCodes)
                    );
                }
            }
        }
    }
}
