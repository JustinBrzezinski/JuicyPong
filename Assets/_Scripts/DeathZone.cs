using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Death zone triggered!");

        
        if (other.gameObject.CompareTag("Ball"))
        {
            //destroy the ball
            Destroy(other.gameObject);

            // add 1 to other player's score

            //new ball
            GameObject obj = GameObject.Find("GameManager");
            obj.GetComponent<GameManager>().CreateNewBall();
        }
        
    }

}
