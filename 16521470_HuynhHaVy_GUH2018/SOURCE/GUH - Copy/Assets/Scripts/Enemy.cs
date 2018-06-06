using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {

    public GameObject DeathEff;
    public GameObject LoseWall;
    public GameObject SoundEff;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Instantiate(DeathEff, transform.position, Quaternion.identity);
        
        Destroy(gameObject);
        
    }
 
    private void OnTriggerEnter2D(Collider2D collider)
    {
        SceneManager.LoadScene("LostMenu");
    }
}
