using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDisparo : MonoBehaviour {
	[SerializeField]
	float t = 0.2f;
	// Use this for initialization
	void Start () {
		Invoke("fin",t);
	}
	
	void fin(){
		Destroy(gameObject);
	}
}
