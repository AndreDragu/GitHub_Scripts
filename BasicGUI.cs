using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class BasicGUI : MonoBehaviour {

	void OnGUI ()
	{
		GUI.contentColor = Color.red;
		GUILayout.Label(gameObject.name);
		if (GUILayout.Button(gameObject.name))
			Debug.Log(gameObject.name);
	}
}
