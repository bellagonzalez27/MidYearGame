using UnityEngine;

public class NewPlatform : MonoBehaviour
{
    [SerializeField] GameObject[] platforms; // Platform prefabs
    [SerializeField] float platformDestroyTime = 20f; // Time before a platform is destroyed
    [SerializeField] float spawnDistance = 8f; // Distance between platforms

    void Start()
    {
        // Destroy platform after a certain time to free memory
        Destroy(gameObject, platformDestroyTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player triggered platform: " + gameObject.name);

            // Spawn a new platform at a fixed distance ahead
            GameObject newPlatform = Instantiate(
                platforms[Random.Range(0, platforms.Length)],
                new Vector3(transform.position.x, transform.position.y - 2, transform.position.z + spawnDistance),
                Quaternion.identity
            );

            Debug.Log("New platform spawned: " + newPlatform.name);
        }
    }
}