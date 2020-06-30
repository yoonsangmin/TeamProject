using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public static UI instance;
    public GameObject[] State_Text;         //0: 트리플렉스 1: 세계여행 2: 시작칸

    private void Awake()
    {
        instance = this;
    }

    public void Gameexit()
    {
        Application.Quit();
    }
}
