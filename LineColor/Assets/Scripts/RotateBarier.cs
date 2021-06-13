using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBarier : MonoBehaviour
{
    public float speedRot;

    private void FixedUpdate()
    {
        transform.Rotate(0f, speedRot * Time.deltaTime, 0f);
    }
}
