using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObject : MonoBehaviour
{
    public float rotatingSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotatingSpeed, 0);
    }
}
