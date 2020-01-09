using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallGame : MonoBehaviour
{
    public GameObject Torus;
    Animator Torus_Animation;

    public GameObject BallPrefab;
    public GameObject BallSpawnPoint;
    public GameObject Room;
    public GameObject Hands;
    public GameObject Basket;
    public GameObject BezierCurve;
    public GameObject Canvas;

    public Text timer;

    public int Score;

    // Start is called before the first frame update
    void Start()
    {
        Torus_Animation = Torus.GetComponent<Animator>();

        Score = 0;
    }


    public void Activate()
    {
        Score = 0;

        Torus.transform.GetChild(0).gameObject.SetActive(true);
        Torus_Animation.enabled = true;
        BezierCurve.SetActive(true);
        Room.SetActive(true);
        Hands.SetActive(true);
        Basket.SetActive(true);
        Canvas.SetActive(true);

        gameObject.GetComponent<InputMouse>().enabled = true;
        gameObject.GetComponent<Timer>().countdown_start = true;
        gameObject.GetComponent<Timer>().timer = gameObject.GetComponent<Timer>().reset_time;

        Torus.transform.position = new Vector3(0,7,2);

        CreateNewBall();
    }

    public void Deactivate()
    {
        Torus.transform.GetChild(0).gameObject.SetActive(false);
        Torus_Animation.enabled = false;
        BezierCurve.SetActive(false);
        Room.SetActive(false);
        Hands.SetActive(false);
        Basket.SetActive(false);

        gameObject.GetComponent<InputMouse>().enabled = false;
        gameObject.GetComponent<InputMaster>().BallGameToggle = false;
        gameObject.GetComponent<Timer>().timer = gameObject.GetComponent<Timer>().reset_time;
        gameObject.GetComponent<Timer>().countdown_start = false;

        timer.text = "0.00";

        if (GameObject.Find("Ball_new"))
        {
            Destroy(GameObject.Find("Ball_new"));
        }
    }

    public void CreateNewBall()
    {
        if (GameObject.Find("Ball_new"))
            GameObject.Find("Ball_new").name = "Ball";

        GameObject Ball = Instantiate(BallPrefab, new Vector3(BallSpawnPoint.transform.position.x, BallSpawnPoint.transform.position.y - 0.5f, BallSpawnPoint.transform.position.z + 1), Quaternion.identity);
        Ball.name = "Ball_new";

        gameObject.GetComponent<InputMouse>().start = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
