using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCylinders : MonoBehaviour
{
    public static int numCylinders = 0;
    new AudioSource audio;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audio.Play();
            numCylinders++;
        }
    }
}