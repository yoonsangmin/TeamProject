using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Card_Move : MonoBehaviourPunCallbacks
{
    void Update()
    {
        if (PhotonNetwork.PlayerList.Length < 3)
        {
            return;
        }

        if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            if (Card_Select.instance.select_num[0] == 1 && gameObject == Card_Spawn.instance.Card_Obj[0])
            {
                transform.position = Vector3.MoveTowards(transform.position, Card_Spawn.instance.Card_Arrive[0].transform.position, 0.1f);

                if (transform.position == Card_Spawn.instance.Card_Arrive[0].transform.position)
                {
                    //도착 완료
                    photonView.RPC("C_1", RpcTarget.All, 0);
                }

                if (Card_Select.instance.Card_Do[0] && Card_Select.instance.Card_Do[1] && Card_Select.instance.Card_Do[2] && !Card_Select.instance.Card_EX[0])  //DO가 다 참일때
                {
                    if (transform.rotation.z > 0)
                    {
                        transform.Rotate(new Vector3(0, 0, -1 * 100 * Time.deltaTime));
                    }
                    else
                    {
                        photonView.RPC("EX", RpcTarget.All, 0, true);
                        transform.eulerAngles = new Vector3(0, 0, 180);
                        transform.position = Card_Spawn.instance.Card_Cann[0].transform.position;
                    }  
                }
                
            }
            else if (Card_Select.instance.select_num[0] == 2 && gameObject == Card_Spawn.instance.Card_Obj[1])
            {
                transform.position = Vector3.MoveTowards(transform.position, Card_Spawn.instance.Card_Arrive[0].transform.position, 0.1f);

                if (transform.position == Card_Spawn.instance.Card_Arrive[0].transform.position)
                {
                    //도착 완료
                    photonView.RPC("C_1", RpcTarget.All, 0);
                }

                if (Card_Select.instance.Card_Do[0] && Card_Select.instance.Card_Do[1] && Card_Select.instance.Card_Do[2] && !Card_Select.instance.Card_EX[0])  //DO가 다 참일때
                {
                    if (transform.rotation.z > 0)
                    {
                        transform.Rotate(new Vector3(0, 0, -1 * 100 * Time.deltaTime));
                    }
                    else
                    {
                        photonView.RPC("EX", RpcTarget.All, 0, true);
                        transform.eulerAngles = new Vector3(0, 0, 180);
                        transform.position = Card_Spawn.instance.Card_Cann[0].transform.position;
                    }
                }
            }
            else if (Card_Select.instance.select_num[0] == 3 && gameObject == Card_Spawn.instance.Card_Obj[2])
            {
                transform.position = Vector3.MoveTowards(transform.position, Card_Spawn.instance.Card_Arrive[0].transform.position, 0.1f);

                if (transform.position == Card_Spawn.instance.Card_Arrive[0].transform.position)
                {
                    //도착 완료
                    photonView.RPC("C_1", RpcTarget.All, 0);
                }

                if (Card_Select.instance.Card_Do[0] && Card_Select.instance.Card_Do[1] && Card_Select.instance.Card_Do[2] && !Card_Select.instance.Card_EX[0])  //DO가 다 참일때
                {
                    if (transform.rotation.z > 0)
                    {
                        transform.Rotate(new Vector3(0, 0, -1 * 100 * Time.deltaTime));
                    }
                    else
                    {
                        photonView.RPC("EX", RpcTarget.All, 0, true);
                        transform.eulerAngles = new Vector3(0, 0, 180);
                        transform.position = Card_Spawn.instance.Card_Cann[0].transform.position;
                    }
                }
            }


            



        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            if (Card_Select.instance.select_num[1] == 1 && gameObject == Card_Spawn.instance.Card_Obj[3])
            {
                transform.position = Vector3.MoveTowards(transform.position, Card_Spawn.instance.Card_Arrive[1].transform.position, 0.1f);

                if (transform.position == Card_Spawn.instance.Card_Arrive[1].transform.position)
                {
                    //도착 완료
                    photonView.RPC("C_1", RpcTarget.All, 1);
                }

                if (Card_Select.instance.Card_Do[0] && Card_Select.instance.Card_Do[1] && Card_Select.instance.Card_Do[2] && !Card_Select.instance.Card_EX[1])  //DO가 다 참일때
                {
                    if (transform.rotation.z > 0)
                    {
                        transform.Rotate(new Vector3(0, 0, -1 * 100 * Time.deltaTime));
                    }
                    else
                    {
                        photonView.RPC("EX", RpcTarget.All, 1, true);
                        transform.eulerAngles = new Vector3(0, -90, 180);
                        transform.position = Card_Spawn.instance.Card_Cann[1].transform.position;
                    }
                }
            }
            else if (Card_Select.instance.select_num[1] == 2 && gameObject == Card_Spawn.instance.Card_Obj[4])
            {
                transform.position = Vector3.MoveTowards(transform.position, Card_Spawn.instance.Card_Arrive[1].transform.position, 0.1f);

                if (transform.position == Card_Spawn.instance.Card_Arrive[1].transform.position)
                {
                    //도착 완료
                    photonView.RPC("C_1", RpcTarget.All, 1);
                }


                if (Card_Select.instance.Card_Do[0] && Card_Select.instance.Card_Do[1] && Card_Select.instance.Card_Do[2] && !Card_Select.instance.Card_EX[1])  //DO가 다 참일때
                {
                    if (transform.rotation.z > 0)
                    {
                        transform.Rotate(new Vector3(0, 0, -1 * 100 * Time.deltaTime));
                    }
                    else
                    {
                        photonView.RPC("EX", RpcTarget.All, 1, true);
                        transform.eulerAngles = new Vector3(0, -90, 180);
                        transform.position = Card_Spawn.instance.Card_Cann[1].transform.position;
                    }
                }
            }
            else if (Card_Select.instance.select_num[1] == 3 && gameObject == Card_Spawn.instance.Card_Obj[5])
            {
                transform.position = Vector3.MoveTowards(transform.position, Card_Spawn.instance.Card_Arrive[1].transform.position, 0.1f);

                if (transform.position == Card_Spawn.instance.Card_Arrive[1].transform.position)
                {
                    //도착 완료
                    photonView.RPC("C_1", RpcTarget.All, 1);
                }


                if (Card_Select.instance.Card_Do[0] && Card_Select.instance.Card_Do[1] && Card_Select.instance.Card_Do[2] && !Card_Select.instance.Card_EX[1])  //DO가 다 참일때
                {
                    if (transform.rotation.z > 0)
                    {
                        transform.Rotate(new Vector3(0, 0, -1 * 100 * Time.deltaTime));
                    }
                    else
                    {
                        photonView.RPC("EX", RpcTarget.All, 1, true);
                        transform.eulerAngles = new Vector3(0, -90, 180);
                        transform.position = Card_Spawn.instance.Card_Cann[1].transform.position;
                    }
                }
            }

        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 3)
        {
            if (Card_Select.instance.select_num[2] == 1 && gameObject == Card_Spawn.instance.Card_Obj[6])
            {
                transform.position = Vector3.MoveTowards(transform.position, Card_Spawn.instance.Card_Arrive[2].transform.position, 0.1f);

                if (transform.position == Card_Spawn.instance.Card_Arrive[2].transform.position)
                {
                    //도착 완료
                    photonView.RPC("C_1", RpcTarget.All, 2);
                }

                if (Card_Select.instance.Card_Do[0] && Card_Select.instance.Card_Do[1] && Card_Select.instance.Card_Do[2] && !Card_Select.instance.Card_EX[2])  //DO가 다 참일때
                {
                    if (transform.rotation.z > 0)
                    {
                        transform.Rotate(new Vector3(0, 0, -1 * 100 * Time.deltaTime));
                    }
                    else
                    {
                        photonView.RPC("EX", RpcTarget.All, 2, true);
                        transform.eulerAngles = new Vector3(0, 90, 180);
                        transform.position = Card_Spawn.instance.Card_Cann[2].transform.position;
                    }
                }
            }
            else if (Card_Select.instance.select_num[2] == 2 && gameObject == Card_Spawn.instance.Card_Obj[7])
            {
                transform.position = Vector3.MoveTowards(transform.position, Card_Spawn.instance.Card_Arrive[2].transform.position, 0.1f);

                if (transform.position == Card_Spawn.instance.Card_Arrive[2].transform.position)
                {
                    //도착 완료
                    photonView.RPC("C_1", RpcTarget.All, 2);
                }

                if (Card_Select.instance.Card_Do[0] && Card_Select.instance.Card_Do[1] && Card_Select.instance.Card_Do[2] && !Card_Select.instance.Card_EX[2])  //DO가 다 참일때
                {
                    if (transform.rotation.z > 0)
                    {
                        transform.Rotate(new Vector3(0, 0, -1 * 100 * Time.deltaTime));
                    }
                    else
                    {
                        photonView.RPC("EX", RpcTarget.All, 2, true);
                        transform.eulerAngles = new Vector3(0, 90, 180);
                        transform.position = Card_Spawn.instance.Card_Cann[2].transform.position;
                    }
                }
            }
            else if (Card_Select.instance.select_num[2] == 3 && gameObject == Card_Spawn.instance.Card_Obj[8])
            {
                transform.position = Vector3.MoveTowards(transform.position, Card_Spawn.instance.Card_Arrive[2].transform.position, 0.1f);

                if (transform.position == Card_Spawn.instance.Card_Arrive[2].transform.position)
                {
                    //도착 완료
                    photonView.RPC("C_1", RpcTarget.All, 2);
                }

                if (Card_Select.instance.Card_Do[0] && Card_Select.instance.Card_Do[1] && Card_Select.instance.Card_Do[2] && !Card_Select.instance.Card_EX[2])  //DO가 다 참일때
                {
                    if (transform.rotation.z > 0)
                    {
                        transform.Rotate(new Vector3(0, 0, -1 * 100 * Time.deltaTime));
                    }
                    else
                    {
                        photonView.RPC("EX", RpcTarget.All, 2, true);
                        transform.eulerAngles = new Vector3(0, 90, 180);
                        transform.position = Card_Spawn.instance.Card_Cann[2].transform.position;
                    }
                }
            }
        }






        if (Card_Select.instance.Card_EX[0] && Card_Select.instance.Card_EX[1] && Card_Select.instance.Card_EX[2]) //다 참일때
        {
            //Do변경
            photonView.RPC("C_2", RpcTarget.All, 0);
            photonView.RPC("C_2", RpcTarget.All, 1);
            photonView.RPC("C_2", RpcTarget.All, 2);


            //몇번째 턴일때
            //카드 선택한 수 포지션에 추가
            //photonView.RPC("P_P", RpcTarget.All, Board_Spawn.instance.Turn % 3, Card_Select.instance.select_num[0] + Card_Select.instance.select_num[1] + Card_Select.instance.select_num[2] - 1);
            Player_Spawn.instance.Player_Position[Board_Spawn.instance.Turn % 3] += (Card_Select.instance.select_num[0] + Card_Select.instance.select_num[1] + Card_Select.instance.select_num[2] - 1);
            Player_Spawn.instance.Player_Position[Board_Spawn.instance.Turn % 3] %= 8;

            //플레이어 이동 시작할때 키는거
            photonView.RPC("P_Moving", RpcTarget.All, true);


            //카드가 선택한 수 초기화
            photonView.RPC("C_3", RpcTarget.All, 0, 0);
            photonView.RPC("C_3", RpcTarget.All, 1, 0);
            photonView.RPC("C_3", RpcTarget.All, 2, 0);

            //EX변경
            photonView.RPC("EX", RpcTarget.All, 0, false);
            photonView.RPC("EX", RpcTarget.All, 1, false);
            photonView.RPC("EX", RpcTarget.All, 2, false);
        }






    }


    [PunRPC]
    public void C_1(int num1)
    {
        Card_Select.instance.Card_Do[num1] = true;
    }

    [PunRPC]
    public void C_2(int num1)
    {
        Card_Select.instance.Card_Do[num1] = false;
    }


    //카드 숫자 초기화
    [PunRPC]
    public void C_3(int num1, int num2)
    {
        Card_Select.instance.select_num[num1] = num2;
    }

    //EX변경
    [PunRPC]
    public void EX(int num1, bool num2)
    {
        Card_Select.instance.Card_EX[num1] = num2;
    }


    //플레이어 포지션 변경
    [PunRPC]
    public void P_P(int num1, int num2)
    {
        Player_Spawn.instance.Player_Position[num1] += num2;
        Player_Spawn.instance.Player_Position[num1] %= 8;
    }


    //플레이어 포지션 변경
    [PunRPC]
    public void P_Moving(bool num1)
    {
        Player_Spawn.instance.Player_MovingDo = num1;
    }
}
