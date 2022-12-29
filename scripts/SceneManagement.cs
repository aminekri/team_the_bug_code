using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagement : MonoBehaviour
{
    public void returnMenu()
    {
        SceneManager.LoadScene(0);

    }
    public void playgames()
    {
        SceneManager.LoadScene(1);
    }
    public void exitgames()
    {
        Application.Quit();
    }
    public void playgames1()
    {
        SceneManager.LoadScene(2);

    }
    public void playgames2()
    {
        SceneManager.LoadScene(3);

    }

}