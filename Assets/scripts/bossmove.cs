using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossmove : MonoBehaviour
{
    Vector3 dir;
    GameObject player;
    public float speed = 5;
    Vector3 pos;







    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        if (player != null)
        {
            int random = Random.Range(0, 100);

            if (random < 50)
            {
                dir = Vector3.left;

            }
            else
            {
                dir = Vector3.right;
            }




        }
    }

    // Update is called once per frame
    void Update()
    {
        

        pos = this.GameObject.transform.position;
        
        
        if (pos.x > 2.5) 
        {
            dir = Vector3.left;
               
        }

        if (pos.x < -2.5)
        {
            dir = Vector3.right;

        }

        transform.position += dir * speed * Time.deltaTime;
    }
    






    



        
       

        
    
}
