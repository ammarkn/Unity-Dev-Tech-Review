using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{

    // Specifies distance from starting position to final position.
    public float distance = 1.0f;

    // Specifies speed of the camera movement to the final position.
    public float speed = 1.0f;

    private Vector3 endPosition;

    // Start is called before the first frame update
    void Start()
    {
        // Calculates the end position for the camera based on the current position, forward position, and distance.
        endPosition = transform.position + transform.forward * distance;
    }

    // Update is called once per frame
    void Update()
    {
        // Decides whether to move the camera needs to move based on proximity to final position
        if(Vector3.Distance(transform.position, endPosition) > 0.01f) {
            // Moves the camera towards the final position
            transform.position = Vector3.MoveTowards(transform.position, endPosition, speed * Time.deltaTime);
        }
    }
}
