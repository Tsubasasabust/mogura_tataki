using UnityEngine;
using System.Collections;

public class SampleGUI : MonoBehaviour {


	void OnGUI()
	{
		GUILayout.Label("球はフラグが立ってる時に↑、立ってない時は↓へ移動");

		GUILayout.Label("---");

		if( FlagManager.Instance.flags[0] == true) 
		{
			GUILayout.Label("Flag 0 が立った");
		}else{
			GUILayout.Label("Flag 0 が立っていない");
		}
		if( FlagManager.Instance.flags[1] == true) 
		{
			GUILayout.Label("Flag 1 が立った");
		}else{
			GUILayout.Label("Flag 1 が立っていない");
		}

		if( FlagManager.Instance.flags[2] == true) 
		{
			GUILayout.Label("Flag 2 が立った");
		}else{
			GUILayout.Label("Flag 2 が立っていない");
		}


		GUILayout.Label("--------------");

		if( GUILayout.Button("flag 0 を立てる"))
		{
			FlagManager.Instance.flags[0] = true;
		}
		if( GUILayout.Button("flag 0 を折る"))
		{
			FlagManager.Instance.flags[0] = false;
		}

		GUILayout.Label("--------------");

		if( GUILayout.Button("flag 1 を立てる"))
		{
			FlagManager.Instance.flags[1] = true;
		}
		if( GUILayout.Button("flag 1 を折る"))
		{
			FlagManager.Instance.flags[1] = false;
		}

		GUILayout.Label("--------------");

		if( GUILayout.Button("reset する"))
		{
			FlagManager.Instance.ResetFlags();
		}
	}
}
