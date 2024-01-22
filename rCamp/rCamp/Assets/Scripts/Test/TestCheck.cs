using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCheck : MonoBehaviour
{
    public static int wrongNumer = 0;
    public GameObject passedText;
    public GameObject wrongText;
    public GameObject testPage;
    public GameObject cluePage;

    public void checkAnswer()
    {
        if(wrongNumer == 0)
        {
            passedText.active = true;
        }
        else
        {
            wrongText.active = true;
        }
        testPage.active = false;
        cluePage.active = false;
    }
}
