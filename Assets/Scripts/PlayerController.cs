using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float speed = 20.0f;        // Forward/backward speed
    private float turnSpeed = 45.0f;    // Turning speed

    private float horizontalInput;  // Player input (A/D, Left/Right arrows)
    private float forwardInput;     // Player input (W/S, Up/Down arrows)

    void Start()
    {

    }
    void Update()
    {
        // Get input values
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the car forward/backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotate the car left/right
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
