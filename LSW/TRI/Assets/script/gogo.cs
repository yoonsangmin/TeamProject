using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gogo : MonoBehaviour
{
    public int startcann = 0;
    public int nowcann = 3;
    public int gocann = 6;

    bool aaaaa = false;

    // Start is called before the first frame update
    void Start()
    {
        aaaaa = true;
    }

    // Update is called once per frame
    void Update()
    {
        //if (nowcann != gocann)
        //{
        //    if (transform.position.z <= Player.instance.cann[tempcann].transform.position.z && aaaaa == true)
        //    {
        //        transform.position = Vector3.Lerp(transform.position, Player.instance.cann[nowcann + 3].transform.position, 0.05f);
        //        Debug.Log("1111");


        //        if (transform.position.z == Player.instance.cann[nowcann + 3].transform.position.z)
        //        {
        //            aaaaa = false;

        //        }



        //    }
        //    else 
        //    {
        //        Debug.Log("하이");
        //        nowcann += 3;
        //        tempcann += 3;
        //    }

        //}
        //else
        //{
        //}

        transform.position = Vector3.MoveTowards(transform.position, Player.instance.cann[(nowcann) % 24].transform.position, 0.1f);

        if(gocann != nowcann)
        {
            if (transform.position == Player.instance.cann[(nowcann) % 24].transform.position)
            {
                Debug.Log("asdasd");

                startcann += 3;
                startcann %= 24;
                nowcann = startcann + 3;
                nowcann %= 24;
            }
        }
        

    }

}
