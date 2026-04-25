using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float resetX = -20f;
    public float startX = 20f;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x <= resetX)
        {
            transform.position = new Vector3(startX, transform.position.y, transform.position.z);
        }
    }
}
