using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvManager : MonoBehaviour {

    public string LvName;
	// Use this for initialization
	//public void LoadLv(string LvName)
 //   {
 //       SceneManager.LoadScene(LvName);
 //   }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadLv(string LvName)
    {
        SceneManager.LoadScene(LvName);
    }
}
