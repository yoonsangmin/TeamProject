using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Player : MonoBehaviourPun
{
    //현제 플레이어가 가지는 값 초기화
    

    void Start()
    {
        //로컬 플레이어의 ActorNumber 가져오기 1번부터 시작해서 -1 해준것
        var A = PhotonNetwork.LocalPlayer.ActorNumber - 1;

        //플레이어 위치 초기화
        GameManager.Instance.player_pos[ A % GameManager.Instance.player_pos.Length ] = 0;
        
        //플레이어 점수 초기화
        GameManager.Instance.player_money[ A % GameManager.Instance.player_money.Length ] = 0;

        // 플레이어 상태 체크하는 플래그 초기화
        GameManager.Instance.is_prison[ A % GameManager.Instance.is_prison.Length ] = false;
        GameManager.Instance.is_travel[A % GameManager.Instance.is_travel.Length] = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //이동, 조작 아직 없음
}
