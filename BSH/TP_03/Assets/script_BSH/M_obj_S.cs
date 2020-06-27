using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class M_obj_S : MonoBehaviourPunCallbacks
{
    public GameObject f;
    public GameObject fff;


    // Start is called before the first frame update
    void Start()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            SpawnF();
        }
    }
    

    void SpawnF()
    {
        fff = PhotonNetwork.Instantiate(f.name, Vector3.zero, Quaternion.identity);
    }


    public void asfdfadsfdas()
    {
        fff.GetComponent<test>().sdafas();
    }
}
