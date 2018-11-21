using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagFalse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("mogura1"))
        {
            FlagManager.Instance.flags[0] = false;
        }
        if (collision.gameObject.CompareTag("mogura2"))
        {
            FlagManager.Instance.flags[1] = false;
        }
        if (collision.gameObject.CompareTag("mogura3"))
        {
            FlagManager.Instance.flags[2] = false;
        }
        if (collision.gameObject.CompareTag("mogura4"))
        {
            FlagManager.Instance.flags[3] = false;
        }
        if (collision.gameObject.CompareTag("mogura5"))
        {
            FlagManager.Instance.flags[4] = false;
        }
        if (collision.gameObject.CompareTag("mogura6"))
        {
            FlagManager.Instance.flags[5] = false;
        }
        if (collision.gameObject.CompareTag("mogura7"))
        {
            FlagManager.Instance.flags[6] = false;
        }
        if (collision.gameObject.CompareTag("mogura8"))
        {
            FlagManager.Instance.flags[7] = false;
        }
        if (collision.gameObject.CompareTag("mogura9"))
        {
            FlagManager.Instance.flags[8] = false;
        }
    }
}
