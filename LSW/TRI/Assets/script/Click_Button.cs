using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Click_Button : MonoBehaviour
{
    Camera _mainCam = null;
    private bool _mouseState; 
    private GameObject target;
    private Vector3 MousePos;

    public int a = 0;

    void Awake()
    {
        _mainCam = Camera.main;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = GetClickedObject();
            
            try
            {
                if (target.Equals(gameObject))
                {
                    _mouseState = true;
                }



                if (target.gameObject.tag == "SP1")
                {

                    a = 1;
                }
                else if (target.gameObject.tag == "SP2")
                {
                    a = 2;
                }
                else if (target.gameObject.tag == "SP3")
                {
                    a = 3;
                }
                else if (target.gameObject.tag == "SP4")
                {
                    a = 4;
                }
                else if (target.gameObject.tag == "SP5")
                {
                    a = 5;
                }
                else if (target.gameObject.tag == "SP6")
                {
                    a = 6;
                }
                else if (target.gameObject.tag == "SP7")
                {
                    a = 7;
                }
                else if (target.gameObject.tag == "SP8")
                {
                    a = 8;
                }
            }

            catch (NullReferenceException ex)
            {

                    Debug.Log(ex);

            }


        }
        else if (Input.GetMouseButtonUp(0))
        {
            _mouseState = false;
        }
        
        if ( _mouseState)
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

  


    }
    

    private GameObject GetClickedObject()
    {
        RaycastHit hit;
        GameObject target = null;
        Ray ray = _mainCam.ScreenPointToRay(Input.mousePosition);
        if ((Physics.Raycast(ray.origin, ray.direction * 10, out hit)))
        {
            target = hit.collider.gameObject;
        }
        return target;
    }
}