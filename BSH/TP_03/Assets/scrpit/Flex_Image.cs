using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flex_Image : MonoBehaviour
{
    public GameObject FlexImage;
    public GameObject DoubleFlexImage;
    public GameObject TriFlexImage;

    float timer = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if(Player_Spawn.instance.Player_Is_Flex[Board_Spawn.instance.Turn % 3] == 0 && timer < 0.0f)
        {
            FlexImage.SetActive(false);
            DoubleFlexImage.SetActive(false);
            TriFlexImage.SetActive(false);
            timer = 1.0f;
        }
        else if (Player_Spawn.instance.Player_Is_Flex[Board_Spawn.instance.Turn % 3] == 1)
        {
            FlexImage.SetActive(true);
            timer -= Time.deltaTime;
        }
        else if (Player_Spawn.instance.Player_Is_Flex[Board_Spawn.instance.Turn % 3] == 2)
        {
            DoubleFlexImage.SetActive(true);
            timer -= Time.deltaTime;
        }
        else if (Player_Spawn.instance.Player_Is_Flex[Board_Spawn.instance.Turn % 3] == 3)
        {
            TriFlexImage.SetActive(true);
            timer -= Time.deltaTime;
        }
        else if(timer < 1.0f)
        {
            timer -= Time.deltaTime;
        }
    }
}
