using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float horizontal;
    public float speed = 8f;
    public float jumpingpower = 16f;
    private bool isFacingRight = true;
    public int deathcount = 0;
    public GameObject GameOvermenu;
    public GameObject walkingsoun;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundcheck;
    [SerializeField] private LayerMask groundLayer;

    void Start()
    {
        GameOvermenu.SetActive(false);
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingpower);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();

        if (horizontal != 0)
        {
            if (!walkingsoun.GetComponent<AudioSource>().isPlaying)
            {
                walkingsoun.GetComponent<AudioSource>().Play();
            }
        }
        else
        {
            if (walkingsoun.GetComponent<AudioSource>().isPlaying)
            {
                walkingsoun.GetComponent<AudioSource>().Stop();
            }
        }

        if (deathcount > 5)
        {
            Destroy(gameObject);
            GameOvermenu.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundcheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("boomb"))
        {
            Destroy(collision.gameObject);
            deathcount = deathcount + 1;
        }
    }
}
