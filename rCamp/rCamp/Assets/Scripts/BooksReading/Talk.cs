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
    public static int dialogNumber;
    public static bool firstWord;
    public static bool lastWord;
    //����
    private void Start()
    {
        pageNumber = 1;
        pageChange();
    }
    public void bookChange()
    {
        bookNumber = TalkSystem.bookNumber;
    }
    //��ҳ
    public void pageChange()
    {
        if (bookNumber == 0)
        {
            if (dialogNumber == 1)
            {
                textMeshPro.text = "С��ñ�����Ŷ���ס��ɭ�����ס�����������ڱ�ʮ�ֺóԡ�";
                firstWord = true;
                lastWord = false;
            }
            if (dialogNumber == 2)
            {
                textMeshPro.text = "ÿ�θϼ����Ŷ����һЩ�ڱ�ȥ������������С����񶼺�ϲ�����ŵ��ڱ�";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 3)
            {
                textMeshPro.text = "С��ñÿ��һ��ʱ��ͻ�ȥ���żҸ����Ŵ�Щ������Ʒ�Լ����ڱ�����Ҫ�Ĳ��ϡ�";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 4)
            {
                textMeshPro.text = "�������磬Ϊ�˸������Ͳ��ϣ�С��ñ�����˼��С�";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 5)
            {
                textMeshPro.text = "Ů��A��С��ñ������������������ʳ�İ����Ҷ���ʼ���������������ڱ��ˡ�";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 6)
            {
                textMeshPro.text = "С��ñ��������ϼ��ͻ����ˣ������Ҫȥ��������ʳ���ˡ�";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 7)
            {
                textMeshPro.text = "Ů��B�������Ҫ������˵��������һЩ�ڱ������ϴε��ڱ��Ҷ�û�򵽡�";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 8)
            {
                textMeshPro.text = "�����ţ�С��ñ����ȥ��ʱ����Һ������������á���ɭ����ע�ⰲȫ����";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 9)
            {
                textMeshPro.text = "С��ñ���õģ��һ������˵�ġ�С��ñ��·�ϻ�ע�ⰲȫ�ġ�ɭ�������Ҳ������ʲôΣ�ա�";
                firstWord = false;
                lastWord = true;
            }
            if (dialogNumber == 10)
            {
                textMeshPro.text = "С��ñ��ɭ�ֻ�����û��ֱ�ӻؼң�����ǰ�������˼�";
                firstWord = true;
                lastWord = false;
            }
            if (dialogNumber == 11)
            {
                textMeshPro.text = "����A���������������ɭ��������������ֵ�����ҵ�һ�μ�����ô��Ľ�ӡ������˵���������˳��ֻþ���Ģ���������Խ��ԽΣ���˰�����������ȥ����֪���ܲ����ټ�����ɭ��������ˡ�";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 12)
            {
                textMeshPro.text = "���ˣ�������������������Щ���ԣ��ϴ���˵ɭ���￴�����ǣ��������ȥɭ���Ѳ��ʱ��������ë��û�п��������������㲻�������Լ����Լ��ɡ�";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 13)
            {
                textMeshPro.text = "С��ñ�������˵�С��ǰ���������塣�ҽ������ǰ�������Ҫ��ʳ�ĸ����͹�ȥ�ˣ����ڹ�ȥ�Ļ�Ҫ��ڲ��ܻ��������е㺦�¡�";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 14)
            {
                textMeshPro.text = "С��ñ�о��Լ�����������ʲô���飬����ͷʹ�����벻������";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 15)
            {
                textMeshPro.text = "���ˣ��У�����������һ��";
                firstWord = false;
                lastWord = true;
            }
            if (dialogNumber == 16)
            {
                textMeshPro.text = "�ڽ���ɭ��֮��һ��������û��ʲô��ֵ����鷢����������һ��ת��ĵط���С��ñ��С�Ĳȵ���һ��Ģ��������Ļ�ɫ������С��ñ������ֱ���ԡ�";
                firstWord = true;
                lastWord = false;
            }
            if (dialogNumber == 17)
            {
                textMeshPro.text = "����û�����£���������С��ñ��ǰ���š�ͻȻ��Χ��״�������ľ�����˸о����Ծ�������ǰ���������졣";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 18)
            {
                textMeshPro.text = "���ˣ�С��ñ����ȷ������ȥ�����żҵ�·��";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 19)
            {
                textMeshPro.text = "С��ñ���ǰ�������������������һֱס������ġ�";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 20)
            {
                textMeshPro.text = "���ˣ��������ľ���������أ��ҵ�һ����ɭ���м�������������";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 21)
            {
                textMeshPro.text = "��Ȼ���˲�����������˵����Щ�������Ĵ��ԣ����ǻ��ǰ����е�ǹ������";
                firstWord = false;
                lastWord = true;
            }
            if (dialogNumber == 22)
            {
                textMeshPro.text = "��״��������������ߵ��˾�ͷ�������Ѿ����������ŵ�Сľ�ݡ�";
                firstWord = true;
                lastWord = false;
            }
            if (dialogNumber == 23)
            {
                textMeshPro.text = "С��ñ�����ڵ��ˣ����������㿴���Ǿ������ŵķ��ӡ�";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 24)
            {
                textMeshPro.text = "���ˣ��ã�С��ñ���⸽�����ǲ���ô��ȫ�ģ������������ż�סһ��ɡ��Ҿ��Ȼ�ȥ�ˣ��������ǻ�������ȥ�������ġ�";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 25)
            {
                textMeshPro.text = "�������壬�����ˣ������ŵ�ʳ����ô�찡��";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 26)
            {
                textMeshPro.text = "���˵���Ӱ�������������צ�Ӵ������˵ļ����----�¹��£�ѪҺ�ڿ��зɽ���";
                firstWord = false;
                lastWord = true;
            }
            if (dialogNumber == 27)
            {
                textMeshPro.text = "һ������֮�����˵����˵��ϡ�Ѫ����������ڿ��У�С��ñ���������߽����ӡ�Ժ���⣬ս�������Ģ�����Ӵ�����������ſ��γ���һƪ����";
                firstWord = true;
                lastWord = false;
            }
            if (dialogNumber == 28)
            {
                textMeshPro.text = "���˻�����Ѫ�ش��Ŵ���";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 29)
            {
                textMeshPro.text = "���ˣ��������������С��ûƭ�ң�������������Ģ���澢��";
                firstWord = false;
                lastWord = true;
            }
        }
    }
}
