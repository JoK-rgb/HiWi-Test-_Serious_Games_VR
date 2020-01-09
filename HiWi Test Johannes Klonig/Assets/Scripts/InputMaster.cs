using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMaster : MonoBehaviour
{
    public GameObject Torus;
    Material torus_Material;

    public bool BallGameToggle;

    void Start()
    {
        //Fetch the Torus Material
        torus_Material = Torus.GetComponent<Renderer>().material;

        BallGameToggle = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            torus_Material.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            torus_Material.color = Color.green;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            torus_Material.color = Color.blue;
        }

        if (Input.GetKeyDown(KeyCode.Return)){
            BallGameToggle = !BallGameToggle;

            if (BallGameToggle)
                GetComponent<BallGame>().Activate();
            else
                GetComponent<BallGame>().Deactivate();
        }
    }
}
