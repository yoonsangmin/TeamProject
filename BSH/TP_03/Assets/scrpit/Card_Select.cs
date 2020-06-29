using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class Card_Select : MonoBehaviourPunCallbacks
{
    public static Card_Select instance;

    public int[] select_num; // 0이 아니면 앞으로 간다


    public bool[] Card_Do;  //카드 도착 여부
    public bool[] Card_EX;  //카드 끝났을때

    private void Awake()
    {
        instance = this;
    }


    public void Click_1()
    {
        if (PhotonNetwork.PlayerList.Length < 3)
        {
            return;
        }


        if (PhotonNetwork.LocalPlayer.ActorNumber == 1 && select_num[0] == 0)
        {
            photonView.RPC("b", RpcTarget.All, 0, 1);
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 2 && select_num[1] == 0)
        {
            photonView.RPC("b", RpcTarget.All, 1, 1);
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 3 && select_num[2] == 0)
        {
            photonView.RPC("b", RpcTarget.All, 2, 1);
        }

        Card_Spawn.instance.CardSelectButton.SetActive(false);
    }
    public void Click_2()
    {

        if (PhotonNetwork.PlayerList.Length < 3)
        {
            return;
        }
        if (PhotonNetwork.LocalPlayer.ActorNumber == 1 && select_num[0] == 0)
        {
            photonView.RPC("b", RpcTarget.All, 0, 2);
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 2 && select_num[1] == 0)
        {
            photonView.RPC("b", RpcTarget.All, 1, 2);
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 3 && select_num[2] == 0)
        {
            photonView.RPC("b", RpcTarget.All, 2, 2);
        }

        Card_Spawn.instance.CardSelectButton.SetActive(false);
    }
    public void Click_3()
    {
        if (PhotonNetwork.PlayerList.Length < 3)
        {
            return;
        }

        if (PhotonNetwork.LocalPlayer.ActorNumber == 1 && select_num[0] == 0)
        {
            photonView.RPC("b", RpcTarget.All, 0, 3);
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 2 && select_num[1] == 0)
        {
            photonView.RPC("b", RpcTarget.All, 1, 3);
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 3 && select_num[2] == 0)
        {
            photonView.RPC("b", RpcTarget.All, 2, 3);
        }

        Card_Spawn.instance.CardSelectButton.SetActive(false);
    }


    [PunRPC]
    public void b(int num1, int num2)
    {
        select_num[num1] = num2;
    }
}
