using UnityEngine;
using System.Collections;

public class BaseClass : MonoBehaviour {
	
	public string myName;
	
	protected virtual void Start () {
		myName = "Ik ben de base class";
	}

}
