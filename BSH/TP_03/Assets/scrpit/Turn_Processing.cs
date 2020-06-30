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
            if (Player_Spawn.instance.Player_Is_Start[0])     //시작칸 밟았을 때
            {
                photonView.RPC("UIButtonSwitch", RpcTarget.All, false);      //UI버튼 전체 다 꺼버림
                UI.instance.State_Text[2].SetActive(true);                   //시작칸 설명서
                if (Click_Button.instance.ClickDone)
                {
                    if (Click_Button.instance.a != 0 && Click_Button.instance.a != 2 && Click_Button.instance.a != 4 && Click_Button.instance.a != 6)            //점수칸만 클릭 가능해야 함
                    {
                        photonView.RPC("B_Money_Square", RpcTarget.All, Click_Button.instance.a);        //선택한 칸의 숫자를 2배 함 여기서 몇번 곱해줬는지 같이 올림
                        photonView.RPC("P_Start_F", RpcTarget.All, 0);                                            //프리덤 사용했다고 알려줌
                        photonView.RPC("UIButtonSwitch", RpcTarget.All, true);                                      //숫자 부호 바꾼 후에 UI버튼 다시 켜줌
                        UI.instance.State_Text[2].SetActive(false);                   //시작칸 설명서 꺼줌
                        if (!Player_Spawn.instance.Player_Is_TriFlex[0])
                        {
                            photonView.RPC("Turn_UP", RpcTarget.All);                                        //턴을 올림
                        }
                    }
                    Click_Button.instance.ClickDone = false;                                                    //마우스 클릭 false로 바꿔줌
                }
            }
            else if (Player_Spawn.instance.Player_Is_TriFlex[0])     //트리플렉스 하고 난 후 한턴 더 진행하기 전에 숫자칸 부호 바꾸기
            {
                Debug.Log("트리플렉스");
                photonView.RPC("UIButtonSwitch", RpcTarget.All, false);      //UI버튼 전체 다 꺼버림
                UI.instance.State_Text[0].SetActive(true);                   //원하는칸 선택하라고 알려줘야 함
                if (Click_Button.instance.ClickDone)
                {
                    if (Click_Button.instance.a != 0 && Click_Button.instance.a != 2 && Click_Button.instance.a != 4 && Click_Button.instance.a != 6)            //숫자칸만 선택가능해야 함
                    {
                        if (Board_Spawn.instance.BoardMoney[Click_Button.instance.a] > 0 && Board_Spawn.instance.BoardMoney[(Click_Button.instance.a + 2) % 8] < 0 && Board_Spawn.instance.BoardMoney[(Click_Button.instance.a + 4) % 8] < 0 && Board_Spawn.instance.BoardMoney[(Click_Button.instance.a + 6) % 8] < 0) { }
                        //바꾸려는 칸이 양수인데 나머지가 모두 음수인 경우 아무것도 안함
                        else if (Board_Spawn.instance.BoardMoney[Click_Button.instance.a] < 0 && Board_Spawn.instance.BoardMoney[(Click_Button.instance.a + 2) % 8] > 0 && Board_Spawn.instance.BoardMoney[(Click_Button.instance.a + 4) % 8] > 0 && Board_Spawn.instance.BoardMoney[(Click_Button.instance.a + 6) % 8] > 0) { }
                        //바꾸려는 칸이 음수인데 나머지가 모두 양수인 경우 아무것도 안함
                        else                                                                                //나머지 경우에만 실행 함 (모두 판단하기 힘들어서 예외인 경우만 처리했음)
                        {
                            photonView.RPC("B_Money_Change_Plus_Minus", RpcTarget.All, Click_Button.instance.a);        //선택한 칸의 숫자의 부호를 바꿔줌
                            photonView.RPC("P_TriFlex_F", RpcTarget.All, 0);                                            //트리플렉스 사용했다고 알려줌
                            photonView.RPC("UIButtonSwitch", RpcTarget.All, true);                                      //숫자 부호 바꾼 후에 UI버튼 다시 켜줌
                            UI.instance.State_Text[0].SetActive(false);                   //트리플렉스 설명서 끄기
                        }

                    }
                    Click_Button.instance.ClickDone = false;                                                    //마우스 클릭 false로 바꿔줌
                }
            }
            else if (Player_Spawn.instance.Player_Is_Prision[0])        // 무브 끝나고 턴 시작할 때, 진행 할 플레이어가 감옥에 있으면
            {
                Debug.Log("감옥칸 턴 넘김");
                photonView.RPC("P_Prison_F", RpcTarget.All, 0); //감옥 트리거를 초기화
                photonView.RPC("Turn_UP", RpcTarget.All);          //턴을 올림

            }
            else if (Player_Spawn.instance.Player_Is_Freedom[0])     //여행칸 밟았을때
            {
                photonView.RPC("UIButtonSwitch", RpcTarget.All, false);      //UI버튼 전체 다 꺼버림
                UI.instance.State_Text[1].SetActive(true);                   //세계여행 설명서
                if (Click_Button.instance.ClickDone)
                {   
                    if(Click_Button.instance.a != 6)            //다시 프리덤칸으로 가면 안됨
                    {
                        photonView.RPC("P_Position_Change", RpcTarget.All, 0, Click_Button.instance.a);             //플레이어 위치를 마우스 클릭한 곳으로 해줌
                        photonView.RPC("P_Moving_On", RpcTarget.All);                                               //움직임 트루로 해줌 무브코드로 가서 UI켜주고 턴 올려주고 무빙 끝나면 알아서 movingdo false됨
                        photonView.RPC("P_Freedom_F", RpcTarget.All, 0);                                            //프리덤 사용했다고 알려줌
                        UI.instance.State_Text[1].SetActive(false);                   //세계여행 끝나면 설명서 꺼줌
                    }
                    Click_Button.instance.ClickDone = false;                                                    //마우스 클릭 false로 바꿔줌
                }
            }
            
        }

        else if (PhotonNetwork.LocalPlayer.ActorNumber == 2 && Board_Spawn.instance.Turn % 3 == 1)             //플레이어 2이고 자기 턴일 때
        {
            if (Player_Spawn.instance.Player_Is_Start[1])     //시작칸 밟았을 때
            {
                photonView.RPC("UIButtonSwitch", RpcTarget.All, false);      //UI버튼 전체 다 꺼버림
                UI.instance.State_Text[2].SetActive(true);                   //시작칸 설명서
                if (Click_Button.instance.ClickDone)
                {
                    if (Click_Button.instance.a != 0 && Click_Button.instance.a != 2 && Click_Button.instance.a != 4 && Click_Button.instance.a != 6)            //점수칸만 클릭 가능해야 함
                    {
                        photonView.RPC("B_Money_Square", RpcTarget.All, Click_Button.instance.a);        //선택한 칸의 숫자를 2배 함
                        photonView.RPC("P_Start_F", RpcTarget.All, 1);                                            //프리덤 사용했다고 알려줌
                        photonView.RPC("UIButtonSwitch", RpcTarget.All, true);                                      //숫자 부호 바꾼 후에 UI버튼 다시 켜줌
                        UI.instance.State_Text[2].SetActive(false);                   //시작칸 설명서 꺼줌
                        if (!Player_Spawn.instance.Player_Is_TriFlex[1])
                        {
                            photonView.RPC("Turn_UP", RpcTarget.All);                                        //턴을 올림
                        }
                    }
                    Click_Button.instance.ClickDone = false;                                                    //마우스 클릭 false로 바꿔줌
                }
            }
            else if (Player_Spawn.instance.Player_Is_TriFlex[1])     //트리플렉스 하고 난 후 한턴 더 진행하기 전에 숫자칸 부호 바꾸기
            {
                photonView.RPC("UIButtonSwitch", RpcTarget.All, false);      //UI버튼 전체 다 꺼버림
                UI.instance.State_Text[0].SetActive(true);                   //원하는칸 선택하라고 알려줘야 함
                if (Click_Button.instance.ClickDone)
                {
                    if (Click_Button.instance.a != 0 && Click_Button.instance.a != 2 && Click_Button.instance.a != 4 && Click_Button.instance.a != 6)            //숫자칸만 선택가능해야 함
                    {
                        if (Board_Spawn.instance.BoardMoney[Click_Button.instance.a] > 0 && Board_Spawn.instance.BoardMoney[(Click_Button.instance.a + 2) % 8] < 0 && Board_Spawn.instance.BoardMoney[(Click_Button.instance.a + 4) % 8] < 0 && Board_Spawn.instance.BoardMoney[(Click_Button.instance.a + 6) % 8] < 0) { }
                        //바꾸려는 칸이 양수인데 나머지가 모두 음수인 경우 아무것도 안함
                        else if (Board_Spawn.instance.BoardMoney[Click_Button.instance.a] < 0 && Board_Spawn.instance.BoardMoney[(Click_Button.instance.a + 2) % 8] > 0 && Board_Spawn.instance.BoardMoney[(Click_Button.instance.a + 4) % 8] > 0 && Board_Spawn.instance.BoardMoney[(Click_Button.instance.a + 6) % 8] > 0) { }
                        //바꾸려는 칸이 음수인데 나머지가 모두 양수인 경우 아무것도 안함
                        else                                                                                //나머지 경우에만 실행 함 (모두 판단하기 힘들어서 예외인 경우만 처리했음)
                        {
                            photonView.RPC("B_Money_Change_Plus_Minus", RpcTarget.All, Click_Button.instance.a);        //선택한 칸의 숫자의 부호를 바꿔줌
                            photonView.RPC("P_TriFlex_F", RpcTarget.All, 1);                                            //트리플렉스 사용했다고 알려줌
                            photonView.RPC("UIButtonSwitch", RpcTarget.All, true);                                      //숫자 부호 바꾼 후에 UI버튼 다시 켜줌
                            UI.instance.State_Text[0].SetActive(false);                   //트리플렉스 설명서 끄기
                        }

                    }
                    Click_Button.instance.ClickDone = false;                                                    //마우스 클릭 false로 바꿔줌
                }
            }
            else if (Player_Spawn.instance.Player_Is_Prision[1])        //턴 시작할 때, 진행 할 플레이어가 감옥에 있으면
            {
                photonView.RPC("P_Prison_F", RpcTarget.All, 1); //감옥 트리거를 초기화
                photonView.RPC("Turn_UP", RpcTarget.All);          //턴을 올림
            }
            else if (Player_Spawn.instance.Player_Is_Freedom[1])     //여행칸 밟았을때
            {
                photonView.RPC("UIButtonSwitch", RpcTarget.All, false);      //UI버튼 전체 다 꺼버림
                UI.instance.State_Text[1].SetActive(true);                   //세계여행 설명서
                if (Click_Button.instance.ClickDone)
                {
                    if (Click_Button.instance.a != 6)            //다시 프리덤칸으로 가면 안됨
                    {
                        photonView.RPC("P_Position_Change", RpcTarget.All, 1, Click_Button.instance.a);             //플레이어 위치를 마우스 클릭한 곳으로 해줌
                        photonView.RPC("P_Moving_On", RpcTarget.All);                                               //움직임 트루로 해줌 무브코드로 가서 UI켜주고 턴 올려주고 무빙 끝나면 알아서 movingdo false됨
                        photonView.RPC("P_Freedom_F", RpcTarget.All, 1);                                            //프리덤 사용했다고 알려줌
                        UI.instance.State_Text[1].SetActive(false);                   //세계여행 끝나면 설명서 꺼줌
                    }
                    Click_Button.instance.ClickDone = false;                                                    //마우스 클릭 false로 바꿔줌
                }
            }
        }

        else if (PhotonNetwork.LocalPlayer.ActorNumber == 3 && Board_Spawn.instance.Turn % 3 == 2)             //플레이어 3이고 자기 턴일 때)
        {
            if (Player_Spawn.instance.Player_Is_Start[2])     //시작칸 밟았을 때
            {
                photonView.RPC("UIButtonSwitch", RpcTarget.All, false);      //UI버튼 전체 다 꺼버림
                UI.instance.State_Text[2].SetActive(true);                   //시작칸 설명서
                if (Click_Button.instance.ClickDone)
                {
                    if (Click_Button.instance.a != 0 && Click_Button.instance.a != 2 && Click_Button.instance.a != 4 && Click_Button.instance.a != 6)            //점수칸만 클릭 가능해야 함
                    {
                        photonView.RPC("B_Money_Square", RpcTarget.All, Click_Button.instance.a);        //선택한 칸의 숫자를 2배 함
                        photonView.RPC("P_Start_F", RpcTarget.All, 2);                                            //프리덤 사용했다고 알려줌
                        photonView.RPC("UIButtonSwitch", RpcTarget.All, true);                                      //숫자 부호 바꾼 후에 UI버튼 다시 켜줌
                        UI.instance.State_Text[2].SetActive(false);                   //시작칸 설명서 꺼줌
                        if (!Player_Spawn.instance.Player_Is_TriFlex[2])
                        {
                            photonView.RPC("Turn_UP", RpcTarget.All);                                        //턴을 올림
                        }
                    }
                    Click_Button.instance.ClickDone = false;                                                    //마우스 클릭 false로 바꿔줌
                }
            }
            else if (Player_Spawn.instance.Player_Is_TriFlex[2])     //트리플렉스 하고 난 후 한턴 더 진행하기 전에 숫자칸 부호 바꾸기
            {
                photonView.RPC("UIButtonSwitch", RpcTarget.All, false);      //UI버튼 전체 다 꺼버림
                UI.instance.State_Text[0].SetActive(true);                   //원하는칸 선택하라고 알려줘야 함
                if (Click_Button.instance.ClickDone)
                {
                    if (Click_Button.instance.a != 0 && Click_Button.instance.a != 2 && Click_Button.instance.a != 4 && Click_Button.instance.a != 6)            //숫자칸만 선택가능해야 함
                    {
                        if (Board_Spawn.instance.BoardMoney[Click_Button.instance.a] > 0 && Board_Spawn.instance.BoardMoney[(Click_Button.instance.a + 2) % 8] < 0 && Board_Spawn.instance.BoardMoney[(Click_Button.instance.a + 4) % 8] < 0 && Board_Spawn.instance.BoardMoney[(Click_Button.instance.a + 6) % 8] < 0) { }
                        //바꾸려는 칸이 양수인데 나머지가 모두 음수인 경우 아무것도 안함
                        else if (Board_Spawn.instance.BoardMoney[Click_Button.instance.a] < 0 && Board_Spawn.instance.BoardMoney[(Click_Button.instance.a + 2) % 8] > 0 && Board_Spawn.instance.BoardMoney[(Click_Button.instance.a + 4) % 8] > 0 && Board_Spawn.instance.BoardMoney[(Click_Button.instance.a + 6) % 8] > 0) { }
                        //바꾸려는 칸이 음수인데 나머지가 모두 양수인 경우 아무것도 안함
                        else                                                                                //나머지 경우에만 실행 함 (모두 판단하기 힘들어서 예외인 경우만 처리했음)
                        {
                            photonView.RPC("B_Money_Change_Plus_Minus", RpcTarget.All, Click_Button.instance.a);        //선택한 칸의 숫자의 부호를 바꿔줌
                            photonView.RPC("P_TriFlex_F", RpcTarget.All, 2);                                            //트리플렉스 사용했다고 알려줌
                            photonView.RPC("UIButtonSwitch", RpcTarget.All, true);                                      //숫자 부호 바꾼 후에 UI버튼 다시 켜줌
                            UI.instance.State_Text[0].SetActive(false);                   //트리플렉스 설명서 끄기
                        }

                    }
                    Click_Button.instance.ClickDone = false;                                                    //마우스 클릭 false로 바꿔줌
                }
            }
            else if (Player_Spawn.instance.Player_Is_Prision[2])        //턴 시작할 때, 진행 할 플레이어가 감옥에 있으면
            {
                photonView.RPC("P_Prison_F", RpcTarget.All, 2); //감옥 트리거를 초기화
                photonView.RPC("Turn_UP", RpcTarget.All);          //턴을 올림
            }
            else if (Player_Spawn.instance.Player_Is_Freedom[2])     //여행칸 밟았을때
            {
                photonView.RPC("UIButtonSwitch", RpcTarget.All, false);      //UI버튼 전체 다 꺼버림
                UI.instance.State_Text[1].SetActive(true);                   //세계여행 설명서
                if (Click_Button.instance.ClickDone)
                {
                    if (Click_Button.instance.a != 6)            //다시 프리덤칸으로 가면 안됨
                    {
                        photonView.RPC("P_Position_Change", RpcTarget.All, 2, Click_Button.instance.a);             //플레이어 위치를 마우스 클릭한 곳으로 해줌
                        photonView.RPC("P_Moving_On", RpcTarget.All);                                               //움직임 트루로 해줌 무브코드로 가서 UI켜주고 턴 올려주고 무빙 끝나면 알아서 movingdo false됨
                        photonView.RPC("P_Freedom_F", RpcTarget.All, 2);                                            //프리덤 사용했다고 알려줌
                        UI.instance.State_Text[1].SetActive(false);                   //세계여행 끝나면 설명서 꺼줌
                    }
                    Click_Button.instance.ClickDone = false;                                                    //마우스 클릭 false로 바꿔줌
                }
            }
        }


    }

    [PunRPC]
    public void B_Money_Square(int num1)
    {
        Board_Spawn.instance.Board_Is_Square[num1]++;
        Board_Spawn.instance.BoardMoney[num1] *= 2;
    }

    [PunRPC]
    public void B_Money_Change_Plus_Minus(int num1)
    {
        Board_Spawn.instance.BoardMoney[num1] = -Board_Spawn.instance.BoardMoney[num1];
    }

    [PunRPC]
    public void P_TriFlex_F(int num1)
    {
        Player_Spawn.instance.Player_Is_TriFlex[num1] = false;
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
    public void P_Start_F(int num1)
    {
        Player_Spawn.instance.Player_Is_Start[num1] = false;
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
