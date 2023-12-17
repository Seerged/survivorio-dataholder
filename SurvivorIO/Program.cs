using PlayerData;
using System.Diagnostics.CodeAnalysis;

internal partial class Program
{
    private static void Main(string[] args)
    {
        (int knownTotal, int unknownTotal, int overallTotal) = CalculateTotals(Data.twentyTonsSurvivorData, Data.twentyTonsTotalExpeditionScores[^1]);

        double unknownAverage = CalculateUnknownAverage(Data.twentyTonsSurvivorData, unknownTotal);
        double knownAverage = CalculateKnownAverage(Data.twentyTonsSurvivorData, knownTotal);

        PrintLatestValuesInDictionary(Data.twentyTonsSurvivorData);

        // if -1 there are no unknown values
        PrintUnknownPlayersNames(Data.twentyTonsSurvivorData);

        Console.WriteLine();

        PrintKnownAndUnknownPlayers(Data.twentyTonsSurvivorData);
        Console.WriteLine($"Average of Unknown Players Points: {Math.Round(unknownAverage, 1)}");
        Console.WriteLine($"Average of Known Players Points: {Math.Round(knownAverage, 1)}");
        Console.WriteLine($"Unknown Points Total: {unknownTotal}");
        Console.WriteLine($"Known Points Total: {knownTotal}");
        Console.WriteLine($"Total Overall: {overallTotal}"); 
    }
}