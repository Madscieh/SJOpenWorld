using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TocaMelodia : MonoBehaviour
{
    [SerializeField] AudioClip notaDo, notaRe, notaMi, notaFa;
    new AudioSource audio;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine (nameof(TocaNota));
        }
    }
    IEnumerator TocaNota()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        audio.PlayOneShot(notaDo);
        yield return new WaitForSeconds(.5f);
        gameObject.GetComponent<Renderer>().material.color = Color.blue;
        audio.PlayOneShot(notaRe);
        yield return new WaitForSeconds(.5f);
        gameObject.GetComponent<Renderer>().material.color = Color.green;
        audio.PlayOneShot(notaMi);
        yield return new WaitForSeconds(.5f);
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        audio.PlayOneShot(notaFa);
        yield return new WaitForSeconds(.5f);
        gameObject.GetComponent<Renderer>().material.color = Color.white;
        yield return null;
    }
}