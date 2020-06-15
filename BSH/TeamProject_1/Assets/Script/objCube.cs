using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class objCube : MonoBehaviourPun
{
    //방장인 즉 마스터 클라이언트에서만 이동시키게 만들것이라서 방장인지 아닌지 확인할 불 값을 하나 준다.
    public bool IsMasterClientLocal => PhotonNetwork.IsMasterClient && photonView.IsMine;

    //물체가 가지는 값들 넣을곳
    //------------------------------

    //------------------------------

    
    private void FixedUpdate()
    {
        //방장이아니라면 바로 리턴, 플레이어가 다 차지 않았으면 바로 리턴
        if (!IsMasterClientLocal || PhotonNetwork.PlayerList.Length < 3)
        {
            return;
        }

        

        //여기에 오브젝트 이동관련 넣기
        //---------------------------------

        //---------------------------------


        //로컬(내꺼)에서 생성한 오브젝트가 아니면
        if (!photonView.IsMine)
        {
            return;
        }

        //오브젝트 이동 관련 넣기
        //---------------------------------

        //---------------------------------
    }
}
