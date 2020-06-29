using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Player_Move : MonoBehaviourPunCallbacks
{
    // Update is called once per frame
    void Update()
    {
        if (PhotonNetwork.PlayerList.Length < 3)
        {
            return;
        }


        if (Player_Spawn.instance.Player_MovingDo)
        {
            if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
            {
                if (gameObject == Player_Spawn.instance.Player_Obj[0] && Board_Spawn.instance.Turn % 3 == 0)
                {
                    //0번플레이어 이동
                    transform.position = Vector3.MoveTowards(transform.position, Player_Spawn.instance.PLayer_Cann[Player_Spawn.instance.Player_Previous_Position[0]].transform.position, 0.1f);
                    if(transform.position == Player_Spawn.instance.PLayer_Cann[Player_Spawn.instance.Player_Previous_Position[0]].transform.position)       //이동 중일 떄
                    {
                        if (Player_Spawn.instance.Player_Previous_Position[0] == 0)      //시작칸 밟았을 떄
                        {
                            photonView.RPC("P_money_plus", RpcTarget.All, 0, 2);       //한바퀴 돌았을 때 돈 올려줌
                        }

                        photonView.RPC("P_Prev", RpcTarget.All, 0);     //현재위치 업데이트
                    }
                    if (transform.position == Player_Spawn.instance.PLayer_Cann[Player_Spawn.instance.Player_Position[0] * 3].transform.position)        //이동 끝났을때
                    {
                        photonView.RPC("P_Moving_F", RpcTarget.All);    //무빙 거짓으로 바꾸기
                        photonView.RPC("P_money_plus", RpcTarget.All, 0, Board_Spawn.instance.BoardMoney[Player_Spawn.instance.Player_Position[0]]);        // 돈 올리기



                        if (Player_Spawn.instance.Player_Is_Flex[0] == 2)        //트리플렉스 일 때
                        {

                            photonView.RPC("P_Flex_Init", RpcTarget.All, 0);    //플래그 초기화
                        }
                        else if (Player_Spawn.instance.Player_Is_Flex[0] == 1)        //나머지 플렉스 일 때 턴을 안 올리면 한 턴 더 함
                        {
                            photonView.RPC("P_Flex_Init", RpcTarget.All, 0);    //플래그 초기화
                        }
                        else if (Player_Spawn.instance.Player_Is_Flex[0] == 0)
                        {
                            photonView.RPC("T_UP", RpcTarget.All);          //턴 올리기
                        }

                        //특수칸 밟았을 때 설정해 줘야 함

                        if (Player_Spawn.instance.Player_Position[0] == 2)       //감옥칸 밟았을 때 트리거 줘야함
                        {
                            photonView.RPC("P_Prison", RpcTarget.All, 0, true);
                        }

                        else if (Player_Spawn.instance.Player_Position[0] == 4)      //도네이션칸 밟았을 때
                        {
                            photonView.RPC("P_money_plus", RpcTarget.All, 0, -2);       //밟은 사람 2원 깎음
                            photonView.RPC("P_money_plus", RpcTarget.All, 1, 1);       //다른 사람 1원 올림
                            photonView.RPC("P_money_plus", RpcTarget.All, 2, 1);       //다른 사람 1원 올림
                        }

                        else if (Player_Spawn.instance.Player_Position[0] == 6)       //세계여행칸 밟았을 때 트리거 줘야함
                        {
                            photonView.RPC("P_Freedom", RpcTarget.All, 0, true);
                        }

                        
                        photonView.RPC("P_money_under", RpcTarget.All);         //돈 0보다 작아지면 0으로 하한 제한


                        photonView.RPC("UIButton", RpcTarget.All, true);     //무브 끝나면 턴 스위치 켜주기
                    }
                }
               
            }
            else if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
            {
                if (gameObject == Player_Spawn.instance.Player_Obj[1] && Board_Spawn.instance.Turn % 3 == 1)
                {
                    //0번플레이어 이동
                    transform.position = Vector3.MoveTowards(transform.position, Player_Spawn.instance.PLayer_Cann[Player_Spawn.instance.Player_Previous_Position[1]].transform.position, 0.1f);
                    if (transform.position == Player_Spawn.instance.PLayer_Cann[Player_Spawn.instance.Player_Previous_Position[1]].transform.position)       //이동 중일 떄
                    {
                        if (Player_Spawn.instance.Player_Previous_Position[1] == 1)      //시작칸 밟았을 떄
                        {
                            photonView.RPC("P_money_plus", RpcTarget.All, 1, 2);       //한바퀴 돌았을 때 돈 올려줌
                        }

                        photonView.RPC("P_Prev", RpcTarget.All, 1);     //현재위치 업데이트
                    }
                    if (transform.position == Player_Spawn.instance.PLayer_Cann[Player_Spawn.instance.Player_Position[1] * 3 + 1].transform.position)        //이동 끝났을때
                    {
                        photonView.RPC("P_Moving_F", RpcTarget.All);    //무빙 거짓으로 바꾸기
                        photonView.RPC("P_money_plus", RpcTarget.All, 1, Board_Spawn.instance.BoardMoney[Player_Spawn.instance.Player_Position[1]]);        //돈 올리기


                        if (Player_Spawn.instance.Player_Is_Flex[1] == 2)        //트리플렉스 일 때
                        {

                            photonView.RPC("P_Flex_Init", RpcTarget.All, 1);    //플래그 초기화
                        }
                        else if (Player_Spawn.instance.Player_Is_Flex[1] == 1)        //나머지 플렉스 일 때 턴을 안 올리면 한 턴 더 함
                        {
                            photonView.RPC("P_Flex_Init", RpcTarget.All, 1);    //플래그 초기화
                        }
                        else if (Player_Spawn.instance.Player_Is_Flex[1] == 0)
                        {
                            photonView.RPC("T_UP", RpcTarget.All);          //턴 올리기
                        }

                        //특수칸 밟았을 때 설정해 줘야 함

                        if (Player_Spawn.instance.Player_Position[1] == 2)       //감옥칸 밟았을 때 트리거 줘야함
                        {
                            photonView.RPC("P_Prison", RpcTarget.All, 1, true);
                        }

                        else if (Player_Spawn.instance.Player_Position[1] == 4)      //도네이션칸 밟았을 때
                        {
                            photonView.RPC("P_money_plus", RpcTarget.All, 1, -2);       //밟은 사람 2원 깎음
                            photonView.RPC("P_money_plus", RpcTarget.All, 0, 1);       //다른 사람 1원 올림
                            photonView.RPC("P_money_plus", RpcTarget.All, 2, 1);       //다른 사람 1원 올림
                        }

                        else if (Player_Spawn.instance.Player_Position[1] == 6)       //세계여행칸 밟았을 때 트리거 줘야함
                        {
                            photonView.RPC("P_Freedom", RpcTarget.All, 1, true);
                        }

                        photonView.RPC("P_money_under", RpcTarget.All);         //돈 0보다 작아지면 0으로 하한 제한

                        

                        photonView.RPC("UIButton", RpcTarget.All, true);     //무브 끝나면 턴 스위치 켜주기
                    }
                }
            }
            else if (PhotonNetwork.LocalPlayer.ActorNumber == 3)
            {
                if (gameObject == Player_Spawn.instance.Player_Obj[2] && Board_Spawn.instance.Turn % 3 == 2)
                {
                    //0번플레이어 이동
                    transform.position = Vector3.MoveTowards(transform.position, Player_Spawn.instance.PLayer_Cann[Player_Spawn.instance.Player_Previous_Position[2]].transform.position, 0.1f);
                    if (transform.position == Player_Spawn.instance.PLayer_Cann[Player_Spawn.instance.Player_Previous_Position[2]].transform.position)       //이동 중일 떄
                    {
                        if (Player_Spawn.instance.Player_Previous_Position[2] == 2)      //시작칸 밟았을 떄
                        {
                            photonView.RPC("P_money_plus", RpcTarget.All, 2, 2);       //한바퀴 돌았을 때 돈 올려줌
                        }

                        photonView.RPC("P_Prev", RpcTarget.All, 2);     //현재위치 업데이트
                    }
                    if (transform.position == Player_Spawn.instance.PLayer_Cann[Player_Spawn.instance.Player_Position[2] * 3 + 2].transform.position)        //이동 끝났을때
                    {
                        photonView.RPC("P_Moving_F", RpcTarget.All);    //무빙 거짓으로 바꾸기
                        photonView.RPC("P_money_plus", RpcTarget.All, 2, Board_Spawn.instance.BoardMoney[Player_Spawn.instance.Player_Position[2]]);        //돈 올리기


                        if (Player_Spawn.instance.Player_Is_Flex[2] == 2)        //트리플렉스 일 때
                        {

                            photonView.RPC("P_Flex_Init", RpcTarget.All, 2);    //플래그 초기화
                        }
                        else if (Player_Spawn.instance.Player_Is_Flex[2] == 1)        //나머지 플렉스 일 때 턴을 안 올리면 한 턴 더 함
                        {
                            photonView.RPC("P_Flex_Init", RpcTarget.All, 2);    //플래그 초기화
                        }
                        else if (Player_Spawn.instance.Player_Is_Flex[2] == 0)
                        {
                            photonView.RPC("T_UP", RpcTarget.All);          //턴 올리기
                        }

                        //특수칸 밟았을 때 설정해 줘야 함

                        if (Player_Spawn.instance.Player_Position[2] == 2)       //감옥칸 밟았을 때 트리거 줘야함
                        {
                            photonView.RPC("P_Prison", RpcTarget.All, 2, true);
                        }

                        else if (Player_Spawn.instance.Player_Position[2] == 4)      //도네이션칸 밟았을 때
                        {
                            photonView.RPC("P_money_plus", RpcTarget.All, 2, -2);       //밟은 사람 2원 깎음
                            photonView.RPC("P_money_plus", RpcTarget.All, 1, 1);       //다른 사람 1원 올림
                            photonView.RPC("P_money_plus", RpcTarget.All, 0, 1);       //다른 사람 1원 올림
                        }

                        else if (Player_Spawn.instance.Player_Position[2] == 6)       //세계여행칸 밟았을 때 트리거 줘야함
                        {
                            photonView.RPC("P_Freedom", RpcTarget.All, 2, true);
                        }

                        photonView.RPC("P_money_under", RpcTarget.All);         //돈 0보다 작아지면 0으로 하한 제한

                     

                        photonView.RPC("UIButton", RpcTarget.All, true);     //무브 끝나면 턴 스위치 켜주기
                    }
                }
            }
        }
       
           
    }

    [PunRPC]
    public void UIButton(bool num1)
    {
        Card_Spawn.instance.CardSelectButton.SetActive(num1);
    }

    [PunRPC]
    public void P_Freedom(int num1, bool num2)
    {
        Player_Spawn.instance.Player_Is_Freedom[num1] = num2;
    }

    [PunRPC]
    public void P_Prison(int num1, bool num2)
    {
        Player_Spawn.instance.Player_Is_Prision[num1] = num2;
    }

    [PunRPC]
    public void P_Prev(int num1)
    {
        Player_Spawn.instance.Player_Previous_Position[num1] += 3;
        Player_Spawn.instance.Player_Previous_Position[num1] %= 24;
    }

    [PunRPC]
    public void P_Moving_F()
    {
        Player_Spawn.instance.Player_MovingDo = false;
    }

    [PunRPC]
    public void T_UP()
    {
        Board_Spawn.instance.Turn++;
    }

    [PunRPC]
    public void P_Flex_Init(int num1)
    {
        Player_Spawn.instance.Player_Is_Flex[num1] = 0;
    }

    [PunRPC]
    public void P_money_plus(int num1, int num2)
    {
        Player_Spawn.instance.Player_Money[num1] += num2;
    }

    [PunRPC]
    public void P_money_under()
    {
        if (Player_Spawn.instance.Player_Money[0] < 0)
        {
            Player_Spawn.instance.Player_Money[0] = 0;
        }
        if (Player_Spawn.instance.Player_Money[1] < 0)
        {
            Player_Spawn.instance.Player_Money[1] = 0;
        }
        if (Player_Spawn.instance.Player_Money[2] < 0)
        {
            Player_Spawn.instance.Player_Money[2] = 0;
        }
    } 
}
