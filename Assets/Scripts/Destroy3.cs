using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy3 : MonoBehaviour
{
    
    
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("SnakeHead"))
            {
            
              int count = 4;
              for (int i = 0; i < count; i++)
              {
                  other.GetComponent<SnakeTail>().RemoveCircle();
                  
               }
                 Destroy(gameObject);
            }
        }
    }
