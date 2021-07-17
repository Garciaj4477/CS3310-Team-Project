using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 cameraOffset;
    public Vector3 cameraRotation;

    // Update is called once per frame
    void Update()
    {

        transform.position = player.position + cameraOffset;
        transform.eulerAngles = cameraRotation;
    }
}
