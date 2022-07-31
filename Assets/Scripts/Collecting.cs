using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecting : MonoBehaviour
{
    public GameObject mainBurger;
    public static  float heightIncrease;
    bool isGreen;

    void Start()
    {
        isGreen = true;
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GreenWall")
        {
            
            isGreen = true;
        }


        if (other.gameObject.tag == "GreenBurgers" && isGreen == true)
        {
            heightIncrease += 0.4f;
            other.gameObject.transform.parent = mainBurger.transform;
            other.gameObject.transform.position = new Vector3(mainBurger.transform.position.x, mainBurger.transform.position.y + heightIncrease, mainBurger.transform.position.z);
        }

        if (other.gameObject.tag == "RedWall")
        {
            isGreen = false;
        }

        if(other.gameObject.tag == "RedBurgers" && isGreen == false)
        {
            heightIncrease += 0.4f;
            other.gameObject.transform.parent = mainBurger.transform;
            other.gameObject.transform.position = new Vector3(mainBurger.transform.position.x, mainBurger.transform.position.y + heightIncrease, mainBurger.transform.position.z);
        }
    }

    
    
        
    
   
    
}
