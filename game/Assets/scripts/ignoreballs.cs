using UnityEngine;

public class ignoreballs : MonoBehaviour
{
    void Start()
    {
        Collider2D playerCollider = GetComponent<Collider2D>();
        if (playerCollider == null)
        {
            Debug.LogWarning("Brak komponentu Collider2D na graczu!");
            return;
        }

       
        GameObject[] balls = GameObject.FindGameObjectsWithTag("ball");
        foreach (GameObject ball in balls)
        {
            Collider2D other = ball.GetComponent<Collider2D>();
            if (other != null)
                Physics2D.IgnoreCollision(playerCollider, other);
        }

        
        GameObject[] loops = GameObject.FindGameObjectsWithTag("loop");
        foreach (GameObject loop in loops)
        {
            Collider2D other = loop.GetComponent<Collider2D>();
            if (other != null)
                Physics2D.IgnoreCollision(playerCollider, other);
        }

        GameObject[] bats = GameObject.FindGameObjectsWithTag("bat");
        foreach(GameObject bat in bats)
        {
            Collider2D other = bat.GetComponent<Collider2D>();
            if (other != null)
                Physics2D.IgnoreCollision(playerCollider, other);
        }
    }
}
