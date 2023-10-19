using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermode : MonoBehaviour
{
    //플레이어 속력
    public float speed = 5;
    public int count;
    //현재점수 Ui
    public Text countUI;






    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, v, 0);
        




        transform.position += dir * speed * Time.deltaTime;


    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("item"))
        {
            count++;
            countUI.text = "Life point:" + count;
            Debug.Log("hello");
        }
    }
}
