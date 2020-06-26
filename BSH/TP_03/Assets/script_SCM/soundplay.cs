using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundplay : MonoBehaviour
{
    public AudioClip soundclip;

    // Start is acalled before the first frame update
    void Start()
    {

        GetComponent<AudioSource>().clip = soundclip;


    }

// Update is called once per frame
public void playse()
    {

        GetComponent<AudioSource>().Play();
    }
}
