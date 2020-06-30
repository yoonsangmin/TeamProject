using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Player_Spawn : MonoBehaviourPunCallbacks
{
    public static Player_Spawn instance;

    public GameObject[] Player_PF;   //플레이어 프리팹
    public GameObject[] PLayer_Cann;  //플레이어 칸

    public GameObject[] Player_Obj;   //플레이어 오브젝트

    public int[] Player_Position;       //플레이어 위치

    public int[] Player_Previous_Position; //플레이어 이동 전 위치

    public int[] Player_Money;          //플레이어 총 머니

    public int[] Player_Ranking;        //플레이어 랭크

    public int[] Player_Is_Flex;        //플레이어가 플렉스가 됐는지 1 = 플렉스 2 = 더블플렉스 3 = 트리플렉스

    public bool[] Player_Is_Prision;    //플레이어가 감옥칸 밟았는지

    public bool[] Player_Is_Freedom;    //플레이어가 프리덤칸 밟았는지

    public bool[] Player_Is_TriFlex;    //플레이어가 트리플렉스인지

    public bool[] Player_Is_Start;    //플레이어가 스타트칸인지

    public bool Player_MovingDo;       //플레이어 이동 했는지 아닌지

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
            Player_Obj[0] = PhotonNetwork.Instantiate(Player_PF[0].name, PLayer_Cann[0].transform.position, Quaternion.identity);
        }

        else if (localPleyerIndex == 1)
        {
            Player_Obj[1] = PhotonNetwork.Instantiate(Player_PF[1].name, PLayer_Cann[1].transform.position, Quaternion.identity);
        }

        else if (localPleyerIndex == 2)
        {
            Player_Obj[2] = PhotonNetwork.Instantiate(Player_PF[2].name, PLayer_Cann[2].transform.position, Quaternion.identity);
        }
    }

}
