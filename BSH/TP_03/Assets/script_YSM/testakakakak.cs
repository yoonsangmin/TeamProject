using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class testakakakak : MonoBehaviourPunCallbacks
{
    public static testakakakak instance;
    public int[] a;

    public int[] localmoney;

    public int localturn; //턴

    public int[] localplayerpos;

    public bool b;

    public int[] boardmoney;


    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            if (Player.instance.player[0].cardselectdone && Player.instance.player[1].cardselectdone && a[0] != 1)
            {
                if (localturn % 3 == 0)
                    localplayerpos[0] += Player.instance.sum_card - 1;
                else if (localturn % 3 == 1)
                    localplayerpos[1] += Player.instance.sum_card - 1;

                
                a[0]++;

               

                //dorara
                //hotonView.RPC("RPCdorara1_T", RpcTarget.All);

            }

            if (!Player.instance.player[0].cardselectdone && !Player.instance.player[1].cardselectdone && a[0] == 1)
            {
                //gogo.instance.dorara1 = true;

                a[0] = 0;
                if(localturn % 3 == 0)
                    localmoney[0] += boardmoney[localplayerpos[0]];
                else if (localturn % 3 == 1)
                    localmoney[1] += boardmoney[localplayerpos[1]];
                //else if (localturn % 3 == 2)
                //    localmoney[2] += Board.instance.gameboard[Player.instance.player[2].player_pos].money;
                localturn++;
            }
        }

        if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            if (Player.instance.player[0].cardselectdone && Player.instance.player[1].cardselectdone && a[0] != 1)
            {
                if (localturn % 3 == 0)
                    localplayerpos[0] += Player.instance.sum_card - 1;
                else if (localturn % 3 == 1)
                    localplayerpos[1] += Player.instance.sum_card - 1;

                //gogo.instance.dorara1 = true;
                a[0]++;


                //dorara
                //photonView.RPC("RPCdorara2_T", RpcTarget.All);

            }

            if (!Player.instance.player[0].cardselectdone && !Player.instance.player[1].cardselectdone && a[0] == 1)
            {
                a[0] = 0;

                if (localturn % 3 == 0)
                    localmoney[0] += boardmoney[localplayerpos[0]];
                else if (localturn % 3 == 1)
                    localmoney[1] += boardmoney[localplayerpos[1]];
                //else if (localturn % 3 == 2)
                //    localmoney[2] += Board.instance.gameboard[Player.instance.player[2].player_pos].money;
                localturn++;
            }
        }

        if (PhotonNetwork.LocalPlayer.ActorNumber == 3)
        {
            if (Player.instance.player[0].cardselectdone && Player.instance.player[1].cardselectdone && Player.instance.player[2].cardselectdone && a[0] != 1)
            {
                a[0]++;

            }

            if (!Player.instance.player[0].cardselectdone && !Player.instance.player[1].cardselectdone && !Player.instance.player[2].cardselectdone && a[0] == 1)
            {
                a[0] = 0;
                localturn++;
            }
        }

    }
}

