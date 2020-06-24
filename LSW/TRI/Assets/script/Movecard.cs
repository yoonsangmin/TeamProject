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
    

    // Start is called before the first frame update
    void Start()
    {
        select_this_card = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(select_this_card == true) { 
            if(gameObject.tag == "1Player_card") { 
            transform.position = Vector3.MoveTowards(transform.position, ins_card.instance.card_cann[9].transform.position, 0.1f);
                goal_in = 9;
            }
            else if (gameObject.tag == "2Player_card")
            {
                transform.position = Vector3.MoveTowards(transform.position, ins_card.instance.card_cann[10].transform.position, 0.1f);
                goal_in = 10;
            }
            else if (gameObject.tag == "3Player_card")
            {
                transform.position = Vector3.MoveTowards(transform.position, ins_card.instance.card_cann[11].transform.position, 0.1f);
                goal_in = 11;
            }
        }

        if (gameObject.tag == "1Player_card") {

            if (transform.position == ins_card.instance.card_cann[goal_in].transform.position)
            {
                if (rotation > 0.0f)
                {
                    transform.eulerAngles = new Vector3(0, 0, rotation);
                    rotation -= 1.0f;
                }
                else
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                }
            }

        }
        else if (gameObject.tag == "2Player_card")
        {

            if (transform.position == ins_card.instance.card_cann[goal_in].transform.position)
            {
                if (rotation > 0.0f)
                {
                    transform.eulerAngles = new Vector3(0, 90f, rotation);
                    rotation -= 1.0f;
                }
                else
                {
                    transform.eulerAngles = new Vector3(0, 90f, 0);
                }
            }
        }

        else if (gameObject.tag == "3Player_card")
        {

            if (transform.position == ins_card.instance.card_cann[goal_in].transform.position)
            {
                if (rotation > 0.0f)
                {
                    transform.eulerAngles = new Vector3(0, -90f, rotation);
                    rotation -= 1.0f;
                }
                else
                {
                    transform.eulerAngles = new Vector3(0, -90f, 0);
                }
            }
        }
    }


}
