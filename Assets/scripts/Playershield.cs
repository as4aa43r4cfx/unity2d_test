using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playershield : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

   //  Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        { 
            shield();
        }

    }

    public void shield()
    {
        gameObject.SetActive(true);
        transform.position = transform.position;
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, v+1, 0);


    }
}




