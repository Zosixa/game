using UnityEngine;

public class Batthrow : MonoBehaviour
{
    public GameObject batPrefab;
    public float interval = 2f;
    public float speed = 5f;
    public int playerdestroyer = 0;

    void Start()
    {
        InvokeRepeating(nameof(SpawnBat), 0f, interval);
    }

    void SpawnBat()
    {
        if (!batPrefab) return;

        var player = GameObject.FindGameObjectWithTag("Player1");
        if (!player) return;

        var bat = Instantiate(batPrefab, transform.position, Quaternion.identity);
        var dir = (player.transform.position - transform.position).normalized;

        (bat.GetComponent<Rigidbody2D>() ?? bat.AddComponent<Rigidbody2D>()).velocity = dir * speed;
        
        
    }

    

   
}
