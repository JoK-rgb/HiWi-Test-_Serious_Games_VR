using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetWayPoints : MonoBehaviour
{
    LineRenderer lineRenderer;
    public Vector3[] positions;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponentInChildren<LineRenderer>();
        positions = new Vector3[lineRenderer.positionCount];
    }

    // Update is called once per frame
    public void SaveWaypoints()
    {
        for (int i = 0; i < lineRenderer.positionCount; i++)
        {
            positions[i] = lineRenderer.GetPosition(i);
        }
            
    }
}
