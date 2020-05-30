using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cardsystem : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gamemanager.instance.cardturn == 3)
        {
            Move_player();
        }
        //일단 한 컴퓨터에서 3번 하게 만들었는 데 조건을 다른 사람이 모두 카드를 냈을 때, 시간이 지났을 때(시간 넘어가면 랜덤으로 내게? 만드는 코드도 짜야할 것 같음)
        //턴 넘기는 버튼 활성 비활성 하는 코드도 만들어야 함
    }

    //터치 했을 때 실행하게 변경해야 함
    public void Select_1()
    {
        gamemanager.instance.cardturn++;

        if(gamemanager.instance.cardturn == 1)
        {
            gamemanager.instance.p1_selectedNum = 1;
        }
        else if (gamemanager.instance.cardturn == 2)
        {
            gamemanager.instance.p2_selectedNum = 1;
        }
        else if (gamemanager.instance.cardturn == 3)
        {
            gamemanager.instance.p3_selectedNum = 1;
        }
    }

    public void Select_2()
    {
        gamemanager.instance.cardturn++;

        if (gamemanager.instance.cardturn == 1)
        {
            gamemanager.instance.p1_selectedNum = 2;
        }
        else if (gamemanager.instance.cardturn == 2)
        {
            gamemanager.instance.p2_selectedNum = 2;
        }
        else if (gamemanager.instance.cardturn == 3)
        {
            gamemanager.instance.p3_selectedNum = 2;
        }
    }

    public void Select_3()
    {
        gamemanager.instance.cardturn++;

        if (gamemanager.instance.cardturn == 1)
        {
            gamemanager.instance.p1_selectedNum = 3;
        }
        else if (gamemanager.instance.cardturn == 2)
        {
            gamemanager.instance.p2_selectedNum = 3;
        }
        else if (gamemanager.instance.cardturn == 3)
        {
            gamemanager.instance.p3_selectedNum = 3;
        }
    }

    //이름 잘 못 지음 무브는 아니고 모두가 카드 다 냈을 때 나오는 코드
    //지금은 턴 엔드를 코드로 짜서 ㅜㅜ
    void Move_player()
    {
        gamemanager.instance.cardturn = 0;

        gamemanager.instance.sum_card = gamemanager.instance.p1_selectedNum + gamemanager.instance.p2_selectedNum + gamemanager.instance.p3_selectedNum;
        //세 플레이어 모든 카드의 숫자 합


        gamemanager.instance.p1_selectedNum = 0;
        gamemanager.instance.p2_selectedNum = 0;
        gamemanager.instance.p3_selectedNum = 0;

        GameObject.FindWithTag("turn end").GetComponent<Button>().interactable = true;
        GameObject.FindWithTag("c1").GetComponent<Button>().interactable = false;
        GameObject.FindWithTag("c2").GetComponent<Button>().interactable = false;
        GameObject.FindWithTag("c3").GetComponent<Button>().interactable = false;
        //턴 종료 버튼 활성화
        //    if (gamemanager.instance.tempPlayer == gamemanager.instance.first_Player)
        //    {
        //        gamemanager.instance.player1 += gamemanager.instance.sum_card;
        //        gamemanager.instance.player1 %= 8;
        //    }

        //    else if (gamemanager.instance.tempPlayer == gamemanager.instance.first_Player)
        //    {
        //        gamemanager.instance.player2 += gamemanager.instance.sum_card;
        //        gamemanager.instance.player1 %= 8;
        //    }

        //    else if (gamemanager.instance.tempPlayer == gamemanager.instance.first_Player)
        //    {
        //        gamemanager.instance.player3 += gamemanager.instance.sum_card;
        //        gamemanager.instance.player1 %= 8;
        //    }

        //    gamemanager.instance.sum_card = 0;
    }

}
