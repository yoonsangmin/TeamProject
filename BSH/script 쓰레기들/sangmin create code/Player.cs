using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviourPunCallbacks
{
    static public Player instance;


    //플레이어 구조체
    public struct Player_struct
    {
        //플레이어가 가야할 칸
        public int player_pos;

        //플레이어가 선택한 카드
        public int player_card;

        //플레이어가 카드를 선택 완료 했는지
        public bool cardselectdone;

        //플레이어의 점수
        public int player_money;

        //플레이어가 감옥칸 밟았는지 검사하는 플래그
        public bool is_onstart;

        //플레이어가 감옥칸 밟았는지 검사하는 플래그
        public bool is_prison;

        //플레이어가 우주 여행칸 밟았는지 검사하는 플래그
        public bool is_travel;

        //플레이어가 움직이고 있는지 검사하는 플래그
        public bool is_moving;

        //플레이어의 오브젝트
        public GameObject player_model;
    };

    //플레이어 오브젝트 설정할 수 있게 해주는 변수
    public GameObject[] playerprefab;
    public Player_struct[] player = new Player_struct[3];
    public GameObject[] cann;

    public int[] aaaaaaaaaaaa = new int[3];
    public bool[] bbbb = new bool[3];

    public int sum_card;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    void Start()
    {

        cann[0] = GameObject.FindWithTag("1Cann_0");
        cann[1] = GameObject.FindWithTag("2Cann_0");
        cann[2] = GameObject.FindWithTag("3Cann_0");
        cann[3] = GameObject.FindWithTag("1Cann_1");
        cann[4] = GameObject.FindWithTag("2Cann_1");
        cann[5] = GameObject.FindWithTag("3Cann_1");
        cann[6] = GameObject.FindWithTag("1Cann_2");
        cann[7] = GameObject.FindWithTag("2Cann_2");
        cann[8] = GameObject.FindWithTag("3Cann_2");
        cann[9] = GameObject.FindWithTag("1Cann_3");
        cann[10] = GameObject.FindWithTag("2Cann_3");
        cann[11] = GameObject.FindWithTag("3Cann_3");
        cann[12] = GameObject.FindWithTag("1Cann_4");
        cann[13] = GameObject.FindWithTag("2Cann_4");
        cann[14] = GameObject.FindWithTag("3Cann_4");
        cann[15] = GameObject.FindWithTag("1Cann_5");
        cann[16] = GameObject.FindWithTag("2Cann_5");
        cann[17] = GameObject.FindWithTag("3Cann_5");
        cann[18] = GameObject.FindWithTag("1Cann_6");
        cann[19] = GameObject.FindWithTag("2Cann_6");
        cann[20] = GameObject.FindWithTag("3Cann_6");
        cann[21] = GameObject.FindWithTag("1Cann_7");
        cann[22] = GameObject.FindWithTag("2Cann_7");
        cann[23] = GameObject.FindWithTag("3Cann_7");

      
        //if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        //{
        //    photonView.RPC("RPC_Player", RpcTarget.All, 0);
        //}
        //else if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
        //{
        //    photonView.RPC("RPC_Player", RpcTarget.All, 1);
        //}
        //else if (PhotonNetwork.LocalPlayer.ActorNumber == 3)
        //{
        //    photonView.RPC("RPC_Player", RpcTarget.All, 2);
        //}



        ////보드 위에서의 위치 0으로 초기화
        //player[PhotonNetwork.LocalPlayer.ActorNumber - 1].player_pos = 0;
        ////각 플레이어의 점수 초기화 몇으로 해야하는지 처음 들고 시작하는 돈
        //player[PhotonNetwork.LocalPlayer.ActorNumber - 1].player_money = 10;
        //player[PhotonNetwork.LocalPlayer.ActorNumber - 1].player_card = 0;
        //player[PhotonNetwork.LocalPlayer.ActorNumber - 1].cardselectdone = false;
        //player[PhotonNetwork.LocalPlayer.ActorNumber - 1].is_onstart = false;
        //player[PhotonNetwork.LocalPlayer.ActorNumber - 1].is_moving = false;

        ////감옥칸이 아님
        //player[PhotonNetwork.LocalPlayer.ActorNumber - 1].is_prison = false;
        ////여행칸이 아님
        //player[PhotonNetwork.LocalPlayer.ActorNumber - 1].is_travel = false;


        //aaaaaaaaaaaa[PhotonNetwork.LocalPlayer.ActorNumber - 1] += 4;

        //방장 마스터클라이언트 에서만 생성할 오브젝트 (게임에 하나만 있어야하는 오브젝트 ex. 공)
        if (PhotonNetwork.IsMasterClient)
        {
            SpawnObj_L();
        }

    }

    private void Update()
    {
        if (PhotonNetwork.PlayerList.Length < 2)
        {
            return;
        }

        //Debug.Log("이런");
        if (PhotonNetwork.LocalPlayer.ActorNumber == 1 && !bbbb[PhotonNetwork.LocalPlayer.ActorNumber -1])
        {
            //Debug.Log("이런_1");
            photonView.RPC("RPC_Player", RpcTarget.All, 0);
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 2 && !bbbb[PhotonNetwork.LocalPlayer.ActorNumber - 1])
        {
            //Debug.Log("이런_2");
            photonView.RPC("RPC_Player", RpcTarget.All, 1);
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 3 && !bbbb[PhotonNetwork.LocalPlayer.ActorNumber - 1])
        {
            //Debug.Log("이런_3");
            photonView.RPC("RPC_Player", RpcTarget.All, 2);
        }



    }


    //[PunRPC]
    //public void RPCMoneyUpdate(int num)
    //{
    //    player[num].player_money = 10;
    //}

    [PunRPC]
    public void RPC_Player(int num)
    {
        //보드 위에서의 위치 0으로 초기화
        player[num].player_pos = 0;
        //각 플레이어의 점수 초기화 몇으로 해야하는지 처음 들고 시작하는 돈
        player[num].player_money = 10;
        player[num].player_card = 0;
        player[num].cardselectdone = false;
        player[num].is_onstart = false;
        player[num].is_moving = false;

        //감옥칸이 아님
        player[num].is_prison = false;
        //여행칸이 아님
        player[num].is_travel = false;


        aaaaaaaaaaaa[num] += 4;
        bbbb[num] = true; 
    }


    //오브젝트 생성 함수
    private void SpawnObj_L()
    {
        //내꺼에 오브젝트 생성 생성 후 다른 컴퓨터에서도 복제본을 생성
        //무조건 리소스 파일 안에있는 이름을 받아서 생성
        PhotonNetwork.Instantiate(playerprefab[0].name, cann[0].transform.position, cann[0].transform.rotation);
        PhotonNetwork.Instantiate(playerprefab[1].name, cann[1].transform.position, cann[1].transform.rotation);
        PhotonNetwork.Instantiate(playerprefab[2].name, cann[2].transform.position, cann[2].transform.rotation);
    }
}