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

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        var localPleyerIndex = PhotonNetwork.LocalPlayer.ActorNumber - 1;

        if (localPleyerIndex == 0)
        {
            for (int i = 0; i < 3; i++)
            {
                card_model[i].gameObject.tag = "1Player_card";
                PhotonNetwork.Instantiate(card_model[i].name, card_cann[localPleyerIndex].transform.position, Quaternion.Euler(0f, 0.0f, 180f));
            }
        }
        else if (localPleyerIndex == 1)
        {
            for (int i = 0; i < 3; i++)
            {
                card_model[i].gameObject.tag = "2Player_card";
                PhotonNetwork.Instantiate(card_model[i].name, card_cann[localPleyerIndex].transform.position, Quaternion.Euler(0f, 90.0f, 180f));
            }
        }
        else if (localPleyerIndex == 2)
        {
            for (int i = 0; i < 3; i++)
            {
                card_model[i].gameObject.tag = "3Player_card";
                PhotonNetwork.Instantiate(card_model[i].name, card_cann[localPleyerIndex].transform.position, Quaternion.Euler(0f, -90.0f, 180f));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
