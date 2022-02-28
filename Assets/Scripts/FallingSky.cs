using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSky : MonoBehaviour
{
    float time;
    public float speed = 0.1f;
    public GameObject targetMarker;


    // Update is called once per frame
    void Update()
    {
        // transform.position -= transform.localPosition * Time.deltaTime;
        if (!targetMarker) return;

        var dir = (targetMarker.transform.position - transform.position).normalized;
        transform.position += dir * speed * Time.deltaTime;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            print("hit player"); 
        }
    }
}
