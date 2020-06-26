using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movecard : MonoBehaviour
{
    public bool select_this_card = false;
    public bool fin_move = false;
    int goal_in = 0;
    public int select_what_number = 0;
    float rotation = 180.0f;
    float delay = 180.0f;

    bool rotate_flag;
   

    // Start is called before the first frame update
    void Start()
    {
        select_this_card = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.instance.player[Player.instance.naaaaa].cardselectdone)
        {
            if (Player.instance.naaaaa == 0 && Player.instance.player[Player.instance.naaaaa].player_card == 1)
            {
                ins_card.instance.cardobj[Player.instance.naaaaa * 3].transform.position = Vector3.MoveTowards(ins_card.instance.cardobj[Player.instance.naaaaa * 3].transform.position, ins_card.instance.card_cann[9].transform.position, 0.1f);
            }
            else if (Player.instance.naaaaa == 0 && Player.instance.player[Player.instance.naaaaa].player_card == 2)
            {
                ins_card.instance.cardobj[Player.instance.naaaaa * 3 + 1].transform.position = Vector3.MoveTowards(ins_card.instance.cardobj[Player.instance.naaaaa * 3 + 1].transform.position, ins_card.instance.card_cann[9].transform.position, 0.1f);
            }
            else if (Player.instance.naaaaa == 0 && Player.instance.player[Player.instance.naaaaa].player_card == 3)
            {
                ins_card.instance.cardobj[Player.instance.naaaaa * 3 + 2].transform.position = Vector3.MoveTowards(ins_card.instance.cardobj[Player.instance.naaaaa * 3 + 2].transform.position, ins_card.instance.card_cann[9].transform.position, 0.1f);
            }

            if (Player.instance.naaaaa == 1 && Player.instance.player[Player.instance.naaaaa].player_card == 1)
            {
                ins_card.instance.cardobj[Player.instance.naaaaa * 3].transform.position = Vector3.MoveTowards(ins_card.instance.cardobj[Player.instance.naaaaa * 3].transform.position, ins_card.instance.card_cann[10].transform.position, 0.1f);
            }
            else if (Player.instance.naaaaa == 1 && Player.instance.player[Player.instance.naaaaa].player_card == 2)
            {
                ins_card.instance.cardobj[Player.instance.naaaaa * 3 + 1].transform.position = Vector3.MoveTowards(ins_card.instance.cardobj[Player.instance.naaaaa * 3 + 1].transform.position, ins_card.instance.card_cann[10].transform.position, 0.1f);
            }
            else if (Player.instance.naaaaa == 1 && Player.instance.player[Player.instance.naaaaa].player_card == 3)
            {
                ins_card.instance.cardobj[Player.instance.naaaaa * 3 + 2].transform.position = Vector3.MoveTowards(ins_card.instance.cardobj[Player.instance.naaaaa * 3 + 2].transform.position, ins_card.instance.card_cann[10].transform.position, 0.1f);
            }

            if (Player.instance.naaaaa == 2 && Player.instance.player[Player.instance.naaaaa].player_card == 1)
            {
                ins_card.instance.cardobj[Player.instance.naaaaa * 3].transform.position = Vector3.MoveTowards(ins_card.instance.cardobj[Player.instance.naaaaa * 3].transform.position, ins_card.instance.card_cann[11].transform.position, 0.1f);
            }
            else if (Player.instance.naaaaa == 2 && Player.instance.player[Player.instance.naaaaa].player_card == 2)
            {
                ins_card.instance.cardobj[Player.instance.naaaaa * 3 + 1].transform.position = Vector3.MoveTowards(ins_card.instance.cardobj[Player.instance.naaaaa * 3 + 1].transform.position, ins_card.instance.card_cann[11].transform.position, 0.1f);
            }
            else if (Player.instance.naaaaa == 2 && Player.instance.player[Player.instance.naaaaa].player_card == 3)
            {
                ins_card.instance.cardobj[Player.instance.naaaaa * 3 + 2].transform.position = Vector3.MoveTowards(ins_card.instance.cardobj[Player.instance.naaaaa * 3 + 2].transform.position, ins_card.instance.card_cann[11].transform.position, 0.1f);
            }
        }

        if(Player.instance.player[0].cardselectdone)     //모두 다 냈을 때로 바꿔줘야 함
        {
            rotate_flag = true;
        }

        if(rotate_flag)           
        {
            for (int i = 0; i < 3; i++)
            {
                if (ins_card.instance.cardobj[Player.instance.naaaaa * 3 + i].transform.position == ins_card.instance.card_cann[9 + Player.instance.naaaaa].transform.position)
                {
                    if (Player.instance.naaaaa == 0)
                    {
                        if (rotation > 0.0f)
                        {
                            ins_card.instance.cardobj[Player.instance.naaaaa * 3 + i].transform.eulerAngles = new Vector3(0, 0, rotation);
                            rotation -= 1.0f;
                        }
                        else
                        {
                            ins_card.instance.cardobj[Player.instance.naaaaa * 3 + i].transform.eulerAngles = new Vector3(0, 0, 0);
                            Player.instance.player[Player.instance.naaaaa * 3 + i].cardselectdone = false;
                        }
                    }
                    if (Player.instance.naaaaa == 1)
                    {
                        if (rotation > 0.0f)
                        {
                            ins_card.instance.cardobj[Player.instance.naaaaa * 3 + i].transform.eulerAngles = new Vector3(0, 90.0f, rotation);
                            rotation -= 1.0f;
                        }
                        else
                        {
                            ins_card.instance.cardobj[Player.instance.naaaaa * 3 + i].transform.eulerAngles = new Vector3(0, 90.0f, 0);
                            Player.instance.player[Player.instance.naaaaa * 3 + i].cardselectdone = false;
                        }
                    }
                    if (Player.instance.naaaaa == 2)
                    {
                        if (rotation > 0.0f)
                        {
                            ins_card.instance.cardobj[Player.instance.naaaaa * 3 + i].transform.eulerAngles = new Vector3(0, -90.0f, rotation);
                            rotation -= 1.0f;       //로테이션은 한 번만 빼기 해 줘야 해서 밑에만 넣어 놓음 어차피 모두 다 뱅글 뱅글 돌아야 함
                        }
                        else
                        {
                            ins_card.instance.cardobj[Player.instance.naaaaa * 3 + i].transform.eulerAngles = new Vector3(0, -90.0f, 0);
                            Player.instance.player[Player.instance.naaaaa * 3 + i].cardselectdone = false;
                        }
                    }
                }
            }
            if (!Player.instance.player[0].cardselectdone)          //모두 돌아서 false가 됐을 때
            {
                rotate_flag = false;
                rotation = 180.0f;
            }
        }
       if(!rotate_flag && delay > 0.0f)
        {
            for (int i = 0; i < 3; i++)
            {
                if (ins_card.instance.cardobj[Player.instance.naaaaa * 3 + i].transform.position == ins_card.instance.card_cann[9 + Player.instance.naaaaa].transform.position)
                {
                    delay -= 1.0f;
                }
            }
        }

        if(!rotate_flag && delay <= 0.0f)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i >= 0 && i < 3)
                {
                    ins_card.instance.cardobj[i].transform.position = ins_card.instance.card_cann[i].transform.position;
                    ins_card.instance.cardobj[i].transform.rotation = Quaternion.Euler(0f, 0.0f, 180f);
                }
                else if (i >= 3 && i < 6)
                {
                    ins_card.instance.cardobj[i].transform.position = ins_card.instance.card_cann[i].transform.position;
                    ins_card.instance.cardobj[i].transform.rotation = Quaternion.Euler(0f, 90.0f, 180f);
                }

                else if (i >= 6 && i < 9)
                {

                    ins_card.instance.cardobj[i].transform.position = ins_card.instance.card_cann[i].transform.position;
                    ins_card.instance.cardobj[i].transform.rotation = Quaternion.Euler(0f, -90.0f, 180f);
                }

            }
            delay = 180.0f;
        }
        

        //if (select_this_card == true) { 
        //    if(gameObject.tag == "1Player_card") { 
        //    transform.position = Vector3.MoveTowards(transform.position, ins_card.instance.card_cann[9].transform.position, 0.1f);
        //        goal_in = 9;
        //    }
        //    else if (gameObject.tag == "2Player_card")
        //    {
        //        transform.position = Vector3.MoveTowards(transform.position, ins_card.instance.card_cann[10].transform.position, 0.1f);
        //        goal_in = 10;
        //    }
        //    else if (gameObject.tag == "3Player_card")
        //    {
        //        transform.position = Vector3.MoveTowards(transform.position, ins_card.instance.card_cann[11].transform.position, 0.1f);
        //        goal_in = 11;
        //    }
        //}

        //if (gameObject.tag == "1Player_card") {

        //    if (transform.position == ins_card.instance.card_cann[goal_in].transform.position)
        //    {
        //        if (rotation > 0.0f)
        //        {
        //            transform.eulerAngles = new Vector3(0, 0, rotation);
        //            rotation -= 1.0f;
        //        }
        //        else
        //        {
        //            transform.eulerAngles = new Vector3(0, 0, 0);
        //        }
        //    }

        //}
        //else if (gameObject.tag == "2Player_card")
        //{

        //    if (transform.position == ins_card.instance.card_cann[goal_in].transform.position)
        //    {
        //        if (rotation > 0.0f)
        //        {
        //            transform.eulerAngles = new Vector3(0, 90f, rotation);
        //            rotation -= 1.0f;
        //        }
        //        else
        //        {
        //            transform.eulerAngles = new Vector3(0, 90f, 0);
        //        }
        //    }
        //}

        //else if (gameObject.tag == "3Player_card")
        //{

        //    if (transform.position == ins_card.instance.card_cann[goal_in].transform.position)
        //    {
        //        if (rotation > 0.0f)
        //        {
        //            transform.eulerAngles = new Vector3(0, -90f, rotation);
        //            rotation -= 1.0f;
        //        }
        //        else
        //        {
        //            transform.eulerAngles = new Vector3(0, -90f, 0);
        //        }
        //    }
        //}
    }


}
