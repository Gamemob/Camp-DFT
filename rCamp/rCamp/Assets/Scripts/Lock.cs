using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lock : MonoBehaviour
{
    public GameObject LevelPanelsList;//总关卡
    Button[] LevelPanel;//关卡
    int UnlockedLevel;//解锁的关卡数量
    int CurrentLevel;//当前关卡的数目
    public int MaxLevel;//最大关卡数
    // Start is called before the first frame update
    void Start()
    {
        UnlockedLevel = PlayerPrefs.GetInt("UnlockedLevel");//读取关卡卡存档
        LevelPanel = new Button[LevelPanelsList.transform.childCount];

        if (UnlockedLevel == 0)
        {
            UnlockedLevel = 1;
        }
        else if (UnlockedLevel > MaxLevel)
        {
            UnlockedLevel = MaxLevel;
        }

        for (int i = 0; i < LevelPanelsList.transform.childCount; i++)
        {
            LevelPanel[i] = LevelPanelsList.transform.GetChild(i).GetComponent<Button>();
        }
        for (int i = 0; i < LevelPanel.Length; i++)
        {
            LevelPanel[i].interactable = false;
        }
        for (int i = 0; i < UnlockedLevel; i++)
        {
            LevelPanel[i].interactable = true;
        }
        CurrentLevel = UnlockedLevel;
        PlayerPrefs.SetInt("CurrentLevel", CurrentLevel);
    }

    public void Replay()
    {
        PlayerPrefs.SetInt("UnlockedLevel", 1);
        PlayerPrefs.SetInt("CurrentLevel", 0);

        for (int i = 0; i < LevelPanel.Length; i++)
        {
            LevelPanel[i].interactable = false;
        }
        for (int i = 0; i < UnlockedLevel; i++)
        {
            LevelPanel[i].interactable = true;
        }
        SceneManager.LoadScene("Play");
    }
}
