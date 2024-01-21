using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;

public class ClueSystem : MonoBehaviour
{
    [Header("书页")]
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject page4;
    public GameObject page5;
    [Header("文字")]
    public GameObject clueWord;
    public static string word;//线索出现的文本
    public static int clueNumber;//线索序号
    int[] clueSequence;//发现线索的顺序
    int[] clueNumberInPage;//每一页线索的数量
    int sequenceNumber;//线索版上的序号
    int cluePageNumber;//正在看的页码
    private int maxPage;

    void Start()
    {
        maxPage = 1;
        clueSequence = new int[30];
        sequenceNumber = 1;
        cluePageNumber = 1;
    }
    public void printGlue()
    {
        bool used = false;
        for (int i = 1; i <= sequenceNumber; i++)
        {
            if (clueNumber == clueSequence[i])
            {
                used = true;
            }
        }
        if(used != true)
        {
            clueSequence[sequenceNumber] = clueNumber;
            sequenceNumber += 1;
            for (int i = 1; i < maxPage; i++)
            {
                PageDown();
                pageChange();
            }
            if (sequenceNumber % 6 == 0)
            {
                maxPage += 1;
                PageDown();
                pageChange();
            }
            GameObject clue = Instantiate(clueWord);//生成线索在线索本上
            clue.name = clueNumber.ToString();
            if (cluePageNumber == 1)
            {
                clue.transform.parent = page1.transform;
            }
            if (cluePageNumber == 2)
            {
                clue.transform.parent = page2.transform;
            }
            if (cluePageNumber == 3)
            {
                clue.transform.parent = page3.transform;
            }
            if (cluePageNumber == 4)
            {
                clue.transform.parent = page4.transform;
            }
            if (cluePageNumber == 5)
            {
                clue.transform.parent = page5.transform;
            }
        }
    }

    
    public void PageDown()
    {
        if(cluePageNumber < maxPage)
        {
            cluePageNumber += 1;
            
        }
    }
    public void PageUp()
    {
        if (cluePageNumber > 1)
        {
            cluePageNumber -= 1;

        }
    }

    public void pageChange()
    {
        if (cluePageNumber == 1)
        {
            page2.active = false;
            page1.active = true;
        }
        if (cluePageNumber == 2)
        {
            page1.active = false;
            page2.active = true;
            page3.active = false;
        }
        if (cluePageNumber == 3)
        {
            page2.active = false;
            page3.active = true;
            page4.active = false;
        }
        if (cluePageNumber == 4)
        {
            page3.active = false;
            page4.active = true;
            page5.active = false;
        }
        if (cluePageNumber == 5)
        {
            page4.active = false;
            page5.active = true;
        }
    }


    public void ChangeWords(int clueNumbers)
    {
        {
            clueNumber = clueNumbers;
            if (clueNumbers == 1)
            {
                word = "独居深林的外婆";
            }
            if (clueNumbers == 2)
            {
                word = "奇特的肉馅";
            }
            if (clueNumbers == 3)
            {
                word = "小红帽";
            }
            if (clueNumbers == 4)
            {
                word = "奇怪的食材";
            }
            if (clueNumbers == 5)
            {
                word = "小镇中的狼";
            }
            if (clueNumbers == 6)
            {
                word = "猎人";
            }
            if (clueNumbers == 7)
            {
                word = "奇怪的传言";
            }
            if (clueNumbers == 8)
            {
                word = "经验丰富的猎手";
            }
            if (clueNumbers == 9)
            {
                word = "奇怪的森林";
            }
            if (clueNumbers == 10)
            {
                word = "上膛的枪";
            }
            if (clueNumbers == 11)
            {
                word = "外婆房子里的怪声";
            }
            if (clueNumbers == 12)
            {
                word = "伊文口中的奇怪蘑菇";
            }
            if (clueNumbers == 13)
            {
                word = "蘑菇的孢子";
            }
            if (clueNumbers == 14)
            {
                word = "诡异的世界";
            }
            if (clueNumbers == 15)
            {
                word = "生死未卜的猎人";
            }
            if (clueNumbers == 16)
            {
                word = "奇怪的小红帽";
            }
        }

    }
}
