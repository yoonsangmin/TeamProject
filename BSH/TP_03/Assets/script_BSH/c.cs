using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class c : MonoBehaviourPunCallbacks
{
    public void Click()
    {
        if (photonView.IsMine)
        {
            photonView.RPC("RPCtttttt", RpcTarget.All, 1);
        }

        

        if (!photonView.IsMine && PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            photonView.RPC("RPCtttttt", RpcTarget.All, 2);
        }


        if (!photonView.IsMine && PhotonNetwork.LocalPlayer.ActorNumber == 3)
        {
            photonView.RPC("RPCtttttt", RpcTarget.All, 3);
        }
    }



    [PunRPC]
    public void RPCtttttt(int num)
    {
        b.instance.num_1 += num;
        b.instance.num_2 += (num + 2);
    }
}
