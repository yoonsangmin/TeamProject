using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    //제한 시간이 얼마인지
    public float count_time;

    //제한시간이 끝났는지 확인하는 변수
    bool time_over = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //if (time_over == false && !Player.instance.player[Turn.instance.turn_number % 3].cardselectdone)   //시간이 아직 다 안지났다면, 카드가 다 선택이 안됬을때 // 모든플레이어 다 체크해야함
        //{
        //    count_time -= Time.deltaTime;    //시간을 줄임

        //}

        //else if (time_over == true && Player.instance.player[Turn.instance.turn_number % 3].cardselectdone == false)
        //{
        //    Player.instance.player[Turn.instance.turn_number % 3].player_card = Random.Range(1, 4);

        //    Turn.instance.card_sum += Player.instance.player[Turn.instance.turn_number % 3].player_card;            //내가 선택한 카드가 전체에 더해짐

        //    Player.instance.player[Turn.instance.turn_number % 3].player_pos += Turn.instance.card_sum * 3;     //현재 턴인 플레이어의 값이 변경됨

        //    Player.instance.player[Turn.instance.turn_number % 3].player_pos %= 24;             //현재 턴인 플레이어의 값을 24로 모듈러 연산

        //    Player.instance.player[Turn.instance.turn_number % 3].cardselectdone = true;
        //    Player.instance.player[Turn.instance.turn_number % 3].is_moving = true;
        //    count_time = 60.0f;


        //    time_over = false;

        //}

        //if (time_over == false && count_time <= 0)
        //{
        //    Debug.Log("123");
        //    count_time = 0;
        //    time_over = true;                   //시간이 다 지났다고 알려줌
        //}
        //else if (time_over == false && Player.instance.player[Turn.instance.turn_number % 3].cardselectdone && Player.instance.player[Turn.instance.turn_number % 3].is_moving == false)    //카드가 다 선택했을때, 시간이 아직 다 안지났음
        //{
        //    Debug.Log("121233");
        //    count_time = 60.0f;          //다시 시간 늘려주기
        //}


    }
}
