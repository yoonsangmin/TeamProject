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
    public int get_number = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (get_number >= 0)
        {
            pz1.gameObject.GetComponent<TextMeshPro>().text = "+" + get_number.ToString();
        }
        else
        { 
            pz1.gameObject.GetComponent<TextMeshPro>().text = get_number.ToString();
        }



    }
}
