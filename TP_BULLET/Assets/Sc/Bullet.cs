﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("aaa");


        if (transform.position.y <= -10)
        {
            gameObject.SetActive(false);
            Debug.Log("bbb");
        }
    }
}
