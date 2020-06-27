using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class b : MonoBehaviourPunCallbacks
{

    static public b instance;
    //f에 들어갈 코드

    public int num_1 = 0;
    public int num_2 = 0;

    private void Awake()
    {
        instance = this;
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
