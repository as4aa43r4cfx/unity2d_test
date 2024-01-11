using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    public int count = 0;
    public GameObject Bullet;

    // Start is called before the first frame update
    void Start()
    {

        Bullet = GameObject.Find("Bullet");





    }

    // Update is called once per frame
    void Update()
    {

        



    }
    private void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.name.Contains("Bullet"))
        {
            Debug.Log("heo");
            count += 1;
            if (count > 10)
            {
                Debug.Log("h111eo");
                Destroy(gameObject);
            }


        }
    }
}
