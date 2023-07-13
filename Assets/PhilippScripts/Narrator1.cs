using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narrator1 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Intro());
        StartCoroutine(suggestion());
        StartCoroutine(question1());
        StartCoroutine(question2());
    }

    IEnumerator Intro()
    {
        yield return new WaitForSeconds(5f);
        // SpeechManager.StartReadMessage("Welcome to \"Embodiment\", an interactive, collaborative journey into exploring your body and mind.\r\nIn this experiment, you will share a body with another participant and experience first-hand, what this feels like. You will have to work together to navigate the body of a whale through its surroundings, controlled by your breathing. The depth of your breathing will influence the direction and how well synced you are your speed. Feel free to explore and enjoy the experience!");
        SpeechManager.StartReadMessage("Now is the moment where you combine your thoughts and memories. " +
            "During this stage your memories will fuse into one ");
    }
    IEnumerator suggestion()
    {
        yield return new WaitForSeconds(30f);
        SpeechManager.StartReadMessage("try to maintain your normal breathing ");
    }

    IEnumerator question1()
    {
        yield return new WaitForSeconds(40f);
        SpeechManager.StartReadMessage("And now Would you describe the place where you felt the most safe in your childhood ");
    }
    IEnumerator question2()
    {
        yield return new WaitForSeconds(65f);
        SpeechManager.StartReadMessage("What was your closest pet");
    }
}
