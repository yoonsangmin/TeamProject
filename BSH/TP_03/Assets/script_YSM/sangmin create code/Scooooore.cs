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

        if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            scoreText1.text = Player.instance.player[0].player_money.ToString();
            scoreText2.text = Player.instance.player[1].player_money.ToString();
            scoreText3.text = Player.instance.player[2].player_money.ToString();
            Debug.Log(Player.instance.player[0].player_money);
            Debug.Log(Player.instance.player[1].player_money);
           

            NickNameText1.text = PhotonNetwork.PlayerList[0].NickName;
            NickNameText2.text = PhotonNetwork.PlayerList[1].NickName;
            //NickNameText3.text = PhotonNetwork.PlayerList[2].NickName;
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            scoreText1.text = Player.instance.player[1].player_money.ToString();
            scoreText2.text = Player.instance.player[2].player_money.ToString();
            scoreText3.text = Player.instance.player[0].player_money.ToString();
            Debug.Log(Player.instance.player[0].player_money);
            Debug.Log(Player.instance.player[1].player_money);

            NickNameText1.text = PhotonNetwork.PlayerList[1].NickName;
            NickNameText2.text = PhotonNetwork.PlayerList[0].NickName;
            //NickNameText3.text = PhotonNetwork.PlayerList[0].NickName;
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 3)
        {
            scoreText1.text = Player.instance.player[2].player_money.ToString();
            scoreText2.text = Player.instance.player[1].player_money.ToString();
            scoreText3.text = Player.instance.player[0].player_money.ToString();

            //NickNameText1.text = PhotonNetwork.PlayerList[2].NickName;
            //NickNameText2.text = PhotonNetwork.PlayerList[1].NickName;
            //NickNameText3.text = PhotonNetwork.PlayerList[0].NickName;
        }


    }
}
