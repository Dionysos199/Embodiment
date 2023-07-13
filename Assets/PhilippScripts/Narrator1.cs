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
            SpeechManager.StartReadMessage("Hello and welcome to our experience! I will guide you threw this little journey. Today you will find out how it feels like to share a body with another person and control it by synchronise your breathing");
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
