using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 10;



    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called o0nce per frame
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}

