using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollow : MonoBehaviour
{

    public Transform objFollow;
    private Vector3 deltaPos;
    void Start()
    {

        deltaPos = transform.position - objFollow.position;
    }


    void Update()
    {
        if (GameObject.FindWithTag("SnakeHead") != null)
        { 
            transform.position = objFollow.position + deltaPos; 
        }
           

    }
}