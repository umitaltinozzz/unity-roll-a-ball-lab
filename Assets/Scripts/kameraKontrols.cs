using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject top;

    Vector3 aradakiMesafe;

    void Start()
    {
        aradakiMesafe = transfrom.position - top.transform.position;
    }

    
    void FixedUpdate()
    {
        transfrom.position = top.transform.position + aradakiMesafe;
    }
}
