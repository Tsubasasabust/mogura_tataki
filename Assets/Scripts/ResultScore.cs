using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour {
    public Text resultText;
    //private int score;
    public int resultScore;
    // Use this for initialization
    void Start () {
        Debug.Log(Score.Instance.score);
        resultScore = Score.Instance.score - 1;
        resultText.text = resultScore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
