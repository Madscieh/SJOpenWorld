using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPyres : MonoBehaviour
{
    [SerializeField] GameObject fire;
    public static int numPyres = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(fire, new Vector3 (transform.position.x, 2.3f, transform.position.z), Quaternion.identity);
            numPyres++;
        }
    }
}
