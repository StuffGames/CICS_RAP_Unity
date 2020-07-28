using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    public float speed = 0.05f;

    void LateUpdate()
    {
        transform.position = Vector3.Slerp(transform.position, player.transform.position + offset, speed);
    }
}
