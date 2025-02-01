using UnityEngine;

public class CamController : MonoBehaviour
{
    [SerializeField] GameObject camera;
    [SerializeField] GameObject player;

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = new Vector3(player.transform.position.x, player.transform.position.y+5, player.transform.position.z-5);
    }
}
