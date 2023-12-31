using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    float minTime = 14;

    float maxTime = 20;

    float currentTime;

    public float createTime = 15;

    public GameObject ItemFactory;
    // Start is called before the first frame update
    void Start()
    {
        createTime = UnityEngine.Random.Range(minTime, maxTime);

        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > createTime)
        {
            GameObject enemy = Instantiate(ItemFactory);
            
            enemy.transform.position = transform.position;

            currentTime = 2;

            createTime = UnityEngine.Random.Range(minTime, maxTime);
        }
        
    }
}
