using UnityEngine;
using System.Collections;

public class Leaveable : MonoBehaviour {

	public bool canLeave = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		//leavegame;
		if (canLeave)
			Application.LoadLevel (2);
	}
}
