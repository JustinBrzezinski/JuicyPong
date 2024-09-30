using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(1, 5, 1);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localScale *= 1.01f;
    }
}
