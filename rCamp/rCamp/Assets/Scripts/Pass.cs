using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Pass : MonoBehaviour
{
    public void CheckLevel()
    {
        int UnlockedLevel = PlayerPrefs.GetInt("UnlockedLevel");
        int CurrentLevel = PlayerPrefs.GetInt("CurrentLevel");

        if (CurrentLevel >= UnlockedLevel)
        {
            PlayerPrefs.SetInt("UnlockedLevel", UnlockedLevel + 1);
        }
    }


}
