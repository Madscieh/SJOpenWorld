using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubes : MonoBehaviour
{
    new Rigidbody rigidbody;
    public static int numCubes = 0;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == gameObject.name)
        {
            transform.position = other.gameObject.transform.position;
            rigidbody.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
            numCubes++;
        }
    }
}