using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Card_Spawn : MonoBehaviourPunCallbacks
{
    public static Card_Spawn instance;

    public GameObject[] Card_PF;   //카드 프리팹
    public GameObject[] Card_Cann;  //카드 생성 위치
    public GameObject[] Card_Arrive;  //카드 도착 위치


    public GameObject[] Card_Obj;   //카드 오브젝트

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        var localPleyerIndex = PhotonNetwork.LocalPlayer.ActorNumber - 1;



        if (localPleyerIndex == 0)
        {
            for (int i = 0; i < 3; i++)
            {
                //card_model[i].gameObject.tag = "1Player_card";
                Card_Obj[i] = PhotonNetwork.Instantiate(Card_PF[i].name, Card_Cann[0].transform.position, Quaternion.Euler(0f, 0.0f, 180f));
            }
        }

        else if (localPleyerIndex == 1)
        {
            for (int i = 3; i < 6; i++)
            {
                //card_model[i].gameObject.tag = "1Player_card";
                Card_Obj[i] = PhotonNetwork.Instantiate(Card_PF[i].name, Card_Cann[1].transform.position, Quaternion.Euler(0f, -90.0f, 180f));
            }
        }
        else if (localPleyerIndex == 2)
        {
            for (int i = 6; i < 9; i++)
            {
                //card_model[i].gameObject.tag = "1Player_card";
                Card_Obj[i] = PhotonNetwork.Instantiate(Card_PF[i].name, Card_Cann[2].transform.position, Quaternion.Euler(0f, 90.0f, 180f));
            }
        }
    }
}
