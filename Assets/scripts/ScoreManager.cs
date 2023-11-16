using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//����Ƽ UI�� ����ϱ����� ���� �����̽�
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    //�������� Ui
    public Text currentScoreUI;
    //��������
    public int currentScore;
    //�ְ����� UI
    public Text bestScoreUI;
    //�ְ� ����
    private int bestScore;


    //�̱��� ��ü
    public static ScoreManager Instance = null;
    public int Score
    {
        get
        {
            return currentScore;
        }
        set
        {
            
            //3. ScoreManager Ŭ������ �Ӽ��� ���� �Ҵ��Ѵ�.
            currentScore = value;
            //4.ȭ�鿡 ��������ǥ��
            currentScoreUI.text = "���� ����:" + currentScore;
            //�ְ�����ǥ�� = ��ǥ
            //1. �������� > �ְ�����
            //���� ���������� �ְ��������� ũ�ٸ�
            if (currentScore > bestScore)
            {
                //2.�ְ����� ����
                bestScore = currentScore;
                //3. �ְ����� (UI)
                bestScoreUI.text = "�ְ�����:" + bestScore;
                //��ǥ: �ְ������� �����ϰ�ʹ�.
                PlayerPrefs.SetInt("bestScore Score", bestScore);
            }
            if (currentScore > 30)
            {
                //2.�ְ����� ����
                
            }
        }
    }


    //�̱��� ��ü�� ���̾����� �������ڱ��ڽ��� �Ҵ�
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        //�ְ� ������ ����Ʈ ���ھ�ֱ�
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        //�ְ����� ǥ��
        bestScoreUI.text = "�ְ� ����:" + bestScore;

    }
    //currenScore�� ���� �ְ� ȭ�鿡 ǥ��
    public void SetScore(int value)
    {
        //3 ���ھ� �Ŵ��� Ŭ���� �Ӽ��� ���� �Ҵ��Ѵ�.
        currentScore = value;
        //4 ȭ�鿡 ���� ǥ���ϱ�
        currentScoreUI.text = "���� ���� :" + currentScore;



        //���������� �ְ��������� ũ�ϱ�
        if (currentScore > bestScore)
        {
            //2 �ְ������� ���Ž�Ų��
            bestScore = currentScore;
            //3�ְ������� ǥ��
            bestScoreUI.text = "�ְ�����:" + bestScore;
            // �ְ����� ����
            PlayerPrefs.SetInt("Best Score", bestScore);
        }
    }
    //currenScore �� ��������
    public int GetScore()
    {
        return currentScore;
    }
}
