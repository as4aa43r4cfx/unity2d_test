using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossmove : MonoBehaviour
{


    public Transform target;
    public Vector3 direction;
    public float velocity;
    public float default_velocity;
    public float accelaration;
    public Vector3 default_direction;


    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        ScoreManager cs = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        if (cs.currentScore > 2)
        {
            default_direction.x = Random.Range(-1.0f, 1.0f);
            default_direction.y = Random.Range(-1.0f, 1.0f);
        }



    }
    






    



        
       

        
    
}
