namespace ClairEtNet.Web.Config;


public class Env
{
    private static Dictionary<string, string> OVERLOAD = new Dictionary<string, string>();

    public static void Load()
    {
        string env = Path.Combine(Directory.GetCurrentDirectory(), ".env");
        string[] lines = File.ReadAllLines(env);
        foreach (string line in lines)
        {
            string[] kvp = line.Split("=", 2);
            if (kvp.Length == 2)
                OVERLOAD.Add(kvp[0].Trim(), kvp[1].Trim());
        }
        
    }

    public static string? Get(string key, string? dummy = null)
    {
        string? value;
        OVERLOAD.TryGetValue(key, out value);
        return value ?? Environment.GetEnvironmentVariable(key) ?? dummy;
    }

    public static bool Has(string key)
        => !string.IsNullOrEmpty(Get(key));

    public static void Add(string[] args, string argKey, string envKey)
    {
        foreach (string arg in args)
            if (arg.StartsWith(argKey))
            {
                string value = arg[argKey.Length..];
                value = value.Trim('"');
                if (value.Length == 0)
                    value = "true";
                Environment.SetEnvironmentVariable(envKey, value);
                OVERLOAD.Add(envKey.Trim(), value.Trim());
            }
    }
}