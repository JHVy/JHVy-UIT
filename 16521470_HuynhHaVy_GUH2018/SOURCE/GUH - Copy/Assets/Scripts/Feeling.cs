using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Feeling : MonoBehaviour
{

    // Use this for initialization
    public float MoveSpeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 BarPos = new Vector3(this.transform.position.x, this.transform.position.y, 0f);
        if (this.transform.position.x < -2.7 || this.transform.position.x > 3.8)
            MoveSpeed = -MoveSpeed;
        BarPos.x = this.transform.position.x + MoveSpeed;
        this.transform.position = BarPos;


    }

}
