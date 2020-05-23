using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PERCENT : MonoBehaviour
{
    Text textpencentage;

    // Start is called before the first frame update
    void Start()
    {
        textpencentage = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void textupdate(float value)
    {
        textpencentage.text = Mathf.RoundToInt(value * 100) + "%";

    }
}
