using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    int Point = 0;
    public Text Scoretxt;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Point += 1;
        Scoretxt.text = Point.ToString();
	}
}
