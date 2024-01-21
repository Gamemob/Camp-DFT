using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;

public class ClueSystem : MonoBehaviour
{
    [Header("��ҳ")]
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject page4;
    public GameObject page5;
    [Header("����")]
    public GameObject clueWord;
    public static string word;//�������ֵ��ı�
    public static int clueNumber;//�������
    int[] clueSequence;//����������˳��
    int[] clueNumberInPage;//ÿһҳ����������
    int sequenceNumber;//�������ϵ����
    int cluePageNumber;//���ڿ���ҳ��
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
            GameObject clue = Instantiate(clueWord);//������������������
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
                word = "�������ֵ�����";
            }
            if (clueNumbers == 2)
            {
                word = "���ص�����";
            }
            if (clueNumbers == 3)
            {
                word = "С��ñ";
            }
            if (clueNumbers == 4)
            {
                word = "��ֵ�ʳ��";
            }
            if (clueNumbers == 5)
            {
                word = "С���е���";
            }
            if (clueNumbers == 6)
            {
                word = "����";
            }
            if (clueNumbers == 7)
            {
                word = "��ֵĴ���";
            }
            if (clueNumbers == 8)
            {
                word = "����ḻ������";
            }
            if (clueNumbers == 9)
            {
                word = "��ֵ�ɭ��";
            }
            if (clueNumbers == 10)
            {
                word = "���ŵ�ǹ";
            }
            if (clueNumbers == 11)
            {
                word = "���ŷ�����Ĺ���";
            }
            if (clueNumbers == 12)
            {
                word = "���Ŀ��е����Ģ��";
            }
            if (clueNumbers == 13)
            {
                word = "Ģ��������";
            }
            if (clueNumbers == 14)
            {
                word = "���������";
            }
            if (clueNumbers == 15)
            {
                word = "����δ��������";
            }
            if (clueNumbers == 16)
            {
                word = "��ֵ�С��ñ";
            }
        }

    }
}
