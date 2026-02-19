using UnityEngine;
using UnityEngine.InputSystem;

public class CubeMovement : MonoBehaviour
{
    private InputAction moveAction;
    private InputAction jumpAction;
    [SerializeField] private Vector3 velocity;

    private void Start()
    {
        moveAction = InputSystem.actions.FindAction("move");
        jumpAction = InputSystem.actions.FindAction("jump");
    }

    void Update()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        velocity = new Vector3(moveValue.x, 0, moveValue.y);

        if(jumpAction.IsPressed())
        {
            velocity += new Vector3(0, 2, 0);
        }
    }

    void FixedUpdate()
    {
        transform.position += velocity * Time.fixedDeltaTime;

        velocity -= new Vector3 (0, 1, 0);
    }
}
