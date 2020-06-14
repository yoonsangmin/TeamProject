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

    //각 플레이어들이 낸 카드의 숫자, 나중에 플렉스 검사하기 위해선 게임 메니저에 있는 게 좋을 듯 플레이어 구조체에 합쳐도 되려나? 이거는 변수를 배열로 안하고 각자 해야되는지 모르겠엉
    public int[] selectedNum = new int[3];


    //카드턴 어차피 카드 순서는 상관없긴 함
    //한명이 카드를 선택하면 하나씩 올라감 3이 되면 모두 다 카드를 선택한 것임
    public int cardturn = 0;


    //플레이어 오브젝트를 담고있는 변수
    public GameObject first_Player;
    public GameObject second_Player;
    public GameObject third_Player;


    //플레이어 구조체
    public struct Player
    {
        //플레이어가 어떤 칸에 있는지
        public int player_pos;

        //플레이어의 점수
        public int player_money;

        //플레이어가 감옥칸 밟았는지 검사하는 플래그
        public bool is_prison;

        //플레이어가 우주 여행칸 밟았는지 검사하는 플래그
        public bool is_travel;
    };

    //플레이어 3명 배열로 선언
    public Player[] player = new Player[3];

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

        gamemanager.instance.turn_count = 0;

        gamemanager.instance.player1 = 0;
        gamemanager.instance.player2 = 0;
        gamemanager.instance.player3 = 0;

        //플레이어 초기화 함수
        Initialize_Player();
    }

    //플레이어 초기화 함수
    void Initialize_Player()
    {
        for (int i = 0; i < 3; i++)
        {
            //보드 위에서의 위치 0으로 초기화
            player[i].player_pos = 0;

            //각 플레이어의 점수 초기화 몇으로 해야하는지 처음 들고 시작하는 돈
            player[i].player_money = 0;

            //감옥칸이 아님
            player[i].is_prison = false;
            //여행칸이 아님
            player[i].is_travel = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
