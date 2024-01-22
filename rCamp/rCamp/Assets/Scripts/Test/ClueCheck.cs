using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class ClueCheck : MonoBehaviour
{
    public string targetClueNumber;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("clues"))
        {
            if(collision.name == targetClueNumber)
            {

            }
            else
            {
                TestCheck.wrongNumer += 1;
            }
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("clues"))
        {
            if (collision.name == targetClueNumber)
            {

            }
            else
            {
                TestCheck.wrongNumer -= 1;
            }
        }
    }
}
