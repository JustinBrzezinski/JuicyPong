using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float startSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(1, 1, 1);
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            // pick a direction
            float rand = Random.value;
            int direction;
            if (rand <= .5f)
            {
                direction = -1;
            }
            else
            {
                direction = 1;
            }

            //pick a random angle around the Y axis
            Quaternion angle = Quaternion.AngleAxis(Random.Range(40, 140), direction * Vector3.up);

            //set the ball to that angle
            transform.rotation = angle;
            //move the ball forward at start speed
            rb.velocity = transform.forward * startSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localScale *= 1.01f;
    }
}
