using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyevrything : MonoBehaviour
{
    public GameObject moo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            moo.GetComponent<AudioSource>().Play();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("loop"))
        {
            Destroy(collision.gameObject);
        }
        
    }
}
