using System;
using UnityEngine;

public abstract class ASingletonMonoBehavior<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if(instance == null)
            {
                Type t = typeof(T);
                instance = (T) FindObjectOfType(t);
                if(instance == null) DebugLog.Error(t + "");
            }

            return instance;
        }
    }

    virtual protected void Awake()
    {
        CheckInstance();
    }

    protected bool CheckInstance()
    {
        if(instance == null)
        {
            instance = this as T;
            return true;
        }
        else if(Instance == this)
        {
            return true;
        }

        Destroy(this);

        return false;
    }
}
