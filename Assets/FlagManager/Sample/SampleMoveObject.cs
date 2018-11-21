using UnityEngine;
using System.Collections;

public class SampleMoveObject : MonoBehaviour {

	float y = 0;

	void Update () 
	{
		// "球はフラグが立ってる時に↑、立ってない時は↓へ移動"

		if( FlagManager.Instance.flags[0] == true ){
			y = y + 0.05f;
		}else{
			y = y - 0.05f;
		}

		// 座標を更新

		transform.position = new Vector3(0, y, 0);
	}
}
