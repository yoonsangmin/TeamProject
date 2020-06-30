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
        if(Player_Spawn.instance.Player_Ranking[0] <= Player_Spawn.instance.Player_Ranking[1] && Player_Spawn.instance.Player_Ranking[1] <= Player_Spawn.instance.Player_Ranking[2])
        {
            PlayerName[0].text = Player_Spawn.instance.Player_name[0];
            PlayerName[1].text = Player_Spawn.instance.Player_name[1];
            PlayerName[2].text = Player_Spawn.instance.Player_name[2];
            PlayerScore[0].text = Player_Spawn.instance.Player_Money[0].ToString() + "점";
            PlayerScore[1].text = Player_Spawn.instance.Player_Money[1].ToString() + "점";
            PlayerScore[2].text = Player_Spawn.instance.Player_Money[2].ToString() + "점";
            PlayerRankText[0].text = Player_Spawn.instance.Player_Ranking[0].ToString() + "위";
            PlayerRankText[1].text = Player_Spawn.instance.Player_Ranking[1].ToString() + "위";
            PlayerRankText[2].text = Player_Spawn.instance.Player_Ranking[2].ToString() + "위";
        }

        else if (Player_Spawn.instance.Player_Ranking[0] <= Player_Spawn.instance.Player_Ranking[2] && Player_Spawn.instance.Player_Ranking[2] < Player_Spawn.instance.Player_Ranking[1])
        {
            PlayerName[0].text = Player_Spawn.instance.Player_name[0];
            PlayerName[1].text = Player_Spawn.instance.Player_name[2];
            PlayerName[2].text = Player_Spawn.instance.Player_name[1];
            PlayerScore[0].text = Player_Spawn.instance.Player_Money[0].ToString() + "점";
            PlayerScore[1].text = Player_Spawn.instance.Player_Money[2].ToString() + "점";
            PlayerScore[2].text = Player_Spawn.instance.Player_Money[1].ToString() + "점";
            PlayerRankText[0].text = Player_Spawn.instance.Player_Ranking[0].ToString() + "위";
            PlayerRankText[1].text = Player_Spawn.instance.Player_Ranking[2].ToString() + "위";
            PlayerRankText[2].text = Player_Spawn.instance.Player_Ranking[1].ToString() + "위";
        }

        else if (Player_Spawn.instance.Player_Ranking[1] < Player_Spawn.instance.Player_Ranking[0] && Player_Spawn.instance.Player_Ranking[0] <= Player_Spawn.instance.Player_Ranking[2])
        {
            PlayerName[0].text = Player_Spawn.instance.Player_name[1];
            PlayerName[1].text = Player_Spawn.instance.Player_name[0];
            PlayerName[2].text = Player_Spawn.instance.Player_name[2];
            PlayerScore[0].text = Player_Spawn.instance.Player_Money[1].ToString() + "점";
            PlayerScore[1].text = Player_Spawn.instance.Player_Money[0].ToString() + "점";
            PlayerScore[2].text = Player_Spawn.instance.Player_Money[2].ToString() + "점";
            PlayerRankText[0].text = Player_Spawn.instance.Player_Ranking[1].ToString() + "위";
            PlayerRankText[1].text = Player_Spawn.instance.Player_Ranking[0].ToString() + "위";
            PlayerRankText[2].text = Player_Spawn.instance.Player_Ranking[2].ToString() + "위";
        }

        else if (Player_Spawn.instance.Player_Ranking[1] <= Player_Spawn.instance.Player_Ranking[2] && Player_Spawn.instance.Player_Ranking[2] < Player_Spawn.instance.Player_Ranking[0])
        {
            PlayerName[0].text = Player_Spawn.instance.Player_name[1];
            PlayerName[1].text = Player_Spawn.instance.Player_name[2];
            PlayerName[2].text = Player_Spawn.instance.Player_name[0];
            PlayerScore[0].text = Player_Spawn.instance.Player_Money[1].ToString() + "점";
            PlayerScore[1].text = Player_Spawn.instance.Player_Money[2].ToString() + "점";
            PlayerScore[2].text = Player_Spawn.instance.Player_Money[0].ToString() + "점";
            PlayerRankText[0].text = Player_Spawn.instance.Player_Ranking[1].ToString() + "위";
            PlayerRankText[1].text = Player_Spawn.instance.Player_Ranking[2].ToString() + "위";
            PlayerRankText[2].text = Player_Spawn.instance.Player_Ranking[0].ToString() + "위";
        }

        else if (Player_Spawn.instance.Player_Ranking[2] < Player_Spawn.instance.Player_Ranking[0] && Player_Spawn.instance.Player_Ranking[0] <= Player_Spawn.instance.Player_Ranking[1])
        {
            PlayerName[0].text = Player_Spawn.instance.Player_name[2];
            PlayerName[1].text = Player_Spawn.instance.Player_name[0];
            PlayerName[2].text = Player_Spawn.instance.Player_name[1];
            PlayerScore[0].text = Player_Spawn.instance.Player_Money[2].ToString() + "점";
            PlayerScore[1].text = Player_Spawn.instance.Player_Money[0].ToString() + "점";
            PlayerScore[2].text = Player_Spawn.instance.Player_Money[1].ToString() + "점";
            PlayerRankText[0].text = Player_Spawn.instance.Player_Ranking[2].ToString() + "위";
            PlayerRankText[1].text = Player_Spawn.instance.Player_Ranking[0].ToString() + "위";
            PlayerRankText[2].text = Player_Spawn.instance.Player_Ranking[1].ToString() + "위";
        }

        else if (Player_Spawn.instance.Player_Ranking[2] < Player_Spawn.instance.Player_Ranking[1] && Player_Spawn.instance.Player_Ranking[1] < Player_Spawn.instance.Player_Ranking[0])
        {
            PlayerName[0].text = Player_Spawn.instance.Player_name[2];
            PlayerName[1].text = Player_Spawn.instance.Player_name[1];
            PlayerName[2].text = Player_Spawn.instance.Player_name[0];
            PlayerScore[0].text = Player_Spawn.instance.Player_Money[2].ToString() + "점";
            PlayerScore[1].text = Player_Spawn.instance.Player_Money[1].ToString() + "점";
            PlayerScore[2].text = Player_Spawn.instance.Player_Money[0].ToString() + "점";
            PlayerRankText[0].text = Player_Spawn.instance.Player_Ranking[2].ToString() + "위";
            PlayerRankText[1].text = Player_Spawn.instance.Player_Ranking[1].ToString() + "위";
            PlayerRankText[2].text = Player_Spawn.instance.Player_Ranking[0].ToString() + "위";
        }
    }
}
