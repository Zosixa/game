using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBallDestroyer : MonoBehaviour
{
    public string nextSceneName = "lvl2";
    public GameObject moo;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            moo.GetComponent<AudioSource>().Play();
            Destroy(collision.gameObject); 

            
            GameObject[] remainingBalls = GameObject.FindGameObjectsWithTag("ball");
            if (remainingBalls.Length <= 1) 
            {
                moo.GetComponent<AudioSource>().Play();
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }

}
