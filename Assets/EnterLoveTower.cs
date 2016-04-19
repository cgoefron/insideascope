﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnterLoveTower : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            Debug.Log("Trigger Level Change");
            StartCoroutine(ChangeLevel());
        }
    }

    IEnumerator ChangeLevel ()
    {
        Debug.Log("People");
        float fadeTime = GameObject.Find("fadeInOut").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        Debug.Log("Places");
		SceneManager.LoadScene("gem1"); //make a win message
    }
}
