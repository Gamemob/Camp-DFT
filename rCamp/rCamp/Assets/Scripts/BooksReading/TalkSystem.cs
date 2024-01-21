using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TalkSystem : MonoBehaviour
{
    public GameObject dialog;
    public static int bookNumber;
    public static int pageNumber;
    public int bookMaxPages;
    [Header("书页")]
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject page4;
    public GameObject page5;
    [Header("测试")]
    public GameObject test;
    private void Start()
    {
        pageNumber = 1;
        bookMaxPages = 5;
    }
    public void bookChange()
    {
        pageNumber = 1;
        bookMaxPages = 5; //这行记得改    
    }
    public void pageUp()
    {
        if (pageNumber >= 1)
        {
            pageNumber -= 1;
        }
    }
    public void pageDown()
    {
        if (pageNumber == bookMaxPages)
        {
            test.active = true;
        }
        if (pageNumber < bookMaxPages)
        {
            pageNumber += 1;
        }
    }
    public void pageChange()
    {
        if (pageNumber == 1)
        {
            page2.active = false;
            page1.active = true;
        }
        if (pageNumber == 2)
        {
            page1.active = false;
            page2.active = true;
            page3.active = false;
        }
        if (pageNumber == 3)
        {
            page2.active = false;
            page3.active = true;
            page4.active = false;
        }
        if (pageNumber == 4)
        {
            page3.active = false;
            page4.active = true;
            page5.active = false;
        }
        if (pageNumber == 5)
        {
            page4.active = false;
            page5.active = true;
        }
    }
}
