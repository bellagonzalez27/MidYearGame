using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce(Vector3.left * speed);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(Vector3.right * speed);
        }
    }
}
