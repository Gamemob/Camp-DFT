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
    //换书
    private void Start()
    {
        pageNumber = 1;
        pageChange();
    }
    public void bookChange()
    {
        bookNumber = TalkSystem.bookNumber;
    }
    //翻页
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
            textMeshPro.text = "这行用来演示一下如果这个玩意太长了他会有一个自动适应的换行功能";
        }
        if (pageNumber == 4)
        {
            textMeshPro.text = "Page4";
        }
        if (pageNumber == 5)
        {
            textMeshPro.text = "Page5";
        }
    }
}
