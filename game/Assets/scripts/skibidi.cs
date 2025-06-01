using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skibidi : MonoBehaviour
{
    public float speed = 2f; 
    private bool isFacingRight = false;
    public GameObject sadtung;

    // Start is called before the first frame update
    void Start()
    {
        Flip();
    }

    private void Update()
    {
       
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;

        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            sadtung.GetComponent<AudioSource>().Play();
            Destroy(gameObject);
            SceneManager.LoadScene("lastlvl");
        }
    }
} 
