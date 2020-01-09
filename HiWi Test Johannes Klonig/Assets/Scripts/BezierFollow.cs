using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierFollow : MonoBehaviour
{
    public Vector3[] path;
    public float speed;
    public float reachDist = 0.1f;
    public int currentPoint = 0;

    void Start()
    {
        
    }

    void Update()
    {
        path = GameObject.Find("Bezier").GetComponent<GetWayPoints>().positions;

        float dist = Vector3.Distance(path[currentPoint], transform.position);

        transform.position = Vector3.Lerp(transform.position, path[currentPoint], Time.deltaTime*speed);

        if(dist <= reachDist)
        {
            currentPoint++;
        }

        if (currentPoint >= path.Length)
        {
            currentPoint = 0;
            Destroy(gameObject);
            GameObject.Find("Main Camera").GetComponent<BallGame>().CreateNewBall();
        }
    }
    
}
