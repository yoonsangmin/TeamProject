using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cardaaaaa : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    //public void ClickCard1()
    //{
    //    if(Player.instance.player[Turn.instance.turn_number % 3].is_moving == false)            //현재턴인 플레이어가 무빙중인지
    //    {
    //        Debug.Log("111");
    //        Player.instance.player[Turn.instance.turn_number % 3].player_card = 1;              //나야 내가 선택한 카드가 1이 됨

    //        Turn.instance.card_sum += Player.instance.player[Turn.instance.turn_number % 3].player_card;            //내가 선택한 카드가 전체에 더해짐

    //        //이거 왜 여기있음?
    //        Player.instance.player[Turn.instance.turn_number % 3].player_pos += Turn.instance.card_sum * 3;     //현재 턴인 플레이어의 값이 변경됨
    //        Player.instance.player[Turn.instance.turn_number % 3].player_pos %= 24;             //현재 턴인 플레이어의 값을 24로 모듈러 연산

    //        Player.instance.player[Turn.instance.turn_number % 3].cardselectdone = true;        //내가 카드 선택을 완료했다고 변경            
    //    }
    //}

    //public void ClickCard2()
    //{
    //    if (Player.instance.player[Turn.instance.turn_number % 3].is_moving == false)
    //    {
    //        Player.instance.player[Turn.instance.turn_number % 3].player_card = 2;

    //        Turn.instance.card_sum += Player.instance.player[Turn.instance.turn_number % 3].player_card;

    //        Player.instance.player[Turn.instance.turn_number % 3].player_pos += Turn.instance.card_sum * 3;

    //        Player.instance.player[Turn.instance.turn_number % 3].player_pos %= 24;

    //        Player.instance.player[Turn.instance.turn_number % 3].cardselectdone = true;
    //    }
    //}

    //public void ClickCard3()                //세명다 같은 카드 냈을때 한번더 하는 코드
    //{
    //    if (true)              //플레이어들의 카드가 모두 같을 때
    //    {
    //        Turn.instance.turn_number--;
    //    }
    //}

    public void ClickCard4()
    {
        //var localPleyerIndex = PhotonNetwork.LocalPlayer.ActorNumber - 1;

        Debug.Log("1111111");

        if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            Debug.Log("플레이어 1 카드 1");
            photonView.RPC("Click_1", RpcTarget.All, 1);
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            Debug.Log("플레이어 2 카드 1");
            photonView.RPC("Click_1", RpcTarget.All, 2);
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 3)
        {
            photonView.RPC("Click_1", RpcTarget.All, 3);
        }
    }

    public void ClickCard5()
    {
        if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            photonView.RPC("Click_2", RpcTarget.All, 1);
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            photonView.RPC("Click_2", RpcTarget.All, 2);
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 3)
        {
            photonView.RPC("Click_2", RpcTarget.All, 3);
        }
    }

    public void ClickCard6()
    {
        if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            photonView.RPC("Click_3", RpcTarget.All, 1);
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            photonView.RPC("Click_3", RpcTarget.All, 2);
        }
        else if (PhotonNetwork.LocalPlayer.ActorNumber == 3)
        {
            photonView.RPC("Click_3", RpcTarget.All, 3);
        }
    }


    [PunRPC]
    public void Click_1(int num)
    {
        if (Player.instance.player[num - 1].cardselectdone == false)
        {
            if (num == 1)
            {
                Debug.Log("일일일일");

                Player.instance.player[num - 1].cardselectdone = true;
                Player.instance.player[num - 1].player_card = 1;

                Player.instance.aaaaaaaaaaaa[num - 1] += 4;
            }
            else if (num == 2)
            {
                Player.instance.player[num - 1].cardselectdone = true;
                Player.instance.player[num - 1].player_card = 1;

                Player.instance.aaaaaaaaaaaa[num - 1] += 4;
            }
            else if (num == 3)
            {
                Player.instance.player[num - 1].cardselectdone = true;
                Player.instance.player[num - 1].player_card = 1;

                Player.instance.aaaaaaaaaaaa[num - 1] += 4;
            }
        }
    }

    [PunRPC]
    public void Click_2(int num)
    {
        if (Player.instance.player[num - 1].cardselectdone == false)
        {
            if (num == 1)
            {
                Player.instance.player[num - 1].cardselectdone = true;
                Player.instance.player[num - 1].player_card = 2;

                Player.instance.aaaaaaaaaaaa[num - 1] += 4;
            }
            else if (num == 2)
            {
                Player.instance.player[num - 1].cardselectdone = true;
                Player.instance.player[num - 1].player_card = 2;

                Player.instance.aaaaaaaaaaaa[num - 1] += 4;
            }
            else if (num == 3)
            {
                Player.instance.player[num - 1].cardselectdone = true;
                Player.instance.player[num - 1].player_card = 2;

                Player.instance.aaaaaaaaaaaa[num - 1] += 4;
            }
        }
    }

    [PunRPC]
    public void Click_3(int num)
    {
        if (Player.instance.player[num - 1].cardselectdone == false)
        {
            if (num == 1)
            {
                Player.instance.player[num - 1].cardselectdone = true;
                Player.instance.player[num - 1].player_card = 3;

                Player.instance.aaaaaaaaaaaa[num - 1] += 4;
            }
            else if (num == 2)
            {
                Player.instance.player[num - 1].cardselectdone = true;
                Player.instance.player[num - 1].player_card = 3;

                Player.instance.aaaaaaaaaaaa[num - 1] += 4;
            }
            else if (num == 3)
            {
                Player.instance.player[num - 1].cardselectdone = true;
                Player.instance.player[num - 1].player_card = 3;

                Player.instance.aaaaaaaaaaaa[num - 1] += 4;
            }
        }
    }

}
