using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public static gamemanager instance;

    //게임 시작하고 현재 몇 번째 턴인지
    public int turn_count;
    
    //카드 숫자 합
    public int sum_card = 0;
    
    //각 플레이어들이 낸 카드의 숫자
    //나중에 플렉스 검사하기 위해선 게임 메니저에 있는 게 좋을 듯
    public int[] selectedNum = new int[3];


    //카드턴 어차피 카드 순서는 상관없긴 함
    //한명이 카드를 선택하면 하나씩 올라감 3이 되면 모두 다 카드를 선택한 것임
    public int cardturn = 0;


    //플레이어 오브젝트를 담고있는 변수
    public GameObject first_Player;
    public GameObject second_Player;
    public GameObject third_Player;


    //플레이어가 몇번째 칸에 있는지
    public int player1;
    public int player2;
    public int player3;
    

    public GameObject tempPlayer;

    //턴 진행중인지 확인값
    bool turnPros;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<3;i++)
            selectedNum[i] = 0;

        gamemanager.instance.turn_count = 0;

        gamemanager.instance.player1 = 0;
        gamemanager.instance.player2 = 0;
        gamemanager.instance.player3 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
