using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class turnsystem : MonoBehaviour
{
    private int turn_count;
    //게임 시작하고 현재 몇 번째 턴인지

    //public GameObject first_Player;
    //public GameObject second_Player;
    //public GameObject third_Player;
    //플레이어 오브젝트를 담고있는 변수

    //private int player1;
    //private int player2;
    //private int player3;
    //플레이어가 몇번째 칸에 있는지

    private int temp;

    public int[] order = Enumerable.Range(0, 3).ToArray();      //0, 1, 2를 넣는 배열을 만듦, 순서를 정할 때 사용함
                                                                //public GameObject tempPlayer;


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

    //선택한 칸이 몇번째 칸 인지
    int cann;

    // Start is called before the first frame update
    void Start()
    {
        //랜덤으로 플레이어 순서를 결정하는 함수 아마 이제 필요없는 함수
        SetPlayerOrder();

        //나중에 카드를 선택해서 플레이어 순서를 결정하는 함수로 변경해야함
        //1, 2, 3을 랜덤으로 중복없이 생성하는 코드는 사용 가능할 거 같음



        //보드 초기화 함수
        Initialize_Board();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //보드 점수 초기화 함수
    void Initialize_Board()
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

    //i번째 플레이어가 어떤 칸에 있는지 체크 함수
    void Check_Cann(int i)
    {
        //플레이어가 밟은 칸의 머니를 플레이어 한테 추가함
        gamemanager.instance.player[i].player_money = gameboard[gamemanager.instance.player[i].player_pos].money;

        //감옥칸 밟았을 때
        if (gamemanager.instance.player[i].player_pos == 2)
            gamemanager.instance.player[i].is_prison = true;

        //기부칸 밟았을 때
        else if (gamemanager.instance.player[i].player_pos == 4)
        {
            //밟은 플레이어한테 2원을 뺐음
            gamemanager.instance.player[i].player_money -= 2;
            //다른 플레이어들한테 1원씩 뿌림
            gamemanager.instance.player[(i + 1) % 3].player_money++;
            //다른 플레이어들한테 1원씩 뿌림
            gamemanager.instance.player[(i + 2) % 3].player_money++;
        }

        //우주 여행칸 밟았을 때
        else if (gamemanager.instance.player[i].player_pos == 6)
            gamemanager.instance.player[i].is_travel = true;

        //시작칸 밟았을 때
        else if (gamemanager.instance.player[i].player_pos == 0)
        {
            if (true)   //내가 원하는 보드의 칸을 선택했을 때
            {
                //트리거 값을 1올려 줬음 해당 칸을 몇 번 배수 해줬는지 알아야 하기 때문
                gameboard[cann].trigger_a += 1;
                //해당 칸의 값을 두 배 해줌
                gameboard[cann].money *= 2;
            }
        }

    }
    //감옥 함수 i = 플레이어
    void Prison(int i)
    {
        //카드 내는작업 실행해야 함


        //감옥 작업 끝나면 트리거를 false로 바꿔줌
        gamemanager.instance.player[i].is_prison = false;
    }

    //우주 여행 함수 i = 플레이어
    void Travel(int i)
    {
        if (true)   //내가 원하는 보드의 칸을 선택했을 때
        {
            //플레이어가 해당 위치까지 이동
            gamemanager.instance.player[i].player_pos = cann;
        }
        //여행 작업 끝나면 트리거를 false로 바꿔줌
        gamemanager.instance.player[i].is_travel = false;
    }


    //턴 종료 버튼
    //턴 종료 누르고 나면 비활성화
    public void ButtonClick()
    {
        PlayingTurn();
        //버튼이 클릭이 됐을 때 턴 카운트를 1씩 올리면서 말을 이동할 플레이어를 변경함
        //나중엔 각 턴이 끝났을 때 호출하게 하면 좋을 것 같음
        GameObject.FindWithTag("turn end").GetComponent<UnityEngine.UI.Button>().interactable = false;
        GameObject.FindWithTag("c1").GetComponent<UnityEngine.UI.Button>().interactable = true;
        GameObject.FindWithTag("c2").GetComponent<UnityEngine.UI.Button>().interactable = true;
        GameObject.FindWithTag("c3").GetComponent<UnityEngine.UI.Button>().interactable = true;
        
    }

    void PlayingTurn()
    {
        FindPlayer();
        //이번 턴에 말을 이동할 플레이어를 변경해 줌
        TurnProgress();
        //턴 진행때 일어날 일을 넣어줄 함수
        gamemanager.instance.turn_count++;
        //한 턴이 지나면 턴 카운트를 1증가 시킴
    }

    void FindPlayer()
    {
        switch (gamemanager.instance.turn_count % 3)            //현재 플레이어 오브젝트 찾아서 저장하는 스위치문 필요 없을 거 같은데 초기에 짠 코드라 일단 놔뒀음
        {
            case 0:
                gamemanager.instance.tempPlayer = gamemanager.instance.first_Player;

                //gamemanager.instance.player1++;
                //gamemanager.instance.player1 %= 8;
                //temp = gamemanager.instance.player1;
                //gamemanager.instance.first_Player.GetComponent<playermove>().i = temp;
                break;
            case 1:
                gamemanager.instance.tempPlayer = gamemanager.instance.second_Player;

                //gamemanager.instance.player2++;
                //gamemanager.instance.player2 %= 8;
                //temp = gamemanager.instance.player2;
                //gamemanager.instance.second_Player.GetComponent<playermove>().i = temp;
                break;
            case 2:
                gamemanager.instance.tempPlayer = gamemanager.instance.third_Player;

                //gamemanager.instance.player3++;
                //gamemanager.instance.player3 %= 8;
                //temp = gamemanager.instance.player3;
                //gamemanager.instance.third_Player.GetComponent<playermove>().i = temp;
                break;
            default:
                temp = 0;
                Debug.Log("플레이어를 찾을 수 없습니다.");
                break;
                //오류 부분인데 필요할까 잘 모르겠음
        }


        //if (gamemanager.instance.tempPlayer == gamemanager.instance.first_Player)   //현재플레이어 체크하는 조건문인데 이건 내가 오브젝트로 해 놨는데 수정해야 할 거 같음
        if (gamemanager.instance.turn_count % 3 == 1)       //전체 턴에서 모듈러연산을 해서 1번 2번 3번 플레이어 체크함 - 수정하긴 했는데 이대로 해도 되는지 잘 모르겠음
        {
            //카드를 합해서 그만큼 1번 플레이어 이동
            Card_Sum_and_Move(0);
        }

        else if (gamemanager.instance.turn_count % 3 == 2)
        {
            //카드를 합해서 그만큼 2번 플레이어 이동
            Card_Sum_and_Move(1);
        }

        else if (gamemanager.instance.turn_count % 3 == 0)
        {
            //카드를 합해서 그만큼 3번 플레이어 이동
            Card_Sum_and_Move(2);
        }

        //카드합을 0으로 초기화
        gamemanager.instance.sum_card = 0;

    //나중에 카드를 내는 함수, 말을 카드 수 만큼 이동하는 함수를 추가해서 여기에 넣어주면 될 것 같음
}


    //카드를 합해서 플레이어 이동하는 함수
    void Card_Sum_and_Move(int n)
    {
        //이동, 현재 자리도 카운트 해야 하기 때문에 - 1을 하고, 보드 위치이기 때문에 %8해줬음
        gamemanager.instance.player[n].player_pos += gamemanager.instance.sum_card - 1;
        gamemanager.instance.player[n].player_pos %= 8;

        if (gameboard[gamemanager.instance.player[n].player_pos].trigger_a != 0)         //자신이 밟은 칸의 밸류가 곱하기 되어있나 체크
        {
            for (int i = 0; i < gameboard[gamemanager.instance.player[n].player_pos].trigger_a; i++)
            {
                //다시 초기화 해줌
                gameboard[gamemanager.instance.player[n].player_pos].money /= 2;
            }
            //자신이 밟은 칸의 밸류가 곱셈이 안 돼있다고 해줌
            gameboard[gamemanager.instance.player[n].player_pos].trigger_a = 0;
        }

        //당도한 칸에서 해야할 것이 있는지 체크
        Check_Cann(n);
    }



    void TurnProgress()
    {
        Debug.Log(gamemanager.instance.turn_count +1 + "턴 입니다.");

        //if(gamemanager.instance.player1 == 0)
        //{
        //    if (true)   //내가 원하는 보드의 칸을 선택했을 때
        //    {
        //        //트리거 값을 1올려 줬음 해당 칸을 몇 번 배수 해줬는지 알아야 하기 때문
        //        gameboard[cann].trigger_a += 1;
        //        //해당 칸의 값을 두 배 해줌
        //        gameboard[cann].money *= 2;
        //    }
        //}


        //모든 플레이어가 같은 숫자가나왔을 때
        if (gamemanager.instance.selectedNum[0] == gamemanager.instance.selectedNum[1] && gamemanager.instance.selectedNum[1] == gamemanager.instance.selectedNum[2])
        {
            if (true)       //내가 원하는 보드의 칸을 선택했을 때
            {
                gameboard[cann].money *= -1;
            }
            //턴을 줄여버림, 다시 이전 플레이어가 한 번 더 플레이 함
            gamemanager.instance.turn_count--;
        }

        //current_Player.transform.Translate(0.0f, 0.0f, temp);
        //Debug.Log("" + current_Player.name + current_Player.transform.position.z);

    }



    //플레이어 순서 랜덤으로 짜는 코드 어차피 나중에 카드 선택으로 바꿔야 함 ,, ㅜㅜ 이거 어케 구현하지
    void SetPlayerOrder()
    {
        for (int i = 0; i < 3; ++i)
        {
            int ranIdx = Random.Range(i, 3);
            //i부터 3사이에 서 랜덤으로 숫자를 하나 정함(인덱스 값임)
            int tmp = order[ranIdx];
            order[ranIdx] = order[i];
            order[i] = tmp;
            //랜덤으로 정한 인덱스와 i를 스왑함
        }
        //i를 증가시키면서 진행하면 0, 1, 2를 중복없이 생성해서 순서를 섞는게 가능함


        for (int i = 0; i < 3; i++)
        {
            switch (order[i])
            {
                case 0:
                    gamemanager.instance.tempPlayer = GameObject.FindWithTag("p1");      //플레이어1 임 (순서가 첫번째는 아님)
                    break;
                case 1:
                    gamemanager.instance.tempPlayer = GameObject.FindWithTag("p2");      //플레이어2
                    break;
                case 2:
                    gamemanager.instance.tempPlayer = GameObject.FindWithTag("p3");      //플레이어3
                    break;
            }
            //tempPlayer에 임시적으로 플레이어1, 2, 3을 넣음(배열의 값을 사용해서 랜덤으로 정해진 순서대로 들어감)

            switch (i)
            {
                case 0:
                    gamemanager.instance.first_Player = gamemanager.instance.tempPlayer;
                    break;
                case 1:
                    gamemanager.instance.second_Player = gamemanager.instance.tempPlayer;
                    break;
                case 2:
                    gamemanager.instance.third_Player = gamemanager.instance.tempPlayer;
                    break;
            }
            //tempPlayer에 있는 플레이어를 순서대로 첫번째, 두번째, 세번째 순서로 정해줌
        }
    }
}
