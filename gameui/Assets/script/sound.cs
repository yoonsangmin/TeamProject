using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioClip soundclip;

    // Start is acalled before the first frame update
    void Start()
    {




    }

    // Update is called once per frame
  void playse()

    {

        GetComponent<AudioSource>().clip = soundclip;
        GetComponent<AudioSource>().Play();
    }
}
