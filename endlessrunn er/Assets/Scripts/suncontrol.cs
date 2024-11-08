using UnityEngine;
using System.Collections;

public class SunCycle : MonoBehaviour
{
    [Header("Sunset Settings")]
    public float sunsetYPosition = -5f; // Y position for sunset
    public float sunriseYPosition = 0f; // Y position for sunrise
    public float moveSpeed = 1f; // Speed of movement
    public float waitTimeAtSunset = 2f; // Time to wait at sunset
    public float waitTimeAtSunrise = 2f; // Time to wait at sunrise

    private bool isMovingDown = true; // Tracks if we are moving down (sunset)
    private bool isWaiting = false; // Tracks if we are waiting

    void Update()
    {
        if (!isWaiting) // Only move if not waiting
        {
            if (isMovingDown)
            {
                // Move down to simulate sunset
                transform.position = Vector3.MoveTowards(transform.position, 
                    new Vector3(transform.position.x, sunsetYPosition, transform.position.z), 
                    moveSpeed * Time.deltaTime);

                // Check if we've reached the sunset position
                if (transform.position.y <= sunsetYPosition)
                {
                    isMovingDown = false; // Start moving up (sunrise)
                    StartCoroutine(WaitAndRise(waitTimeAtSunset));
                }
            }
            else
            {
                // Move up to simulate sunrise
                transform.position = Vector3.MoveTowards(transform.position, 
                    new Vector3(transform.position.x, sunriseYPosition, transform.position.z), 
                    moveSpeed * Time.deltaTime);

                // Check if we've reached the sunrise position
                if (transform.position.y >= sunriseYPosition)
                {
                    isMovingDown = true; // Start moving down again (sunset)
                    StartCoroutine(WaitAndSettle(waitTimeAtSunrise));
                }
            }
        }
    }

    private IEnumerator WaitAndRise(float waitTime)
    {
        isWaiting = true; // Set waiting flag
        // Wait for the specified time at sunset
        yield return new WaitForSeconds(waitTime);
        isWaiting = false; // Reset waiting flag
    }

    private IEnumerator WaitAndSettle(float waitTime)
    {
        isWaiting = true; // Set waiting flag
        // Wait for the specified time at sunrise
        yield return new WaitForSeconds(waitTime);
        isWaiting = false; // Reset waiting flag
    }
}
