using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class AngelController : MonoBehaviour {
    //private int face=1;
    Rigidbody2D rd;
    float DicrectionX;
    public float MoveSpeed = 10f;
    public Text ScoreBroad;
    int score =0;

    // Use this for initialization
    void Start () {

        rd = GetComponent<Rigidbody2D>();
    }
    //void SetTransformZ(float n)
    //{
    //    transform.position = new Vector3(transform.position.x, transform.position.y,n);
    //}

    // Update is called once per frame
    void FixedUpdate()
    {

        DicrectionX = CrossPlatformInputManager.GetAxis("Horizontal");
        rd.velocity = new Vector2(DicrectionX * MoveSpeed, 0f);
        if(rd.transform.position.x<-8||rd.transform.position.x>8)
        {
            rd.velocity = new Vector2(0, 0);
            if (rd.transform.position.x < -8)
                rd.transform.position = new Vector2(-8f, rd.transform.position.y);
            else if (rd.transform.position.x > 8)
                rd.transform.position = new Vector2(8f, rd.transform.position.y);
                

        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        score += 50;
        ScoreBroad.text = score.ToString();
    }

}
