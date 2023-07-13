using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActivePortal : MonoBehaviour
{
    public GameObject portal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > 30)
        {
            Debug.Log("set active");
           portal.SetActive(true);
        }
    }
}
