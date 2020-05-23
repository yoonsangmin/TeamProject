using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{

    public GameObject setting;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void quit()
    {
        setting.SetActive(false);

    }
    public void setbtn()
    {

        setting.SetActive(true);
    }
    public void loginbtn()
    {

        SceneManager.LoadScene(1);
    }
}
