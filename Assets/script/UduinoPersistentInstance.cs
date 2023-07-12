using Uduino;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UduinoPersistentInstance : MonoBehaviour
{
    public static UduinoPersistentInstance instance;
    UduinoManager u;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
