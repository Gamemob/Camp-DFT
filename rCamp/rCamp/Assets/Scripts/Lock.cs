using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lock : MonoBehaviour
{
    public GameObject LevelPanelsList;//�ܹؿ�
    Button[] LevelPanel;//�ؿ�
    int UnlockedLevel;//�����Ĺؿ�����
    int CurrentLevel;//��ǰ�ؿ�����Ŀ
    public int MaxLevel;//���ؿ���
    // Start is called before the first frame update
    void Start()
    {
        UnlockedLevel = PlayerPrefs.GetInt("UnlockedLevel");//��ȡ�ؿ����浵
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
