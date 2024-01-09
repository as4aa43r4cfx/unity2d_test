using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bossattack : MonoBehaviour
{
    float currentTime;
    public float createTime = 1;
    public GameObject BBulletFactory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > createTime)
        {
            GameObject BBullet = Instantiate(BBulletFactory);

            BBullet.transform.position = transform.position;
            currentTime = 0;    
        }
        
    }
}
