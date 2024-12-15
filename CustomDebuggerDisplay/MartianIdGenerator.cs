namespace CustomDebuggerDisplay;

public static class MartianIdGenerator
{
    private static readonly string[] MartianPrefixes = { "Zorg", "Blor", "Xylo", "Krag", "Plox", "Vrom", "Taal", "Zyph", "Vrak", "Torr", "Grav", "Snax", "Flim" };
    private static readonly string[] MartianMiddleParts = { "zor", "vex", "blor", "krax", "trix", "flan", "glo", "prax", "nex", "plex", "zux", "marx" };
    private static readonly string[] MartianSuffixes = { "zok", "rinn", "trax", "blorp", "zilk", "klarn", "nox", "phlex", "fex", "gorn", "warp", "grox", "zzal" };
    private static readonly string[] MartianNumbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
    private static readonly string[] MartianSymbols = { "!", "@", "#", "$", "%", "&", "*", "_", "-", "+" };

    private static Random _random = new();

    public static string Next()
    {
        string prefix = MartianPrefixes[_random.Next(MartianPrefixes.Length)];
        string middlePart = MartianMiddleParts[_random.Next(MartianMiddleParts.Length)];
        string suffix = MartianSuffixes[_random.Next(MartianSuffixes.Length)];
        string number = MartianNumbers[_random.Next(MartianNumbers.Length)];
        string symbol = MartianSymbols[_random.Next(MartianSymbols.Length)];

        return $"{prefix}{middlePart}{suffix}{number}{symbol}";
    }
}
