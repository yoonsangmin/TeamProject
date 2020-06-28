using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Photon.Pun;
using Photon.Realtime;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    private readonly string gameVersion = "1"; //게임의 버전 알려주는 변수

    public InputField NickNameInput;  //닉네임 넣는곳
    public Button joinButton; //서버로 들어가는 버튼

    



    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.GameVersion = gameVersion;
        PhotonNetwork.ConnectUsingSettings();

        joinButton.interactable = false;
    }

    private void Update()
    {
        
    }

    //마스터서버
    public override void OnConnectedToMaster()
    {
        if (PhotonNetwork.LocalPlayer.NickName == null)
        {
            joinButton.interactable = false;
           
        }

        


        joinButton.interactable = true;

        //base.OnConnectedToMaster();
    }


    //마스터서버에 접속하지 못했을때
    public override void OnDisconnected(DisconnectCause cause)
    {
        joinButton.interactable = false;
        PhotonNetwork.ConnectUsingSettings();//다시접속

        //base.OnDisconnected(cause);
    }


    public void Connect()
    {
        joinButton.interactable = false;

        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinRandomRoom(); //랜덤으로 방에 참가 -> 나중에 바꿀 수 있게 하기
        }
        else
        {
            PhotonNetwork.ConnectUsingSettings();//다시접속
        }

    }

    //방이 없을때
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        PhotonNetwork.CreateRoom(roomName: null, new RoomOptions { MaxPlayers = 3 }); //방이름과 최대 플레이어 수

    }

    //방에 접속을 성공했을 때
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LocalPlayer.NickName = NickNameInput.text;

        Debug.Log(PhotonNetwork.LocalPlayer.NickName);


        PhotonNetwork.LoadLevel("SampleScene"); //게임할 씬으로 넘어가게하기



        // base.OnJoinedRoom();
    }
}
