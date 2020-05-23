using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //private int a = 0;
    //public int b = 0;

    private float x_pos;

    public GameObject myobject;

    public GameObject C;
    public GameObject Ca;

    // Start is called before the first frame update
    void Start()
    {
        //x_pos = 0;

      

        //Debug.Log("x" + transform.position.x);
        //Debug.Log("y" + transform.position.y);
        //Debug.Log("z" + transform.position.z);
        
        //transform.position = new Vector3(3,5,4);
        
    }

    // Update is called once per frame
    void Update()
    {
        ////Debug.Log(Time.deltaTime);
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Debug.Log("123");

        //}
    }

    private void FixedUpdate()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    x_pos += 0.01f;
        //}

        ////Debug.Log(Time.deltaTime);
        //GameObject.Find("Cube(Clone)").transform.Translate(x_pos, 0.0f, 0.0f);
        ////transform.Rotate(x_pos, 0.0f, 0.0f);

        //if (transform.position.x > 3.0f)
        //{
        //    Destroy(gameObject, 0);
        //}
    }

    private void OnMouseDown()
    {
        Debug.Log("asdfas");

    }

    public void playerSpown()
    {
        Instantiate(myobject, new Vector3(5,  5 , 10), Quaternion.identity);
    }

    public void aaa()
    {
        C.SetActive(false);
        Ca.SetActive(false);
    }

    
}
