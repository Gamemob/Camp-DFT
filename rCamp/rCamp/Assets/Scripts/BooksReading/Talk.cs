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
        if (bookNumber == 0)
        {
            if (dialogNumber == 1)
            {
                textMeshPro.text = "小红帽的外婆独自住在森林深处居住，外婆做的馅饼十分好吃。";
                firstWord = true;
                lastWord = false;
            }
            if (dialogNumber == 2)
            {
                textMeshPro.text = "每次赶集外婆都会带一些馅饼去集市上售卖，小镇居民都很喜欢外婆的馅饼";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 3)
            {
                textMeshPro.text = "小红帽每过一段时间就会去外婆家给外婆带些生活用品以及做馅饼所需要的材料。";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 4)
            {
                textMeshPro.text = "这天上午，为了给外婆送材料，小红帽来到了集市。";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 5)
            {
                textMeshPro.text = "女性A：小红帽啊，又来帮你外婆买食材啊？我都开始怀念你外婆做的馅饼了。";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 6)
            {
                textMeshPro.text = "小红帽：过几天赶集就会来了，我这就要去给外婆送食材了。";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 7)
            {
                textMeshPro.text = "女性B：那你可要和外婆说让她多做一些馅饼啊，上次的馅饼我都没买到。";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 8)
            {
                textMeshPro.text = "老婆婆：小红帽，你去的时候帮我和你外婆问声好。在森林里注意安全啊。";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 9)
            {
                textMeshPro.text = "小红帽：好的，我会和外婆说的。小红帽在路上会注意安全的。森林里白天也不会有什么危险。";
                firstWord = false;
                lastWord = true;
            }
            if (dialogNumber == 10)
            {
                textMeshPro.text = "小红帽从森林回来后，没有直接回家，反而前往了猎人家";
                firstWord = true;
                lastWord = false;
            }
            if (dialogNumber == 11)
            {
                textMeshPro.text = "村民A：你最近听到了吗？森林里好像出现了奇怪的生物，我第一次见到那么大的脚印。”听说还有能让人出现幻觉的蘑菇。真的是越来越危险了啊，再这样下去还不知道能不能再继续在森林里打猎了。";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 12)
            {
                textMeshPro.text = "猎人：你又在哪里听到的这些传言？上次你说森林里看到了狼？结果我们去森林搜查的时候连根狼毛都没有看到，哈哈哈，你不会又是自己吓自己吧。";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 13)
            {
                textMeshPro.text = "小红帽来到猎人的小屋前：猎人叔叔。我今天忘记把外婆需要的食材给她送过去了，现在过去的话要天黑才能回来，我有点害怕。";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 14)
            {
                textMeshPro.text = "小红帽感觉自己好像忘记了什么事情，但是头痛让她想不起来了";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 15)
            {
                textMeshPro.text = "猎人：行，那我陪你走一趟";
                firstWord = false;
                lastWord = true;
            }
            if (dialogNumber == 16)
            {
                textMeshPro.text = "在进入森林之后，一切正常，没有什么奇怪的事情发生。但是在一处转弯的地方，小红帽不小心踩到了一个蘑菇，喷出的灰色孢子让小红帽和猎人直咳嗽。";
                firstWord = true;
                lastWord = false;
            }
            if (dialogNumber == 17)
            {
                textMeshPro.text = "猎人没当回事，继续跟着小红帽向前走着。突然周围形状诡异的树木让猎人感觉不对劲，继续前进愈发诡异。";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 18)
            {
                textMeshPro.text = "猎人：小红帽，你确定这是去你外婆家的路吗？";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 19)
            {
                textMeshPro.text = "小红帽：是啊，猎人先生，我外婆一直住在这里的。";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 20)
            {
                textMeshPro.text = "猎人：这里的树木可真是奇特，我第一次在森林中见到这样的树。";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 21)
            {
                textMeshPro.text = "虽然猎人并不相信伊文说的那些奇怪生物的传言，但是还是把手中的枪上了膛";
                firstWord = false;
                lastWord = true;
            }
            if (dialogNumber == 22)
            {
                textMeshPro.text = "形状诡异的树林终于走到了尽头，猎人已经看到了外婆的小木屋。";
                firstWord = true;
                lastWord = false;
            }
            if (dialogNumber == 23)
            {
                textMeshPro.text = "小红帽：终于到了，猎人先生你看，那就是外婆的房子。";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 24)
            {
                textMeshPro.text = "猎人：好，小红帽，这附近还是不怎么安全的，你今晚就在外婆家住一晚吧。我就先回去了，伊文他们还等着我去打猎来的。";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 25)
            {
                textMeshPro.text = "猎人叔叔，你走了，我外婆的食材怎么办啊？";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 26)
            {
                textMeshPro.text = "狼人的身影出现在猎人身后，爪子搭在猎人的肩膀上----月光下，血液在空中飞溅。";
                firstWord = false;
                lastWord = true;
            }
            if (dialogNumber == 27)
            {
                textMeshPro.text = "一声巨响之后，猎人倒在了地上。血红的月亮挂在空中，小红帽扶着狼人走进屋子。院子外，战斗引起的蘑菇孢子大量喷出，在门口形成了一篇红雾。";
                firstWord = true;
                lastWord = false;
            }
            if (dialogNumber == 28)
            {
                textMeshPro.text = "猎人浑身是血地喘着粗气";
                firstWord = false;
                lastWord = false;
            }
            if (dialogNumber == 29)
            {
                textMeshPro.text = "猎人：看来这次伊文那小子没骗我，呼——呼，这蘑菇真劲啊";
                firstWord = false;
                lastWord = true;
            }
        }
    }
}
