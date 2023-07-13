using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class eatMandleBulb : MonoBehaviour
{
    public GameObject portal;
    private void OnTriggerEnter(Collider other)
    {
  
        if (other.CompareTag("mandleBulb"))
        {
            portal.SetActive(true);
            other.gameObject.SetActive(false);
        }
    }
}
