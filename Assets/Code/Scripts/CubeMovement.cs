using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class CubeMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.right + Vector3.forward) * Time.deltaTime;
    }
}
