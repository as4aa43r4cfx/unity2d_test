using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��ǥ : ���� �ٸ� ��ü�� �浹 ���� �� ���� ȿ���� �߻� ��Ű�� �ʹ�.
// ���� : 1. ���� �ٸ� ��ü�� �浹 �����ϱ�.
//        2. ���� ȿ�� ���忡�� ���� ȿ���� �ϳ� ������ �Ѵ�.
//        3. ���� ȿ���� �߻�(��ġ) ��Ű�� �ʹ�.
//�ʿ��� �Ӽ� : ���� ���� �ּ�(�ܺο��� ���� �־��ش�.)
public class Enemy : MonoBehaviour
{
    public float speed = 5;

    GameObject player;
    Vector3 dir;
    //���� ���� �ּ�(�ܺο��� ���� �־��ش�.)
    public GameObject explosionFactory;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        if (player != null)
        {
            int random = Random.Range(0, 100);

            if (random < 50)
            {
                dir = player.transform.position - transform.position;
                dir.Normalize();
            }
            else
            {
                dir = Vector3.down;
            }
        }
        else
        {
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    //1. ���� �ٸ� ��ü�� �浹 �����ϱ�.
    private void OnCollisionEnter(Collision other)
    {
        // ���ʹ̸� ���� ������ ���� ���� ǥ���ϰ� �ʹ�.
        ScoreManager.Instance.Score++;

        //2.���� ȿ�� ���忡�� ���� ȿ���� �ϳ� ������ �Ѵ�.
        GameObject explosion = Instantiate(explosionFactory);
        //3.���� ȿ���� �߻�(��ġ) ��Ű�� �ʹ�.
        explosion.transform.position = transform.position;
        // ���� �ε��� ��ü�� Bullet �� ��쿡�� ��Ȱ��ȭ ���� źâ�� �ٽ� �־��ش�.
        //1.���� �ε��� ��ü�� Bullet �̶��
        if (other.gameObject.name.Contains("Bullet"))
        {
            //2.�ε��� ��ü�� ��Ȱ��ȭ
            other.gameObject.SetActive(false);
            // PlayerFire Ŭ���� ������
            PlayerFire player = GameObject.Find("Player").GetComponent<PlayerFire>();
            // list �� �Ѿ� ����
            player.bulletObjectPool.Add(other.gameObject);
        }
        else if (other.gameObject.name.Contains("Shield"))
        {
            other.gameObject.SetActive(false);
        }
  
        //3.�׷��� ������ ����
        else
        {
            Destroy(other.gameObject);
        }
        // EnemyManager Ŭ���� ������
        EnemyManager manager = GameObject.Find("EnemyManager").GetComponent<EnemyManager>();
        // list �� �Ѿ� ����
        manager.enemyObjectPool.Add(gameObject);
        //Destroy(gameObject);
        gameObject.SetActive(false);
    }
}