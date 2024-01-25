using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTest : MonoBehaviour
{
    public GameObject strattest;
    public GameObject test;
    public GameObject book;
    public GameObject submit;
    public GameObject UI;
    public GameObject clues;
    public void Yes()
    {
        book.active = false;
        UI.SetActive(false);
        clues.SetActive(false);
        test.active = true;
        strattest.active = false;
        submit.SetActive(true);
    }
    public void No()
    {
        strattest.active = false;
    }
}
