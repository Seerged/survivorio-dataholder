namespace PlayerData;

public class PlayerInfo
{
    public int? attack;
    public int? clanPoints;
    public DateTime? date;

    public PlayerInfo()
    {
        attack = null;
        clanPoints = null;
        date = null;
    }

    public PlayerInfo(int? atk, int? clanPts)
    {
        attack = atk;
        clanPoints = clanPts;
    }

    public PlayerInfo(int? atk, int? clanPts, DateTime datetime) : this(atk, clanPts)
    {
        date = datetime;
    }

}

public static class Data
{
    public static readonly int[] twentyTonsTotalExpeditionScores =
    [
        597,
        547
    ];

    public readonly static Dictionary<string, List<PlayerInfo>> twentyTonsSurvivorData = new()
    {
        {
            "Marcus",
            new List<PlayerInfo>
            {
                new(107000, 27),
                new(null, 21, new(day: 16, month: 12, year: 2023)),
            }
        },
        {
            "Highco",
            new List<PlayerInfo>
            {
                new(91000, 28),
                new(104607, 21),
            }
        },
        {
            "Panda",
            new List<PlayerInfo>
            {
                new(88000, 26),
                new(null, 19),
            }
        },
        {
            "Fogie",
            new List<PlayerInfo>
            {
                new(113000, 30),
                new(null, 23),
            }
        },
        {
            "Matoru",
            new List<PlayerInfo>
            {
                new(114000, 29),
                new(null, 22, new(day: 16, month: 12, year: 2023)),
            }
        },
        {
            "8Fold",
            new List<PlayerInfo>
            {
                new(70000, 26),
                new(null, 21),
            }
        },
        {
            "Darknite",
            new List<PlayerInfo>
            {
                new(105000, 28),
                new(null, 21, new(day: 16, month: 12, year: 2023)),
            }
        },
        {
            "Mcdirty",
            new List<PlayerInfo>
            {
                new(65000, 22),
                new(71865, 18, new(day: 16, month: 12, year: 2023)),
            }
        },
        {
            "Thewliz",
            new List<PlayerInfo>
            {
                new(70000, 28),
                new(null, 20, new(day: 16, month: 12, year: 2023)),
            }
        },
        {
            "Klayla",
            new List<PlayerInfo>
            {
                new(95000, 30),
                new(null, 20, new(day: 16, month: 12, year: 2023)),
            }
        },
        {
            "Infidel",
            new List<PlayerInfo>
            {
                new(94000, 30),
                new(101794, 22, new(day: 16, month: 12, year: 2023)),
            }
        },
        {
            "Shoppa",
            new List<PlayerInfo>
            {
                new(85000, 27),
                new(95000, 20),
            }
        },
        {
            "Valkyrie",
            new List<PlayerInfo>
            {
                new(74000, 21),
                new(null, 17, new(day: 17, month: 12, year: 2023)),
            }
        },
        {
            "unmalnombre",
            new List<PlayerInfo>
            {
                new(67000, 24),
                new(null, 20, new(day: 16, month: 12, year: 2023)),
            }
        },
        {
            "Sirrius",
            new List<PlayerInfo>
            {
                new(53000, 23),
                new(54000, 19),
            }
        },
        {
            "Icykle",
            new List<PlayerInfo>
            {
                new(71000, 24),
                new(null, 19),
            }
        },
        {
            "Xaero",
            new List<PlayerInfo>
            {
                new(121000, 30),
                new(152000, 22),
            }
        },
        {
            "Vetramont",
            new List<PlayerInfo>
            {
                new(97000, 30),
                new(112000, 22),
            }
        },
        {
            "Seerious",
            new()
            {
                new(54000, 21),
                new(71000, 19, new(day: 16, month: 12, year: 2023)),
            }
        },
        {
            "Xig",
            new()
            {
                new(103000, 26),
                new(null, 21),
            }
        },
        {
            "Boredcouch",
            new()
            {
                new(60000, 22),
                new(null, 18, new(day: 16, month: 12, year: 2023)),
            }
        },
        /* 
        {
            "Nhazulc",
            new()
            {
                new(66000, 22),
                new(),
            }
        },*/
        {
            "BlessedKraken",
            new()
            {
                new(null, 23),
                new(),
            }
        },
        {
            "Mich43l", // discord username
            new()
            {
                new(null, 20, new(day: 16, month: 12, year: 2023))
            }
        },
        {
            "Ares",
            new()
            {
                new(null, 21, new(day: 16, month: 12, year: 2023))
            }
        },
        {
            "philmcgooch",
            new()
            {
                new(90000, 21, new(day: 16, month: 12, year: 2023))
            }
        },
        {
            "Darkneto",
            new()
            {
                new(94795, 21, new(day: 17, month: 12, year: 2023))
            }
        },
        {
            "DEX",
            new()
            {
                new(90000, null)
            }
        },
        {
            "Davenemesis",
            new()
            {
                new(96000, 21)
            }
        }
    };
}