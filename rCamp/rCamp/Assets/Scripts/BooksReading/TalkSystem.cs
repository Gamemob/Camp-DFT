using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkSystem : MonoBehaviour
{
    public GameObject dialog;
    public static int bookNumber;
    public static int pageNumber;
    public int test;
    public int bookMaxPages;
    private void Start()
    {
        pageNumber = 1;
    }
    public void bookChange()
    {
        pageNumber = 1;
        bookMaxPages = 100; //这行记得改    
    }
    public void pageUp()
    {
        if(pageNumber >= 1)
        {
            pageNumber -= 1;
            test = pageNumber;
        }
    }
    public void pageDown()
    {
        if(bookNumber <= bookMaxPages)
        {
            pageNumber += 1;
            test = pageNumber;
        }
    }

}
