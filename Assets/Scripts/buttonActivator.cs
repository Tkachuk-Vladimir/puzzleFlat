using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonActivator : MonoBehaviour
{
    public GameObject firstGroup;
    public Material normal;
    public Material transparent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube")|| other.CompareTag("Player"))
        {
            GetComponent<Renderer>().material = transparent;
            firstGroup.GetComponent<Renderer>().material = transparent;
            firstGroup.GetComponent<Collider>().isTrigger = true;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cube") || other.CompareTag("Player"))
        {
            GetComponent<Renderer>().material = normal; 
            firstGroup.GetComponent<Renderer>().material = normal; ;
            firstGroup.GetComponent<Collider>().isTrigger = false;

        }
    }
}
