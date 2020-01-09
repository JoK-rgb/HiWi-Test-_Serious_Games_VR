using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public bool countonce;

    private void Start()
    {
        countonce = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponentInParent<BezierFollow>().enabled = false;
        gameObject.GetComponentInParent<Rigidbody>().useGravity = true;
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
        
        if (collision.gameObject.name == "Ground")
        {
            Destroy(gameObject);
            GameObject.Find("Main Camera").GetComponent<BallGame>().CreateNewBall();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Target" && countonce)
        {
            countonce = false;
            GameObject.Find("Main Camera").GetComponent<BallGame>().Score++;
        }
    }
}
