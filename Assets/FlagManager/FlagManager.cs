using UnityEngine;
using System.Collections;

public class FlagManager : MonoBehaviour
{
	private static FlagManager instance = null;
	public static FlagManager Instance 
	{
		get{
			if( instance == null){
				instance = FindObjectOfType<FlagManager>();

				if( instance == null )
				{
					instance = new GameObject("FlagManager").AddComponent<FlagManager>();
				}
			}
			return instance;
		}
	}

	void Awake()
	{
		if( Instance == this )
		{
			DontDestroyOnLoad(gameObject);
		}else{
			Destroy (gameObject);
		}
	}

	public bool[] flags = new bool[128];

	[ContextMenu("ResetFlags")]
	public void ResetFlags()
	{
		flags = new bool[flags.Length];
	}
}