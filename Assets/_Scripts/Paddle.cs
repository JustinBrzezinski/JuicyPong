using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;
    public float paddleSpeed = 2.0f;

    void Update()
    {
        if (Input.GetKey(up))
        {
            transform.position += Vector3.forward * paddleSpeed * Time.deltaTime;
        } 
        else if (Input.GetKey(down))
        {
            transform.position -= Vector3.forward * paddleSpeed * Time.deltaTime;
        }
    }
}
