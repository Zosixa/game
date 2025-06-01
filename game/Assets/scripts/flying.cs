using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flying : MonoBehaviour
{
    public float speed = 3f;
    private bool isFacingRight = false;

    private void Update()
    {
        float moveDirection = isFacingRight ? 1f : -1f;
        transform.Translate(Vector2.right * moveDirection * speed * Time.deltaTime);
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
        if (collision.gameObject.CompareTag("barrier"))
        {
            Flip();
        }
    }
}
