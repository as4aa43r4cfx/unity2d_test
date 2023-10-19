using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public float speed = 7;
    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);



        





    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.down;

        transform.position += dir * speed * Time.deltaTime;
        
        
    }


}
