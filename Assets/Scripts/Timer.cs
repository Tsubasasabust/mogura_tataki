using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    public Text TimerText;
    private float timer;
    int seconds;
    //private float totalTime;
    // Use this for initialization
    void Start () {
        //StartReset();
        timer = 30.0f;
    }
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        seconds = (int)timer;
        TimerText.text = seconds.ToString();
        if(seconds <= 0){
            
            SceneManager.LoadScene("ResultScene");
        }
    }



}
