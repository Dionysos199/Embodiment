using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narrator1 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Intro());

    }

    IEnumerator Intro()
    {
        yield return new WaitForSeconds(5f);
        SpeechManager.StartReadMessage("Welcome to \"Embodiment\", an interactive, collaborative journey into exploring your body and mind.\r\nIn this experiment, you will share a body with another participant and experience first-hand, what this feels like. You will have to work together to navigate the body of a whale through its surroundings, controlled by your breathing. The depth of your breathing will influence the direction and how well synced you are your speed. Feel free to explore and enjoy the experience!");
    }
}
