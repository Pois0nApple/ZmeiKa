using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeHead"))
        {
                if (GameObject.FindWithTag("SnakeHead") != null)
                Destroy(other.gameObject);
                Application.LoadLevel(Application.loadedLevel); 
            
            

        }
    }
}
