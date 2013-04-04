using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class BasicGUI : MonoBehaviour {

	void OnGUI ()
	{
		GUILayout.Label(gameObject.name);
	}
}
