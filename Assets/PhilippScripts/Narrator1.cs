using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narrator1 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Intro());
        //StartCoroutine(suggestion());
        StartCoroutine(question1());
//        StartCoroutine(question2());
    }

        IEnumerator Intro()
        {
            yield return new WaitForSeconds(5f);
            SpeechManager.StartReadMessage("Now that you've mastered to control your body, let's move on to the mind. Over the course of the next few minutes, you will both be asked a few meaningful questions. Please answer them openly, you will have 10 seconds for each answer.\r\nLet's create some shared memories …");
        }
    
    //IEnumerator suggestion()
    //{
    //    yield return new WaitForSeconds(30f);
    //    SpeechManager.StartReadMessage("try to maintain your normal breathing ");
    //}

    IEnumerator question1()
    {
        yield return new WaitForSeconds(20f);
        SpeechManager.StartReadMessage("If you could transform into any creature, what would it be ? ");
    }
    //IEnumerator question2()
    //{
    //    yield return new WaitForSeconds(65f);
    //    SpeechManager.StartReadMessage("What was your closest pet");
    //}
}
