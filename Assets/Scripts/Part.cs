using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part : MonoBehaviour
{
    ParticleSystem crash;
    void Awake()
    {
        crash = GetComponent<ParticleSystem>();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SnakeHead")
        {
            crash.Play();
        }
    }
}
