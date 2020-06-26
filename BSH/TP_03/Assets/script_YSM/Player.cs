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

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        SpawnObj_L();

        //보드 위에서의 위치 0으로 초기화
        player[PhotonNetwork.LocalPlayer.ActorNumber - 1].player_pos = 0;
        //각 플레이어의 점수 초기화 몇으로 해야하는지 처음 들고 시작하는 돈
        player[PhotonNetwork.LocalPlayer.ActorNumber - 1].player_money = 10;
        player[PhotonNetwork.LocalPlayer.ActorNumber - 1].player_card = 0;
        player[PhotonNetwork.LocalPlayer.ActorNumber - 1].cardselectdone = false;
        player[PhotonNetwork.LocalPlayer.ActorNumber - 1].is_onstart = false;
        player[PhotonNetwork.LocalPlayer.ActorNumber - 1].is_moving = false;

        //감옥칸이 아님
        player[PhotonNetwork.LocalPlayer.ActorNumber - 1].is_prison = false;
        //여행칸이 아님
        player[PhotonNetwork.LocalPlayer.ActorNumber - 1].is_travel = false;

        //방장 마스터클라이언트 에서만 생성할 오브젝트 (게임에 하나만 있어야하는 오브젝트 ex. 공)
        if (PhotonNetwork.IsMasterClient)
        {
            
        }
    }

    //오브젝트 생성 함수
    private void SpawnObj_L()
    {
        //로컬 플레이어의 ActorNumber 가져오기 1번부터 시작해서 -1 해준것
        var localPleyerIndex = PhotonNetwork.LocalPlayer.ActorNumber - 1;
        //오브젝트 위치
        var spawnPosition = cann[localPleyerIndex];

        //내꺼에 오브젝트 생성 생성 후 다른 컴퓨터에서도 복제본을 생성
        //무조건 리소스 파일 안에있는 이름을 받아서 생성
        PhotonNetwork.Instantiate(playerprefab[localPleyerIndex].name, spawnPosition.transform.position, spawnPosition.transform.rotation);
    }

}