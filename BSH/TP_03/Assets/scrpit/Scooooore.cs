using System.Collections;
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
        if (PhotonNetwork.PlayerList.Length < 3)
        {
            return;
        }

        if(Player_Spawn.instance.Player_Money[0] > Player_Spawn.instance.Player_Money[1] && Player_Spawn.instance.Player_Money[0] > Player_Spawn.instance.Player_Money[2])
        {
            photonView.RPC("Rank", RpcTarget.All, 0, 1);
            ranking1.text = "1위";
            if(Player_Spawn.instance.Player_Money[1] > Player_Spawn.instance.Player_Money[2])
            {
                photonView.RPC("Rank", RpcTarget.All, 1, 2);
                ranking2.text = "2위";
                photonView.RPC("Rank", RpcTarget.All, 2, 3);
                ranking3.text = "3위";
            }
            else if(Player_Spawn.instance.Player_Money[1] < Player_Spawn.instance.Player_Money[2])
            {
                photonView.RPC("Rank", RpcTarget.All, 1, 3);
                ranking2.text = "3위";
                photonView.RPC("Rank", RpcTarget.All, 2, 2);
                ranking3.text = "2위";
            }
            else if (Player_Spawn.instance.Player_Money[1] == Player_Spawn.instance.Player_Money[2])
            {
                photonView.RPC("Rank", RpcTarget.All, 1, 2);
                ranking2.text = "2위";
                photonView.RPC("Rank", RpcTarget.All, 2, 2);
                ranking3.text = "2위";
            }
        }

        else if (Player_Spawn.instance.Player_Money[1] > Player_Spawn.instance.Player_Money[0] && Player_Spawn.instance.Player_Money[1] > Player_Spawn.instance.Player_Money[2])
        {
            photonView.RPC("Rank", RpcTarget.All, 1, 1);
            ranking2.text = "1위";
            if (Player_Spawn.instance.Player_Money[0] > Player_Spawn.instance.Player_Money[2])
            {
                photonView.RPC("Rank", RpcTarget.All, 0, 2);
                ranking1.text = "2위";
                photonView.RPC("Rank", RpcTarget.All, 2, 3);
                ranking3.text = "3위";
            }
            else if (Player_Spawn.instance.Player_Money[0] < Player_Spawn.instance.Player_Money[2])
            {
                photonView.RPC("Rank", RpcTarget.All, 0, 3);
                ranking1.text = "3위";
                photonView.RPC("Rank", RpcTarget.All, 2, 2);
                ranking3.text = "2위";
            }
            else if (Player_Spawn.instance.Player_Money[0] == Player_Spawn.instance.Player_Money[2])
            {
                photonView.RPC("Rank", RpcTarget.All, 0, 2);
                ranking1.text = "2위";
                photonView.RPC("Rank", RpcTarget.All, 2, 2);
                ranking3.text = "2위";
            }
        }

        else if (Player_Spawn.instance.Player_Money[2] > Player_Spawn.instance.Player_Money[0] && Player_Spawn.instance.Player_Money[2] > Player_Spawn.instance.Player_Money[1])
        {
            photonView.RPC("Rank", RpcTarget.All, 2, 1);
            ranking3.text = "1위";
            if (Player_Spawn.instance.Player_Money[0] > Player_Spawn.instance.Player_Money[1])
            {
                photonView.RPC("Rank", RpcTarget.All, 0, 2);
                ranking1.text = "2위";
                photonView.RPC("Rank", RpcTarget.All, 1, 3);
                ranking2.text = "3위";
            }
            else if (Player_Spawn.instance.Player_Money[0] < Player_Spawn.instance.Player_Money[1])
            {
                photonView.RPC("Rank", RpcTarget.All, 0, 3);
                ranking1.text = "3위";
                photonView.RPC("Rank", RpcTarget.All, 1, 2);
                ranking2.text = "2위";
            }
            else if (Player_Spawn.instance.Player_Money[0] == Player_Spawn.instance.Player_Money[1])
            {
                photonView.RPC("Rank", RpcTarget.All, 0, 2);
                ranking1.text = "2위";
                photonView.RPC("Rank", RpcTarget.All, 1, 2);
                ranking2.text = "2위";
            }
        }

        else if(Player_Spawn.instance.Player_Money[0] == Player_Spawn.instance.Player_Money[1] && Player_Spawn.instance.Player_Money[0] > Player_Spawn.instance.Player_Money[2])
        {
            photonView.RPC("Rank", RpcTarget.All, 0, 1);
            ranking1.text = "1위";
            photonView.RPC("Rank", RpcTarget.All, 1, 1);
            ranking2.text = "1위";
            photonView.RPC("Rank", RpcTarget.All, 2, 2);
            ranking3.text = "2위";
        }

        else if (Player_Spawn.instance.Player_Money[0] == Player_Spawn.instance.Player_Money[2] && Player_Spawn.instance.Player_Money[0] > Player_Spawn.instance.Player_Money[1])
        {
            photonView.RPC("Rank", RpcTarget.All, 0, 1);
            ranking1.text = "1위";
            photonView.RPC("Rank", RpcTarget.All, 1, 2);
            ranking2.text = "2위";
            photonView.RPC("Rank", RpcTarget.All, 2, 1);
            ranking3.text = "1위";
        }

        else if (Player_Spawn.instance.Player_Money[1] == Player_Spawn.instance.Player_Money[2] && Player_Spawn.instance.Player_Money[1] > Player_Spawn.instance.Player_Money[0])
        {
            photonView.RPC("Rank", RpcTarget.All, 0, 2);
            ranking1.text = "2위";
            photonView.RPC("Rank", RpcTarget.All, 1, 1);
            ranking2.text = "1위";
            photonView.RPC("Rank", RpcTarget.All, 2, 1);
            ranking3.text = "1위";
        }

        else if(Player_Spawn.instance.Player_Money[0] == Player_Spawn.instance.Player_Money[1] && Player_Spawn.instance.Player_Money[1] == Player_Spawn.instance.Player_Money[2])
        {
            photonView.RPC("Rank", RpcTarget.All, 0, 1);
            ranking1.text = "1위";
            photonView.RPC("Rank", RpcTarget.All, 1, 1);
            ranking2.text = "1위";
            photonView.RPC("Rank", RpcTarget.All, 2, 1);
            ranking3.text = "1위";
        }

        if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            scoreText1.text = Player_Spawn.instance.Player_Money[0].ToString() + " 점";
            scoreText2.text = Player_Spawn.instance.Player_Money[1].ToString() + " 점";
            scoreText3.text = Player_Spawn.instance.Player_Money[2].ToString() + " 점";



            NickNameText1.text = PhotonNetwork.PlayerList[0].NickName;
            NickNameText2.text = PhotonNetwork.PlayerList[1].NickName;
            NickNameText3.text = PhotonNetwork.PlayerList[2].NickName;
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            scoreText1.text = Player_Spawn.instance.Player_Money[0].ToString() + " 점";
            scoreText2.text = Player_Spawn.instance.Player_Money[1].ToString() + " 점";
            scoreText3.text = Player_Spawn.instance.Player_Money[2].ToString() + " 점";


            NickNameText1.text = PhotonNetwork.PlayerList[0].NickName;
            NickNameText2.text = PhotonNetwork.PlayerList[1].NickName;
            NickNameText3.text = PhotonNetwork.PlayerList[2].NickName;
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 3)
        {
            scoreText1.text = Player_Spawn.instance.Player_Money[0].ToString() + " 점";
            scoreText2.text = Player_Spawn.instance.Player_Money[1].ToString() + " 점";
            scoreText3.text = Player_Spawn.instance.Player_Money[2].ToString() + " 점";

            NickNameText1.text = PhotonNetwork.PlayerList[0].NickName;
            NickNameText2.text = PhotonNetwork.PlayerList[1].NickName;
            NickNameText3.text = PhotonNetwork.PlayerList[2].NickName;
        }


    }

    [PunRPC]
    public void Rank(int num1, int num2)
    {
        Player_Spawn.instance.Player_Ranking[num1] = num2;
    }
}
