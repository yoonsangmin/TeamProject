using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Linq;

public class turnsystem : MonoBehaviour
{
    private int turn_count;
    //게임 시작하고 현재 몇 번째 턴인지

    public GameObject first_Player;
    public GameObject second_Player;
    public GameObject third_Player;
    //플레이어 오브젝트를 담고있는 변수

    private int player1;
    private int player2;
    private int player3;
    //플레이어가 몇번째 칸에 있는지

    private int temp;

    public int[] order = Enumerable.Range(0, 3).ToArray();      //0, 1, 2를 넣는 배열을 만듦, 순서를 정할 때 사용함
    public GameObject tempPlayer;

    // Start is called before the first frame update
    void Start()
    {
        SetPlayerOrder();
        //랜덤으로 플레이어 순서를 결정하는 함수
        //나중에 카드를 선택해서 플레이어 순서를 결정하는 함수로 변경해야함
        //1, 2, 3을 랜덤으로 중복없이 생성하는 코드는 사용 가능할 거 같음
        turn_count = 0;

        player1 = 0;
        player2 = 0;
        player3 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick()
    {
        PlayingTurn();

        //버튼이 클릭이 됐을 때 턴 카운트를 1씩 올리면서 말을 이동할 플레이어를 변경함
        //나중엔 각 턴이 끝났을 때 호출하게 하면 좋을 것 같음
    }

    void PlayingTurn()
    {
        FindPlayer();
        //이번 턴에 말을 이동할 플레이어를 변경해 줌
        TurnProgress();
        //턴 진행때 일어날 일을 넣어줄 함수
        turn_count++;
        //한 턴이 지나면 턴 카운트를 1증가 시킴
    }

    void FindPlayer()
    {
        switch (turn_count % 3)
        {
            case 0:
                player1++;
                player1 %= 8;
                temp = player1;
                first_Player.GetComponent<playermove>().i = temp;
                break;
            case 1:
                player2++;
                player2 %= 8;
                temp = player2;
                second_Player.GetComponent<playermove>().i = temp;
                break;
            case 2:
                player3++;
                player3 %= 8;
                temp = player3;
                third_Player.GetComponent<playermove>().i = temp;
                break;
            default:
                temp = 0;
                Debug.Log("플레이어를 찾을 수 없습니다.");
                break;
                //오류 부분인데 필요할까 잘 모르겠음
        }
        //각 플레이어에 있는 스크립트 컴포넌트에 있는 정수값을 1씩 증가해 줌
        //나중에 카드를 내는 함수, 말을 카드 수 만큼 이동하는 함수를 추가해서 여기에 넣어주면 될 것 같음
    }

    void TurnProgress()
    {
        Debug.Log(turn_count+1 + "턴 입니다.");
        //current_Player.transform.Translate(0.0f, 0.0f, temp);
        //Debug.Log("" + current_Player.name + current_Player.transform.position.z);

    }

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
                    tempPlayer = GameObject.FindWithTag("p1");      //플레이어1 임 (순서가 첫번째는 아님)
                    break;
                case 1:
                    tempPlayer = GameObject.FindWithTag("p2");      //플레이어2
                    break;
                case 2:
                    tempPlayer = GameObject.FindWithTag("p3");      //플레이어3
                    break;
            }
            //tempPlayer에 임시적으로 플레이어1, 2, 3을 넣음(배열의 값을 사용해서 랜덤으로 정해진 순서대로 들어감)

            switch (i)
            {
                case 0:
                    first_Player = tempPlayer;
                    break;
                case 1:
                    second_Player = tempPlayer;
                    break;
                case 2:
                    third_Player = tempPlayer;
                    break;
            }
            //tempPlayer에 있는 플레이어를 순서대로 첫번째, 두번째, 세번째 순서로 정해줌
        }
    }
}
