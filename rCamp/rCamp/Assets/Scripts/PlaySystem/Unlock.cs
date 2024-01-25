using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour
{
    public GameObject lockBook;
    private void Start()
    {
        if(Lock.UnlockedLevel > 1)
        {
            lockBook.SetActive(false);
        }
    }
}
