using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_scene : MonoBehaviour
{

    public void load_main()
    {
        SceneManager.LoadScene(0);
    }

    public void load_Test()
    {
        SceneManager.LoadScene(1);
    }
    public void load_Test_2()
    {
        SceneManager.LoadScene(2);
    }
}
