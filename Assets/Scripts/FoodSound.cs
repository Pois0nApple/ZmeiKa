using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSound : MonoBehaviour
{
    public AudioClip Audio;
    [Min(0)]
    public float Vol;
    private AudioSource _audio;
    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeHead"))
        {
            _audio.PlayOneShot(Audio, Vol);
        }

    }
}
