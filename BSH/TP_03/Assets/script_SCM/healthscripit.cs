using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthscripit : MonoBehaviour
{
    public Transform loadingbar;

    public Transform textloading;
    [SerializeField] private float currentamount;
    [SerializeField] private float speed;

    public GameObject startgame;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(currentamount<100)
        {
            currentamount += speed * Time.deltaTime;
           
            textloading.gameObject.SetActive(true);
        }

        else
        {

            textloading.gameObject.SetActive(false);

            SceneManager.LoadScene(3);

        }
        loadingbar.GetComponent<Image>().fillAmount = currentamount / 100;

    }




}
