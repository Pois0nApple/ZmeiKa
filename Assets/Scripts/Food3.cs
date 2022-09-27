using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food3 : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeHead"))
        {
            int count = 4;
            for (int i = 0; i < count; i++)
            {
                other.GetComponent<SnakeTail>().AddCircle();
            }
            Destroy(gameObject);
            
        }
    }

}
