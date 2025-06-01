using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("lvl1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void lvls()
    {
        SceneManager.LoadScene("lvlmenu");
    }
}
