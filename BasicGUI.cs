using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class BasicGUI : MonoBehaviour {
	
	
	
	void OnGUI ()
	{
		GUI.contentColor = Color.red;
		GUILayout.Label(gameObject.name);
	}
}
