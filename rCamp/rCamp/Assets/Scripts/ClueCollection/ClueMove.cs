using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClueMove : MonoBehaviour
{
    public GameObject Canvas;
    private bool picked; //是否被拿起
    public bool used; //是否在框里
    private Vector2 startPostion;
    private Vector2 targetPostion;
    public void Pick()
    {
        if(picked == false)
        {
            if(used == false)
            {
                startPostion = transform.position;
            }
            picked = true;
        }
        else
        {
            if(used == false)
            {
                transform.position = startPostion;
            }
            else
            {
                transform.position = targetPostion;
            }
            picked = false;
        }
        
    }
    private void Update()
    {
        if (picked)
        {
            transform.position = Input.mousePosition + new Vector3(0,20,0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Clue"))
        {
            used = true;
            if (collision.CompareTag("clues"))
            {

            }
            else
            {
            targetPostion = collision.transform.position;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Clue"))
        {
            used = false;
        }
    }
}


    


