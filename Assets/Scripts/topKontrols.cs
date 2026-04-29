using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topKontrols : MonoBehaviour
{

    public int hiz = 1;

    Rigidbody rigidbody_;

    void Start()
    {
        rigidbody_ = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vector = new Vector3(yatay, 0, dikey);

        rigidbody_.AddForce(vector * hiz);
    }
}
