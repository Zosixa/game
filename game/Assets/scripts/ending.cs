using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ending : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            int totalObjects = 0;
            totalObjects += GameObject.FindGameObjectsWithTag("loop").Length;
            totalObjects += GameObject.FindGameObjectsWithTag("ball").Length;
            totalObjects += GameObject.FindGameObjectsWithTag("tungtung").Length;

            if (totalObjects > 0)
            {
                SceneManager.LoadScene("Badending");
            }
            else if (totalObjects == 0)
            {
                SceneManager.LoadScene("goodending");
            }
        }
    }
}
