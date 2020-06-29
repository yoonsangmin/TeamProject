using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Photon.Pun;

public class Click_Button : MonoBehaviourPunCallbacks
{
    public static Click_Button instance;

    Camera _mainCam = null;
    private bool _mouseState; 
    private GameObject target;
    private Vector3 MousePos;


    public int a;
    public bool ClickDone;

    void Awake()
    {
        instance = this;
        _mainCam = Camera.main;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PhotonNetwork.PlayerList.Length < 3)
        {
            return;
        }

        if (PhotonNetwork.LocalPlayer.ActorNumber == 1 && Board_Spawn.instance.Turn % 3 == 0 && Player_Spawn.instance.Player_Is_Freedom[0] == true)           //플레이어 1이고 자기 턴일 때
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
                        a = 0;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP2")
                    {
                        a = 1;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP3")
                    {
                        a = 2;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP4")
                    {
                        a = 3;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP5")
                    {
                        a = 4;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP6")
                    {
                        a = 5;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP7")
                    {
                        a = 6;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP8")
                    {
                        a = 7;
                        ClickDone = true;
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

            if (_mouseState)
            {
                transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
            else
            {
                transform.localScale = new Vector3(1f, 1f, 1f);
            }
        }

        if (PhotonNetwork.LocalPlayer.ActorNumber == 2 && Board_Spawn.instance.Turn % 3 == 1 && Player_Spawn.instance.Player_Is_Freedom[1] == true)           //플레이어 1이고 자기 턴일 때
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
                        a = 0;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP2")
                    {
                        a = 1;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP3")
                    {
                        a = 2;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP4")
                    {
                        a = 3;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP5")
                    {
                        a = 4;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP6")
                    {
                        a = 5;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP7")
                    {
                        a = 6;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP8")
                    {
                        a = 7;
                        ClickDone = true;
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

            if (_mouseState)
            {
                transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
            else
            {
                transform.localScale = new Vector3(1f, 1f, 1f);
            }
        }

        if (PhotonNetwork.LocalPlayer.ActorNumber == 3 && Board_Spawn.instance.Turn % 3 == 2 && Player_Spawn.instance.Player_Is_Freedom[2] == true)           //플레이어 1이고 자기 턴일 때
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
                        a = 0;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP2")
                    {
                        a = 1;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP3")
                    {
                        a = 2;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP4")
                    {
                        a = 3;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP5")
                    {
                        a = 4;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP6")
                    {
                        a = 5;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP7")
                    {
                        a = 6;
                        ClickDone = true;
                    }
                    else if (target.gameObject.tag == "SP8")
                    {
                        a = 7;
                        ClickDone = true;
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

            if (_mouseState)
            {
                transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
            else
            {
                transform.localScale = new Vector3(1f, 1f, 1f);
            }
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