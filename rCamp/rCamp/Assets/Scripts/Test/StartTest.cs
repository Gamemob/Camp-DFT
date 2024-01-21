using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTest : MonoBehaviour
{
    public GameObject strattest;
    public GameObject test;
    public GameObject book;
    public void Yes()
    {
        book.active = false;
        test.active = true;
        strattest.active = false;
    }
    public void No()
    {
        strattest.active = false;
    }
}
