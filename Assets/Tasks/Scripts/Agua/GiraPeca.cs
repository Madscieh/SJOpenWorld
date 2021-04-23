using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiraPeca : MonoBehaviour
{
    [SerializeField] Transform peca;
    public static int numPecas = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            peca.RotateAround(peca.position, Vector3.up, 90);
            numPecas++;
        }
    }
}