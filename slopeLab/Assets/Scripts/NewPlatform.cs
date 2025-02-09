using UnityEngine;

public class NewPlatform : MonoBehaviour
{
    public int platformCount = 0;
    [SerializeField] int maxPlatforms = 100; // Set a larger limit
    [SerializeField] GameObject[] platforms;

    void Start()
    {
        Destroy(gameObject, 15f); // Destroy old platforms after 15 seconds
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && platformCount < maxPlatforms)
        {
            Debug.Log("Triggered by: " + other.gameObject.name);

            Instantiate(
                platforms[Random.Range(0, platforms.Length)],
                new Vector3(transform.position.x, transform.position.y - 2, transform.position.z + 8),
                Quaternion.identity
            );

            platformCount++;
        }
    }

    void Update()
    {
        // Reset platform count if no platforms exist
        if (GameObject.FindGameObjectsWithTag("Platform").Length == 0)
        {
            platformCount = 0;
        }
    }
}
