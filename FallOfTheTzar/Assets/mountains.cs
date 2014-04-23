using UnityEngine;
using System.Collections;

public class mountains : MonoBehaviour {

	// Use this for initialization
	void Start () {
		foreach(GameObject g in GameObject.FindGameObjectsWithTag("Generic Building")){
			Destroy(g);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
