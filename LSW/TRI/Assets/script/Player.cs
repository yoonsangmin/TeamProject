using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    static public Player instance;

    public GameObject[] player_model;
    public GameObject[] cann;

    // Start is called before the first frame update
    void Awake() {
        instance = this;
    }

    void Start()
    {

        for (int i = 0; i < 3; i++)
        {
            Instantiate(player_model[i], cann[i].transform.position, Quaternion.identity);

        }


    }

    // Update is called once per frame
    void Update()
    {





        
    }
    
}
