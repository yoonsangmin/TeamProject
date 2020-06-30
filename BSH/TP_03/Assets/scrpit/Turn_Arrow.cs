using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Turn_Arrow : MonoBehaviourPunCallbacks
{
    public GameObject[] Arrow;

    public GameObject winpanel;
    public GameObject losepanel;

    void start()
    {
        Arrow[0].SetActive(false);
        Arrow[1].SetActive(false);
        Arrow[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PhotonNetwork.PlayerList.Length < 3)
        {
            return;
        }

        if (Board_Spawn.instance.Turn % 3 == 0 && PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            if (winpanel.activeSelf || losepanel.activeSelf)
            {
                Arrow[0].GetComponent<AudioSource>().enabled = false;
            }
            else
            {
                Arrow[0].GetComponent<AudioSource>().enabled = true;
            }
        }
        else if (Board_Spawn.instance.Turn % 3 == 1 && PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            if (winpanel.activeSelf || losepanel.activeSelf)
            {
                Arrow[1].GetComponent<AudioSource>().enabled = false;
            }
            else
            {
                Arrow[1].GetComponent<AudioSource>().enabled = true;
            }
        }
        else if (Board_Spawn.instance.Turn % 3 == 2 && PhotonNetwork.LocalPlayer.ActorNumber == 3)
        {
            if (winpanel.activeSelf || losepanel.activeSelf)
            {
                Arrow[2].GetComponent<AudioSource>().enabled = false;
            }
            else
            {
                Arrow[2].GetComponent<AudioSource>().enabled = true;
            }
        }

        if (Board_Spawn.instance.Turn % 3 == 0)
        {
            Arrow[0].SetActive(true);
            Arrow[1].SetActive(false);
            Arrow[2].SetActive(false);
        }
        else if (Board_Spawn.instance.Turn % 3 == 1)
        {
            Arrow[1].SetActive(true);
            Arrow[0].SetActive(false);
            Arrow[2].SetActive(false);
        }
        else if (Board_Spawn.instance.Turn % 3 == 2)
        {
            Arrow[2].SetActive(true);
            Arrow[1].SetActive(false);
            Arrow[0].SetActive(false);
        }
    }
}
