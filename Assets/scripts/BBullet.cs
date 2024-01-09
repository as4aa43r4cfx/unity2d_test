using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BBullet : MonoBehaviour
{
    public int count;
    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.down * speed * Time.deltaTime;

    }
    private void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.name.Contains("Player"))
        {
            //2.ºÎµúÈù ¹°Ã¼¸¦ ºñÈ°¼ºÈ­
            //other.gameObject.SetActive(false);
            Debug.Log("player hit");
            Destroy(other.gameObject);

        }
        else 
            //(other.gameObject.name.Contains("Shield"))
        {
            other.gameObject.SetActive(false);
        }




    }
}
