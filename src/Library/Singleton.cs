using System;

namespace Library;

public sealed class Singleton<T> where T : new()
{
    public Singleton()
    {
    }

    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new T();
            }

            return _instance;
        }
    }
}