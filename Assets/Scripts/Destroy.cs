using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
     

    private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("SnakeHead"))
            {
                        
              {
                  other.GetComponent<SnakeTail>().RemoveCircle();
              }
             Destroy(gameObject);
           
             }
        }
}
