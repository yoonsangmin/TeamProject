using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Result_Panel : MonoBehaviourPunCallbacks
{
    public Text[] PlayerName;
    public Text[] PlayerScore;
    public Text[] PlayerRankText;

    // Update is called once per frame
    void Update()
    {
        if (PhotonNetwork.PlayerList.Length < 3)
        {
            return;
        }

        if(Player_Spawn.instance.Player_Ranking[0] <= Player_Spawn.instance.Player_Ranking[1] && Player_Spawn.instance.Player_Ranking[1] <= Player_Spawn.instance.Player_Ranking[2])
        {
            PlayerName[0].text = PhotonNetwork.PlayerList[0].NickName;
            PlayerName[1].text = PhotonNetwork.PlayerList[1].NickName;
            PlayerName[2].text = PhotonNetwork.PlayerList[2].NickName;
            PlayerScore[0].text = Player_Spawn.instance.Player_Money[0].ToString();
            PlayerScore[1].text = Player_Spawn.instance.Player_Money[1].ToString();
            PlayerScore[2].text = Player_Spawn.instance.Player_Money[2].ToString();
            PlayerRankText[0].text = Player_Spawn.instance.Player_Ranking[0].ToString() + "위";
            PlayerRankText[1].text = Player_Spawn.instance.Player_Ranking[1].ToString() + "위";
            PlayerRankText[2].text = Player_Spawn.instance.Player_Ranking[2].ToString() + "위";
        }

        else if (Player_Spawn.instance.Player_Ranking[0] <= Player_Spawn.instance.Player_Ranking[2] && Player_Spawn.instance.Player_Ranking[2] < Player_Spawn.instance.Player_Ranking[1])
        {
            PlayerName[0].text = PhotonNetwork.PlayerList[0].NickName;
            PlayerName[1].text = PhotonNetwork.PlayerList[2].NickName;
            PlayerName[2].text = PhotonNetwork.PlayerList[1].NickName;
            PlayerScore[0].text = Player_Spawn.instance.Player_Money[0].ToString();
            PlayerScore[1].text = Player_Spawn.instance.Player_Money[2].ToString();
            PlayerScore[2].text = Player_Spawn.instance.Player_Money[1].ToString();
            PlayerRankText[0].text = Player_Spawn.instance.Player_Ranking[0].ToString() + "위";
            PlayerRankText[1].text = Player_Spawn.instance.Player_Ranking[2].ToString() + "위";
            PlayerRankText[2].text = Player_Spawn.instance.Player_Ranking[1].ToString() + "위";
        }

        else if (Player_Spawn.instance.Player_Ranking[1] < Player_Spawn.instance.Player_Ranking[0] && Player_Spawn.instance.Player_Ranking[0] <= Player_Spawn.instance.Player_Ranking[2])
        {
            PlayerName[0].text = PhotonNetwork.PlayerList[1].NickName;
            PlayerName[1].text = PhotonNetwork.PlayerList[0].NickName;
            PlayerName[2].text = PhotonNetwork.PlayerList[2].NickName;
            PlayerScore[0].text = Player_Spawn.instance.Player_Money[1].ToString();
            PlayerScore[1].text = Player_Spawn.instance.Player_Money[0].ToString();
            PlayerScore[2].text = Player_Spawn.instance.Player_Money[2].ToString();
            PlayerRankText[0].text = Player_Spawn.instance.Player_Ranking[1].ToString() + "위";
            PlayerRankText[1].text = Player_Spawn.instance.Player_Ranking[0].ToString() + "위";
            PlayerRankText[2].text = Player_Spawn.instance.Player_Ranking[2].ToString() + "위";
        }

        else if (Player_Spawn.instance.Player_Ranking[1] <= Player_Spawn.instance.Player_Ranking[2] && Player_Spawn.instance.Player_Ranking[2] < Player_Spawn.instance.Player_Ranking[0])
        {
            PlayerName[0].text = PhotonNetwork.PlayerList[1].NickName;
            PlayerName[1].text = PhotonNetwork.PlayerList[2].NickName;
            PlayerName[2].text = PhotonNetwork.PlayerList[0].NickName;
            PlayerScore[0].text = Player_Spawn.instance.Player_Money[1].ToString();
            PlayerScore[1].text = Player_Spawn.instance.Player_Money[2].ToString();
            PlayerScore[2].text = Player_Spawn.instance.Player_Money[0].ToString();
            PlayerRankText[0].text = Player_Spawn.instance.Player_Ranking[1].ToString() + "위";
            PlayerRankText[1].text = Player_Spawn.instance.Player_Ranking[2].ToString() + "위";
            PlayerRankText[2].text = Player_Spawn.instance.Player_Ranking[0].ToString() + "위";
        }

        else if (Player_Spawn.instance.Player_Ranking[2] < Player_Spawn.instance.Player_Ranking[0] && Player_Spawn.instance.Player_Ranking[0] <= Player_Spawn.instance.Player_Ranking[1])
        {
            PlayerName[0].text = PhotonNetwork.PlayerList[2].NickName;
            PlayerName[1].text = PhotonNetwork.PlayerList[0].NickName;
            PlayerName[2].text = PhotonNetwork.PlayerList[1].NickName;
            PlayerScore[0].text = Player_Spawn.instance.Player_Money[2].ToString();
            PlayerScore[1].text = Player_Spawn.instance.Player_Money[0].ToString();
            PlayerScore[2].text = Player_Spawn.instance.Player_Money[1].ToString();
            PlayerRankText[0].text = Player_Spawn.instance.Player_Ranking[2].ToString() + "위";
            PlayerRankText[1].text = Player_Spawn.instance.Player_Ranking[0].ToString() + "위";
            PlayerRankText[2].text = Player_Spawn.instance.Player_Ranking[1].ToString() + "위";
        }

        else if (Player_Spawn.instance.Player_Ranking[2] < Player_Spawn.instance.Player_Ranking[1] && Player_Spawn.instance.Player_Ranking[1] < Player_Spawn.instance.Player_Ranking[0])
        {
            PlayerName[0].text = PhotonNetwork.PlayerList[2].NickName;
            PlayerName[1].text = PhotonNetwork.PlayerList[1].NickName;
            PlayerName[2].text = PhotonNetwork.PlayerList[0].NickName;
            PlayerScore[0].text = Player_Spawn.instance.Player_Money[2].ToString();
            PlayerScore[1].text = Player_Spawn.instance.Player_Money[1].ToString();
            PlayerScore[2].text = Player_Spawn.instance.Player_Money[0].ToString();
            PlayerRankText[0].text = Player_Spawn.instance.Player_Ranking[2].ToString() + "위";
            PlayerRankText[1].text = Player_Spawn.instance.Player_Ranking[1].ToString() + "위";
            PlayerRankText[2].text = Player_Spawn.instance.Player_Ranking[0].ToString() + "위";
        }
    }
}
