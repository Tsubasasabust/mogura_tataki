using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
　  public AudioClip[] clips;
    AudioSource audio;
    private float lebel;

     public float Lebelchange{
        get { return this.lebel; }
        private set { this.lebel = value; }
    }

    public void Setlevel(float setVal) {
        Lebelchange = setVal;
    }

    public void ReplayGame()
    {
        audio = GetComponent<AudioSource>();
		audio.clip = clips[0];
        audio.Play();
        SceneManager.LoadScene("MainScene");
    }

    

}