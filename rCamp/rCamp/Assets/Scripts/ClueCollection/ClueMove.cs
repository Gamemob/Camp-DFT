using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClueMove : MonoBehaviour
{ 
    private static bool picked; //是否被拿起
    public static bool used; //是否在框里
    public bool whysomanybugs;
    private Vector2 startPostion;
    private Vector2 targetPostion;
    public void Pick()
    {
        if (whysomanybugs)
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

 


    public void setTrue()
    {
        whysomanybugs = true;
    }
    public void setFalse()
    {
        whysomanybugs = false;
    }
}


    


