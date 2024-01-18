using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BookPlay : MonoBehaviour
{
    public void Book1()
    {
        SceneManager.LoadScene("Book1");
    }

    public void Book2()
    {
        SceneManager.LoadScene("Book2");
    }

    public void Book3()
    {
        SceneManager.LoadScene("Book3");
    }

    public void Book4()
    {
        SceneManager.LoadScene("Book4");
    }

    public void Back()
    {
        SceneManager.LoadScene("Begin");
    }
}
