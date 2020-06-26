using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    static public Board instance;
    //각 보드칸이 가지고 있는 정보를 구조체로 만들었음
    public struct board
    {
        //각 보드칸이 가지고 있는 돈의 밸류
        public int money;
        //money값을 몇번 곱해줬는지 알려주는 트리거 값
        public int trigger_a;
    };

    //전체 8칸 짜리 보드 선언
    public board[] gameboard = new board[8];

    private void Awake()
    {
        instance = this;   
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            gameboard[i].money = 0;
            gameboard[i].trigger_a = 0;
        }

        //보드 점수 설정 하는 부분
        gameboard[1].money = 2;
        gameboard[3].money = -3;
        gameboard[5].money = -4;
        gameboard[7].money = 5;
    }

    // Update is called once per frame
    void Update()
    {
  
    }
}
