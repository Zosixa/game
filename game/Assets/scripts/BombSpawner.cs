using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public GameObject bombPrefab;
    public float interval = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnBomb), 0f, interval);
    }

    void SpawnBomb()
    {
        if (bombPrefab != null)
            Instantiate(bombPrefab, transform.position, Quaternion.identity);
    }
}
