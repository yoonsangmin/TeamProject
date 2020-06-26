using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    private Animation anim;

    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.instance.jump == true) { 
            anim.Blend("Object_Jump_Ani");
            Player.instance.jump = false;
        }
    }
}
