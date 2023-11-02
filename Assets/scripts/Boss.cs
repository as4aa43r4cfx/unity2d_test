using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ScoreManager js  = GameObject.Find("Scoremanager").GetComponent<Scoremanager>();

        if (js.currentScore > 25)
        {

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
