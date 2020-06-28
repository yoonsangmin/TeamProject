﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Scooooore : MonoBehaviourPunCallbacks
{
    public Text scoreText1;
    public Text scoreText2;
    public Text scoreText3;

    public Text ranking1;
    public Text ranking2;
    public Text ranking3;

    public Text NickNameText1;
    public Text NickNameText2;
    public Text NickNameText3;



    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (PhotonNetwork.PlayerList.Length < 2)
        {
            return;
        }

        if(Player_Spawn.instance.Player_Money[0] > Player_Spawn.instance.Player_Money[1] && Player_Spawn.instance.Player_Money[0] > Player_Spawn.instance.Player_Money[2])
        {
            ranking1.text = "1위";
            if(Player_Spawn.instance.Player_Money[1] > Player_Spawn.instance.Player_Money[2])
            {
                ranking2.text = "2위";
                ranking3.text = "3위";
            }
            else if(Player_Spawn.instance.Player_Money[1] < Player_Spawn.instance.Player_Money[2])
            {
                ranking2.text = "3위";
                ranking3.text = "2위";
            }
            else if (Player_Spawn.instance.Player_Money[1] == Player_Spawn.instance.Player_Money[2])
            {
                ranking2.text = "2위";
                ranking3.text = "2위";
            }
        }

        else if (Player_Spawn.instance.Player_Money[1] > Player_Spawn.instance.Player_Money[0] && Player_Spawn.instance.Player_Money[1] > Player_Spawn.instance.Player_Money[2])
        {
            ranking2.text = "1위";
            if (Player_Spawn.instance.Player_Money[0] > Player_Spawn.instance.Player_Money[2])
            {
                ranking1.text = "2위";
                ranking3.text = "3위";
            }
            else if (Player_Spawn.instance.Player_Money[0] < Player_Spawn.instance.Player_Money[2])
            {
                ranking1.text = "3위";
                ranking3.text = "2위";
            }
            else if (Player_Spawn.instance.Player_Money[0] == Player_Spawn.instance.Player_Money[2])
            {
                ranking1.text = "2위";
                ranking3.text = "2위";
            }
        }

        else if (Player_Spawn.instance.Player_Money[2] > Player_Spawn.instance.Player_Money[0] && Player_Spawn.instance.Player_Money[2] > Player_Spawn.instance.Player_Money[1])
        {
            ranking3.text = "1위";
            if (Player_Spawn.instance.Player_Money[0] > Player_Spawn.instance.Player_Money[1])
            {
                ranking1.text = "2위";
                ranking2.text = "3위";
            }
            else if (Player_Spawn.instance.Player_Money[0] < Player_Spawn.instance.Player_Money[1])
            {
                ranking1.text = "3위";
                ranking2.text = "2위";
            }
            else if (Player_Spawn.instance.Player_Money[0] == Player_Spawn.instance.Player_Money[1])
            {
                ranking1.text = "2위";
                ranking2.text = "2위";
            }
        }

        else if(Player_Spawn.instance.Player_Money[0] == Player_Spawn.instance.Player_Money[1] && Player_Spawn.instance.Player_Money[0] > Player_Spawn.instance.Player_Money[2])
        {
            ranking1.text = "1위";
            ranking2.text = "1위";
            ranking3.text = "2위";
        }

        else if (Player_Spawn.instance.Player_Money[0] == Player_Spawn.instance.Player_Money[2] && Player_Spawn.instance.Player_Money[0] > Player_Spawn.instance.Player_Money[1])
        {
            ranking1.text = "1위";
            ranking2.text = "2위";
            ranking3.text = "1위";
        }

        else if (Player_Spawn.instance.Player_Money[1] == Player_Spawn.instance.Player_Money[2] && Player_Spawn.instance.Player_Money[1] > Player_Spawn.instance.Player_Money[0])
        {
            ranking1.text = "2위";
            ranking2.text = "1위";
            ranking3.text = "1위";
        }

        else if(Player_Spawn.instance.Player_Money[0] == Player_Spawn.instance.Player_Money[1] && Player_Spawn.instance.Player_Money[1] == Player_Spawn.instance.Player_Money[2])
        {
            ranking1.text = "1위";
            ranking2.text = "1위";
            ranking3.text = "1위";
        }

        if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            scoreText1.text = Player_Spawn.instance.Player_Money[0].ToString() + " 원";
            scoreText2.text = Player_Spawn.instance.Player_Money[1].ToString() + " 원";
            scoreText3.text = Player_Spawn.instance.Player_Money[2].ToString() + " 원";


            //Debug.Log(Player.instance.player[0].player_money);
            //Debug.Log(Player.instance.player[1].player_money);

            NickNameText1.text = PhotonNetwork.PlayerList[0].NickName;
            NickNameText2.text = PhotonNetwork.PlayerList[1].NickName;
            //NickNameText3.text = PhotonNetwork.PlayerList[2].NickName;
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            scoreText1.text = Player_Spawn.instance.Player_Money[0].ToString() + " 원";
            scoreText2.text = Player_Spawn.instance.Player_Money[1].ToString() + " 원";
            scoreText3.text = Player_Spawn.instance.Player_Money[2].ToString() + " 원";
            // Debug.Log(Player.instance.player[0].player_money);
            //Debug.Log(Player.instance.player[1].player_money);

            NickNameText1.text = PhotonNetwork.PlayerList[0].NickName;
            NickNameText2.text = PhotonNetwork.PlayerList[1].NickName;
            //NickNameText3.text = PhotonNetwork.PlayerList[2].NickName;
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 3)
        {
            scoreText1.text = Player_Spawn.instance.Player_Money[0].ToString() + " 원";
            scoreText2.text = Player_Spawn.instance.Player_Money[1].ToString() + " 원";
            scoreText3.text = Player_Spawn.instance.Player_Money[2].ToString() + " 원";

            NickNameText1.text = PhotonNetwork.PlayerList[0].NickName;
            NickNameText2.text = PhotonNetwork.PlayerList[1].NickName;
            //NickNameText3.text = PhotonNetwork.PlayerList[2].NickName;
        }


    }
}
