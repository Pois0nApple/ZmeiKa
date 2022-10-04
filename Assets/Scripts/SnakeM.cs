using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeM : MonoBehaviour
{
    
    public float Speed;
    public float RotationSpeed;
    float count = 0;
    public Text countText;

    
    
    

    private void Start()
    {
        count = 0;
        countText.text = count.ToString();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -1 * RotationSpeed * Time.deltaTime);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            count+= 0.5f;
            countText.text =  count.ToString();
        }
        if (other.gameObject.CompareTag("Food1"))
        {
            count += 1f;
            countText.text = count.ToString();
        }
        if (other.gameObject.CompareTag("Food2"))
        {
            count += 1.5f;
            countText.text =  count.ToString();
        }
        if (other.gameObject.CompareTag("Food3"))
        {
            count += 2f;
            countText.text = count.ToString();
        }

        if (other.gameObject.CompareTag("Destr"))
        {
            count -= 0.5f;
            countText.text = count.ToString();
        }
        if (other.gameObject.CompareTag("Destr1"))
        {
            count -= 1f;
            countText.text = count.ToString();
        }
        if (other.gameObject.CompareTag("Destr2"))
        {
            count -= 1.5f;
            countText.text =count.ToString();
        }
        if (other.gameObject.CompareTag("Destr3"))
        {
            count -= 2f;
            countText.text = count.ToString();
        }
        if (count < 0)
        {
            Destroy(gameObject);
          Application.LoadLevel(Application.loadedLevel);
        }
    }
    
       
    }

    
    

