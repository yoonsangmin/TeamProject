using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Turn_Processing : MonoBehaviourPunCallbacks
{
    // Update is called once per frame
    void Update()
    {
        if (PhotonNetwork.PlayerList.Length < 3)
        {
            return;
        }

        if (PhotonNetwork.LocalPlayer.ActorNumber == 1 && Board_Spawn.instance.Turn % 3 == 0)           //플레이어 1이고 자기 턴일 때
        {
            if (Player_Spawn.instance.Player_Is_Prision[0] == true)        // 무브 끝나고 턴 시작할 때, 진행 할 플레이어가 감옥에 있으면
            {
                photonView.RPC("P_Prison_F", RpcTarget.All, 0); //감옥 트리거를 초기화
                photonView.RPC("Turn_UP", RpcTarget.All);          //턴을 올림

            }
            else if (Player_Spawn.instance.Player_Is_Freedom[0] == true)     //여행칸 밟았을때
            {
                photonView.RPC("UIButtonSwitch", RpcTarget.All, false);      //UI버튼 전체 다 꺼버림
                if (Click_Button.instance.ClickDone)
                {   
                    if(Click_Button.instance.a != 6)            //다시 프리덤칸으로 가면 안됨
                    {
                        photonView.RPC("P_Position_Change", RpcTarget.All, 0, Click_Button.instance.a);             //플레이어 위치를 마우스 클릭한 곳으로 해줌
                        photonView.RPC("P_Moving_On", RpcTarget.All);                                               //움직임 트루로 해줌 무브코드로 가서 UI켜주고 턴 올려주고 무빙 끝나면 알아서 movingdo false됨
                        photonView.RPC("P_Freedom_F", RpcTarget.All, 0);                                            //프리덤 사용했다고 알려줌
                    }
                    Click_Button.instance.ClickDone = false;                                                    //마우스 클릭 false로 바꿔줌
                }
                //여행칸 진행
            }
            //else                                                            //감옥이 아닌 경우에 턴 진행
            //{
            //    if (Card_Spawn.instance.CardSelectButton.activeSelf == false)
            //        Card_Spawn.instance.CardSelectButton.SetActive(true);       //버튼 UI 켜기
            //}
        }

        if (PhotonNetwork.LocalPlayer.ActorNumber == 2 && Board_Spawn.instance.Turn % 3 == 1)             //플레이어 2이고 자기 턴일 때
        {
            if (Player_Spawn.instance.Player_Is_Prision[1] == true)        //턴 시작할 때, 진행 할 플레이어가 감옥에 있으면
            {
                photonView.RPC("P_Prison_F", RpcTarget.All, 1); //감옥 트리거를 초기화
                photonView.RPC("Turn_UP", RpcTarget.All);          //턴을 올림
            }
            else if (Player_Spawn.instance.Player_Is_Freedom[1] == true)     //여행칸 밟았을때
            {
                photonView.RPC("UIButtonSwitch", RpcTarget.All, false);      //UI버튼 전체 다 꺼버림
                if (Click_Button.instance.ClickDone)
                {
                    if (Click_Button.instance.a != 6)            //다시 프리덤칸으로 가면 안됨
                    {
                        photonView.RPC("P_Position_Change", RpcTarget.All, 1, Click_Button.instance.a);             //플레이어 위치를 마우스 클릭한 곳으로 해줌
                        photonView.RPC("P_Moving_On", RpcTarget.All);                                               //움직임 트루로 해줌 무브코드로 가서 UI켜주고 턴 올려주고 무빙 끝나면 알아서 movingdo false됨
                        photonView.RPC("P_Freedom_F", RpcTarget.All, 1);                                            //프리덤 사용했다고 알려줌
                    }
                    Click_Button.instance.ClickDone = false;                                                    //마우스 클릭 false로 바꿔줌
                }
                //여행칸 진행
            }
            //else                                                            //감옥이 아닌 경우에 턴 진행
            //{
            //    Card_Spawn.instance.CardSelectButton.SetActive(true);       //버튼 UI 켜기
            //}
        }

        if (PhotonNetwork.LocalPlayer.ActorNumber == 3 && Board_Spawn.instance.Turn % 3 == 2)             //플레이어 3이고 자기 턴일 때)
        {
            if (Player_Spawn.instance.Player_Is_Prision[2] == true)        //턴 시작할 때, 진행 할 플레이어가 감옥에 있으면
            {
                photonView.RPC("P_Prison_F", RpcTarget.All, 2); //감옥 트리거를 초기화
                photonView.RPC("Turn_UP", RpcTarget.All);          //턴을 올림
            }
            else if (Player_Spawn.instance.Player_Is_Freedom[2] == true)     //여행칸 밟았을때
            {
                photonView.RPC("UIButtonSwitch", RpcTarget.All, false);      //UI버튼 전체 다 꺼버림
                if (Click_Button.instance.ClickDone)
                {
                    if (Click_Button.instance.a != 6)            //다시 프리덤칸으로 가면 안됨
                    {
                        photonView.RPC("P_Position_Change", RpcTarget.All, 2, Click_Button.instance.a);             //플레이어 위치를 마우스 클릭한 곳으로 해줌
                        photonView.RPC("P_Moving_On", RpcTarget.All);                                               //움직임 트루로 해줌 무브코드로 가서 UI켜주고 턴 올려주고 무빙 끝나면 알아서 movingdo false됨
                        photonView.RPC("P_Freedom_F", RpcTarget.All, 2);                                            //프리덤 사용했다고 알려줌
                    }
                    Click_Button.instance.ClickDone = false;                                                    //마우스 클릭 false로 바꿔줌
                }
                //여행칸 진행
            }
            //else                                                            //감옥이 아닌 경우에 턴 진행
            //{
            //    Card_Spawn.instance.CardSelectButton.SetActive(true);       //버튼 UI 켜기
            //}
        }


    }

    [PunRPC]
    public void P_Moving_On()
    {
        Player_Spawn.instance.Player_MovingDo = true;
    }

    [PunRPC]
    public void P_Position_Change(int num1, int num2)
    {
        Player_Spawn.instance.Player_Position[num1] = num2;
    }

    [PunRPC]
    public void P_Freedom_F(int num1)
    {
        Player_Spawn.instance.Player_Is_Freedom[num1] = false;
    }

    [PunRPC]
    public void P_Prison_F(int num1)
    {
        Player_Spawn.instance.Player_Is_Prision[num1] = false;
    }

    [PunRPC]
    public void UIButtonSwitch(bool num1)
    {
        Card_Spawn.instance.CardSelectButton.SetActive(num1);
    }

    [PunRPC]
    public void Turn_UP()
    {
        Board_Spawn.instance.Turn++;
    }
}
