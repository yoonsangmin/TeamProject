using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class turnsystem : MonoBehaviour
{
    //private int turn_count;
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


    //각 보드칸이 가지고 있는 돈의 밸류를 배열로 만들어 놨음
    public int[] board_money;

    //선택한 칸이 몇번째 칸 인지
    int cann;

    //값을 변경하고 난 후 밟았는지 트리거 몇번 밟았는지 알려줘야 하기 때문에 int 썼음
    public int[] trigger_a;

    // Start is called before the first frame update
    void Start()
    {
        SetPlayerOrder();
        //랜덤으로 플레이어 순서를 결정하는 함수
        //나중에 카드를 선택해서 플레이어 순서를 결정하는 함수로 변경해야함
        //1, 2, 3을 랜덤으로 중복없이 생성하는 코드는 사용 가능할 거 같음
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //턴 종료 버튼
    //턴 종료 누르고 나면 비활성화
    public void ButtonClick()
    {
        PlayingTurn();

        GameObject.FindWithTag("turn end").GetComponent<Button>().interactable = false;
        GameObject.FindWithTag("c1").GetComponent<Button>().interactable = true;
        GameObject.FindWithTag("c2").GetComponent<Button>().interactable = true;
        GameObject.FindWithTag("c3").GetComponent<Button>().interactable = true;
        //버튼이 클릭이 됐을 때 턴 카운트를 1씩 올리면서 말을 이동할 플레이어를 변경함
        //나중엔 각 턴이 끝났을 때 호출하게 하면 좋을 것 같음
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
        switch (gamemanager.instance.turn_count % 3)
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
        //각 플레이어에 있는 스크립트 컴포넌트에 있는 정수값을 1씩 증가해 줌


        if (gamemanager.instance.tempPlayer == gamemanager.instance.first_Player)
        {
            //이동, 현재 자리도 카운트 해야 하기 때문에 - 1을 하고, 보드 위치이기 때문에 %8해줬음
            gamemanager.instance.player1 += gamemanager.instance.sum_card - 1;
            gamemanager.instance.player1 %= 8;

            if (trigger_a[gamemanager.instance.player1] != 0)         //자신이 밟은 칸의 밸류가 곱하기 되어있나 체크
            {
                for (int i = 0; i < trigger_a[gamemanager.instance.player1]; i++)
                {
                    //다시 초기화 해줌
                    board_money[gamemanager.instance.player1] /= 2;
                }
                //자신이 밟은 칸의 밸류가 곱셈이 안 돼있다고 해줌
                trigger_a[gamemanager.instance.player1] = 0;
            }
        }

        else if (gamemanager.instance.tempPlayer == gamemanager.instance.second_Player)
        {
            gamemanager.instance.player2 += gamemanager.instance.sum_card - 1;
            gamemanager.instance.player2 %= 8;

            if (trigger_a[gamemanager.instance.player2] != 0)         //자신이 밟은 칸의 밸류가 곱하기 되어있나 체크
            {
                for (int i = 0; i < trigger_a[gamemanager.instance.player2]; i++)
                {
                    //다시 초기화 해줌
                    board_money[gamemanager.instance.player2] /= 2;
                }
                //자신이 밟은 칸의 밸류가 곱셈이 안 돼있다고 해줌
                trigger_a[gamemanager.instance.player2] = 0;
            }
        }

        else if (gamemanager.instance.tempPlayer == gamemanager.instance.third_Player)
        {
            gamemanager.instance.player3 += gamemanager.instance.sum_card - 1;
            gamemanager.instance.player3 %= 8;

            if (trigger_a[gamemanager.instance.player3] != 0)         //자신이 밟은 칸의 밸류가 곱하기 되어있나 체크
            {
                for (int i = 0; i < trigger_a[gamemanager.instance.player3]; i++)
                {
                    //다시 초기화 해줌
                    board_money[gamemanager.instance.player3] /= 2;
                }
                //자신이 밟은 칸의 밸류가 곱셈이 안 돼있다고 해줌
                trigger_a[gamemanager.instance.player3] = 0;
            }
        }

        gamemanager.instance.sum_card = 0;

    //나중에 카드를 내는 함수, 말을 카드 수 만큼 이동하는 함수를 추가해서 여기에 넣어주면 될 것 같음
}

    void TurnProgress()
    {
        Debug.Log(gamemanager.instance.turn_count +1 + "턴 입니다.");

        if(gamemanager.instance.player1 == 0)
        {
            if (true)   //내가 원하는 보드의 칸을 선택했을 때
            {
                //트리거 값을 1올려 줬음 해당 칸을 몇 번 배수 해줬는지 알아야 하기 때문
                trigger_a[cann] += 1;
                //해당 칸의 값을 두 배 해줌
                board_money[cann] *= 2;
            }
        }


        //모든 플레이어가 같은 숫자가나왔을 때
        if (gamemanager.instance.selectedNum[0] == gamemanager.instance.selectedNum[1] && gamemanager.instance.selectedNum[1] == gamemanager.instance.selectedNum[2])
        {
            if (true)       //내가 원하는 보드의 칸을 선택했을 때
            {
                board_money[cann] *= -1;
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
