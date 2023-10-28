using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{

    public float distance = 1.0f;
    public float speed = 1.0f;

    private Vector3 endPosition;

    // Start is called before the first frame update
    void Start()
    {
        // transform.position += transform.forward * distance;
        endPosition = transform.position + transform.forward * distance;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, endPosition) > 0.01f) {
            transform.position = Vector3.MoveTowards(transform.position, endPosition, speed * Time.deltaTime);
        }
    }
}
