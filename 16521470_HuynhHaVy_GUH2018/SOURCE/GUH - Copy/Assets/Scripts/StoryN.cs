using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryN : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

        StartCoroutine(Release());
    }

        // Update is called once per frame
        void Update () {
		
	}
    IEnumerator Release()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("GamePlayN");
    }
}

