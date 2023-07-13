using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narrator2 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Intro());

    }

    IEnumerator Intro()
    {
        yield return new WaitForSeconds(5f);
        SpeechManager.StartReadMessage("Now that you've mastered to control your body, let's move on to the mind. Over the course of the next few minutes, you will both be asked a few meaningful questions. Please answer them openly, you will have 10 seconds for each answer.\r\nLet's create some shared memories …");
    }
}
