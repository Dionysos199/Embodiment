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

    // Update is called once per frame
    int counter;
    void Update()
    {
        UduinoDevice myDevice = UduinoManager.Instance.GetBoard("Arduino");
        UduinoManager.Instance.Read(myDevice, "readSensors"); // Read every frame the value of the "readSensors" function on our board.

        if (SceneManager.GetActiveScene().name == "ReadSensor")
        {
            if (counter < 100)
                counter++;
            else
                SceneManager.LoadScene("ReadSensor_Copy");
        }
    }
}
