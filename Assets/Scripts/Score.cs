using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text scoreText;
    public int score;
    public readonly static Score Instance = new Score();
	// Use this for initialization
	void Start () {
        StartReset();
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = score.ToString();
	}
    private void StartReset(){
        score = 0;
        Score.Instance.score = 0;
    }
    public void AddPoint(int point){
        score = score + point;
        Score.Instance.score = score + point;
    }
    /*public static int getScore(){
        result = score;
        return result;
    }*/

}
