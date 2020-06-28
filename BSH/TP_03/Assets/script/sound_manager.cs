using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_manager : MonoBehaviour
{
    public AudioSource musicsource;

    // Start is called before the first frame update
    public void setmusicvolume(float volume)
    {

        musicsource.volume = volume;
    }
}
