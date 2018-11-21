using UnityEngine;
using System.Collections;

public class EscapeGame : MonoBehaviour {

	void Start () 
	{
		FlagManager.Instance.ResetFlags();

		Debug.Log("Stage Start");

	}

	void OnGUI()
	{
		GUILayout.Label("経過時間:" + Time.timeSinceLevelLoad.ToString("000.0"));

		// --------------------------------------------


		if( GUILayout.Button("鍵1を入手") )
		{
			if( FlagManager.Instance.flags[0] == true )
			{

				Debug.Log("鍵1は入手済みだぜ");

			}else{

				Debug.Log("鍵1をゲットだぜ");
				FlagManager.Instance.flags[0] = true;

			}
		}


		// --------------------------------------------



		if( GUILayout.Button("鍵2を入手") )
		{
			if( FlagManager.Instance.flags[1] == true )
			{
				
				Debug.Log("鍵2は入手済みだぜ");
				
			}else{
				
				Debug.Log("鍵2をゲットだぜ");
				FlagManager.Instance.flags[1] = true;
				
			}
		}


		// --------------------------------------------




		if( FlagManager.Instance.flags[2] == true )
		{
			if( GUILayout.Button("レバーを上げる") )
			{

				Debug.Log("レバーを上げたぜ");
				FlagManager.Instance.flags[2] = false;

			}
		}

		if( FlagManager.Instance.flags[2] == false )
		{
			if( GUILayout.Button("れバーを下げる") )
			{
				Debug.Log("れバーを下げるぜ");
				FlagManager.Instance.flags[2] = true;
			}
		}





		// --------------------------------------------



		if( GUILayout.Button("ドアを開ける") )
		{
			if( FlagManager.Instance.flags[0] == true &&
			    FlagManager.Instance.flags[1] == true)
			{

				if( FlagManager.Instance.flags[2] == true )
				{

					Debug.Log("罠が発動して死んだぜ");
					Application.LoadLevel( 0 );

				}else{
				
					Debug.Log("脱出成功だぜ");
					Application.LoadLevel( 0 );

				}


			}else{

				Debug.Log("鍵が足りないぜ");

			}

		}

	}

}
