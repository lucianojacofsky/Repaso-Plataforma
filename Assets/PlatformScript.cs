using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{

    public float movementspeed;
    public float derlimit;
    public float izqlimit;
    public bool derecha;

    public GameObject prefab1;
    public GameObject prefab2;
    // Start is called before the first frame update
    void Start()
    {
        derecha = true;
    }

    // Update is called once per frame
    void Update()
    {
       

        if (derecha == true)
        {
            transform.position += new Vector3(movementspeed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(movementspeed, 0, 0);
        }
            if (transform.position.x > derlimit)
        {
               derecha = false;
                Instantiate(prefab1);
        }
            else if (transform.position.x < izqlimit)
        {
            derecha = true;
            Instantiate(prefab2);
        }
    }
}