using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ins_card : MonoBehaviourPunCallbacks
{
    static public ins_card instance;

    public GameObject[] card_model;
    public GameObject[] card_cann;

    public GameObject[] cardobj;

    public bool[] bbbbb = new bool[3];

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        var localPleyerIndex = PhotonNetwork.LocalPlayer.ActorNumber - 1;


        card_cann[0] = GameObject.FindWithTag("card_p1");
        card_cann[1] = GameObject.FindWithTag("card_p2");
        card_cann[2] = GameObject.FindWithTag("card_p3");
        card_cann[3] = GameObject.FindWithTag("card_p4");
        card_cann[4] = GameObject.FindWithTag("card_p5");
        card_cann[5] = GameObject.FindWithTag("card_p6");




        if (localPleyerIndex == 0)
        {
            
            for (int i = 0; i < 3; i++)
            {
                //card_model[i].gameObject.tag = "1Player_card";
                PhotonNetwork.Instantiate(card_model[i].name, card_cann[localPleyerIndex].transform.position, Quaternion.Euler(0f, 0.0f, 180f));
            }
        }
        else if (localPleyerIndex == 1)
        {
            
            for (int i = 3; i < 6; i++)
            {
                //card_model[i].gameObject.tag = "2Player_card";
                PhotonNetwork.Instantiate(card_model[i].name, card_cann[localPleyerIndex].transform.position, Quaternion.Euler(0f, 90.0f, 180f));
            }
        }
        else if (localPleyerIndex == 2)
        {
           
            for (int i = 6; i < 9; i++)
            {
                //card_model[i].gameObject.tag = "3Player_card";
                PhotonNetwork.Instantiate(card_model[i].name, card_cann[localPleyerIndex].transform.position, Quaternion.Euler(0f, -90.0f, 180f));
            }
        }



    }

    // Update is called once per frame
    void Update()
    {
        if (PhotonNetwork.PlayerList.Length < 2)
        {
            return;
        }
        if (PhotonNetwork.LocalPlayer.ActorNumber == 1 && !bbbbb[PhotonNetwork.LocalPlayer.ActorNumber - 1])
        {
            photonView.RPC("RPCUpdateCard_1", RpcTarget.All, 0);
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 2 && !bbbbb[PhotonNetwork.LocalPlayer.ActorNumber - 1])
        {
            photonView.RPC("RPCUpdateCard_2", RpcTarget.All, 1);
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 3 && !bbbbb[PhotonNetwork.LocalPlayer.ActorNumber - 1])
        {
            photonView.RPC("RPCUpdateCard_3", RpcTarget.All, 2);
        }
    }

    [PunRPC]
    private void RPCUpdateCard_1(int num)
    {
        cardobj[num*3 + 0] = GameObject.FindWithTag("1Player_card_1");
        cardobj[num*3 + 1] = GameObject.FindWithTag("1Player_card_2");
        cardobj[num*3 + 2] = GameObject.FindWithTag("1Player_card_3");

        bbbbb[num] = true;
    }

    [PunRPC]
    private void RPCUpdateCard_2(int num)
    {
        cardobj[num * 3 + 0] = GameObject.FindWithTag("2Player_card_1");
        cardobj[num * 3 + 1] = GameObject.FindWithTag("2Player_card_2");
        cardobj[num * 3 + 2] = GameObject.FindWithTag("2Player_card_3");

        bbbbb[num] = true;
    }

    [PunRPC]
    private void RPCUpdateCard_3(int num)
    {
        cardobj[num * 3 + 0] = GameObject.FindWithTag("3Player_card_1");
        cardobj[num * 3 + 1] = GameObject.FindWithTag("3Player_card_2");
        cardobj[num * 3 + 2] = GameObject.FindWithTag("3Player_card_3");

        bbbbb[num] = true;
    }
}
