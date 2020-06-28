using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Player_Move : MonoBehaviourPunCallbacks
{
    // Update is called once per frame
    void Update()
    {
        if (PhotonNetwork.PlayerList.Length < 3)
        {
            return;
        }


        if (Player_Spawn.instance.Player_MovingDo)
        {
            if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
            {
                if (gameObject == Player_Spawn.instance.Player_Obj[0] && Board_Spawn.instance.Turn % 3 == 0)
                {
                    //0번플레이어 이동
                    transform.position = Vector3.MoveTowards(transform.position, Player_Spawn.instance.PLayer_Cann[Player_Spawn.instance.Player_Previous_Position[0]].transform.position, 0.1f);
                    if(transform.position == Player_Spawn.instance.PLayer_Cann[Player_Spawn.instance.Player_Previous_Position[0]].transform.position)       //이동 중일 떄
                    {
                        photonView.RPC("P_Prev", RpcTarget.All, 0);     //현재위치 업데이트
                    }
                    if(transform.position == Player_Spawn.instance.PLayer_Cann[Player_Spawn.instance.Player_Position[0] * 3].transform.position)        //이동 끝났을때
                    {
                        photonView.RPC("P_Moving_F", RpcTarget.All);    //무빙 거짓으로 바꾸기
                        photonView.RPC("P_money_plus", RpcTarget.All, 0, Board_Spawn.instance.BoardMoney[Player_Spawn.instance.Player_Position[0]]);
                        photonView.RPC("T_UP", RpcTarget.All);          //턴 올리기
                    }
                }
               
            }
            else if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
            {
                if (gameObject == Player_Spawn.instance.Player_Obj[1] && Board_Spawn.instance.Turn % 3 == 1)
                {
                    //0번플레이어 이동
                    transform.position = Vector3.MoveTowards(transform.position, Player_Spawn.instance.PLayer_Cann[Player_Spawn.instance.Player_Previous_Position[1]].transform.position, 0.1f);
                    if (transform.position == Player_Spawn.instance.PLayer_Cann[Player_Spawn.instance.Player_Previous_Position[1]].transform.position)       //이동 중일 떄
                    {
                        photonView.RPC("P_Prev", RpcTarget.All, 1);     //현재위치 업데이트
                    }
                    if (transform.position == Player_Spawn.instance.PLayer_Cann[Player_Spawn.instance.Player_Position[1] * 3 + 1].transform.position)        //이동 끝났을때
                    {
                        photonView.RPC("P_Moving_F", RpcTarget.All);    //무빙 거짓으로 바꾸기
                        photonView.RPC("P_money_plus", RpcTarget.All, 1, Board_Spawn.instance.BoardMoney[Player_Spawn.instance.Player_Position[1]]);
                        photonView.RPC("T_UP", RpcTarget.All);          //턴 올리기
                    }
                }
            }
            else if (PhotonNetwork.LocalPlayer.ActorNumber == 3)
            {
                if (gameObject == Player_Spawn.instance.Player_Obj[2] && Board_Spawn.instance.Turn % 3 == 2)
                {
                    //0번플레이어 이동
                    transform.position = Vector3.MoveTowards(transform.position, Player_Spawn.instance.PLayer_Cann[Player_Spawn.instance.Player_Previous_Position[2]].transform.position, 0.1f);
                    if (transform.position == Player_Spawn.instance.PLayer_Cann[Player_Spawn.instance.Player_Previous_Position[2]].transform.position)       //이동 중일 떄
                    {
                        photonView.RPC("P_Prev", RpcTarget.All, 2);     //현재위치 업데이트
                    }
                    if (transform.position == Player_Spawn.instance.PLayer_Cann[Player_Spawn.instance.Player_Position[2] * 3 + 2].transform.position)        //이동 끝났을때
                    {
                        photonView.RPC("P_Moving_F", RpcTarget.All);    //무빙 거짓으로 바꾸기
                        photonView.RPC("P_money_plus", RpcTarget.All, 2, Board_Spawn.instance.BoardMoney[Player_Spawn.instance.Player_Position[2]]);
                        photonView.RPC("T_UP", RpcTarget.All);          //턴 올리기
                    }
                }
            }
        }
       
           
    }

    [PunRPC]
    public void P_Prev(int num1)
    {
        Player_Spawn.instance.Player_Previous_Position[num1] += 3;
        Player_Spawn.instance.Player_Previous_Position[num1] %= 24;
    }

    [PunRPC]
    public void P_Moving_F()
    {
        Player_Spawn.instance.Player_MovingDo = false;
    }

    [PunRPC]
    public void T_UP()
    {
        Board_Spawn.instance.Turn++;
    }

    [PunRPC]
    public void P_money_plus(int num1, int num2)
    {
        Player_Spawn.instance.Player_Money[num1] += num2;
    }
}
