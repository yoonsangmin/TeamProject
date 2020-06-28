using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{




    public GameObject setting;
    // Start is called before the first frame update

    public void seachroom()
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
    public void back()
    {

        SceneManager.LoadScene(0);
    }

    public void main()
    {

        SceneManager.LoadScene(2);
    }

}
