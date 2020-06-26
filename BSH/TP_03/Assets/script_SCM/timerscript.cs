using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class timerscript : MonoBehaviour
{
    Image timerbar;
    public float maxtime = 5f;
    float timeleft;
    //public GameObject timeuptext;


    // Start is called before the first frame update
    void Start()
    {

        //timeuptext.SetActive(false);
        timerbar = GetComponent<Image>();
        timeleft = maxtime;

        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(timeleft > 0)
        {

            timeleft -= Time.deltaTime;
            timerbar.fillAmount = timeleft / maxtime;

        }
        else
        {

            //timeuptext.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
