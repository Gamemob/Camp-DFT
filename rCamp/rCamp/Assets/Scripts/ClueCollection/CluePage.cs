using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CluePage : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    private void Start()
    {
        textMeshPro.text = ClueSystem.word;

    }
}
