using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TableNumUpdate : MonoBehaviour
{
    public GameObject pz1;
    public GameObject pz2;
    public GameObject pz3;
    public GameObject pz4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Board.instance.gameboard[1].money >= 0)
        {
            pz1.gameObject.GetComponent<TextMeshPro>().text = "+" + Board.instance.gameboard[1].money.ToString();
        }
        else
        { 
            pz1.gameObject.GetComponent<TextMeshPro>().text = Board.instance.gameboard[1].money.ToString();
        }

        if (Board.instance.gameboard[3].money >= 0)
        {
            pz2.gameObject.GetComponent<TextMeshPro>().text = "+" + Board.instance.gameboard[3].money.ToString();
        }
        else
        {
            pz2.gameObject.GetComponent<TextMeshPro>().text = Board.instance.gameboard[3].money.ToString();
        }

        if (Board.instance.gameboard[5].money >= 0)
        {
            pz3.gameObject.GetComponent<TextMeshPro>().text = "+" + Board.instance.gameboard[5].money.ToString();
        }
        else
        {
            pz3.gameObject.GetComponent<TextMeshPro>().text = Board.instance.gameboard[5].money.ToString();
        }

        if (Board.instance.gameboard[7].money >= 0)
        {
            pz4.gameObject.GetComponent<TextMeshPro>().text = "+" + Board.instance.gameboard[7].money.ToString();
        }
        else
        {
            pz4.gameObject.GetComponent<TextMeshPro>().text = Board.instance.gameboard[7].money.ToString();
        }

    }
}
