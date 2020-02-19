using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DestroyObject : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject maincamera;
    

    // Use this for initialization
    void Start()
    {
        maincamera = Camera.main.gameObject;
    }

    

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.position.z < maincamera.transform.position.z)
        {
            
            Destroy(this.gameObject);
        }
    }
}