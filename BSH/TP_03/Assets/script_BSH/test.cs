using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class test : MonoBehaviourPunCallbacks
{
    public int test_num; //sr
    public PhotonView PV;

    public bool sb = false;

    // Start is called before the first frame update
    void Start()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            PV.RPC("RPCtttttt", RpcTarget.All, 2);
        }
        if (!PhotonNetwork.IsMasterClient && PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            PV.RPC("RPCtttttt", RpcTarget.All, 4);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (PV.IsMine)
        //{
        //    Debug.Log("1123");

        //    int num;
        //    num = 2;
        //    PV.RPC("RPCtttttt", RpcTarget.All, num);
        //}
        if (sb)
        {
            if (PhotonNetwork.IsMasterClient)
            {
                PV.RPC("RPCtttttt", RpcTarget.All, 2);
            }
            if (!PhotonNetwork.IsMasterClient && PhotonNetwork.LocalPlayer.ActorNumber == 2)
            {
                PV.RPC("RPCtttttt", RpcTarget.All, 4);
            }
            sb = false;
        }
        


    }

    public void sdafas()
    {
        sb = true;
    }

    [PunRPC]
    public void RPCtttttt(int num)
    {
        test_num += num;
    }
    


}
