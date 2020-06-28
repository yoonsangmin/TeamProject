using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movecard : MonoBehaviourPunCallbacks
{
    public float[] rotation;
    public float[] delay;
    public bool[] rotate_flag;

    public bool[] aaaaaa;
    public bool[] cccccc;

    bool previousmoving;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (PhotonNetwork.PlayerList.Length < 2)
        {
            return;
        }


        var localPleyerIndex = PhotonNetwork.LocalPlayer.ActorNumber - 1;




        if (Player.instance.player[localPleyerIndex].cardselectdone)
        {
            // Debug.Log("이거 나오면 움직여야함");

            if (localPleyerIndex == 0 && Player.instance.player[localPleyerIndex].player_card == 1)
            {
                //Debug.Log("이거 나오면 카드 1 선택한거임");

                ins_card.instance.cardobj[localPleyerIndex * 3].transform.position = Vector3.MoveTowards(ins_card.instance.cardobj[localPleyerIndex * 3].transform.position, ins_card.instance.card_cann[3].transform.position, 0.1f);


                if (ins_card.instance.cardobj[localPleyerIndex * 3].transform.position == ins_card.instance.card_cann[3].transform.position)
                {
                    photonView.RPC("RPCaaaaaa_T", RpcTarget.All, 0);
                    photonView.RPC("RPCrotate_flag_T", RpcTarget.All, 0);
                }
            }
            else if (localPleyerIndex == 0 && Player.instance.player[localPleyerIndex].player_card == 2)
            {
                ins_card.instance.cardobj[localPleyerIndex * 3 + 1].transform.position = Vector3.MoveTowards(ins_card.instance.cardobj[localPleyerIndex * 3 + 1].transform.position, ins_card.instance.card_cann[3].transform.position, 0.1f);
                if (ins_card.instance.cardobj[localPleyerIndex * 3 + 1].transform.position == ins_card.instance.card_cann[3].transform.position)
                {
                    photonView.RPC("RPCaaaaaa_T", RpcTarget.All, 0);
                    photonView.RPC("RPCrotate_flag_T", RpcTarget.All, 0);
                }
            }
            else if (localPleyerIndex == 0 && Player.instance.player[localPleyerIndex].player_card == 3)
            {
                ins_card.instance.cardobj[localPleyerIndex * 3 + 2].transform.position = Vector3.MoveTowards(ins_card.instance.cardobj[localPleyerIndex * 3 + 2].transform.position, ins_card.instance.card_cann[3].transform.position, 0.1f);
                if (ins_card.instance.cardobj[localPleyerIndex * 3 + 2].transform.position == ins_card.instance.card_cann[3].transform.position)
                {
                    photonView.RPC("RPCaaaaaa_T", RpcTarget.All, 0);
                    photonView.RPC("RPCrotate_flag_T", RpcTarget.All, 0);
                }
            }

            if (localPleyerIndex == 1 && Player.instance.player[localPleyerIndex].player_card == 1)
            {
                ins_card.instance.cardobj[localPleyerIndex * 3].transform.position = Vector3.MoveTowards(ins_card.instance.cardobj[localPleyerIndex * 3].transform.position, ins_card.instance.card_cann[4].transform.position, 0.1f);
                if (ins_card.instance.cardobj[localPleyerIndex * 3].transform.position == ins_card.instance.card_cann[4].transform.position)
                {
                    photonView.RPC("RPCaaaaaa_T", RpcTarget.All, 1);
                    photonView.RPC("RPCrotate_flag_T", RpcTarget.All, 1);
                }
            }
            else if (localPleyerIndex == 1 && Player.instance.player[localPleyerIndex].player_card == 2)
            {
                ins_card.instance.cardobj[localPleyerIndex * 3 + 1].transform.position = Vector3.MoveTowards(ins_card.instance.cardobj[localPleyerIndex * 3 + 1].transform.position, ins_card.instance.card_cann[4].transform.position, 0.1f);
                if (ins_card.instance.cardobj[localPleyerIndex * 3 + 1].transform.position == ins_card.instance.card_cann[4].transform.position)
                {
                    photonView.RPC("RPCaaaaaa_T", RpcTarget.All, 1);
                    photonView.RPC("RPCrotate_flag_T", RpcTarget.All, 1);
                }
            }
            else if (localPleyerIndex == 1 && Player.instance.player[localPleyerIndex].player_card == 3)
            {
                ins_card.instance.cardobj[localPleyerIndex * 3 + 2].transform.position = Vector3.MoveTowards(ins_card.instance.cardobj[localPleyerIndex * 3 + 2].transform.position, ins_card.instance.card_cann[4].transform.position, 0.1f);
                if (ins_card.instance.cardobj[localPleyerIndex * 3 + 2].transform.position == ins_card.instance.card_cann[4].transform.position)
                {
                    photonView.RPC("RPCaaaaaa_T", RpcTarget.All, 1);
                    photonView.RPC("RPCrotate_flag_T", RpcTarget.All, 1);
                }
            }

            if (localPleyerIndex == 2 && Player.instance.player[localPleyerIndex].player_card == 1)
            {
                ins_card.instance.cardobj[localPleyerIndex * 3].transform.position = Vector3.MoveTowards(ins_card.instance.cardobj[localPleyerIndex * 3].transform.position, ins_card.instance.card_cann[5].transform.position, 0.1f);
                //if (ins_card.instance.cardobj[localPleyerIndex * 3].transform.position == ins_card.instance.card_cann[5].transform.position)
                //{
                //    photonView.RPC("RPCaaaaaa_T", RpcTarget.All, 2);
                //}
            }
            else if (localPleyerIndex == 2 && Player.instance.player[localPleyerIndex].player_card == 2)
            {
                ins_card.instance.cardobj[localPleyerIndex * 3 + 1].transform.position = Vector3.MoveTowards(ins_card.instance.cardobj[localPleyerIndex * 3 + 1].transform.position, ins_card.instance.card_cann[5].transform.position, 0.1f);
                //if (ins_card.instance.cardobj[localPleyerIndex * 3 + 1].transform.position == ins_card.instance.card_cann[5].transform.position)
                //{
                //    photonView.RPC("RPCaaaaaa_T", RpcTarget.All, 2);
                //}
            }
            else if (localPleyerIndex == 2 && Player.instance.player[localPleyerIndex].player_card == 3)
            {
                ins_card.instance.cardobj[localPleyerIndex * 3 + 2].transform.position = Vector3.MoveTowards(ins_card.instance.cardobj[localPleyerIndex * 3 + 2].transform.position, ins_card.instance.card_cann[5].transform.position, 0.1f);

                //if (ins_card.instance.cardobj[localPleyerIndex * 3 + 2].transform.position == ins_card.instance.card_cann[5].transform.position)
                //{
                //    photonView.RPC("RPCaaaaaa_T", RpcTarget.All, 2);
                //}
            }
        }

        if (rotate_flag[0] == true && rotate_flag[1] == true)// && aaaaaa[2] == true)     //모두 다 냈을 때로 바꿔줘야 함
        {
            photonView.RPC("RPCaaaaaa_T", RpcTarget.All, localPleyerIndex);




            //플레이어 포즈 바꾸기
            photonView.RPC("RPCplayer_pos", RpcTarget.All);

            
        }



        //회전
        if (rotate_flag[0] && rotate_flag[1])
        {
            if (aaaaaa[0] && aaaaaa[1])
            {
                if (Player.instance.player[0].player_card == 1)
                {
                    if (ins_card.instance.cardobj[0 * 3].transform.position == ins_card.instance.card_cann[3 + 0].transform.position)   
                    {
                        if (rotation[0] > 0.0f)
                        {
                            ins_card.instance.cardobj[0 * 3].transform.eulerAngles = new Vector3(0, 0, rotation[0]);  //로테이션이 이상함
                            //rotation[localPleyerIndex] -= 1.0f;
                            photonView.RPC("RPCrotation", RpcTarget.All, 0);
                        }
                        else
                        {
                            ins_card.instance.cardobj[0 * 3].transform.eulerAngles = new Vector3(0 , 0 , 0);
                        }
                    }
                }
                else if (Player.instance.player[0].player_card == 2)
                {
                    if (ins_card.instance.cardobj[0 * 3 + 1].transform.position == ins_card.instance.card_cann[3 + 0].transform.position)
                    {
                        if (rotation[0] > 0.0f)
                        {
                            ins_card.instance.cardobj[0 * 3 + 1].transform.eulerAngles = new Vector3(0, 0 , rotation[0]);
                            //rotation[localPleyerIndex] -= 1.0f;
                            photonView.RPC("RPCrotation", RpcTarget.All, 0);
                        }
                        else
                        {
                            ins_card.instance.cardobj[0 * 3 + 1].transform.eulerAngles = new Vector3(0 , 0 , 0 );
                        }
                    }
                }
                else if (Player.instance.player[0].player_card == 3)
                {
                    if (ins_card.instance.cardobj[0 * 3 + 2].transform.position == ins_card.instance.card_cann[3 + 0].transform.position)
                    {
                        if (rotation[0] > 0.0f)
                        {
                            ins_card.instance.cardobj[0 * 3 + 2].transform.eulerAngles = new Vector3(0 , 0 , rotation[0]);  //로테이션이 이상함
                            //rotation[localPleyerIndex] -= 1.0f;
                            photonView.RPC("RPCrotation", RpcTarget.All, 0);
                        }
                        else
                        {
                            ins_card.instance.cardobj[0 * 3 + 2].transform.eulerAngles = new Vector3(0 , 0 , 0 );
                        }
                    }
                }




                if (Player.instance.player[1].player_card == 1)
                {
                    if (ins_card.instance.cardobj[1 * 3].transform.position == ins_card.instance.card_cann[3 + 1].transform.position)
                    {
                        if (rotation[1] > 0.0f)
                        {
                            ins_card.instance.cardobj[1 * 3].transform.eulerAngles = new Vector3(0 , 90.0f, rotation[1]);  //로테이션이 이상함
                            //rotation[localPleyerIndex] -= 1.0f;
                            photonView.RPC("RPCrotation", RpcTarget.All, 1);
                        }
                        else
                        {
                            ins_card.instance.cardobj[1 * 3].transform.eulerAngles = new Vector3(0 , 90.0f, 0);
                        }
                    }
                }
                else if (Player.instance.player[1].player_card == 2)
                {
                    if (ins_card.instance.cardobj[1 * 3 + 1].transform.position == ins_card.instance.card_cann[3 + 1].transform.position)
                    {
                        if (rotation[1] > 0.0f)
                        {
                            ins_card.instance.cardobj[1 * 3 + 1].transform.eulerAngles = new Vector3(0, 90.0f, rotation[1]);
                            //rotation[localPleyerIndex] -= 1.0f;
                            photonView.RPC("RPCrotation", RpcTarget.All, 1);
                        }
                        else
                        {
                            ins_card.instance.cardobj[1 * 3 + 1].transform.eulerAngles = new Vector3(0, 90.0f, 0);
                        }
                    }
                }
                else if (Player.instance.player[1].player_card == 3)
                {
                    if (ins_card.instance.cardobj[1 * 3 + 2].transform.position == ins_card.instance.card_cann[3 + 1].transform.position)
                    {
                        if (rotation[1] > 0.0f)
                        {
                            ins_card.instance.cardobj[1 * 3 + 2].transform.eulerAngles = new Vector3(0, 90.0f, rotation[1]);
                            //rotation[localPleyerIndex] -= 1.0f;
                            photonView.RPC("RPCrotation", RpcTarget.All, 1);
                        }
                        else
                        {
                            ins_card.instance.cardobj[1 * 3 + 2].transform.eulerAngles = new Vector3(0, 90.0f, 0);
                        }
                    }
                }





                if (Player.instance.player[2].player_card == 1)
                {
                    if (ins_card.instance.cardobj[2 * 3].transform.position == ins_card.instance.card_cann[3 + 2].transform.position)
                    {
                        if (rotation[2] > 0.0f)
                        {
                            ins_card.instance.cardobj[2 * 3].transform.eulerAngles = new Vector3(0 , -90.0f, rotation[2]);  //로테이션이 이상함
                            //rotation[localPleyerIndex] -= 1.0f;
                            photonView.RPC("RPCrotation", RpcTarget.All, 2);
                        }
                        else
                        {
                            ins_card.instance.cardobj[2 * 3].transform.eulerAngles = new Vector3(0 , -90.0f, 0 );
                        }
                    }
                }
                else if (Player.instance.player[2].player_card == 2)
                {
                    if (ins_card.instance.cardobj[2 * 3 + 1].transform.position == ins_card.instance.card_cann[3 + 2].transform.position)
                    {
                        if (rotation[2] > 0.0f)
                        {
                            ins_card.instance.cardobj[2 * 3 + 1].transform.eulerAngles = new Vector3(0, -90.0f, rotation[2]);  //로테이션이 이상함
                            //rotation[localPleyerIndex] -= 1.0f;
                            photonView.RPC("RPCrotation", RpcTarget.All, 2);
                        }
                        else
                        {
                            ins_card.instance.cardobj[2 * 3 + 1].transform.eulerAngles = new Vector3(0, -90.0f, 0);
                        }
                    }
                }
                else if (Player.instance.player[2].player_card == 3)
                {
                    if (ins_card.instance.cardobj[2 * 3 + 2].transform.position == ins_card.instance.card_cann[3 + 2].transform.position)
                    {
                        if (rotation[2] > 0.0f)
                        {
                            ins_card.instance.cardobj[2 * 3 + 2].transform.eulerAngles = new Vector3(0, -90.0f, rotation[2]);  //로테이션이 이상함
                            //rotation[localPleyerIndex] -= 1.0f;
                            photonView.RPC("RPCrotation", RpcTarget.All, 2 );
                        }
                        else
                        {
                            ins_card.instance.cardobj[2 * 3 + 2].transform.eulerAngles = new Vector3(0, -90.0f, 0);
                        }
                    }
                }
            }

        }


        {
            ////회전
            //if (rotate_flag[localPleyerIndex])// && rotate_flag[1]) //&& rotate_flag[2])
            //{
            //    //for (int i = 0; i < 3; i++)
            //    //{

            //    //}

            //    if (Player.instance.player[localPleyerIndex].player_card == 1)
            //    {
            //        //Debug.Log("이건 무슨 조건이지? ");


            //        if (ins_card.instance.cardobj[localPleyerIndex * 3].transform.position == ins_card.instance.card_cann[3 + localPleyerIndex].transform.position)    //card_cann정리해야함
            //        {
            //            if (rotation[localPleyerIndex] > 0.0f)
            //            {
            //                ins_card.instance.cardobj[localPleyerIndex * 3].transform.eulerAngles = new Vector3(0, 0, rotation[localPleyerIndex]);  //로테이션이 이상함


            //                //rotation[localPleyerIndex] -= 1.0f;
            //                photonView.RPC("RPCrotation", RpcTarget.All, localPleyerIndex);

            //            }
            //            else
            //            {
            //                Debug.Log("@@@");
            //                ins_card.instance.cardobj[localPleyerIndex * 3].transform.eulerAngles = new Vector3(0, 0, 0);

            //                //rotate_flag[localPleyerIndex] = false;

            //                photonView.RPC("RPCrotate_flag_F", RpcTarget.All, localPleyerIndex);

            //                photonView.RPC("RPCcccccc_T", RpcTarget.All, 1);
            //            }
            //        }
            //    }


            //    if (Player.instance.player[localPleyerIndex].player_card == 2)
            //    {
            //        Debug.Log("이건 무슨 조건이지? ");


            //        if (ins_card.instance.cardobj[localPleyerIndex * 3 + 1].transform.position == ins_card.instance.card_cann[3 + localPleyerIndex].transform.position)    //card_cann정리해야함
            //        {
            //            if (rotation[localPleyerIndex] > 0.0f)
            //            {
            //                ins_card.instance.cardobj[localPleyerIndex * 3 + 1].transform.eulerAngles = new Vector3(0, 0, rotation[localPleyerIndex]);


            //                //rotation[localPleyerIndex] -= 1.0f;
            //                photonView.RPC("RPCrotation", RpcTarget.All, localPleyerIndex);

            //            }
            //            else
            //            {
            //                ins_card.instance.cardobj[localPleyerIndex * 3 + 1].transform.eulerAngles = new Vector3(0, 0, 0);


            //                Debug.Log("!!!");

            //                //rotate_flag[localPleyerIndex] = false;

            //                photonView.RPC("RPCrotate_flag_F", RpcTarget.All, localPleyerIndex);

            //                photonView.RPC("RPCcccccc_T", RpcTarget.All, 2);
            //            }
            //        }
            //    }


            //    if (Player.instance.player[localPleyerIndex].player_card == 3)
            //    {
            //        Debug.Log("이건 무슨 조건이지? ");


            //        if (ins_card.instance.cardobj[localPleyerIndex * 3 + 2].transform.position == ins_card.instance.card_cann[3 + localPleyerIndex].transform.position)    //card_cann정리해야함
            //        {
            //            if (rotation[localPleyerIndex] > 0.0f)
            //            {
            //                ins_card.instance.cardobj[localPleyerIndex * 3 + 2].transform.eulerAngles = new Vector3(0, 0, rotation[localPleyerIndex]);


            //                //rotation[localPleyerIndex] -= 1.0f;
            //                photonView.RPC("RPCrotation", RpcTarget.All, localPleyerIndex);

            //            }
            //            else
            //            {
            //                ins_card.instance.cardobj[localPleyerIndex * 3 + 2].transform.eulerAngles = new Vector3(0, 0, 0);


            //                Debug.Log("###");

            //                //rotate_flag[localPleyerIndex] = false;

            //                photonView.RPC("RPCrotate_flag_F", RpcTarget.All, localPleyerIndex);


            //                photonView.RPC("RPCcccccc_T", RpcTarget.All, 3);
            //            }
            //        }
            //    }
            //}
        }

       
        //딜레이주고 다시 원래 위치로 돌아가게 하기
        if (localPleyerIndex == 0 && Player.instance.player[0].player_card == 1)
        {
            if (rotate_flag[0] && rotate_flag[1] && delay[0] > 0.0f)// && cccccc[localPleyerIndex])
            {
                if (ins_card.instance.cardobj[0].transform.position == ins_card.instance.card_cann[3].transform.position)
                {
                    //delay[localPleyerIndex] -= 1.0f;
                    photonView.RPC("RPCdelay", RpcTarget.All, localPleyerIndex);
                }
            }
            else if (rotate_flag[0] && rotate_flag[1] && delay[0] <= 0.0f)
            {
                ins_card.instance.cardobj[0].transform.position = ins_card.instance.card_cann[0].transform.position;

                ins_card.instance.cardobj[0].transform.eulerAngles = new Vector3(0, 0, 180.0f);


                //Player.instance.player[localPleyerIndex].player_card = 0; //카드 선택 해제
                photonView.RPC("RPCplayer_card", RpcTarget.All, localPleyerIndex);


                //elay[localPleyerIndex] = 180.0f;
                photonView.RPC("RPCdelay_I", RpcTarget.All, localPleyerIndex);

                //dorara
                photonView.RPC("RPCdorara1_T", RpcTarget.All);
            }
        }
        else if (localPleyerIndex == 0 && Player.instance.player[0].player_card == 2)
        {
            if (rotate_flag[0] && rotate_flag[1] && delay[0] > 0.0f)// && cccccc[localPleyerIndex])
            {
                if (ins_card.instance.cardobj[1].transform.position == ins_card.instance.card_cann[3].transform.position)
                {
                    //delay[localPleyerIndex] -= 1.0f;
                    photonView.RPC("RPCdelay", RpcTarget.All, localPleyerIndex);
                }
            }
            else if (rotate_flag[0] && rotate_flag[1] && delay[0] <= 0.0f)
            {
                ins_card.instance.cardobj[1].transform.position = ins_card.instance.card_cann[0].transform.position;

                ins_card.instance.cardobj[1].transform.eulerAngles = new Vector3(0, 0, 180.0f);

                //Player.instance.player[localPleyerIndex].player_card = 0; //카드 선택 해제
                photonView.RPC("RPCplayer_card", RpcTarget.All, localPleyerIndex);


                //elay[localPleyerIndex] = 180.0f;
                photonView.RPC("RPCdelay_I", RpcTarget.All, localPleyerIndex);

                //dorara
                photonView.RPC("RPCdorara1_T", RpcTarget.All);
            }
        }
        else if (localPleyerIndex == 0 && Player.instance.player[0].player_card == 3)
        {
            if (rotate_flag[0] && rotate_flag[1] && delay[0] > 0.0f)// && cccccc[localPleyerIndex])
            {
                if (ins_card.instance.cardobj[2].transform.position == ins_card.instance.card_cann[3].transform.position)
                {
                    //delay[localPleyerIndex] -= 1.0f;
                    photonView.RPC("RPCdelay", RpcTarget.All, localPleyerIndex);
                }
            }
            else if (rotate_flag[0] && rotate_flag[1] && delay[0] <= 0.0f)
            {
                ins_card.instance.cardobj[2].transform.position = ins_card.instance.card_cann[0].transform.position;

                ins_card.instance.cardobj[2].transform.eulerAngles = new Vector3(0, 0, 180.0f);

                //Player.instance.player[localPleyerIndex].player_card = 0; //카드 선택 해제
                photonView.RPC("RPCplayer_card", RpcTarget.All, localPleyerIndex);


                //elay[localPleyerIndex] = 180.0f;
                photonView.RPC("RPCdelay_I", RpcTarget.All, localPleyerIndex);

                //dorara
                photonView.RPC("RPCdorara1_T", RpcTarget.All);
            }
        }

        if (localPleyerIndex == 1 && Player.instance.player[1].player_card == 1)
        {
            if (rotate_flag[0] && rotate_flag[1] && delay[1] > 0.0f)// && cccccc[localPleyerIndex])
            {
                if (ins_card.instance.cardobj[1 * 3].transform.position == ins_card.instance.card_cann[4].transform.position)
                {
                    //delay[localPleyerIndex] -= 1.0f;
                    photonView.RPC("RPCdelay", RpcTarget.All, localPleyerIndex);
                }
            }
            else if (rotate_flag[0] && rotate_flag[1] && delay[1] <= 0.0f)
            {
                ins_card.instance.cardobj[1 * 3].transform.position = ins_card.instance.card_cann[1].transform.position;
                ins_card.instance.cardobj[1 * 3].transform.eulerAngles = new Vector3(0, 90.0f, 180.0f);

                //Player.instance.player[localPleyerIndex].player_card = 0; //카드 선택 해제
                photonView.RPC("RPCplayer_card", RpcTarget.All, localPleyerIndex);


                //elay[localPleyerIndex] = 180.0f;
                photonView.RPC("RPCdelay_I", RpcTarget.All, localPleyerIndex);

                //dorara
                photonView.RPC("RPCdorara2_T", RpcTarget.All);
            }
        }
        else if (localPleyerIndex == 1 && Player.instance.player[1].player_card == 2)
        {
            if (rotate_flag[0] && rotate_flag[1] && delay[1] > 0.0f)// && cccccc[localPleyerIndex])
            {
                if (ins_card.instance.cardobj[1 * 3 + 1].transform.position == ins_card.instance.card_cann[4].transform.position)
                {
                    //delay[localPleyerIndex] -= 1.0f;
                    photonView.RPC("RPCdelay", RpcTarget.All, localPleyerIndex);
                }
            }
            else if (rotate_flag[0] && rotate_flag[1] && delay[1] <= 0.0f)
            {
                ins_card.instance.cardobj[1 * 3 + 1].transform.position = ins_card.instance.card_cann[1].transform.position;
                ins_card.instance.cardobj[1 * 3 + 1].transform.eulerAngles = new Vector3(0, 90.0f, 180.0f);

                //Player.instance.player[localPleyerIndex].player_card = 0; //카드 선택 해제
                photonView.RPC("RPCplayer_card", RpcTarget.All, localPleyerIndex);


                //elay[localPleyerIndex] = 180.0f;
                photonView.RPC("RPCdelay_I", RpcTarget.All, localPleyerIndex);

                //dorara
                photonView.RPC("RPCdorara2_T", RpcTarget.All);
            }
        }
        else if (localPleyerIndex == 1 && Player.instance.player[1].player_card == 3)
        {
            if (rotate_flag[0] && rotate_flag[1] && delay[1] > 0.0f)// && cccccc[localPleyerIndex])
            {
                if (ins_card.instance.cardobj[1 * 3 + 2].transform.position == ins_card.instance.card_cann[4].transform.position)
                {
                    //delay[localPleyerIndex] -= 1.0f;
                    photonView.RPC("RPCdelay", RpcTarget.All, localPleyerIndex);
                }
            }
            else if (rotate_flag[0] && rotate_flag[1] && delay[1] <= 0.0f)
            {
                ins_card.instance.cardobj[1 * 3 + 2].transform.position = ins_card.instance.card_cann[1].transform.position;
                ins_card.instance.cardobj[1 * 3 + 2].transform.eulerAngles = new Vector3(0, 90.0f, 180.0f);

                //Player.instance.player[localPleyerIndex].player_card = 0; //카드 선택 해제
                photonView.RPC("RPCplayer_card", RpcTarget.All, localPleyerIndex);


                //elay[localPleyerIndex] = 180.0f;
                photonView.RPC("RPCdelay_I", RpcTarget.All, localPleyerIndex);

                //dorara
                photonView.RPC("RPCdorara2_T", RpcTarget.All);
            }
        }

        if (localPleyerIndex == 2 && Player.instance.player[2].player_card == 1)
        {
            if (rotate_flag[0] && rotate_flag[1] && delay[2] > 0.0f)// && cccccc[localPleyerIndex])
            {
                if (ins_card.instance.cardobj[2 * 3].transform.position == ins_card.instance.card_cann[5].transform.position)
                {
                    //delay[localPleyerIndex] -= 1.0f;
                    photonView.RPC("RPCdelay", RpcTarget.All, localPleyerIndex);
                }
            }
            else if (rotate_flag[0] && rotate_flag[1] && delay[2] <= 0.0f)
            {
                ins_card.instance.cardobj[2 * 3].transform.position = ins_card.instance.card_cann[2].transform.position;
                ins_card.instance.cardobj[2 * 3].transform.eulerAngles = new Vector3(0, -90.0f, 180.0f);

                //Player.instance.player[localPleyerIndex].player_card = 0; //카드 선택 해제
                photonView.RPC("RPCplayer_card", RpcTarget.All, localPleyerIndex);


                //elay[localPleyerIndex] = 180.0f;
                photonView.RPC("RPCdelay_I", RpcTarget.All, localPleyerIndex);

                //dorara
                //photonView.RPC("RPCdorara3_T", RpcTarget.All);
            }
        }
        else if (localPleyerIndex == 2 && Player.instance.player[2].player_card == 2)
        {
            if (rotate_flag[0] && rotate_flag[1] && delay[2] > 0.0f)// && cccccc[localPleyerIndex])
            {
                if (ins_card.instance.cardobj[2 * 3 + 1].transform.position == ins_card.instance.card_cann[5].transform.position)
                {
                    //delay[localPleyerIndex] -= 1.0f;
                    photonView.RPC("RPCdelay", RpcTarget.All, localPleyerIndex);
                }
            }
            else if (rotate_flag[0] && rotate_flag[1] && delay[2] <= 0.0f)
            {
                ins_card.instance.cardobj[2 * 3 + 1].transform.position = ins_card.instance.card_cann[2].transform.position;
                ins_card.instance.cardobj[2 * 3 + 1].transform.eulerAngles = new Vector3(0, -90.0f, 180.0f);


                //Player.instance.player[localPleyerIndex].player_card = 0; //카드 선택 해제
                photonView.RPC("RPCplayer_card", RpcTarget.All, localPleyerIndex);


                //elay[localPleyerIndex] = 180.0f;
                photonView.RPC("RPCdelay_I", RpcTarget.All, localPleyerIndex);

                //dorara
                //photonView.RPC("RPCdorara3_T", RpcTarget.All);
            }
        }
        else if (localPleyerIndex == 2 && Player.instance.player[2].player_card == 3)
        {
            if (rotate_flag[0] && rotate_flag[1] && delay[2] > 0.0f)// && cccccc[localPleyerIndex])
            {
                if (ins_card.instance.cardobj[2 * 3 + 2].transform.position == ins_card.instance.card_cann[5].transform.position)
                {
                    //delay[localPleyerIndex] -= 1.0f;
                    photonView.RPC("RPCdelay", RpcTarget.All, localPleyerIndex);
                }
            }
            else if (rotate_flag[0] && rotate_flag[1] && delay[2] <= 0.0f)
            {
                ins_card.instance.cardobj[2 * 3 + 2].transform.position = ins_card.instance.card_cann[2].transform.position;
                ins_card.instance.cardobj[2 * 3 + 2].transform.eulerAngles = new Vector3(0, -90.0f, 180.0f);


                //Player.instance.player[localPleyerIndex].player_card = 0; //카드 선택 해제
                photonView.RPC("RPCplayer_card", RpcTarget.All, localPleyerIndex);


                //elay[localPleyerIndex] = 180.0f;
                photonView.RPC("RPCdelay_I", RpcTarget.All, localPleyerIndex);

                //dorara
                //photonView.RPC("RPCdorara3_T", RpcTarget.All);
            }
        }

        {
            ////회전 후 딜레이
            //for (int i = 0; i < 3; i++)
            //{
            //    if (Player.instance.player[localPleyerIndex].player_card == i + 1)
            //    {
            //        if (!rotate_flag[0] && !rotate_flag[1] && delay[localPleyerIndex] > 0.0f)// && cccccc[localPleyerIndex])
            //        {
            //            if (ins_card.instance.cardobj[localPleyerIndex * 3 + i].transform.position == ins_card.instance.card_cann[3 + localPleyerIndex].transform.position)
            //            {
            //                //delay[localPleyerIndex] -= 1.0f;
            //                photonView.RPC("RPCdelay", RpcTarget.All, localPleyerIndex);
            //            }
            //        }
            //        else if (!rotate_flag[0] && !rotate_flag[1] && delay[localPleyerIndex] <= 0.0f)
            //        {
            //            ins_card.instance.cardobj[localPleyerIndex * 3 + i].transform.position = ins_card.instance.card_cann[localPleyerIndex].transform.position;
            //            if (localPleyerIndex == 0)
            //            {
            //                ins_card.instance.cardobj[localPleyerIndex * 3 + i].transform.rotation = Quaternion.Euler(0f, 0.0f, 180f);
            //            }
            //            else if (localPleyerIndex == 1)
            //            {
            //                ins_card.instance.cardobj[localPleyerIndex * 3 + i].transform.rotation = Quaternion.Euler(0f, 90.0f, 180f);
            //            }
            //            else if (localPleyerIndex == 2)
            //            {
            //                ins_card.instance.cardobj[localPleyerIndex * 3 + i].transform.rotation = Quaternion.Euler(0f, -90.0f, 180f);
            //            }

            //            //Player.instance.player[localPleyerIndex].player_card = 0; //카드 선택 해제
            //            photonView.RPC("RPCplayer_card", RpcTarget.All, localPleyerIndex);


            //            //elay[localPleyerIndex] = 180.0f;
            //            photonView.RPC("RPCdelay_I", RpcTarget.All, localPleyerIndex);


            //            photonView.RPC("RPCaaaaaa_F", RpcTarget.All, localPleyerIndex);
            //            //photonView.RPC("RPCaaaaaa_F", RpcTarget.All, 1);

            //            //photonView.RPC("RPCcccccc_F", RpcTarget.All, localPleyerIndex);
            //        }
            //    }
            //}
        }


        if (Player.instance.player[0].player_card == 0 && Player.instance.player[1].player_card == 0)          //모두 돌아서 false가 됐을 때
        {
            photonView.RPC("RPCmovedone", RpcTarget.All);

            //Player.instance.player[localPleyerIndex].cardselectdone = false;
            photonView.RPC("RPCcardselectdone", RpcTarget.All, localPleyerIndex);

            //rotation[localPleyerIndex] = 180.0f;
            photonView.RPC("RPCrotation_I", RpcTarget.All, localPleyerIndex);

            photonView.RPC("RPCrotate_flag_F", RpcTarget.All, 0);
            photonView.RPC("RPCrotate_flag_F", RpcTarget.All, 1);
            //photonView.RPC("RPCrotate_flag_F", RpcTarget.All, 2);

            photonView.RPC("RPCaaaaaa_F", RpcTarget.All, 0);
            photonView.RPC("RPCaaaaaa_F", RpcTarget.All, 1);
            //photonView.RPC("RPCaaaaaa_F", RpcTarget.All, 2);



           

        }

    }

    [PunRPC]
    public void RPCmovedone()
    {
        if (previousmoving == true && Player.instance.player[gogo.instance.turn_number % 3].is_moving == false)
        {
            Player.instance.player[gogo.instance.turn_number % 3].player_money += Board.instance.gameboard[Player.instance.player[gogo.instance.turn_number % 3].player_pos % 8].money;
            Debug.Log("player 머니"+Player.instance.player[gogo.instance.turn_number % 3].player_money);
            Debug.Log("보드칸의 머니"+Board.instance.gameboard[Player.instance.player[gogo.instance.turn_number % 3].player_pos % 8].money);
            Debug.Log("면번째 칸인지" + Player.instance.player[gogo.instance.turn_number % 3].player_pos);
            gogo.instance.turn_number++;
        }
        previousmoving = Player.instance.player[gogo.instance.turn_number % 3].is_moving;
        
        
    }


    [PunRPC]
    public void RPCdorara1_T()
    {
        gogo.instance.dorara1 = true;
    }

    [PunRPC]
    public void RPCdorara2_T()
    {
        gogo.instance.dorara2 = true;
    }

    [PunRPC]
    public void RPCdorara3_T()
    {
        gogo.instance.dorara3 = true;
    }

    [PunRPC]
    public void RPCplayer_pos()
    {
        if(Player.instance.sum_card != 0)
        {
            Player.instance.player[gogo.instance.turn_number % 3].player_pos += (Player.instance.sum_card - 1);
            
            Player.instance.sum_card = 0;
        }
    }

    [PunRPC]
    public void RPCaaaaaa_T(int num)
    {
        aaaaaa[num] = true;
    }
    [PunRPC]
    public void RPCaaaaaa_F(int num)
    {
        aaaaaa[num] = false;
    }

    [PunRPC]
    public void RPCccccc_T(int num)
    {
        cccccc[num] = true;
    }
    [PunRPC]
    public void RPCcccccc_F(int num)
    {
        cccccc[num] = false;
    }



    [PunRPC]
    public void RPCrotate_flag_T(int num)
    {
        rotate_flag[num] = true;
    }
    [PunRPC]
    public void RPCrotate_flag_F(int num)
    {
        rotate_flag[num] = false;
    }



    [PunRPC]
    public void RPCrotation(int num)
    {
        rotation[num] -= 1.0f;
    }
    [PunRPC]
    public void RPCrotation_I(int num)
    {
        rotation[num] = 180.0f;
    }



    [PunRPC]
    public void RPCdelay(int num)
    {
        delay[num] -= 1.0f;
    }
    [PunRPC]
    public void RPCdelay_I(int num)
    {
        delay[num] = 300.0f;
    }



    [PunRPC]
    public void RPCplayer_card(int num)
    {
        Player.instance.player[num].player_card = 0; //카드 선택 해제
    }
    [PunRPC]
    public void RPCcardselectdone(int num)
    {
        Player.instance.player[num].cardselectdone = false;
    }


    

}
