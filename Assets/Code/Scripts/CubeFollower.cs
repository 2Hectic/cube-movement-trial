using UnityEngine;

public class CubeFollower : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject player;

    public Vector3 offset;

    void Start()
    {
        offset = player.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
