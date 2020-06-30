using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class Board_Spawn : MonoBehaviourPunCallbacks
{ 
    public static Board_Spawn instance;

    public GameObject pz1;
    public GameObject pz2;
    public GameObject pz3;
    public GameObject pz4;

    //각 보드칸이 가지고 있는 돈의 밸류
    public int[] BoardMoney;

    public int[] Board_Is_Square;

    private void Awake()
    {
        instance = this;
    }

    public int Turn;   //턴

    // Start is called before the first frame update
    void Start()
    {
        //보드 점수 설정 하는 부분
        photonView.RPC("B_M", RpcTarget.All, 1, 2);
        photonView.RPC("B_M", RpcTarget.All, 3, -3);
        photonView.RPC("B_M", RpcTarget.All, 5, -4);
        photonView.RPC("B_M", RpcTarget.All, 7, 5);
    }

    private void Update()
    {

       

        if (BoardMoney[1] >= 0)
        {
            pz1.gameObject.GetComponent<TextMeshPro>().text = "+" + BoardMoney[1].ToString();
        }
        else
        {
            pz1.gameObject.GetComponent<TextMeshPro>().text = BoardMoney[1].ToString();
        }

        if (BoardMoney[3] >= 0)
        {
            pz2.gameObject.GetComponent<TextMeshPro>().text = "+" + BoardMoney[3].ToString();
        }
        else
        {
            pz2.gameObject.GetComponent<TextMeshPro>().text = BoardMoney[3].ToString();
        }

        if (BoardMoney[5] >= 0)
        {
            pz3.gameObject.GetComponent<TextMeshPro>().text = "+" + BoardMoney[5].ToString();
        }
        else
        {
            pz3.gameObject.GetComponent<TextMeshPro>().text = BoardMoney[5].ToString();
        }

        if (BoardMoney[7] >= 0)
        {
            pz4.gameObject.GetComponent<TextMeshPro>().text = "+" + BoardMoney[7].ToString();
        }
        else
        {
            pz4.gameObject.GetComponent<TextMeshPro>().text = BoardMoney[7].ToString();
        }

    }

    [PunRPC]
    public void B_M(int num1, int num2)
    {
        BoardMoney[num1] = num2;
    }
}
