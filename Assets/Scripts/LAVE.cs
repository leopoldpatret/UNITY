using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LAVE : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Collider>().gameObject.tag == "Lave")
        {
            print("game over");
        }
    }
}
