using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Talk : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    private int bookNumber;
    private int pageNumber;
    //����
    public void bookChange()
    {
        bookNumber = TalkSystem.bookNumber;
    }
    //��ҳ
    public void pageChange()
    {
        pageNumber = TalkSystem.pageNumber;
        if(pageNumber == 1)
        {
            textMeshPro.text = "Page1";
        }
        if(pageNumber == 2)
        {
            textMeshPro.text = "Page2";
        }
        if (pageNumber == 3)
        {
            textMeshPro.text = "TestTestTestTestTestTestTestTestTestTestTest";
        }
    }
}
