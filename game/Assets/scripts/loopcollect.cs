using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loopcollect : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        { 
            Destroy(gameObject, 1f);


            GameObject[] remainingBalls = GameObject.FindGameObjectsWithTag("loop");
            if (remainingBalls.Length <= 1)
            {
                SceneManager.LoadScene("lvl3");
            }
        }
    }
}
