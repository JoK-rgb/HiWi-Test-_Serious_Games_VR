using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer;
    public float reset_time;

    public bool countdown_start;

    public Text timeleft;

    // Start is called before the first frame update
    void Start()
    {
        countdown_start = false;
        reset_time = timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown_start)
        {
            timer -= Time.deltaTime;

            timeleft.text = timer.ToString();
        }

        if (timer <= 0)
        {
            countdown_start = false;
            gameObject.GetComponent<BallGame>().Deactivate();
        }
    }
}
