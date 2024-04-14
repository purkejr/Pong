using UnityEngine;

public class Paddle2Follow : MonoBehaviour
{
    public Transform ballTransform; // Reference to the ball's transform
    public float moveSpeed = 5f; // Speed at which the paddle moves

    // Update is called once per frame
    void Update()
    {
        if (ballTransform != null) // Check if ballTransform is assigned
        {
            // Get the current position of the paddle
            Vector3 currentPosition = transform.position;

            // Calculate the target position for the paddle
            Vector3 targetPosition = new Vector3(currentPosition.x, ballTransform.position.y, currentPosition.z);

            // Move the paddle towards the target position
            transform.position = Vector3.MoveTowards(currentPosition, targetPosition, moveSpeed * Time.deltaTime);
        }
    }
}
