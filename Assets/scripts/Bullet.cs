using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int count;
    public float speed = 10;
    public GameObject boss;
    

    // Start is called before the first frame update
    void Start()
    {
        boss = GameObject.Find("boss");

    }

    // Update is called o0nce per frame
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.name.Contains("boss"))
        {
            count++;
            if(count>15)
                Destroy(boss);


        }
    }
}