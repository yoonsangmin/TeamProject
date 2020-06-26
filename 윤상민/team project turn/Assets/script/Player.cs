using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    static public Player instance;


    //플레이어 구조체
    public struct Player_struct
    {
        //플레이어가 가야할 칸
        public int player_pos;

        //플레이어가 선택한 카드
        public int player_card;

        //플레이어가 카드를 선택 완료 했는지
        public bool cardselectdone;

        //플레이어의 점수
        public int player_money;

        //플레이어가 감옥칸 밟았는지 검사하는 플래그
        public bool is_onstart;

        //플레이어가 감옥칸 밟았는지 검사하는 플래그
        public bool is_prison;

        //플레이어가 우주 여행칸 밟았는지 검사하는 플래그
        public bool is_travel;

        //플레이어가 움직이고 있는지 검사하는 플래그
        public bool is_moving;

        //플레이어의 오브젝트
        public GameObject player_model;
    };

    //플레이어 오브젝트 설정할 수 있게 해주는 변수
    public GameObject[] playerprefab;
    public Player_struct[] player = new Player_struct[3];
    public GameObject[] cann;


    public int naaaaa;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    void Start()
    {


        //플레이어 생성 및 초기화
        for (int i = 0; i < 3; i++)
        {
            player[i].player_model = playerprefab[i];
            Instantiate(player[i].player_model, cann[i].transform.position, Quaternion.identity);

            //보드 위에서의 위치 0으로 초기화
            player[i].player_pos = 0;

            //각 플레이어의 점수 초기화 몇으로 해야하는지 처음 들고 시작하는 돈
            player[i].player_money = 10;

            player[i].player_card = 0;

            player[i].cardselectdone = false;

            player[i].is_onstart = false;

            player[i].is_moving = false;

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