using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class countdowntodie : MonoBehaviour
{
    public GameObject GameOvermenu;
    float currentTime;
    public float startingTime = 10f;
    public GameObject die;

    void Start()
    {
        GameOvermenu.SetActive(false);
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            GameObject[] remainingBoxes = GameObject.FindGameObjectsWithTag("box");

            if (remainingBoxes.Length >= 1) 
            {
                die.GetComponent<AudioSource>().Play();
                GameOvermenu.SetActive(true);
                Time.timeScale = 0f; 
            }
        }
    }

    public void GoToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
