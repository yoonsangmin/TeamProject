using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchRoom : MonoBehaviour
{
    public static SearchRoom instance;

    public GameObject SearchRoomImage;

    public bool Is_SearchLoading;
    public bool Is_SearchLoading_Done;

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
