using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;


public class Love : MonoBehaviour
{

    public Slider HealthBar;
    public GameObject HateBar;
    public GameObject FeelBar;
    public GameObject DeathEff;
    public float DamperTick;
    public float HealthperClick;
    public float StartHealth;

    bool isClick = false;
    int Timer = 0;
    // Use this for initialization
    void Start()
    {
        HealthBar.value = StartHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Timer++;
        if (Timer == 4*60)
        {
            DamperTick *= 1.25f;
            Timer = 0;
        }
        HealthBar.value -= DamperTick;
        if (HealthBar.value <= 0)
            SceneManager.LoadScene("LostMenu");
        if (isClick)
        {
            HealthBar.value += HealthperClick;
            isClick = false;
            if (FeelBar.transform.position.x > HateBar.transform.position.x && FeelBar.transform.position.x < HateBar.transform.position.x + 1.29)
                SceneManager.LoadScene("LostMenu");

            

            if (HealthBar.value ==1)
                SceneManager.LoadScene("WinMenu");
            Instantiate(DeathEff, transform.position, Quaternion.identity);

        }


    }
    void OnMouseDown()
    {
        isClick = true;

    }

    void OnMouseUp()
    {
        isClick = false;

    }
}
