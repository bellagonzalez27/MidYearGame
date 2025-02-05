using UnityEngine;

public class NewPlatform : MonoBehaviour
{
    public int platformCount = 0;
    public bool alreadyCollided = false;

    [SerializeField] GameObject[] platforms;
    void OnTriggerEnter(Collider other){
        if(!alreadyCollided){
            alreadyCollided = true;
            
            Debug.Log("Platform Count: " + platformCount);
            platformCount++;

            if(other.gameObject.tag == "Player"){
                Instantiate(platforms[Random.Range(0, platforms.Length)], 
                new Vector3(transform.position.x, transform.position.y-2, transform.position.z+8), Quaternion.identity);
            }
        }
    }
}
