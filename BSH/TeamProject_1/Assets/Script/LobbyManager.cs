using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Photon.Pun;
using Photon.Realtime;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    private readonly string gameVersion = "1"; //게임의 버전 알려주는 변수

    public Text connectionInfoText;
    public Button joinButton;


    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.GameVersion = gameVersion;
        PhotonNetwork.ConnectUsingSettings();

        joinButton.interactable = false;
        connectionInfoText.text = "Connecting To Master Server....";
    }

    //마스터서버
    public override void OnConnectedToMaster()
    {
        joinButton.interactable = true;
        connectionInfoText.text = "Online : Connected to Master Server";

        //base.OnConnectedToMaster();
    }

    //마스터서버에 접속하지 못했을때
    public override void OnDisconnected(DisconnectCause cause)
    {
        joinButton.interactable = false;
        connectionInfoText.text = $"Offline : Connection Disabled {cause.ToString()} - Try Reconnecting...";

        PhotonNetwork.ConnectUsingSettings();//다시접속

        //base.OnDisconnected(cause);
    }

    public void Connect()
    {
        joinButton.interactable = false;

        if(PhotonNetwork.IsConnected)
        {
            connectionInfoText.text = "Connexting to Random Room...";//랜덤으로 참가할 수 있는방에 참가
            PhotonNetwork.JoinRandomRoom(); //랜덤으로 방에 참가 -> 나중에 바꿀 수 있게 하기
        }
        else
        {
            connectionInfoText.text = "Offline : Connection Disabled - Try Reconnecting...";

            PhotonNetwork.ConnectUsingSettings();//다시접속
        }
    }

    //방이 없을때
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        connectionInfoText.text = "There is no empty room, Creating new Room.";
        PhotonNetwork.CreateRoom(roomName: null, new RoomOptions { MaxPlayers = 3 }); //방이름과 최대 플레이어 수


        //base.OnJoinRandomFailed(returnCode, message);
    }

    //방에 접속을 성공했을 때
    public override void OnJoinedRoom()
    {
        connectionInfoText.text = "connected with Room.";
        PhotonNetwork.LoadLevel("Main"); //게임할 씬으로 넘어가게하기

       // base.OnJoinedRoom();
    }
}
