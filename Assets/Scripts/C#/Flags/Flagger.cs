using System.Collections.Generic;

public static class Flagger
{
    private static Dictionary<FlagName, bool> _flags;

    public static bool Get(FlagName flag)
    {
        if (_flags.ContainsKey(flag))
        {
            return _flags[flag];
        }
        else
        {
            //if flag doesn't exist, create it (default false)
            Set(flag, false);
            return false;
        }
    }

    public static void Set(FlagName flag, bool value)
    {
        if (_flags.ContainsKey(flag))
        {
            _flags[flag] = value;
        }
        else
        {
            _flags.Add(flag, value);
        }
    }
}