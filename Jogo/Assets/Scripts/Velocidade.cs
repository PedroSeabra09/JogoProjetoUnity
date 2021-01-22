using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocidade : MonoBehaviour
{
    public Vector3 v3Vel;

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += v3Vel;
    }
}
