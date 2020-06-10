using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviourPunCallbacks
{
    //싱글톤
    private static GameManager instance;
    
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    //ui를 받을곳
    public Text UI;

    //오브젝트 생성할 위치
    public Transform[]  spawnPositions;

    //오브젝트의 원형 프리펩
    public GameObject obj_L;
    //오브젝트의 원형 프리펩
    public GameObject obj_M;

    //점수 및 수치 저장하는 곳
    private int[] Scores;

    // Start is called before the first frame update
    void Start()
    {
        //점수 예시 0으로 3개 넣기
        Scores = new[] {0, 0, 0};

        //오브젝트 생성 각자 로컬(내꺼)에서 움직이거나 동작하는 오브젝트(ex. 플레이어)
        SpawnObj_L();

        //방장 마스터클라이언트 에서만 생성할 오브젝트 (게임에 하나만 있어야하는 오브젝트 ex. 공)
        if (PhotonNetwork.IsMasterClient)
        {
            SpawnObj_M();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //오브젝트 생성 함수
    private void SpawnObj_L()
    {
        //로컬 플레이어의 ActorNumber 가져오기 1번부터 시작해서 -1 해준것
        var localPleyerIndex = PhotonNetwork.LocalPlayer.ActorNumber - 1;
        //오브젝트 위치
        var spawnPosition = spawnPositions[localPleyerIndex % spawnPositions.Length];

        //내꺼에 오브젝트 생성 생성 후 다른 컴퓨터에서도 복제본을 생성
        //무조건 리소스 파일 안에있는 이름을 받아서 생성
        PhotonNetwork.Instantiate(obj_L.name, spawnPosition.position, spawnPosition.rotation);
    }


    private void SpawnObj_M()
    {
        //위와 같음
        PhotonNetwork.Instantiate(obj_M.name, Vector3.zero, Quaternion.identity);
    }

    //나자신이 떠나는 경우에 실행되는 함수
    public override void OnLeftRoom()
    {
        //방을 나가기
        //PhotonNetwork.LeaveRoom();


        //나혼자만 로비로 간다
        SceneManager.LoadScene("Lobby");
        base.OnLeftRoom();
    }

    //점수변화
    //수치들의 변경은 방장측에서만 이루어지도록 코드를 짬
    public void AddScore(int playerNumber, int score)
    {
        //방장이 아니라면
        if (!PhotonNetwork.IsMasterClient)
        {
            return;
        }

        Scores[playerNumber - 1] += score;

        //모든 클라이언트에 ui 보여주기
        //--------------------------------------------------
        photonView.RPC("RPCUpdateScoreText", RpcTarget.All,
            Scores[0].ToString(), Scores[1].ToString(), Scores[2].ToString());

        //여러개가 있으면 위에처럼 더 추가


        //--------------------------------------------------

    }


    //UI에 들어갈 값 넣기
    [PunRPC]
    private void RPCUpdateScoreText(string ScoreText_1, string ScoreText_2, string ScoreText_3)
    {
        UI.text = $"{ScoreText_1} : {ScoreText_2} : {ScoreText_3}";
    }
}
