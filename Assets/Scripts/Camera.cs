using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform lookAtTarget;
    public float pLerp = 0.02f;
    public float rLerp = 0.01f;


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, lookAtTarget.position, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, lookAtTarget.rotation, rLerp);
    }
}
