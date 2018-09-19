using System;
using UnityEngine;

public class DebugLog
{
    public static void Info(object obj)
    {
#if DEBUG
        Debug.Log(obj);
#endif
    }

    public static void Warning(object obj)
    {
#if DEBUG
        Debug.LogWarning(obj);
#endif
    }

    public static void Error(object obj)
    {
#if DEBUG
        Debug.LogError(obj);
#endif
    }
}
