using PlayerData;

partial class Program
{
    /// <summary>
    /// Prints a formatted dictionary of PlayerData.
    /// </summary>
    /// <param name="playerData">The dictionary you want to print.</param>
    public static void PrintWholeDictionary(Dictionary<string, List<PlayerInfo>> playerData)
    {
        foreach (KeyValuePair<string, List<PlayerInfo>> kvp in playerData)
        {
            Console.WriteLine($"Player: {kvp.Key}");
            Console.WriteLine($"{"Attack", 7}{"Clan Points", 20}{"Date", 20}");

            foreach (PlayerInfo playerInfo in kvp.Value)
            {
                Console.Write($"{(playerInfo.attack != null ? $"{playerInfo.attack:N0}" : "?"), 7}{(playerInfo.clanPoints != null ? playerInfo.clanPoints : "?"), 20}{(playerInfo.date != null ? $"{playerInfo.date:dd/MM/yyyy}" : "N/A"), 20}");
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }

    /// <summary>
    /// Prints specific key and value from a dictionary of PlayerData.
    /// </summary>
    /// <param name="playerData">The dictionary you want to grab data from.</param>
    /// <param name="player">The name of the player.</param>
    /// <param name="dataIndex">The specific index of PlayerInfo you want to access.</param>
    /// <exception cref="ArgumentException"></exception>
    public static void PrintSpecificInstance(Dictionary<string, List<PlayerInfo>> playerData, string player, int dataIndex)
    {
        if (!playerData.TryGetValue(player, out List<PlayerInfo>? value)) throw new ArgumentException("Player name provided is invalid.");

        if (dataIndex < 0 || dataIndex >= value.Count) throw new ArgumentException("Index provided does not exist for chosen player.");

        PlayerInfo playerInfo = value[dataIndex];

        Console.WriteLine($"Player: {player}");
        Console.WriteLine($"{"Attack", 7}{"Clan Points", 20}{"Date", 20}");
        Console.Write($"{(playerInfo.attack != null ? playerInfo.attack : "?"), 6}{(playerInfo.clanPoints != null ? playerInfo.clanPoints : "?"), 20}{(playerInfo.date != null ? $"{playerInfo.date:dd/MM/yyyy}" : "N/A"), 20}");
        Console.WriteLine();
    }

    /// <summary>
    /// Prints each latest value from each player in a dictionary.
    /// </summary>
    /// <param name="playerData">The dictionary you want to grab data from.</param>
    public static void PrintLatestValuesInDictionary(Dictionary<string, List<PlayerInfo>> playerData)
    {
        foreach (KeyValuePair<string, List<PlayerInfo>> kvp in playerData)
        {
            PlayerInfo playerInfo = kvp.Value[^1];

            Console.WriteLine($"Player: {kvp.Key}");
            Console.WriteLine($"{"Attack",6}{"Clan Points",20}{"Date",20}");
            Console.Write($"{(playerInfo.attack != null ? playerInfo.attack : "?"), 6}{(playerInfo.clanPoints != null ? playerInfo.clanPoints : "?"), 20}{(playerInfo.date != null ? $"{playerInfo.date:dd/MM/yyyy}" : "N/A"), 20}");
            Console.WriteLine("\n");
        }
    }

    /// <summary>
    /// Prints players names who haven't provided their latest clan points.
    /// </summary>
    /// <param name="playerData">The dictionary you want to grab data from.</param>
    public static void PrintUnknownPlayersNames(Dictionary<string, List<PlayerInfo>> playerData)
    {
        Console.WriteLine("Players with Unknown Clan Points");
        int unrecordedPlayers = 0;

        foreach (KeyValuePair<string, List<PlayerInfo>> kvp in playerData)
        {
            PlayerInfo playerInfo = kvp.Value[^1];

            if (playerInfo.clanPoints == null)
            {
                Console.WriteLine(kvp.Key);
                unrecordedPlayers++;
            }
        }

        if (unrecordedPlayers == 0) Console.WriteLine("None!");
    }

    public static void PrintKnownAndUnknownPlayers(Dictionary<string, List<PlayerInfo>> playerData)
    {
        int unrecordedPlayers = 0;
        int recordedPlayers = 0;

        foreach (KeyValuePair<string, List<PlayerInfo>> kvp in playerData)
        {
            PlayerInfo playerInfo = kvp.Value[^1];
            recordedPlayers++;

            if (playerInfo.clanPoints == null)
            {
                unrecordedPlayers++;
            }
        }

        recordedPlayers -= unrecordedPlayers;

        Console.WriteLine($"Players who haven't submitted points: {unrecordedPlayers}");
        Console.WriteLine($"Players who have submitted their points: {recordedPlayers}");
    }

    /// <summary>
    /// Calculates clan point totals.
    /// </summary>
    /// <param name="playerData">The dictionary you want to grab data from.</param>
    /// <param name="overallTotal">The clan point total as displayed within the game.</param>
    /// <returns>knownTotal, unknownTotal, overallTotal</returns>
    public static (int knownTotal, int unknownTotal, int overallTotal) CalculateTotals(Dictionary<string, List<PlayerInfo>> playerData, int overallTotal)
    {
        int clanPointTotal = 0;

        foreach (KeyValuePair<string, List<PlayerInfo>> kvp in playerData)
        {
            PlayerInfo playerInfo = kvp.Value[^1];

            if (playerInfo.clanPoints != null)
            {
                clanPointTotal += (int) playerInfo.clanPoints;
            }
        }

        return (clanPointTotal, overallTotal - clanPointTotal, overallTotal);
    }

    public static double CalculateUnknownAverage(Dictionary<string, List<PlayerInfo>> playerData, int unknownTotal)
    {
        int unrecordedPlayers = 0;

        foreach (KeyValuePair<string, List<PlayerInfo>> kvp in playerData)
        {
            PlayerInfo playerInfo = kvp.Value[^1];

            if (playerInfo.clanPoints == null)
            {
                unrecordedPlayers++;
            }
        }

        if (unrecordedPlayers == 0) return -1;

        return (double) unknownTotal / unrecordedPlayers;
    }

    public static double CalculateKnownAverage(Dictionary<string, List<PlayerInfo>> dictionary, int knownTotal)
    {
        int recordedPlayers = 0;

        foreach (KeyValuePair<string, List<PlayerInfo>> kvp in dictionary)
        {
            PlayerInfo playerInfo = kvp.Value[^1];

            if (playerInfo.clanPoints != null)
            {
                recordedPlayers++;
            }
        }

        if (recordedPlayers == 0) return -1;

        return (double) knownTotal / recordedPlayers;
    }
}