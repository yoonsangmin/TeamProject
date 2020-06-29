using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Win_Check_Script : MonoBehaviourPunCallbacks
{
    public GameObject winpanel;
    public GameObject losepanel;
    
    int win_money = 30;
    
    // Update is called once per frame
    void Update()
    {
        if (PhotonNetwork.PlayerList.Length < 3)
        {
            return;
        }


        if (PhotonNetwork.LocalPlayer.ActorNumber == 1)     //1번 플레이어일 때
        {
            if (Player_Spawn.instance.Player_Money[0] >= win_money)     //자기가 돈이 더 많으면 이김
            {
                winpanel.SetActive(true);
            }

            if (Player_Spawn.instance.Player_Money[1] >= win_money)     //다른사람이 돈이 더 많으면 짐
            {
                losepanel.SetActive(true);
            }

            if (Player_Spawn.instance.Player_Money[2] >= win_money)     //다른사람이 돈이 더 많으면 짐
            {
                losepanel.SetActive(true);
            }
        }

        else if (PhotonNetwork.LocalPlayer.ActorNumber == 2)     //2번 플레이어일 때
        {
            if (Player_Spawn.instance.Player_Money[1] >= win_money)     //자기가 돈이 더 많으면 이김
            {
                winpanel.SetActive(true);
            }

            if (Player_Spawn.instance.Player_Money[0] >= win_money)     //다른사람이 돈이 더 많으면 짐
            {
                losepanel.SetActive(true);
            }

            if (Player_Spawn.instance.Player_Money[2] >= win_money)     //다른사람이 돈이 더 많으면 짐
            {
                losepanel.SetActive(true);
            }
        }

        else if (PhotonNetwork.LocalPlayer.ActorNumber == 3)     //3번 플레이어일 때
        {
            if (Player_Spawn.instance.Player_Money[2] >= win_money)     //자기가 돈이 더 많으면 이김
            {
                winpanel.SetActive(true);
            }

            if (Player_Spawn.instance.Player_Money[1] >= win_money)     //다른사람이 돈이 더 많으면 짐
            {
                losepanel.SetActive(true);
            }

            if (Player_Spawn.instance.Player_Money[0] >= win_money)     //다른사람이 돈이 더 많으면 짐
            {
                losepanel.SetActive(true);
            }
        }

    }
}
