using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ins_card : MonoBehaviour
{
    static public ins_card instance;

    public GameObject[] card_model;
    public GameObject[] card_cann;

    public GameObject[] cardobj;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    void Start()
    {

        for (int i = 0; i < 9; i++)
        {
            if (i >= 0 && i < 3)
            {
                card_model[i].gameObject.tag = "1Player_card";
                cardobj[i] = Instantiate(card_model[i], card_cann[i].transform.position, Quaternion.Euler(0f, 0.0f, 180f));
                
            }
            else if (i >= 3 && i < 6)
            {
                card_model[i].gameObject.tag = "2Player_card";
                cardobj[i] = Instantiate(card_model[i], card_cann[i].transform.position, Quaternion.Euler(0f, 90.0f, 180f));
            }

            else if (i >= 6 && i < 9)
            {

                card_model[i].gameObject.tag = "3Player_card";
                cardobj[i] = Instantiate(card_model[i], card_cann[i].transform.position, Quaternion.Euler(0f, -90.0f, 180f));
            }

        }

        //for (int i = 0; i < 9; i++)
        //{
        //   if(i >= 0 && i < 3)
        //    {
        //        card_model[i % 3].gameObject.tag = "1Player_card";
        //        Instantiate(card_model[i % 3], card_cann[i].transform.position, Quaternion.Euler(0f, 0.0f, 180f));


        //    }
        //    else if (i >= 3 && i < 6)
        //    {
        //        card_model[i % 3].gameObject.tag = "2Player_card";
        //        Instantiate(card_model[i % 3], card_cann[i].transform.position, Quaternion.Euler(0f, 90.0f, 180f));
        //    }

        //    else if (i >= 6 && i < 9)
        //    {

        //        card_model[i % 3].gameObject.tag = "3Player_card";
        //        Instantiate(card_model[i % 3], card_cann[i].transform.position, Quaternion.Euler(0f, -90.0f, 180f));
        //    }

        //}


    }

    // Update is called once per frame
    void Update()
    {

    }
}
