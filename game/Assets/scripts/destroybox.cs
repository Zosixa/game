using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroybox : MonoBehaviour
{
    public int bombcount = 0;
    public GameObject boomb;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("boomb"))
        {
            boomb.GetComponent<AudioSource>().Play();
            bombcount++;
            Destroy(collision.gameObject);
        }

        if (bombcount == 2)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("lvl4");
        }
    }
}
