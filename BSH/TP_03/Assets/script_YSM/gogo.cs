using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gogo : MonoBehaviourPunCallbacks
{
    public static gogo instance;

    public int[] startcann;       //현재 있는 위치의 칸
    public int[] nowcann;         //다음 칸

    public bool dorara1;
    public bool dorara2;
    public bool dorara3;

    public int turn_number;     //몇번쨰 턴

    public GameObject[] playerchar;

    public int momoney;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        playerchar[0] = GameObject.FindWithTag("J");
        playerchar[1] = GameObject.FindWithTag("Q");
        playerchar[2] = GameObject.FindWithTag("K");
    }

    // Update is called once per frame
    void Update()
    {
        if (!PhotonNetwork.IsMasterClient) //마스터 클라이언트가 아니면 리턴
        {
            return;
        }

        var localPleyerIndex = PhotonNetwork.LocalPlayer.ActorNumber - 1;

        Debug.Log(Player.instance.player[0].player_pos);

        if (dorara1 && dorara2)//&& dorara3 카드 딜레이 끝났을때 도라라 트루
        {
            if (turn_number % 3 == 0)
            {
                //Player.instance.player[turn_number % 3].is_moving = true;

                photonView.RPC("RPCis_moving_T", RpcTarget.All);

                playerchar[0].transform.position = Vector3.MoveTowards(playerchar[0].transform.position, Player.instance.cann[(nowcann[0]) % 24].transform.position, 0.1f);

                if ((Player.instance.player[turn_number % 3].player_pos * 3) % 24 != nowcann[0])
                {
                    if (playerchar[0].transform.position == Player.instance.cann[(nowcann[0]) % 24].transform.position)
                    {
                        startcann[0] += 3;
                        startcann[0] %= 24;
                        nowcann[0] = startcann[0] + 3;
                        nowcann[0] %= 24;
                    }
                }
                else if ((Player.instance.player[turn_number % 3].player_pos * 3) % 24 == nowcann[0])
                {
                    if (playerchar[0].transform.position == Player.instance.cann[(Player.instance.player[turn_number % 3].player_pos * 3) % 24].transform.position)
                    {

                        //if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 2 * 3)                              //감옥칸 밟았을 때
                        //{
                        //    Player.instance.player[Turn.instance.turn_number % 3].is_prison = true;
                        //}

                        //------------------
                        //if (Player.instance.player[turn_number % 3].player_pos == 4 * 3)                              //도네이션칸 밟았을 때
                        //{
                        //    Player.instance.player[turn_number % 3].player_money -= 2;
                        //    Player.instance.player[(turn_number + 1) % 3].player_money++;
                        //    Player.instance.player[(turn_number + 2) % 3].player_money++;
                        //}


                        //else if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 6 * 3)                              //여행칸 밟았을 때
                        //{
                        //    Player.instance.player[Turn.instance.turn_number % 3].is_travel = true;                                 //is travel 이 트루이면 카드를 띄우면 안돼요
                        //}


                        //------------------
                        //else if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 0)                                  //시작칸 밟았을 때
                        //{
                        //    Player.instance.player[Turn.instance.turn_number % 3].player_money += 2;                                //시작칸 밟았을 때 돈을 줌
                        //    Player.instance.player[Turn.instance.turn_number % 3].is_onstart = true;                                //시작칸 밟았다는 플래그를 트루로 바꿔줌
                        //    Turn.instance.turn_number--;
                        //}

                        //else
                        //{
                        //    Player.instance.player[turn_number % 3].player_money += Board.instance.gameboard[Player.instance.player[turn_number % 3].player_pos / 3].money;
                        //}


                        //momoney = Player.instance.player[turn_number % 3].player_money;

                        //------------------
                        //if (Player.instance.player[turn_number % 3].player_money < 0)
                        //    Player.instance.player[turn_number % 3].player_money = 0;

                        //Player.instance.player[turn_number % 3].is_moving = false;

                        photonView.RPC("RPCis_moving_F", RpcTarget.All);

                        turn_number++;
                        dorara1 = false;
                        dorara2 = false;
                        //Debug.Log(turn_number);
                    }
                }
            }

            else if (turn_number % 3 == 1)
            {
                //Player.instance.player[turn_number % 3].is_moving = true;

                photonView.RPC("RPCis_moving_T", RpcTarget.All);

                playerchar[1].transform.position = Vector3.MoveTowards(playerchar[1].transform.position, Player.instance.cann[(nowcann[1]) % 24].transform.position, 0.1f);

                if (((Player.instance.player[turn_number % 3].player_pos * 3) + 1) % 24 != nowcann[1])
                {
                    if (playerchar[1].transform.position == Player.instance.cann[(nowcann[1]) % 24].transform.position)
                    {
                        startcann[1] += 3;
                        startcann[1] %= 24;
                        nowcann[1] = startcann[1] + 3;
                        nowcann[1] %= 24;
                    }
                }
                else if (((Player.instance.player[turn_number % 3].player_pos * 3) + 1) % 24 == nowcann[1])
                {
                    if (playerchar[1].transform.position == Player.instance.cann[((Player.instance.player[turn_number % 3].player_pos * 3) + 1) % 24].transform.position)
                    {

                        //if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 2 * 3)                              //감옥칸 밟았을 때
                        //{
                        //    Player.instance.player[Turn.instance.turn_number % 3].is_prison = true;
                        //}

                        //------------------
                        //if (Player.instance.player[turn_number % 3].player_pos == 4 * 3)                              //도네이션칸 밟았을 때
                        //{
                        //    Player.instance.player[turn_number % 3].player_money -= 2;
                        //    Player.instance.player[(turn_number + 1) % 3].player_money++;
                        //    Player.instance.player[(turn_number + 2) % 3].player_money++;
                        //}


                        //else if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 6 * 3)                              //여행칸 밟았을 때
                        //{
                        //    Player.instance.player[Turn.instance.turn_number % 3].is_travel = true;                                 //is travel 이 트루이면 카드를 띄우면 안돼요
                        //}


                        //------------------
                        //else if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 0)                                  //시작칸 밟았을 때
                        //{
                        //    Player.instance.player[Turn.instance.turn_number % 3].player_money += 2;                                //시작칸 밟았을 때 돈을 줌
                        //    Player.instance.player[Turn.instance.turn_number % 3].is_onstart = true;                                //시작칸 밟았다는 플래그를 트루로 바꿔줌
                        //    Turn.instance.turn_number--;
                        //}

                        //else
                        //{
                        //    Player.instance.player[turn_number % 3].player_money += Board.instance.gameboard[Player.instance.player[turn_number % 3].player_pos / 3].money;
                        //}


                        //momoney = Player.instance.player[turn_number % 3].player_money;

                        //------------------
                        //if (Player.instance.player[turn_number % 3].player_money < 0)
                        //    Player.instance.player[turn_number % 3].player_money = 0;

                        //Player.instance.player[turn_number % 3].is_moving = false;

                        photonView.RPC("RPCis_moving_F", RpcTarget.All);

                        turn_number++;
                        dorara1 = false;
                        dorara2 = false;
                        //dorara3 = false;
                        //Debug.Log(turn_number);
                    }
                }
            }

            else if (turn_number % 3 == 2)
            {
                //Player.instance.player[turn_number % 3].is_moving = true;

                photonView.RPC("RPCis_moving_T", RpcTarget.All);

                playerchar[2].transform.position = Vector3.MoveTowards(playerchar[2].transform.position, Player.instance.cann[(nowcann[2]) % 24].transform.position, 0.1f);

                if (((Player.instance.player[turn_number % 3].player_pos * 3) + 2) % 24 != nowcann[2])
                {
                    if (playerchar[2].transform.position == Player.instance.cann[(nowcann[2]) % 24].transform.position)
                    {
                        startcann[2] += 3;
                        startcann[2] %= 24;
                        nowcann[2] = startcann[2] + 3;
                        nowcann[2] %= 24;
                    }
                }
                else if (((Player.instance.player[turn_number % 3].player_pos * 3) + 2) % 24 == nowcann[2])
                {
                    if (playerchar[2].transform.position == Player.instance.cann[((Player.instance.player[turn_number % 3].player_pos * 3) + 2) % 24].transform.position)
                    {

                        //if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 2 * 3)                              //감옥칸 밟았을 때
                        //{
                        //    Player.instance.player[Turn.instance.turn_number % 3].is_prison = true;
                        //}

                        //------------------
                        //if (Player.instance.player[turn_number % 3].player_pos == 4 * 3)                              //도네이션칸 밟았을 때
                        //{
                        //    Player.instance.player[turn_number % 3].player_money -= 2;
                        //    Player.instance.player[(turn_number + 1) % 3].player_money++;
                        //    Player.instance.player[(turn_number + 2) % 3].player_money++;
                        //}


                        //else if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 6 * 3)                              //여행칸 밟았을 때
                        //{
                        //    Player.instance.player[Turn.instance.turn_number % 3].is_travel = true;                                 //is travel 이 트루이면 카드를 띄우면 안돼요
                        //}


                        //------------------
                        //else if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 0)                                  //시작칸 밟았을 때
                        //{
                        //    Player.instance.player[Turn.instance.turn_number % 3].player_money += 2;                                //시작칸 밟았을 때 돈을 줌
                        //    Player.instance.player[Turn.instance.turn_number % 3].is_onstart = true;                                //시작칸 밟았다는 플래그를 트루로 바꿔줌
                        //    Turn.instance.turn_number--;
                        //}

                        //else
                        //{
                        //    Player.instance.player[turn_number % 3].player_money += Board.instance.gameboard[Player.instance.player[turn_number % 3].player_pos / 3].money;
                        //}


                        //momoney = Player.instance.player[turn_number % 3].player_money;

                        //------------------
                        //if (Player.instance.player[turn_number % 3].player_money < 0)
                        //    Player.instance.player[turn_number % 3].player_money = 0;

                        //Player.instance.player[turn_number % 3].is_moving = false;

                        photonView.RPC("RPCis_moving_F", RpcTarget.All);

                        turn_number++;
                        dorara1 = false;
                        dorara2 = false;
                        //dorara3 = false;
                        //Debug.Log(turn_number);
                    }
                }
            }

            //else if (Turn.instance.turn_number % 3 == 1 && gameObject.tag == "Q")
            //{
            //    Player.instance.player[Turn.instance.turn_number % 3].is_moving = true;
            //    transform.position = Vector3.MoveTowards(transform.position, Player.instance.cann[(nowcann + 1) % 24].transform.position, 0.1f);

            //    if ((Player.instance.player[Turn.instance.turn_number % 3].player_pos + 1) != (nowcann + 1))
            //    {
            //        if (transform.position == Player.instance.cann[(nowcann + 1) % 24].transform.position)
            //        {
            //            startcann += 3;
            //            startcann %= 24;
            //            nowcann = startcann + 3;
            //            nowcann %= 24;
            //        }
            //    }
            //    else if ((Player.instance.player[Turn.instance.turn_number % 3].player_pos + 1) == (nowcann + 1))
            //    {
            //        if (transform.position == Player.instance.cann[(Player.instance.player[Turn.instance.turn_number % 3].player_pos + 1) % 24].transform.position)
            //        {
            //            Player.instance.player[Turn.instance.turn_number % 3].cardselectdone = false;
            //            Player.instance.player[Turn.instance.turn_number % 3].is_moving = false;
            //            Player.instance.player[Turn.instance.turn_number % 3].player_money += Board.instance.gameboard[Player.instance.player[Turn.instance.turn_number % 3].player_pos / 3].money;





            //            if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 6 * 3)                              //여행 밟았을 때
            //            {
            //                Player.instance.player[Turn.instance.turn_number % 3].is_travel = true;                                 //is travel 이 트루이면 카드를 띄우면 안돼요
            //            }


            //            if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 4 * 3)                              //도네이션칸 밟았을 때
            //            {
            //                Player.instance.player[Turn.instance.turn_number % 3].player_money -= 2;
            //                Player.instance.player[(Turn.instance.turn_number + 1) % 3].player_money++;
            //                Player.instance.player[(Turn.instance.turn_number + 2) % 3].player_money++;
            //            }



            //            //momoney = Player.instance.player[Turn.instance.turn_number % 3].player_money;

            //            if (Player.instance.player[Turn.instance.turn_number % 3].player_money < 0)
            //                Player.instance.player[Turn.instance.turn_number % 3].player_money = 0;

            //            Turn.instance.turn_number++;
            //            Turn.instance.card_sum = 0;
            //        }
            //    }
            //}

            //else if (Turn.instance.turn_number % 3 == 2 && gameObject.tag == "K")
            //{
            //    Player.instance.player[Turn.instance.turn_number % 3].is_moving = true;
            //    transform.position = Vector3.MoveTowards(transform.position, Player.instance.cann[(nowcann + 2) % 24].transform.position, 0.1f);

            //    if ((Player.instance.player[Turn.instance.turn_number % 3].player_pos + 2) != (nowcann + 2))
            //    {
            //        if (transform.position == Player.instance.cann[(nowcann + 2) % 24].transform.position)
            //        {
            //            startcann += 3;
            //            startcann %= 24;
            //            nowcann = startcann + 3;
            //            nowcann %= 24;
            //        }
            //    }
            //    else if ((Player.instance.player[Turn.instance.turn_number % 3].player_pos + 2) == (nowcann + 2))
            //    {
            //        if (transform.position == Player.instance.cann[(Player.instance.player[Turn.instance.turn_number % 3].player_pos + 2) % 24].transform.position)
            //        {
            //            Player.instance.player[Turn.instance.turn_number % 3].cardselectdone = false;
            //            Player.instance.player[Turn.instance.turn_number % 3].is_moving = false;
            //            Player.instance.player[Turn.instance.turn_number % 3].player_money += Board.instance.gameboard[Player.instance.player[Turn.instance.turn_number % 3].player_pos / 3].money;




            //            if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 6 * 3)                              //여행 밟았을 때
            //            {
            //                Player.instance.player[Turn.instance.turn_number % 3].is_travel = true;                                 //is travel 이 트루이면 카드를 띄우면 안돼요
            //            }


            //            if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 4 * 3)                              //도네이션칸 밟았을 때
            //            {
            //                Player.instance.player[Turn.instance.turn_number % 3].player_money -= 2;
            //                Player.instance.player[(Turn.instance.turn_number + 1) % 3].player_money++;
            //                Player.instance.player[(Turn.instance.turn_number + 2) % 3].player_money++;
            //            }



            //            //momoney = Player.instance.player[Turn.instance.turn_number % 3].player_money;

            //            if (Player.instance.player[Turn.instance.turn_number % 3].player_money < 0)
            //                Player.instance.player[Turn.instance.turn_number % 3].player_money = 0;

            //            Turn.instance.turn_number++;
            //            Turn.instance.card_sum = 0;
            //        }
            //    }
            //}

        }
    }

    [PunRPC]
    public void RPCis_moving_T()
    {
        Player.instance.player[turn_number % 3].is_moving = true;
    }

    [PunRPC]
    public void RPCis_moving_F()
    {
        Player.instance.player[turn_number % 3].is_moving = false;
    }
}


