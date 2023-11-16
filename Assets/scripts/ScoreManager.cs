using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//유니티 UI를 사용하기위한 네임 스페이스
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    //현재점수 Ui
    public Text currentScoreUI;
    //현재점수
    public int currentScore;
    //최고점수 UI
    public Text bestScoreUI;
    //최고 점수
    private int bestScore;


    //싱글턴 객체
    public static ScoreManager Instance = null;
    public int Score
    {
        get
        {
            return currentScore;
        }
        set
        {
            
            //3. ScoreManager 클래스의 속성에 값을 할당한다.
            currentScore = value;
            //4.화면에 현제점수표시
            currentScoreUI.text = "현재 점수:" + currentScore;
            //최고점수표시 = 목표
            //1. 현재점수 > 최고점수
            //만약 현재점수가 최고점수보다 크다면
            if (currentScore > bestScore)
            {
                //2.최고점수 갱신
                bestScore = currentScore;
                //3. 최고점수 (UI)
                bestScoreUI.text = "최고점수:" + bestScore;
                //목표: 최고점수를 저장하고싶다.
                PlayerPrefs.SetInt("bestScore Score", bestScore);
            }
            if (currentScore > 30)
            {
                //2.최고점수 갱신
                
            }
        }
    }


    //싱글턴 객체에 값이없으면 생성된자기자신을 할당
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        //최고 점수를 베스트 스코어에넣기
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        //최고점수 표시
        bestScoreUI.text = "최고 점수:" + bestScore;

    }
    //currenScore에 값을 넣고 화면에 표시
    public void SetScore(int value)
    {
        //3 스코어 매니저 클래스 속성에 값을 할당한다.
        currentScore = value;
        //4 화면에 점수 표시하기
        currentScoreUI.text = "현재 점수 :" + currentScore;



        //현재점수가 최고점수보다 크니까
        if (currentScore > bestScore)
        {
            //2 최고점수를 갱신시킨다
            bestScore = currentScore;
            //3최고점수를 표시
            bestScoreUI.text = "최고점수:" + bestScore;
            // 최고점수 저장
            PlayerPrefs.SetInt("Best Score", bestScore);
        }
    }
    //currenScore 값 가져오기
    public int GetScore()
    {
        return currentScore;
    }
}
