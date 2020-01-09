using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMouse : MonoBehaviour
{
    public GameObject Point1;
    public GameObject Point2;

    public bool start;

    // Start is called before the first frame update
    void Start()
    {
        start = true;
    }

    // Update is called once per frame
    void Update()
    {
        Point2.transform.position = new Vector3(Point2.transform.position.x + Input.GetAxisRaw("Mouse X"), Point2.transform.position.y, Point2.transform.position.z);
        Point1.transform.position = new Vector3(Point1.transform.position.x + Input.GetAxisRaw("Mouse X"), Point1.transform.position.y, Point1.transform.position.z);

        Point1.transform.position = new Vector3(Point1.transform.position.x, Point1.transform.position.y + Input.GetAxisRaw("Mouse Y"), Point1.transform.position.z);

        if (Input.GetMouseButtonDown(0))
        {
            if (start)
            {
                start = false;
                GameObject.Find("Bezier").GetComponent<GetWayPoints>().SaveWaypoints();
                GameObject.Find("Ball_new").GetComponent<BezierFollow>().enabled = true;
                GameObject.Find("Ball_new").GetComponent<SphereCollider>().enabled = true;
            }
        }
    }
}
