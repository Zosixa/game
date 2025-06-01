using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class possibledeaths : MonoBehaviour
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
        if (deadplayer == 8)
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
            Destroy(collision.gameObject);
            deadplayer++;
        }

        if (collision.gameObject.CompareTag("boomb"))
        {
            Destroy(collision.gameObject);
            deadplayer++;
        }


    }
}
