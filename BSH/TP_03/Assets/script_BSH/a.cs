using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class a : MonoBehaviourPunCallbacks
{
    //생성 

    // Start is called before the first frame update
    void Start()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            SpawnF();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnF()
    {
        PhotonNetwork.Instantiate("f", Vector3.zero, Quaternion.identity);
    }
}
