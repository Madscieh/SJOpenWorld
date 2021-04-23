using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCylinders : MonoBehaviour
{
    [SerializeField] GameObject item;
    private void Awake()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            int newSpot = Random.Range(0, transform.childCount);
            Vector3 temp = transform.GetChild(i).position;
            transform.GetChild(i).position = transform.GetChild(newSpot).position;
            transform.GetChild(newSpot).position = temp;
        }
    }
    private void Update()
    {
        if (TouchCylinders.numCylinders == 4)
        {
            Invoke(nameof(ItemAparece), .5f);
            TouchCylinders.numCylinders = 0;
        }
    }
    public void ItemAparece()
    {
        Instantiate(item, new Vector3(0, 1, 14), Quaternion.identity);
    }
}