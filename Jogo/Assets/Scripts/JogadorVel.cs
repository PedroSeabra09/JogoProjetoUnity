using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogadorVel : MonoBehaviour
{
    public Vector3 v3Vel;
    public KeyCode keyPositive;
    public KeyCode keyNegative;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(keyPositive))
            GetComponent<Rigidbody>().velocity += v3Vel;

        if (Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -= v3Vel;
    }
}
