using UnityEngine;
using System.Collections;

public class NextBasicGUI : MonoBehaviour {

	void OnGUI ()
	{
		GUI.Label(new Rect (200, 200, 100, 32), "Ik ben nummer twee");
	}
}
