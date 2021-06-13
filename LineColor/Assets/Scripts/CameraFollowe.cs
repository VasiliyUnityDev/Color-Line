using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowe : MonoBehaviour
{
    [SerializeField]
    private Transform mainCam;

    public float cornerX;
    public float cornerZ;

    private void FixedUpdate()
    {
        mainCam.position = new Vector3(transform.position.x - cornerX, mainCam.transform.position.y, transform.position.z - cornerZ);
    }
}
