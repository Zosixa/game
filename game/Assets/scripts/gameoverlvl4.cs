using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameoverlvl4 : MonoBehaviour
{

    public GameObject GameOver;
    public int deadplayer = 0;
    public GameObject die;
    
    // Start is called before the first frame update
    void Start()
    {
        GameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (deadplayer == 3)
        {
            die.GetComponent<AudioSource>().Play();
            Destroy(gameObject);
            GameOver.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bat"))
        {
            deadplayer++;
            Destroy(collision.gameObject);
            
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
