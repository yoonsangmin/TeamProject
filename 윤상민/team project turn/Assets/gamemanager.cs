using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public static gamemanager instance;


    public int turn_count;
    //게임 시작하고 현재 몇 번째 턴인지

    public int sum_card = 0;
    //카드 숫자 합

    public int p1_selectedNum = 0;
    public int p2_selectedNum = 0;
    public int p3_selectedNum = 0;
    //각 플레이어들이 낸 카드의 숫자
    //나중에 플렉스 검사하기 위해선 게임 메니저에 있는 게 좋을 듯

    public int cardturn = 0;
    //카드턴 어차피 카드 순서는 상관없긴 함

    public GameObject first_Player;
    public GameObject second_Player;
    public GameObject third_Player;
    //플레이어 오브젝트를 담고있는 변수

    public int player1;
    public int player2;
    public int player3;
    //플레이어가 몇번째 칸에 있는지

    public GameObject tempPlayer;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
