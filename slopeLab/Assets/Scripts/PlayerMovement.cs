using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] float startSpeed;
    [SerializeField] float timeStartSpeed; 
    float jumpForce = 2f;
    float timeStartSpeedCounter;
    // Update is called once per frame
    void Start() {
    }
    void Update()
    {   
        if (timeStartSpeedCounter <= timeStartSpeed) {
        rb.AddForce(Vector3.forward * startSpeed); 
        timeStartSpeedCounter+=1; 
        }

        if(Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce(Vector3.left * speed * 2);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(Vector3.right * speed * 2);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            rb.AddForce(new Vector3(0, jumpForce), ForceMode.Impulse);
        }
    }
}
