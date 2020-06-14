using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class loadname : MonoBehaviour
{

    public string thename;
    public GameObject inputfield;
    public GameObject textdisplay;


    // Start is called before the first frame update
    public void storename()
    {
        thename = inputfield.GetComponent<Text>().text;
        textdisplay.GetComponent<Text>().text = thename +  "님";
    }


}
