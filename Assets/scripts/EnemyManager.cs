using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //�ʿ� �Ӽ� : ������ƮǮ ũ��, ������ƮǮ �迭, SpawnPoint ��
    //������ƮǮ ũ��
    public int poolSize = 10;
    //������ƮǮ �迭
    public List<GameObject> enemyObjectPool;
    //SpawnPoint ��
    public Transform[] spawnPoints;

    public GameObject enemyFactory;
    public GameObject boss;

    // ������ �ּҽð�
    public float minTime = 0.5f;
    // ������ �ִ�ð�
    public float maxTime = 1.5f;
    // �����ð�
    float creatTime;
    float currentTime = 0;


    //1. �¾� �� ��
    void Start()
    {
        boss = GameObject.Find("boss");
        
        boss.SetActive(false);

        creatTime = Random.Range(minTime, maxTime);
        //2. ������ƮǮ�� ���ʹ̵��� ���� �� �ִ� ũ��� ����� �ش�.
        enemyObjectPool = new List<GameObject>();
        //3. ������ƮǮ�� ���� ���ʹ� ���� ��ŭ �ݺ��Ͽ�
        for (int i = 0; i < poolSize; i++)
        {
            //4. ���ʹ̰��忡�� ���ʹ̸� �����Ѵ�.
            GameObject enemy = Instantiate(enemyFactory);
            //5. ���ʹ̸� ������ƮǮ�� �ְ�ʹ�.
            enemyObjectPool.Add(enemy);
            // ��Ȱ��ȭ ��Ű��.
            enemy.SetActive(false);

            
        }
    }

    // Update is called once per frame
    void Update()
    {
        ScoreManager cs = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        currentTime += Time.deltaTime;
        //1.���� �ð��� �Ǿ����ϱ�
        if (currentTime > creatTime)
        {
            //2.������ƮǮ�� ���ʹ̰� �ִٸ�
            GameObject enemy = enemyObjectPool[0];
            if (enemyObjectPool.Count > 0)
            {
                //3.���ʹ̸� Ȱ��ȭ �ϰ� �ʹ�.
                enemy.SetActive(true);
                //4.������ƮǮ���� �Ѿ�����
                enemyObjectPool.Remove(enemy);
                // �������� �ε��� ����
                int index = Random.Range(0, spawnPoints.Length);
                // 5.���ʹ� ��ġ ��Ű��
                enemy.transform.position = spawnPoints[index].position;
            }

            creatTime = Random.Range(minTime, maxTime);
            currentTime = 0;
        }

        if (cs.currentScore > 10)
        {
            //Debug.Log("boss");
            //Debug.Log(cs.currentScore);
            boss.SetActive(true);
            //transform.position = new Vector3(0, 4, 0);

        }
    }
}



