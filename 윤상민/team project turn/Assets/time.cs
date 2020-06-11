using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class time : MonoBehaviour
{
    //제한 시간이 얼마인지
    float count_time = 60.0f;


    //카드 선택이 다 되면
    int card_C = 0;


    //제한시간이 끝났는지 확인하는 변수
    bool time_over = false;


    //내가 카드를 선택 했는지 아닌지 확인하는 변수
    bool t = false;


    //카드 합
    int num_C;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (time_over == false && card_C != 3)   //시간이 아직 다 안지났다면, 카드가 다 선택이 안됬을때
        {
            count_time -= Time.deltaTime;    //시간을 줄임
           
        }
        else if (time_over == false && count_time <= 0)
        {
            time_over = true;                   //시간이 다 지났다고 알려줌
        }
        else if (time_over == false && card_C == 3)    //카드가 다 선택했을때, 시간이 아직 다 안지났음
        {
            //count_time = 0;              //시간 다 지났다고 알려줌
            time_over = true;            //체크
            count_time = 60.0f;          //다시 시간 늘려주기
            card_C = 0;
        }




      

    }

    //내가 카드 선택했는지 넘겨주기
    void  aaaa()
    {
        if (true)     //내가 카드를 선택 했다면
        {
            card_C++;
        }
    }

    //시간이 다 지나도 카드를 선택 안했을때
    void bbbbb()
    {
        if (time_over == true && t == false)   //시간이 다 지났고 내가 카드를 선택 하지 않았을때
        {
            num_C = Random.Range(1, 3);        //랜덤
            t = true;
        }
    }


    //시작 순서 카드 선택
    void cccc()
    {
        if (time_over == true || card_C == 2)     //시간이 다 지나거나 두명 이상이 선택 했을때
        {
            card_C = 0;        //초기화
            time_over = false; //초기화

            //시작
        }





    }

    public int[] order = Enumerable.Range(0, 3).ToArray();      //0, 1, 2를 넣는 배열을 만듦, 순서를 정할 때 사용함


    //랜덤으로 카드에 숫자 지정
    void dddd()
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
    }



}
