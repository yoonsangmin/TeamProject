using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select_Code : MonoBehaviour
{
    bool is_selecting;
    bool is_picked;
    // Start is called before the first frame update
    void Start()
    {
        is_selecting = false;
        is_picked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.instance.player[Turn.instance.turn_number % 3].is_onstart)        //자기턴에 시작칸 밟고 끝났으면 다시 자기턴을 시작해서 여기로 빠지게 만듦
        {
            is_selecting = true;
        }
        else if (Player.instance.player[Turn.instance.turn_number % 3].is_travel)   //이전 턴에 여행칸을 밟았을 경우
        {
            is_selecting = true;
        }
        else                                                                        //여기서 아무것도 아니면 카드 고르는 시스템으로 넘어감
        {
            if(Player.instance.player[Turn.instance.turn_number % 3].is_prison)//이전턴에 감옥칸을 밟았을때
            {
                //여기에 카드 카드 고르는 것 넣어서 카드 고른거 비교할꺼임
                if (Player.instance.player[0].player_card == Player.instance.player[1].player_card && Player.instance.player[1].player_card == Player.instance.player[2].player_card)  //플레이어 세명이 같은 카드 냈을 때
                    Player.instance.player[Turn.instance.turn_number % 3].is_prison = false;        //프리즌을 펄스로 만들고 턴을 그대로 -> 한턴 더 시작함 == 탈출한거임
                else                                                                                                               //플레이어 세명이 같은카드가 안 나왔을 때
                {
                    Player.instance.player[Turn.instance.turn_number % 3].is_prison = false;        //다음 턴에 탈출하게 됨
                    Turn.instance.turn_number++;                                                    //턴을 올리면 한턴 넘어감
                }
            }

            else                                                    //나머지 칸들일 때는 카드고르는 버튼 띄워서 카드고르게 하면 될 거 같음
            {
                //카드 고르는 코드 넣기
                //이동하는 코드 넣기
            }
        }

        if(is_selecting && !is_picked)     //선택은 해야되는데 마우스 피킹 아직 안한경우
        {
            //상욱이형이 만든 마우스 피킹 코드 넣기
            if (Player.instance.player[Turn.instance.turn_number % 3].is_onstart)
            {
                //if(피킹한게 1, 3, 5, 7 일떄)                                      //1, 3, 5, 7번 칸만 피킹하게 만들기
                //{
                //    is_picked = true;       //피킹 완료했다고 알려줌 아닌경우 계속 피킹할 수 있음
                //}
            }

            //else if ()          //피킹한 값이 null 아닌경우
            //{
            //    is_picked = true;
            //}

        }


        //if (is_selecting && Player.instance.player[Turn.instance.turn_number % 3].is_onstart && is_picked)       //시작칸 밟았을때 점수 두배로 하는 코드
        //{
            
        //    Board.instance.gameboard[1].money *= 2;         //돈 두배로 해주는 코드 1번자리에 피킹한 위치의 인덱스
        //    Board.instance.gameboard[1].trigger_a++;        //몇번 곱해줬는지 확인하는 코드


        //    Player.instance.player[Turn.instance.turn_number % 3].is_onstart = false;       //올리고나면 false로 바꿈
        //    is_selecting = false;      //셀렉팅 작업 초기화
        //    is_picked = false;      //피킹 초기화
        //    //픽 값을 null로 변경해버림

        //    if (Player.instance.player[0].player_card == Player.instance.player[1].player_card && Player.instance.player[1].player_card == Player.instance.player[2].player_card) //세명이 다 같은 칸을 냈을 떄
        //        ;
        //    else
        //        Turn.instance.turn_number++;                                                    //끝나고 나면 턴 넘김
        //}

        //시작칸 밟았을때 작업은 한번더 하기 전에 실행해야 한다 ㅜㅜ

        if (is_selecting && Player.instance.player[Turn.instance.turn_number % 3].is_travel && is_picked)       //여행칸 밟았을 때
        {
            Player.instance.player[Turn.instance.turn_number % 3].player_pos += 0; //0자리에 피킹한 변수 넣어줘야 함
            Player.instance.player[Turn.instance.turn_number % 3].player_pos %= 24; //24로 모듈러연산 해야함

            Player.instance.player[Turn.instance.turn_number % 3].is_travel = false;       //올리고나면 false로 바꿈
            is_selecting = false;      //셀렉팅 작업 초기화
            is_picked = false;      //피킹 초기화
            //픽 값을 null로 변경해버림
            //이동코드로 가서 이동해야함
            //이동 후 이동끝나면 턴 넘기기 때문에 턴 안늘려줘도됨
        }




        if (Player.instance.player[0].player_card == Player.instance.player[1].player_card && Player.instance.player[1].player_card == Player.instance.player[2].player_card) //세명다 같은 카드를 냈을 때 점수 플러스 마이너스 바꾸는 코드
        {
            //마우스 코드 피킹 넣음
            Board.instance.gameboard[1].money = -Board.instance.gameboard[1].money;     //바꿔줌
            is_picked = false;
        }
    }
}
