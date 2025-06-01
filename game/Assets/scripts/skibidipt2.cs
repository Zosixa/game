using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skibidipt2 : MonoBehaviour
{
    public float speed = 2f;
    public GameObject sadtung;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            sadtung.GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }
    }
}
