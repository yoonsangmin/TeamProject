using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;

public class wincheck : MonoBehaviourPunCallbacks
{
    public GameObject winpanel;
    public GameObject losepanel;

    public int winmoney = 12;

    int previous_turn = 0;

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

        
        
     
            //Debug.Log("들어갔다");
            if(PhotonNetwork.LocalPlayer.ActorNumber == 1)
            {
            //Debug.Log(Player.instance.player[0].player_money);
                if (Player.instance.player[0].player_money >= winmoney)
                {
                    winpanel.SetActive(true);
                    Debug.Log("1번 이겼다");
                }

                if (Player.instance.player[1].player_money >= winmoney)
                {
                    losepanel.SetActive(true);
                    Debug.Log("1번 졌다");
                }

                if (Player.instance.player[2].player_money >= winmoney)
                {
                    losepanel.SetActive(true);
                    Debug.Log("1번 졌다");
                }
            }

            if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
            {
            //Debug.Log(Player.instance.player[1].player_money);
            if (Player.instance.player[1].player_money >= winmoney)
                {
                    winpanel.SetActive(true);
                    Debug.Log("2번 이겼다");
                }

                if (Player.instance.player[0].player_money >= winmoney)
                {
                    losepanel.SetActive(true);
                    Debug.Log("2번 졌다");
                }

                if (Player.instance.player[2].player_money >= winmoney)
                {
                    losepanel.SetActive(true);
                    Debug.Log("2번 졌다");
                }
            }

            if (PhotonNetwork.LocalPlayer.ActorNumber == 3)
            {
            Debug.Log("3들어갔다");
            if (Player.instance.player[2].player_money >= winmoney)
                {
                    winpanel.SetActive(true);
                    Debug.Log("이겼다");
                }

                if (Player.instance.player[1].player_money >= winmoney)
                {
                    losepanel.SetActive(true);
                    Debug.Log("졌다");
                }

                if (Player.instance.player[0].player_money >= winmoney)
                {
                    losepanel.SetActive(true);
                    Debug.Log("졌다");
                }
            }
            //if (Player.instance.player[PhotonNetwork.LocalPlayer.ActorNumber - 1].player_money >= winmoney)
            //{
            //    winpanel.SetActive(true);
            //    Debug.Log("이겼다");
            //}

            //if (Player.instance.player[PhotonNetwork.LocalPlayer.ActorNumber % 3].player_money >= winmoney)
            //{
            //    losepanel.SetActive(true);
            //    Debug.Log("졌다");
            //}

            //if (Player.instance.player[(PhotonNetwork.LocalPlayer.ActorNumber + 1) % 3].player_money >= winmoney)
            //{
            //    losepanel.SetActive(true);
            //    Debug.Log("졌다");
            //}
        

        previous_turn = gogo.instance.turn_number;
        //photonView.RPC("RPCturnprogress", RpcTarget.All);
    }

    //[PunRPC]
    //public void RPCturnprogress()
    //{
        
    //}
}
