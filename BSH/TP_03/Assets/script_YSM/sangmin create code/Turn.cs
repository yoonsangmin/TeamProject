using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    //게임 시작하고 현재 몇 번째 턴인지
    public static Turn instance;
    
    public int turn_number;     //몇번쨰 턴

    public int card_sum;        //플레이어들이 선택한 카드들의 합

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
