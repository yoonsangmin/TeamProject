using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wide_mode : MonoBehaviour
{

    void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.SetResolution(854, 480, true);
        Screen.fullScreen = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
