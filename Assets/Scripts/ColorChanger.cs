using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    
    public Collecting collect;
    void Start()
    {
       
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "GreenWall")
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
            


        }

        if(other.gameObject.tag == "RedWall")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            
        }
    }
}
