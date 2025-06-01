using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonmenager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goto1()
    {
        SceneManager.LoadScene("lvl1");
    }

    public void goto2()
    {
        SceneManager.LoadScene("lvl2");
    }

    public void goto3()
    {
        SceneManager.LoadScene("lvl3");
    }

    public void goto4()
    {
        SceneManager.LoadScene("lvl4");
    }

    public void goto5()
    {
        SceneManager.LoadScene("lastlvl");
    }

    public void quitt()
    {
        Application.Quit();
    }
}
