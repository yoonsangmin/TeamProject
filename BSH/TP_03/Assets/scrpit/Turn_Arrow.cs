using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Turn_Arrow : MonoBehaviourPunCallbacks
{
    public GameObject[] Arrow;
    
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
