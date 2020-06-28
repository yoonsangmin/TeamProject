using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class select_card : MonoBehaviour
{
    public GameObject card;

    int a = 1;
    int b = 2;
    int c = 3;


    public void showcard()
    {
        card.SetActive(true);
     
    }

    public void quit()
    {
        card.SetActive(false);

    }
    public void selectone()
    {
 

        Debug.Log("a");
        
    }

    public void selecttwo()
    {


        Debug.Log("b");
    }


    public void selectthree()
    {

        Debug.Log("c");

    }
    // Start is called before the first frame update

}
