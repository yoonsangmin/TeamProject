using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gogo : MonoBehaviour
{
    public int startcann = 0;       //현재 있는 위치의 칸
    public int nowcann = 3;         //다음 칸

    public int momoney;

    public int suntac;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //if (Player.instance.player[Turn.instance.turn_number % 3].is_onstart == true)       //시작칸을 밟았을때
        //{
        //    if(true)                    //칸 선택 특수 칸은 선택할 수 없음
        //    {
        //        Board.instance.gameboard[suntac].money *= 2;
        //        Board.instance.gameboard[suntac].trigger_a++;
        //    }

        //    Player.instance.player[Turn.instance.turn_number % 3].is_onstart = false;

        //    Turn.instance.turn_number++;
        //    Turn.instance.card_sum = 0;
        //}

        if (Player.instance.player[Turn.instance.turn_number % 3].cardselectdone) //카드 셀렉트가 세명다 됐을 때로 바꿔야됨
        {
            if (Turn.instance.turn_number % 3 == 0 && gameObject.tag == "J")
            {
                Player.instance.player[Turn.instance.turn_number % 3].is_moving = true;
                transform.position = Vector3.MoveTowards(transform.position, Player.instance.cann[(nowcann) % 24].transform.position, 0.1f);

                if (Player.instance.player[Turn.instance.turn_number % 3].player_pos != nowcann)
                {
                    if (transform.position == Player.instance.cann[(nowcann) % 24].transform.position)
                    {
                        startcann += 3;
                        startcann %= 24;
                        nowcann = startcann + 3;
                        nowcann %= 24;
                    }
                }
                else if(Player.instance.player[Turn.instance.turn_number % 3].player_pos == nowcann)
                {
                    if (transform.position == Player.instance.cann[(Player.instance.player[Turn.instance.turn_number % 3].player_pos) % 24].transform.position)
                    {
                        //3명일때 다 초기화 해줘야 함
                        //Player.instance.player[Turn.instance.turn_number % 3].cardselectdone = false;
                        Player.instance.player[Turn.instance.turn_number % 3].is_moving = false;


                        if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 2 * 3)                              //감옥칸 밟았을 때
                        {
                            Player.instance.player[Turn.instance.turn_number % 3].is_prison = true;
                        }

                        else if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 4 * 3)                              //도네이션칸 밟았을 때
                        {
                            Player.instance.player[Turn.instance.turn_number % 3].player_money -= 2;
                            Player.instance.player[(Turn.instance.turn_number + 1) % 3].player_money++;
                            Player.instance.player[(Turn.instance.turn_number + 2) % 3].player_money++;
                        }


                        else if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 6 * 3)                              //여행칸 밟았을 때
                        {
                            Player.instance.player[Turn.instance.turn_number % 3].is_travel = true;                                 //is travel 이 트루이면 카드를 띄우면 안돼요
                        }

                        //else if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 0)                                  //시작칸 밟았을 때
                        //{
                        //    Player.instance.player[Turn.instance.turn_number % 3].player_money += 2;                                //시작칸 밟았을 때 돈을 줌
                        //    Player.instance.player[Turn.instance.turn_number % 3].is_onstart = true;                                //시작칸 밟았다는 플래그를 트루로 바꿔줌
                        //    Turn.instance.turn_number--;
                        //}

                        else
                        {
                            Player.instance.player[Turn.instance.turn_number % 3].player_money += Board.instance.gameboard[Player.instance.player[Turn.instance.turn_number % 3].player_pos / 3].money;
                        }


                        momoney = Player.instance.player[Turn.instance.turn_number % 3].player_money;

                        if (Player.instance.player[Turn.instance.turn_number % 3].player_money < 0)
                            Player.instance.player[Turn.instance.turn_number % 3].player_money = 0;


                        Turn.instance.turn_number++;
                        Turn.instance.card_sum = 0;
                    }
                }
            }

            else if (Turn.instance.turn_number % 3 == 1 && gameObject.tag == "Q")
            {
                Player.instance.player[Turn.instance.turn_number % 3].is_moving = true;
                transform.position = Vector3.MoveTowards(transform.position, Player.instance.cann[(nowcann + 1) % 24].transform.position, 0.1f);

                if ((Player.instance.player[Turn.instance.turn_number % 3].player_pos + 1) != (nowcann + 1))
                {
                    if (transform.position == Player.instance.cann[(nowcann + 1) % 24].transform.position)
                    {
                        startcann += 3;
                        startcann %= 24;
                        nowcann = startcann + 3;
                        nowcann %= 24;
                    }
                }
                else if ((Player.instance.player[Turn.instance.turn_number % 3].player_pos + 1) == (nowcann + 1))
                {
                    if (transform.position == Player.instance.cann[(Player.instance.player[Turn.instance.turn_number % 3].player_pos + 1) % 24].transform.position)
                    {
                        //Player.instance.player[Turn.instance.turn_number % 3].cardselectdone = false;
                        Player.instance.player[Turn.instance.turn_number % 3].is_moving = false;
                        Player.instance.player[Turn.instance.turn_number % 3].player_money += Board.instance.gameboard[Player.instance.player[Turn.instance.turn_number % 3].player_pos / 3].money;





                        if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 6 * 3)                              //여행 밟았을 때
                        {
                            Player.instance.player[Turn.instance.turn_number % 3].is_travel = true;                                 //is travel 이 트루이면 카드를 띄우면 안돼요
                        }


                        if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 4 * 3)                              //도네이션칸 밟았을 때
                        {
                            Player.instance.player[Turn.instance.turn_number % 3].player_money -= 2;
                            Player.instance.player[(Turn.instance.turn_number + 1) % 3].player_money++;
                            Player.instance.player[(Turn.instance.turn_number + 2) % 3].player_money++;
                        }



                        //momoney = Player.instance.player[Turn.instance.turn_number % 3].player_money;

                        if (Player.instance.player[Turn.instance.turn_number % 3].player_money < 0)
                            Player.instance.player[Turn.instance.turn_number % 3].player_money = 0;

                        Turn.instance.turn_number++;
                        Turn.instance.card_sum = 0;
                    }
                }
            }

            else if (Turn.instance.turn_number % 3 == 2 && gameObject.tag == "K")
            {
                Player.instance.player[Turn.instance.turn_number % 3].is_moving = true;
                transform.position = Vector3.MoveTowards(transform.position, Player.instance.cann[(nowcann + 2) % 24].transform.position, 0.1f);

                if ((Player.instance.player[Turn.instance.turn_number % 3].player_pos + 2) != (nowcann + 2))
                {
                    if (transform.position == Player.instance.cann[(nowcann + 2) % 24].transform.position)
                    {
                        startcann += 3;
                        startcann %= 24;
                        nowcann = startcann + 3;
                        nowcann %= 24;
                    }
                }
                else if ((Player.instance.player[Turn.instance.turn_number % 3].player_pos + 2) == (nowcann + 2))
                {
                    if (transform.position == Player.instance.cann[(Player.instance.player[Turn.instance.turn_number % 3].player_pos + 2) % 24].transform.position)
                    {
                        //Player.instance.player[Turn.instance.turn_number % 3].cardselectdone = false;
                        Player.instance.player[Turn.instance.turn_number % 3].is_moving = false;
                        Player.instance.player[Turn.instance.turn_number % 3].player_money += Board.instance.gameboard[Player.instance.player[Turn.instance.turn_number % 3].player_pos / 3].money;




                        if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 6 * 3)                              //여행 밟았을 때
                        {
                            Player.instance.player[Turn.instance.turn_number % 3].is_travel = true;                                 //is travel 이 트루이면 카드를 띄우면 안돼요
                        }


                        if (Player.instance.player[Turn.instance.turn_number % 3].player_pos == 4 * 3)                              //도네이션칸 밟았을 때
                        {
                            Player.instance.player[Turn.instance.turn_number % 3].player_money -= 2;
                            Player.instance.player[(Turn.instance.turn_number + 1) % 3].player_money++;
                            Player.instance.player[(Turn.instance.turn_number + 2) % 3].player_money++;
                        }



                        //momoney = Player.instance.player[Turn.instance.turn_number % 3].player_money;

                        if (Player.instance.player[Turn.instance.turn_number % 3].player_money < 0)
                            Player.instance.player[Turn.instance.turn_number % 3].player_money = 0;

                        Turn.instance.turn_number++;
                        Turn.instance.card_sum = 0;
                    }
                }
            }

        }
    }

}
