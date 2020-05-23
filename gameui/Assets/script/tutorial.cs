using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    public string[] sentences;


    public void click()
    {
        if(talkmanager.instance.dialoguegroup.alpha ==0)
        {
            talkmanager.instance.ondialogue(sentences);
        }
        
    }
}
