using UnityEngine;
using System.Collections;

public class skip : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("q")){
			Application.LoadLevel("LevelTwo_2");
		}
	}
}
